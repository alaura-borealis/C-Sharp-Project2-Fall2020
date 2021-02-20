namespace Project2_PSEInvoice
{
    partial class PSE_Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSE_Invoice));
            this.lblRemit = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.cboStreet = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpMeter = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mnuInvoice = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrintGUI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.mtxtAccount = new System.Windows.Forms.MaskedTextBox();
            this.lstInvoice = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.ttpInvoice = new System.Windows.Forms.ToolTip(this.components);
            this.pdInvoice = new System.Drawing.Printing.PrintDocument();
            this.pdForm = new System.Drawing.Printing.PrintDocument();
            this.ppdInvoice = new System.Windows.Forms.PrintPreviewDialog();
            this.ofdCustomers = new System.Windows.Forms.OpenFileDialog();
            this.lblThanks = new System.Windows.Forms.Label();
            this.grpCustomer.SuspendLayout();
            this.grpMeter.SuspendLayout();
            this.mnuInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemit
            // 
            this.lblRemit.AutoSize = true;
            this.lblRemit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemit.Location = new System.Drawing.Point(20, 42);
            this.lblRemit.Name = "lblRemit";
            this.lblRemit.Size = new System.Drawing.Size(139, 76);
            this.lblRemit.TabIndex = 0;
            this.lblRemit.Text = "Payment Processing\r\nPO Box 19269\r\nBellevue, WA 98009\r\nwww.pse.com";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(388, 58);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(78, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Invoice Date:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(388, 102);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(100, 15);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "Account Number:";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(7, 34);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(58, 15);
            this.lblPrevious.TabIndex = 4;
            this.lblPrevious.Text = "Previous:";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(7, 70);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(51, 15);
            this.lblCurrent.TabIndex = 5;
            this.lblCurrent.Text = "Current:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(6, 70);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(54, 15);
            this.lblStreet.TabIndex = 8;
            this.lblStreet.Text = "Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(6, 106);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 15);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(184, 106);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 15);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(258, 106);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(27, 15);
            this.lblZip.TabIndex = 11;
            this.lblZip.Text = "Zip:";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.cboStreet);
            this.grpCustomer.Controls.Add(this.txtZip);
            this.grpCustomer.Controls.Add(this.txtState);
            this.grpCustomer.Controls.Add(this.txtCity);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.lblZip);
            this.grpCustomer.Controls.Add(this.lblState);
            this.grpCustomer.Controls.Add(this.lblCity);
            this.grpCustomer.Controls.Add(this.lblStreet);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(17, 142);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(359, 140);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Prepared for:";
            // 
            // cboStreet
            // 
            this.cboStreet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet.FormattingEnabled = true;
            this.cboStreet.Location = new System.Drawing.Point(66, 67);
            this.cboStreet.MaxLength = 50;
            this.cboStreet.Name = "cboStreet";
            this.cboStreet.Size = new System.Drawing.Size(279, 23);
            this.cboStreet.TabIndex = 0;
            this.cboStreet.SelectedValueChanged += new System.EventHandler(this.cboStreet_SelectedValueChanged);
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(291, 103);
            this.txtZip.MaxLength = 5;
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(54, 23);
            this.txtZip.TabIndex = 15;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(227, 103);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(25, 23);
            this.txtState.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(66, 103);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(112, 23);
            this.txtCity.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(66, 31);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(279, 23);
            this.txtName.TabIndex = 12;
            // 
            // grpMeter
            // 
            this.grpMeter.Controls.Add(this.txtTotal);
            this.grpMeter.Controls.Add(this.txtCurrent);
            this.grpMeter.Controls.Add(this.txtPrevious);
            this.grpMeter.Controls.Add(this.lblTotal);
            this.grpMeter.Controls.Add(this.lblCurrent);
            this.grpMeter.Controls.Add(this.lblPrevious);
            this.grpMeter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMeter.Location = new System.Drawing.Point(391, 142);
            this.grpMeter.Name = "grpMeter";
            this.grpMeter.Size = new System.Drawing.Size(201, 140);
            this.grpMeter.TabIndex = 1;
            this.grpMeter.TabStop = false;
            this.grpMeter.Text = "Meter Readings:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(88, 103);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(88, 67);
            this.txtCurrent.MaxLength = 10;
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 23);
            this.txtCurrent.TabIndex = 0;
            this.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttpInvoice.SetToolTip(this.txtCurrent, "Enter reading - numbers only");
            // 
            // txtPrevious
            // 
            this.txtPrevious.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.Location = new System.Drawing.Point(88, 31);
            this.txtPrevious.MaxLength = 10;
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.ReadOnly = true;
            this.txtPrevious.Size = new System.Drawing.Size(100, 23);
            this.txtPrevious.TabIndex = 7;
            this.txtPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(7, 106);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 15);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Units:";
            // 
            // mnuInvoice
            // 
            this.mnuInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuInvoice.Location = new System.Drawing.Point(0, 0);
            this.mnuInvoice.Name = "mnuInvoice";
            this.mnuInvoice.Size = new System.Drawing.Size(609, 24);
            this.mnuInvoice.TabIndex = 6;
            this.mnuInvoice.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilePrint,
            this.mnuFilePrintGUI,
            this.mnuFileQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.Size = new System.Drawing.Size(137, 22);
            this.mnuFilePrint.Text = "&Print";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnuFilePrint_Click);
            // 
            // mnuFilePrintGUI
            // 
            this.mnuFilePrintGUI.Name = "mnuFilePrintGUI";
            this.mnuFilePrintGUI.Size = new System.Drawing.Size(137, 22);
            this.mnuFilePrintGUI.Text = "P&rint Screen";
            this.mnuFilePrintGUI.Click += new System.EventHandler(this.mnuFilePrintGUI_Click);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileQuit.Text = "&Quit";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(191, 22);
            this.mnuHelpAbout.Text = "&About this application";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(492, 55);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(100, 23);
            this.txtDate.TabIndex = 15;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtAccount
            // 
            this.mtxtAccount.Location = new System.Drawing.Point(494, 99);
            this.mtxtAccount.Mask = "0000-0000-0";
            this.mtxtAccount.Name = "mtxtAccount";
            this.mtxtAccount.ReadOnly = true;
            this.mtxtAccount.Size = new System.Drawing.Size(100, 23);
            this.mtxtAccount.TabIndex = 16;
            this.mtxtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstInvoice
            // 
            this.lstInvoice.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvoice.FormattingEnabled = true;
            this.lstInvoice.ItemHeight = 16;
            this.lstInvoice.Location = new System.Drawing.Point(17, 295);
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.Size = new System.Drawing.Size(359, 228);
            this.lstInvoice.TabIndex = 17;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(391, 295);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(201, 45);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "&Generate Invoice";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(391, 356);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(201, 45);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "&Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(391, 417);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 45);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear Form";
            this.ttpInvoice.SetToolTip(this.btnClear, "Clear form without saving");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(391, 478);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(201, 45);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pdInvoice
            // 
            this.pdInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdInvoice_PrintPage);
            // 
            // pdForm
            // 
            this.pdForm.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdForm_PrintPage);
            // 
            // ppdInvoice
            // 
            this.ppdInvoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdInvoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdInvoice.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdInvoice.Enabled = true;
            this.ppdInvoice.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdInvoice.Icon")));
            this.ppdInvoice.Name = "ppdInvoice";
            this.ppdInvoice.ShowIcon = false;
            this.ppdInvoice.Visible = false;
            // 
            // ofdCustomers
            // 
            this.ofdCustomers.FileName = "openFileDialog1";
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblThanks.Location = new System.Drawing.Point(152, 541);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(304, 25);
            this.lblThanks.TabIndex = 23;
            this.lblThanks.Text = "Thank you for your patronage!";
            // 
            // PSE_Invoice
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(609, 586);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lstInvoice);
            this.Controls.Add(this.mtxtAccount);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.grpMeter);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRemit);
            this.Controls.Add(this.mnuInvoice);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuInvoice;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 625);
            this.MinimumSize = new System.Drawing.Size(625, 625);
            this.Name = "PSE_Invoice";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpMeter.ResumeLayout(false);
            this.grpMeter.PerformLayout();
            this.mnuInvoice.ResumeLayout(false);
            this.mnuInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpMeter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MenuStrip mnuInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrintGUI;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.MaskedTextBox mtxtAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ListBox lstInvoice;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cboStreet;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ToolTip ttpInvoice;
        private System.Drawing.Printing.PrintDocument pdInvoice;
        private System.Drawing.Printing.PrintDocument pdForm;
        private System.Windows.Forms.PrintPreviewDialog ppdInvoice;
        private System.Windows.Forms.OpenFileDialog ofdCustomers;
        private System.Windows.Forms.Label lblThanks;
    }
}

