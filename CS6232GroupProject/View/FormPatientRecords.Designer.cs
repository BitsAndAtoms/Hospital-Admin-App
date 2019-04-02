namespace CS6232GroupProject.View
{
    partial class FormPatientRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientRecords));
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userControlPatientRecords1 = new CS6232GroupProject.UserControls.UserControlPatientRecords();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataSource = typeof(CS6232GroupProject.Model.Appointment);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(CS6232GroupProject.Model.Appointment);
            // 
            // userControlPatientRecords1
            // 
            this.userControlPatientRecords1.BackColor = System.Drawing.Color.White;
            this.userControlPatientRecords1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPatientRecords1.Location = new System.Drawing.Point(0, 0);
            this.userControlPatientRecords1.Name = "userControlPatientRecords1";
            this.userControlPatientRecords1.Size = new System.Drawing.Size(806, 563);
            this.userControlPatientRecords1.TabIndex = 2;
            // 
            // FormPatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 563);
            this.Controls.Add(this.userControlPatientRecords1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPatientRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClinicCare - Patient Records";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.UserControlPatientRecords userControlPatientRecords1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
    }
}