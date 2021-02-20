/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Project #2 -- PSE Invoice 
' Created by Laura Waite
' Date: 11/01/2020
' Project Name: PSE Invoice
' Class: CS 218
' Time: 21 hours, 14 minutes
' Platform: PC, Windows 10, VS 2017
' Version: 1.0.0
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' This program generates a mock PSE gas utility bill for a 
' selected customer in a list, which is pulled in from a comma delineated text file
' The calculation for charges are based on the following:
' Customer charge— a flat fee of $6.25
' Delivery charge—$0.29062 per thermal unit
' Cost of gas—$0.69156 per thermal unit for the first 50 thermal units, 
' $1.23863 per thermal unit for 51-100 thermal units and $2.0389 per thermal unit thereafter
' Gas Conservation Program Charge—$0.00437 per thermal unit
' City Tax—6% tax on all charges
' Users can also print the form as a GUI or as a paper generated invoice
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the student:
' Image copyright PSE
' Icon file created with Photoshop to remove background from pse logo and
' ico file converter at https://hnet.com/png-to-ico/
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;
using System.Collections.Generic;
using System.Drawing;
using Project2_PSEInvoice.Properties;
using System.Windows.Forms;
using System.IO;

namespace Project2_PSEInvoice
{

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ' Name:             PSE_Invoice : Form
    ' Description:
    ' 
    ' Class for PSE_Invoice Form application. Contains global variables.
    ' 
    ' Date:             10/31/2020
    ' Author:           Laura Waite
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
    public partial class PSE_Invoice : Form
    {
        // Declare class level variables
        Invoice invoice = null;
        private List<Customer> customers = new List<Customer>();
        private string filePath = @"..\\..\\Resources\\customers.txt"; // Gets file from Resources folder instead of debug folder
        private string findFile = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\customers.txt"); // Alternative method for searching for file if it is missing
        private bool generateClicked = false; // used to determine if invoice was generated for combobox selection change event

