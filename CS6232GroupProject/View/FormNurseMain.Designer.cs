namespace CS6232GroupProject.View
{
    partial class FormNurseMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNurseMain));
            this.labelName = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.pictureBoxNurseIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlNurseMain1 = new CS6232GroupProject.UserControls.UserControlNurseMain();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNurseIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(119, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "labelName";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(100)))));
            this.linkLabelLogout.Location = new System.Drawing.Point(703, 0);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.linkLabelLogout.Size = new System.Drawing.Size(88, 35);
            this.linkLabelLogout.TabIndex = 2;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // pictureBoxNurseIcon
            // 
            this.pictureBoxNurseIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNurseIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNurseIcon.Image = global::CS6232GroupProject.Properties.Resources.nurseicon2e;
            this.pictureBoxNurseIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxNurseIcon.Name = "pictureBoxNurseIcon";
            this.pictureBoxNurseIcon.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pictureBoxNurseIcon.Size = new System.Drawing.Size(110, 114);
            this.pictureBoxNurseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNurseIcon.TabIndex = 0;
            this.pictureBoxNurseIcon.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.03425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.96575F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabelLogout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxNurseIcon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 120);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControlNurseMain1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 783);
            this.panel1.TabIndex = 5;
            // 
            // userControlNurseMain1
            // 
            this.userControlNurseMain1.AutoScroll = true;
            this.userControlNurseMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlNurseMain1.Location = new System.Drawing.Point(0, 0);
            this.userControlNurseMain1.Name = "userControlNurseMain1";
            this.userControlNurseMain1.Size = new System.Drawing.Size(794, 783);
            this.userControlNurseMain1.TabIndex = 3;
            this.userControlNurseMain1.Load += new System.EventHandler(this.userControlNurseMain1_Load);
            // 
            // FormNurseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CS6232GroupProject.Properties.Resources.bggradient_topsmall;
            this.ClientSize = new System.Drawing.Size(794, 903);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 942);
            this.Name = "FormNurseMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClinicCare - Nurse View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNurseMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNurseIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNurseIcon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private UserControls.UserControlNurseMain userControlNurseMain1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}