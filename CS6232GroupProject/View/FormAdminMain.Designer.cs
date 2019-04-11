namespace CS6232GroupProject.View
{
    partial class FormAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.pictureBoxNurseIcon = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.userControlAdminMain1 = new CS6232GroupProject.UserControls.UserControlAdminMain();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNurseIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.3211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.6789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabelLogout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxNurseIcon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 149);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(100)))));
            this.linkLabelLogout.Location = new System.Drawing.Point(647, 0);
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
            this.pictureBoxNurseIcon.Image = global::CS6232GroupProject.Properties.Resources.adminicon;
            this.pictureBoxNurseIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxNurseIcon.Name = "pictureBoxNurseIcon";
            this.pictureBoxNurseIcon.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pictureBoxNurseIcon.Size = new System.Drawing.Size(128, 130);
            this.pictureBoxNurseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNurseIcon.TabIndex = 0;
            this.pictureBoxNurseIcon.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(137, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "labelName";
            // 
            // userControlAdminMain1
            // 
            this.userControlAdminMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAdminMain1.Location = new System.Drawing.Point(0, 149);
            this.userControlAdminMain1.Name = "userControlAdminMain1";
            this.userControlAdminMain1.Size = new System.Drawing.Size(738, 754);
            this.userControlAdminMain1.TabIndex = 6;
            this.userControlAdminMain1.Load += new System.EventHandler(this.userControlAdminMain1_Load);
            // 
            // FormAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS6232GroupProject.Properties.Resources.bggradient_topsmall;
            this.ClientSize = new System.Drawing.Size(738, 903);
            this.Controls.Add(this.userControlAdminMain1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNurseIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.PictureBox pictureBoxNurseIcon;
        private System.Windows.Forms.Label labelName;
        private UserControls.UserControlAdminMain userControlAdminMain1;
    }
}