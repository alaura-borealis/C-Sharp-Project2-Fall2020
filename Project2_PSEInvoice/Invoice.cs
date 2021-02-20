/*'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Project #2 -- Invoice
' Created by Laura Waite
' Date: 11/01/2020
' Project Name: PSE Invoice
' Class: CS 218
' Time: 1 hour 10 minutes
' Platform: PC, Windows 10, VS 2017
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Class for invoice generation and all related calculations
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the student:
' Copy constructor not built since it is not used. 
' Are copy constructors required for all classes?
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;
using System.Text;
using System.Windows.Forms;

namespace Project2_PSEInvoice
{
    /// <summary>
    /// Class       Invoice
    /// File        Invoice.cs
    /// Description Support class used by frmInvoice class.
    /// Author      Laura Waite
    /// Environment PC, Windows 10, VS 2017
    /// Date        11/01/2020
    /// Version     1.0.0
    /// History Log 
    /// </summary>
    /// 
    class Invoice
    {
        // Declare constants
        private const double CUSTOMER_CHARGE = 6.25,
                     DELIVERY_CHARGE = 0.29062,
                     COST_OF_GAS_0_50 = 0.69156,
                     COST_OF_GAS_51_100 = 1.23863,
                     COST_OF_GAS_101 = 2.0389,
                     GAS_CONSERVATION_CHARGE = 0.00437,
                     CITY_TAX = 0.06;

        // Declare class level variables
        StringBuilder display = new StringBuilder();    // output
        private ListBox output = new ListBox();
        private long gasUsed;
        private double deliveryCharge;
        private double gasCharge;
        private double consCharge;
        private double subtotal;
        private double cityTax;
        private double totalCharge;

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Default constructor to create new instance of Invoice class
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public Invoice()
        {
            deliveryCharge = gasCharge = consCharge = subtotal = cityTax = totalCharge = 0;
            gasUsed = 0;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Overloaded constructor to create new instance of Invoice class
        ' Parameter     totalUnits--long
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public Invoice(long totalUnits)
        {
            gasUsed = totalUnits;
            GenerateInvoice();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             GenerateInvoice()
        ' Description:
        ' 
        ' Method for calculating invoice charges using running total
        ' 
        ' Parameter:        none
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void GenerateInvoice()
        {
            // Declare method constants
            const double LOW_MAX = 50; // Maximum gas usage at lowest rate
            const double MID_MAX = 50; // Maximum gas usage at mid rate

            // Start running total
            subtotal = 0;

            // Customer charge - flat fee
            subtotal += CUSTOMER_CHARGE;

            // Delivery charge
            deliveryCharge = gasUsed * DELIVERY_CHARGE;
            subtotal += deliveryCharge;

            // Gas charge based on usage
            if (gasUsed > 100)
            {
                // For gas usage over 100 BTUs, first 50 at lowest rate, next 50 at mid rate, remainder at highest rate
                gasCharge = (gasUsed - 100) * COST_OF_GAS_101 + LOW_MAX * COST_OF_GAS_0_50 + MID_MAX * COST_OF_GAS_51_100;
            }
            else if (gasUsed <= 100 && gasUsed > 50)
            {
                // For gas usage between 51 and 100, first 50 at lowest rate, remainder at mid rate
                gasCharge = (gasUsed % 50) * COST_OF_GAS_51_100 + LOW_MAX * COST_OF_GAS_0_50;
            }
            else
            {
                // For gas usage 50 units or less, charge lowest rate
                gasCharge = gasUsed * COST_OF_GAS_0_50;
            }
            subtotal += gasCharge;

            // Gas conservation charge
            consCharge = gasUsed * GAS_CONSERVATION_CHARGE;
            subtotal += consCharge;

            // City tax @ 6%
            cityTax = subtotal * CITY_TAX;

            // Grand total
            totalCharge = subtotal + cityTax;

        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             displayOutput()
        ' Description:
        ' 
        ' Method for loading invoice data into temporary listbox to return to 
        ' GUI class in another method
        ' 
        ' Parameter:        none
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void displayOutput()
        {
            string listBoxFormat = "{0, -28}{1, 14:C}";
            output.Items.Add(String.Format(listBoxFormat, "Customer Charge", CUSTOMER_CHARGE));
            output.Items.Add(String.Format(listBoxFormat, "Delivery Charge", deliveryCharge));
            output.Items.Add(String.Format(listBoxFormat, "Gas Charge", gasCharge));
            output.Items.Add(String.Format(listBoxFormat, "Conservation Program Charge", consCharge));
            output.Items.Add("------------------------------------------");
            output.Items.Add(String.Format(listBoxFormat, "Subtotal", subtotal));
            output.Items.Add(String.Format(listBoxFormat, "City Tax (6%)", cityTax));
            output.Items.Add(String.Format(listBoxFormat, "Total", totalCharge));
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             getListBox()
        ' Description:
        ' 
        ' Calls displayOutput method and passes temp listbox to main
        ' GUI class
        ' 
        ' Parameter:        none
        ' Return:           Listbox output
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public ListBox getListBox()
        {
            displayOutput();
            return output;
        }
    }
}
