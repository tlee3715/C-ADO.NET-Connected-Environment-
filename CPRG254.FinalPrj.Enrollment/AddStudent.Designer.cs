namespace CPRG254.FinalPrj.Enrollment
{
    partial class AddStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uxStudents = new System.Windows.Forms.DataGridView();
            this.uxAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxProvince = new System.Windows.Forms.ComboBox();
            this.uxPostalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uxPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uxDepartment = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uxClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.uxStudents)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxStudents
            // 
            this.uxStudents.AllowUserToOrderColumns = true;
            this.uxStudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uxStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uxStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.uxStudents.Dock = System.Windows.Forms.DockStyle.Right;
            this.uxStudents.EnableHeadersVisualStyles = false;
            this.uxStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uxStudents.Location = new System.Drawing.Point(545, 0);
            this.uxStudents.Name = "uxStudents";
            this.uxStudents.ReadOnly = true;
            this.uxStudents.Size = new System.Drawing.Size(683, 471);
            this.uxStudents.TabIndex = 0;
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(210, 421);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(75, 23);
            this.uxAdd.TabIndex = 1;
            this.uxAdd.Text = "&Add";
            this.toolTip1.SetToolTip(this.uxAdd, "Add new student to system");
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(196, 63);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(132, 20);
            this.uxFirstName.TabIndex = 5;
            this.toolTip1.SetToolTip(this.uxFirstName, "Enter First Name");
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(196, 101);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(132, 20);
            this.uxLastName.TabIndex = 7;
            this.toolTip1.SetToolTip(this.uxLastName, "Enter Last Name");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // uxAddress
            // 
            this.uxAddress.Location = new System.Drawing.Point(196, 139);
            this.uxAddress.Name = "uxAddress";
            this.uxAddress.Size = new System.Drawing.Size(289, 20);
            this.uxAddress.TabIndex = 9;
            this.toolTip1.SetToolTip(this.uxAddress, "Enter Address");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // uxCity
            // 
            this.uxCity.Location = new System.Drawing.Point(196, 180);
            this.uxCity.Name = "uxCity";
            this.uxCity.Size = new System.Drawing.Size(132, 20);
            this.uxCity.TabIndex = 11;
            this.toolTip1.SetToolTip(this.uxCity, "Enter City");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Province:";
            // 
            // uxProvince
            // 
            this.uxProvince.FormattingEnabled = true;
            this.uxProvince.Location = new System.Drawing.Point(196, 216);
            this.uxProvince.Name = "uxProvince";
            this.uxProvince.Size = new System.Drawing.Size(205, 21);
            this.uxProvince.TabIndex = 13;
            this.toolTip1.SetToolTip(this.uxProvince, "Select a Province");
            // 
            // uxPostalCode
            // 
            this.uxPostalCode.Location = new System.Drawing.Point(196, 258);
            this.uxPostalCode.Name = "uxPostalCode";
            this.uxPostalCode.Size = new System.Drawing.Size(132, 20);
            this.uxPostalCode.TabIndex = 15;
            this.toolTip1.SetToolTip(this.uxPostalCode, "Enter Postal Code");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Postal Code:";
            // 
            // uxPhone
            // 
            this.uxPhone.Location = new System.Drawing.Point(196, 296);
            this.uxPhone.Name = "uxPhone";
            this.uxPhone.Size = new System.Drawing.Size(132, 20);
            this.uxPhone.TabIndex = 17;
            this.toolTip1.SetToolTip(this.uxPhone, "Enter Phone Number");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phone:";
            // 
            // uxEmail
            // 
            this.uxEmail.Location = new System.Drawing.Point(196, 334);
            this.uxEmail.Name = "uxEmail";
            this.uxEmail.Size = new System.Drawing.Size(205, 20);
            this.uxEmail.TabIndex = 19;
            this.toolTip1.SetToolTip(this.uxEmail, "Enter Email Address");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email:";
            // 
            // uxDepartment
            // 
            this.uxDepartment.FormattingEnabled = true;
            this.uxDepartment.Location = new System.Drawing.Point(196, 374);
            this.uxDepartment.Name = "uxDepartment";
            this.uxDepartment.Size = new System.Drawing.Size(205, 21);
            this.uxDepartment.TabIndex = 21;
            this.toolTip1.SetToolTip(this.uxDepartment, "Select a Department");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Department:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 471);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(149, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "ADD NEW STUDENT ";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // uxClear
            // 
            this.uxClear.Location = new System.Drawing.Point(410, 60);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(75, 23);
            this.uxClear.TabIndex = 24;
            this.uxClear.Text = "&Clear All";
            this.toolTip1.SetToolTip(this.uxClear, "Clear Input Text Box Value");
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.uxClear);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.uxDepartment);
            this.panel2.Controls.Add(this.uxProvince);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.uxCity);
            this.panel2.Controls.Add(this.uxEmail);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.uxPostalCode);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.uxLastName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.uxAddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.uxAdd);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.uxPhone);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.uxFirstName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 471);
            this.panel2.TabIndex = 23;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(535, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 471);
            this.splitter1.TabIndex = 23;
            this.splitter1.TabStop = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uxStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddStudent";
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxStudents)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxStudents;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox uxProvince;
        private System.Windows.Forms.TextBox uxPostalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uxPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox uxDepartment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button uxClear;
    }
}