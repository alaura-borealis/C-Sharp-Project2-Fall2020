﻿/*'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Project #2 -- SplashScreen
' Created by Laura Waite
' Date: 11/01/2020
' Project Name: PSE Invoice
' Class: CS 218
' Time: 20 minutes
' Platform: PC, Windows 10, VS 2017
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' This form is loaded upon application load and mimics the splash screens generated by many Windows apps.
' Progress bar does not reflect actual application load time - for demonstration only.
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the student:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;
using System.Windows.Forms;

namespace Project2_PSEInvoice
{
    public partial class SplashScreen : Form
    {

        public SplashScreen()
        {
            InitializeComponent();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             SplashScreen_Load()
        ' Description:
        ' 
        ' Event handler for the Splash screen load event.
        ' Starts an instance of the Timer control.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Start timer when application loads
            tmrSplash.Start();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             tmrSplash_Tick()
        ' Description:
        ' 
        ' Event handler for the timer control's "tick" event.
        ' Adds ticks to the progress bar in increments of 5
        ' Stops timer and closes form when progress bar control's value hits 100
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            // Add ticks to progress bar
            prgLoading.Increment(5);
        
            // When progress bar = 100, stop timer and close splash screen
            if (prgLoading.Value == 100)
            {
                tmrSplash.Stop();
                this.Close();
            }
            
        }

    }
}