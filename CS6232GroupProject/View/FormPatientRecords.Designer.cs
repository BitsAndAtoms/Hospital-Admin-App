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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientRecords));
            this.labelPatientRecords = new System.Windows.Forms.Label();
            this.userControlPatientRecords1 = new CS6232GroupProject.UserControls.UserControlPatientRecords();
            this.SuspendLayout();
            // 
            // labelPatientRecords
            // 
            this.labelPatientRecords.AutoSize = true;
            this.labelPatientRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPatientRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelPatientRecords.Location = new System.Drawing.Point(0, 0);
            this.labelPatientRecords.Name = "labelPatientRecords";
            this.labelPatientRecords.Size = new System.Drawing.Size(199, 29);
            this.labelPatientRecords.TabIndex = 1;
            this.labelPatientRecords.Text = "Patient Records";
            // 
            // userControlPatientRecords1
            // 
            this.userControlPatientRecords1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlPatientRecords1.Location = new System.Drawing.Point(0, 29);
            this.userControlPatientRecords1.Name = "userControlPatientRecords1";
            this.userControlPatientRecords1.Size = new System.Drawing.Size(806, 573);
            this.userControlPatientRecords1.TabIndex = 2;
            // 
            // FormPatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 549);
            this.Controls.Add(this.userControlPatientRecords1);
            this.Controls.Add(this.labelPatientRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPatientRecords";
            this.Text = "ClinicCare - Patient Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatientRecords;
        private UserControls.UserControlPatientRecords userControlPatientRecords1;
    }
}