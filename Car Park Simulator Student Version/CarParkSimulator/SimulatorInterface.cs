﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkSimulator
{
    public partial class SimulatorInterface : Form
    {
        // Attributes ///        
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;
        
        
        private List<Ticket> tickets;

        /////////////////


        // Constructor //
        public SimulatorInterface()
        {
            InitializeComponent();
        }
        /////////////////


        // Operations ///
        private void ResetSystem(object sender, EventArgs e)
        {
            // STUDENTS:
            ///// Class contructors are not defined so there will be errors
            ///// This code is correct for the basic version though
            
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);
            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            carPark.CarArrivedAtEntrance();
            UpdateDisplay();
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            if (carPark.HasSpace() == true) carPark.TicketDispensed();
            UpdateDisplay();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            carPark.CarEnteredCarPark();
            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            carPark.CarArrivedAtExit();
            UpdateDisplay();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {
            carPark.TicketValidated();
            UpdateDisplay();

        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            carPark.CarExitedCarPark();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (entryBarrier.isLifted() == true)
            {
                lblEntryBarrier.Text = "True";
            }
            else
            {
                lblEntryBarrier.Text = "False";

            }
            if (entrySensor.IsCarOnSensor() == true)
            {
                lblEntrySensor.Text = "True";
            }
            else
            {
                lblEntrySensor.Text = "False";
            }

            if (exitBarrier.isLifted() == true)
            {
                lblExitBarrier.Text = "True";
            }
            else 
            {
                lblExitBarrier.Text = "False";
            }

            if (exitSensor.IsCarOnSensor() == true)
            {
                lblExitSensor.Text = "True";
            }
            else
            {
                lblExitSensor.Text = "False";
            }

            if (fullSign.isLit() == true)
            {
                lblFullSign.Text = "True";
            }
            else
            {
                lblFullSign.Text = "False";
            }
            lblSpaces.Text = Convert.ToString(carPark.GetCurrentSpaces());
        }
    }
}
