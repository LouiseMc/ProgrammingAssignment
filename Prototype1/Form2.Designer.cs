namespace GroupAssignment
{
    partial class FormManagersAccount
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStaff = new System.Windows.Forms.TabPage();
            this.tabPageMembers = new System.Windows.Forms.TabPage();
            this.tabPageGameCatalogReport = new System.Windows.Forms.TabPage();
            this.labelSelect = new System.Windows.Forms.Label();
            this.buttonViewStaffMember = new System.Windows.Forms.Button();
            this.buttonAddStaffMember = new System.Windows.Forms.Button();
            this.buttonDeleteStaffMember = new System.Windows.Forms.Button();
            this.buttonUpdateStaffMember = new System.Windows.Forms.Button();
            this.labelSelect2 = new System.Windows.Forms.Label();
            this.buttonViewMembers = new System.Windows.Forms.Button();
            this.buttonAddMembers = new System.Windows.Forms.Button();
            this.buttonDeleteMembers = new System.Windows.Forms.Button();
            this.buttonUpdateMembers = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageStaff.SuspendLayout();
            this.tabPageMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStaff);
            this.tabControl1.Controls.Add(this.tabPageMembers);
            this.tabControl1.Controls.Add(this.tabPageGameCatalogReport);
            this.tabControl1.Location = new System.Drawing.Point(13, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageStaff
            // 
            this.tabPageStaff.Controls.Add(this.buttonUpdateStaffMember);
            this.tabPageStaff.Controls.Add(this.buttonDeleteStaffMember);
            this.tabPageStaff.Controls.Add(this.buttonAddStaffMember);
            this.tabPageStaff.Controls.Add(this.buttonViewStaffMember);
            this.tabPageStaff.Controls.Add(this.labelSelect);
            this.tabPageStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStaff.Location = new System.Drawing.Point(4, 22);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStaff.Size = new System.Drawing.Size(579, 239);
            this.tabPageStaff.TabIndex = 0;
            this.tabPageStaff.Text = "View/Add/Delete/Update Staff Members";
            this.tabPageStaff.UseVisualStyleBackColor = true;
            this.tabPageStaff.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPageMembers
            // 
            this.tabPageMembers.Controls.Add(this.buttonUpdateMembers);
            this.tabPageMembers.Controls.Add(this.buttonDeleteMembers);
            this.tabPageMembers.Controls.Add(this.buttonAddMembers);
            this.tabPageMembers.Controls.Add(this.buttonViewMembers);
            this.tabPageMembers.Controls.Add(this.labelSelect2);
            this.tabPageMembers.Location = new System.Drawing.Point(4, 22);
            this.tabPageMembers.Name = "tabPageMembers";
            this.tabPageMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembers.Size = new System.Drawing.Size(579, 239);
            this.tabPageMembers.TabIndex = 1;
            this.tabPageMembers.Text = "View/Add/Delete/Update Members";
            this.tabPageMembers.UseVisualStyleBackColor = true;
            // 
            // tabPageGameCatalogReport
            // 
            this.tabPageGameCatalogReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageGameCatalogReport.Name = "tabPageGameCatalogReport";
            this.tabPageGameCatalogReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGameCatalogReport.Size = new System.Drawing.Size(579, 239);
            this.tabPageGameCatalogReport.TabIndex = 2;
            this.tabPageGameCatalogReport.Text = "Game Catalog Report";
            this.tabPageGameCatalogReport.UseVisualStyleBackColor = true;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.BackColor = System.Drawing.Color.PowderBlue;
            this.labelSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSelect.Location = new System.Drawing.Point(117, 17);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(219, 16);
            this.labelSelect.TabIndex = 1;
            this.labelSelect.Text = "Please Select From The Following: ";
            this.labelSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSelect.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonViewStaffMember
            // 
            this.buttonViewStaffMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonViewStaffMember.Location = new System.Drawing.Point(157, 49);
            this.buttonViewStaffMember.Name = "buttonViewStaffMember";
            this.buttonViewStaffMember.Size = new System.Drawing.Size(148, 23);
            this.buttonViewStaffMember.TabIndex = 2;
            this.buttonViewStaffMember.Text = "View Staff Member";
            this.buttonViewStaffMember.UseVisualStyleBackColor = true;
            this.buttonViewStaffMember.Click += new System.EventHandler(this.buttonAddStaff_Click);
            // 
            // buttonAddStaffMember
            // 
            this.buttonAddStaffMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonAddStaffMember.Location = new System.Drawing.Point(157, 88);
            this.buttonAddStaffMember.Name = "buttonAddStaffMember";
            this.buttonAddStaffMember.Size = new System.Drawing.Size(148, 23);
            this.buttonAddStaffMember.TabIndex = 3;
            this.buttonAddStaffMember.Text = "Add Staff Member";
            this.buttonAddStaffMember.UseVisualStyleBackColor = true;
            this.buttonAddStaffMember.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeleteStaffMember
            // 
            this.buttonDeleteStaffMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonDeleteStaffMember.Location = new System.Drawing.Point(157, 127);
            this.buttonDeleteStaffMember.Name = "buttonDeleteStaffMember";
            this.buttonDeleteStaffMember.Size = new System.Drawing.Size(148, 23);
            this.buttonDeleteStaffMember.TabIndex = 4;
            this.buttonDeleteStaffMember.Text = "Delete Staff Member";
            this.buttonDeleteStaffMember.UseVisualStyleBackColor = true;
            this.buttonDeleteStaffMember.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonUpdateStaffMember
            // 
            this.buttonUpdateStaffMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonUpdateStaffMember.Location = new System.Drawing.Point(157, 168);
            this.buttonUpdateStaffMember.Name = "buttonUpdateStaffMember";
            this.buttonUpdateStaffMember.Size = new System.Drawing.Size(148, 23);
            this.buttonUpdateStaffMember.TabIndex = 5;
            this.buttonUpdateStaffMember.Text = "Update Staff Member";
            this.buttonUpdateStaffMember.UseVisualStyleBackColor = true;
            // 
            // labelSelect2
            // 
            this.labelSelect2.AutoSize = true;
            this.labelSelect2.BackColor = System.Drawing.Color.PowderBlue;
            this.labelSelect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect2.Location = new System.Drawing.Point(123, 20);
            this.labelSelect2.Name = "labelSelect2";
            this.labelSelect2.Size = new System.Drawing.Size(219, 16);
            this.labelSelect2.TabIndex = 0;
            this.labelSelect2.Text = "Please Select From The Following: ";
            this.labelSelect2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonViewMembers
            // 
            this.buttonViewMembers.Location = new System.Drawing.Point(179, 50);
            this.buttonViewMembers.Name = "buttonViewMembers";
            this.buttonViewMembers.Size = new System.Drawing.Size(104, 23);
            this.buttonViewMembers.TabIndex = 1;
            this.buttonViewMembers.Text = "View Members";
            this.buttonViewMembers.UseVisualStyleBackColor = true;
            // 
            // buttonAddMembers
            // 
            this.buttonAddMembers.Location = new System.Drawing.Point(179, 88);
            this.buttonAddMembers.Name = "buttonAddMembers";
            this.buttonAddMembers.Size = new System.Drawing.Size(104, 23);
            this.buttonAddMembers.TabIndex = 2;
            this.buttonAddMembers.Text = "Add Members";
            this.buttonAddMembers.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteMembers
            // 
            this.buttonDeleteMembers.Location = new System.Drawing.Point(179, 128);
            this.buttonDeleteMembers.Name = "buttonDeleteMembers";
            this.buttonDeleteMembers.Size = new System.Drawing.Size(104, 23);
            this.buttonDeleteMembers.TabIndex = 3;
            this.buttonDeleteMembers.Text = "Delete Members";
            this.buttonDeleteMembers.UseVisualStyleBackColor = true;
            this.buttonDeleteMembers.Click += new System.EventHandler(this.buttonDeleteMembers_Click);
            // 
            // buttonUpdateMembers
            // 
            this.buttonUpdateMembers.Location = new System.Drawing.Point(179, 169);
            this.buttonUpdateMembers.Name = "buttonUpdateMembers";
            this.buttonUpdateMembers.Size = new System.Drawing.Size(104, 23);
            this.buttonUpdateMembers.TabIndex = 4;
            this.buttonUpdateMembers.Text = "Update Members";
            this.buttonUpdateMembers.UseVisualStyleBackColor = true;
            // 
            // FormManagersAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormManagersAccount";
            this.Text = "Managers Account";
            this.tabControl1.ResumeLayout(false);
            this.tabPageStaff.ResumeLayout(false);
            this.tabPageStaff.PerformLayout();
            this.tabPageMembers.ResumeLayout(false);
            this.tabPageMembers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStaff;
        private System.Windows.Forms.TabPage tabPageMembers;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.TabPage tabPageGameCatalogReport;
        private System.Windows.Forms.Button buttonUpdateStaffMember;
        private System.Windows.Forms.Button buttonDeleteStaffMember;
        private System.Windows.Forms.Button buttonAddStaffMember;
        private System.Windows.Forms.Button buttonViewStaffMember;
        private System.Windows.Forms.Label labelSelect2;
        private System.Windows.Forms.Button buttonUpdateMembers;
        private System.Windows.Forms.Button buttonDeleteMembers;
        private System.Windows.Forms.Button buttonAddMembers;
        private System.Windows.Forms.Button buttonViewMembers;

    }
}