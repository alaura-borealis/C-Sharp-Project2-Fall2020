namespace Project2_PSEInvoice
{
    partial class SplashScreen
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
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblSplash = new System.Windows.Forms.Label();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(166, 179);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 15);
            this.lblLoading.TabIndex = 36;
            this.lblLoading.Text = "Loading - Please Wait...";
            // 
            // lblSplash
            // 
            this.lblSplash.AutoSize = true;
            this.lblSplash.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash.Location = new System.Drawing.Point(280, 80);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(122, 57);
            this.lblSplash.TabIndex = 35;
            this.lblSplash.Text = "by Laura Waite\r\nfor CS 218\r\nFall Quarter 2020";
            // 
            // prgLoading
            // 
            this.prgLoading.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prgLoading.Location = new System.Drawing.Point(112, 203);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(242, 23);
            this.prgLoading.Step = 1;
            this.prgLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgLoading.TabIndex = 34;
            this.prgLoading.UseWaitCursor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(273, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 39);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "PSE Invoice";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Project2_PSEInvoice.Properties.Resources.pse_logo;
            this.picLogo.Location = new System.Drawing.Point(27, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(219, 109);
            this.picLogo.TabIndex = 37;
            this.picLogo.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(466, 253);
            this.ControlBox = false;
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.prgLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblSplash;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.PictureBox picLogo;
    }
}