        // Print Form
        Bitmap memoryImage;

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Default constructor for form class
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public PSE_Invoice()
        {
            // Show splash screen
            (new SplashScreen()).ShowDialog();

            // Initialize form
            InitializeComponent();

            // Check for customer.txt file
            if (!File.Exists(filePath))
            {
                filePath = findFile;
            }
            // Read from file
            readFromFile(filePath);

            // Display customers
            displayCustomers();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             readFromFile()
        ' Description:
        ' 
        ' Method for reading customers.txt and saving to new instance
        ' of customer object class
        ' 
        ' Parameter:        String file
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void readFromFile(String file)
        {
            customers.Clear();
            try
            {
                String line = string.Empty;
                Customer homeowner = new Customer();    // create a customer

                // Open external file customers.txt and populate combobox
                StreamReader inputFile = File.OpenText(file);
                char[] seps = { ',' };          // delimiter for file

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    String[] values = line.Split(seps); // array of customer info fields
                    homeowner.Name = values[0];
                    homeowner.Address = values[1];
                    homeowner.City = values[2];
                    homeowner.State = values[3];
                    homeowner.Zip = values[4];
                    homeowner.Account = values[5];
                    homeowner.LastRead = values[6];
                    customers.Add(new Customer(homeowner));
                }
                inputFile.Close();
                if (this.cboStreet.Items.Count > 0)
                    this.cboStreet.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to read from file.", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Open file dialog to get customers file
                string filePath = string.Empty;
                ofdCustomers.Title = "Browse Text Files";
                ofdCustomers.DefaultExt = "txt";
                ofdCustomers.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofdCustomers.FilterIndex = 2;
                ofdCustomers.ReadOnlyChecked = true;
                ofdCustomers.ShowReadOnly = true;
                if (ofdCustomers.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofdCustomers.FileName;
                    readFromFile(filePath);
                    displayCustomers();
                }
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             displayCustomers()
        ' Description:
        ' 
        ' Method for loading customers.txt addresses into combobox
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void displayCustomers()
        {
            // Clear instance of cboStreet
            cboStreet.Items.Clear();

            // Create string array
            string[] customerHomes = new string[customers.Count];

            // Loop through all rows in customers object, write to combobox
            for (int i = 0; i < customers.Count; i++)
            {
                customerHomes[i] = customers[i].Address;
                cboStreet.Items.Add(customerHomes[i]);
            }
            if (this.cboStreet.Items.Count > 0)
                this.cboStreet.SelectedIndex = 0;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             frmInvoice_Load()
        ' Description:
        ' 
        ' On Load event handler for the main form.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // Pull form load date, output to textbox
            DateTime todaysDate = DateTime.Today;
            txtDate.Text = todaysDate.ToString("d");
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnGenerate_Click()
        ' Description:
        ' 
        ' Event handler for the GUI button 'Generate'. Validates user
        ' inputs for parsing as long, throws generic exceptions 
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // Define local variables
                long currentUnits = long.Parse(txtCurrent.Text);
                long prevUnits = long.Parse(txtPrevious.Text);
                long totalUnits;

                // If previous meter read is less than current meter read
                if (prevUnits < currentUnits)
                {
                    // Create temp listbox for invoice
                    ListBox tempListBox = new ListBox();

                    // Clear listbox "Invoice" to accept new invoice
                    lstInvoice.Items.Clear();

                    // Calculate total thermal units of gas used and write to textbox
                    totalUnits = currentUnits - prevUnits;
                    txtTotal.Text = totalUnits.ToString();

                    // Create new instance of Invoice class
                    invoice = new Invoice(totalUnits);

                    // Call getListBox method in Invoice class
                    tempListBox = invoice.getListBox();

                    // Display listbox items in control lstInvoice
                    foreach (Object item in tempListBox.Items)
                    {
                        lstInvoice.Items.Add(item);
                    }

                    // Update boolean
                    generateClicked = true;

                }
                // If values for current and previous are the same (not possible for homes with gas hookup)
                else if (prevUnits == currentUnits)
                {
                    // Show error message for no gas usage
                    MessageBox.Show("Warning! Gas usage cannot be zero. Please re-enter current meter read or call for meter service.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Return focus and highlight input
                    txtCurrent.Focus();
                    txtCurrent.SelectAll();
                }
                else
                {
                    // Show error for negative value of gas usage
                    MessageBox.Show("Warning! Gas usage cannot be negative. Please re-enter current meter read.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    // Return focus and highlight input
                    txtCurrent.Focus();
                    txtCurrent.SelectAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Meter read must be entered as whole number. Empty values, letters, and special characters not allowed.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrent.Focus();
                txtCurrent.SelectAll();
            }
        }
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnClear_Click()
        ' Description:
        ' 
        ' Event handler for the Clear Form button. Clears all text boxes and 
        ' listbox, sets the index on the on the combobox to 0 and returns focus,
        ' and also resets the button clicked bool variable to false.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZip.Text = string.Empty;
            mtxtAccount.Text = string.Empty;
            txtPrevious.Text = string.Empty;
            txtCurrent.Text = string.Empty;
            txtTotal.Text = string.Empty;
            lstInvoice.Items.Clear();
            cboStreet.SelectedIndex = 0;
            cboStreet.Focus();
            generateClicked = false;
        }
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnPrint_Click()
        ' Description:
        ' 
        ' Event handler for the Print Invoice button. Calls print preview dialogue
        ' and sends print document pdInvoice to default printer.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ppdInvoice.StartPosition = FormStartPosition.CenterParent;
            ppdInvoice.ClientSize = new Size(700, 700);
            ppdInvoice.PrintPreviewControl.Zoom = 0.75;
            ppdInvoice.Document = pdInvoice;
            ppdInvoice.ShowDialog();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             mnuFilePrint_Click()
        ' Description:
        ' 
        ' Event handler for the menu option File > Print. Calls the Print button
        ' on-click event handler to mimic function.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            // Call Print button method
            btnPrint.PerformClick();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             pdInvoice_PrintPage()
        ' Description:
        ' 
        ' Event handler for the print event for the print document pdInvoice.
        ' Defines printed page.
        ' 
        ' Parameter:        object sender
        ' Parameter:        PrintPageEventArgs e
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void pdInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print Invoice variables
            string strRemit = lblRemit.Text;
            string strCustomer = "Prepared for:" + Environment.NewLine + txtName.Text + Environment.NewLine + cboStreet.Text + Environment.NewLine + txtCity.Text + ", " + txtState.Text + " " + txtZip.Text;
            string strAccount = "Account Number:" + Environment.NewLine + mtxtAccount.Text;
            string strDate = Environment.NewLine + Environment.NewLine + "Invoice Date:" + Environment.NewLine + txtDate.Text;
            string strInvoice = "";
            Bitmap bmpLogo = Resources.pse_logo;
            Font myFont = new Font("Calibri", 12);
            var myBrush = Brushes.Black;

            // Assign listbox items to strInvoice
            foreach (Object items in lstInvoice.Items)
            {
                strInvoice += items.ToString() + Environment.NewLine;
            }

            // Draw invoice for printing
            e.Graphics.DrawString("Remit payment to:" + Environment.NewLine + Environment.NewLine + strRemit, myFont, myBrush, 600, 84);
            e.Graphics.DrawImage(bmpLogo, 72, 72);
            e.Graphics.DrawString(strCustomer, myFont, myBrush, 72, 300);
            e.Graphics.DrawString(strAccount + strDate, myFont, myBrush, 600, 295);
            e.Graphics.DrawString(strInvoice, new Font("Courier New",12), myBrush, 195, 550);
            
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             mnuFilePrintGUI_Click()
        ' Description:
        ' 
        ' Event handler for the menu option File > Print GUI. Calls the 
        ' CaptureScreen method to mimic screenshot function and then calls
        ' the print preview dialog.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFilePrintGUI_Click(object sender, EventArgs e)
        {
            // Print GUI
            CaptureScreen();
            ppdInvoice.StartPosition = FormStartPosition.CenterParent;
            ppdInvoice.ClientSize = new Size(700, 700);
            ppdInvoice.PrintPreviewControl.Zoom = 1.0;
            ppdInvoice.Document = pdForm;
            ppdInvoice.ShowDialog();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             pdForm_PrintPage()
        ' Description:
        ' 
        ' Event handler for the print event for the print document pdForm.
        ' 
        ' Parameter:        object sender
        ' Parameter:        PrintPageEventArgs e
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void pdForm_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create print document
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             CaptureScreen()
        ' Description:
        ' 
        ' Method that mimics the screenshot function in windows to create a
        ' bitmap image that will act as the document to be printed.
        ' 
        ' Parameter:        null
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void CaptureScreen()
        {
            // Capture screen image for printing
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             cboStreet_SelectedValueChanged()
        ' Description:
        ' 
        ' Event handler for the combobox value to change, updates
        ' selected customer in real time without button event
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void cboStreet_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cboStreet.SelectedIndex;
            if (index >= 0)
                showCustomerInfo(index);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             showCustomerInfo()
        ' Description:
        ' 
        ' Method that displays items in customer object list to textboxes
        ' 
        ' Parameter:        int
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void showCustomerInfo(int index)
        {
            if (index > 0 && index < customers.Count)
            {
                txtName.Text = customers[index].Name;
                txtCity.Text = customers[index].City;
                txtState.Text = customers[index].State;
                txtZip.Text = customers[index].Zip;
                mtxtAccount.Text = customers[index].Account;
                txtPrevious.Text = customers[index].LastRead;
                txtCurrent.Text = string.Empty;
                if (generateClicked)
                {
                    txtTotal.Text = string.Empty;
                    lstInvoice.Items.Clear();
                    generateClicked = false;
                }
                txtCurrent.Focus();
            }
            else
            {
                btnClear.PerformClick();
                cboStreet.Focus();
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             bntQuick_Click()
        ' Description:
        ' 
        ' Event handler for Quit button. Closes the application and
        ' all of its forms.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/31/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             mnuHelpAbout_Click()
        ' Description:
        ' 
        ' Event handler for the menu option Help > About. Creates a new instance
        ' of the PSE_Invoice template form.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/01/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            // Show About form
            (new About()).ShowDialog();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             mnuFileQuit_Click()
        ' Description:
        ' 
        ' Event handler for the menu option File > Exit. Closes the application and
        ' all of its forms by calling 
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/02/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFileQuit_Click(object sender, EventArgs e)
        {
            btnQuit.PerformClick();
        }
    }
}
