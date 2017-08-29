namespace CPRG254.FinalPrj.Enrollment
{
    partial class StudentEnrollmentView
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
            this.label11 = new System.Windows.Forms.Label();
            this.uxStudents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDisplay = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.uxFee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(93, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(353, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "STUDENT ENROLLMENT INFO VIEW";
            // 
            // uxStudents
            // 
            this.uxStudents.FormattingEnabled = true;
            this.uxStudents.Location = new System.Drawing.Point(158, 112);
            this.uxStudents.Name = "uxStudents";
            this.uxStudents.Size = new System.Drawing.Size(262, 21);
            this.uxStudents.TabIndex = 46;
            this.toolTip1.SetToolTip(this.uxStudents, "Select a student to display data");
            this.uxStudents.SelectedIndexChanged += new System.EventHandler(this.uxStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Student:";
            // 
            // uxDisplay
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uxDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uxDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.uxDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxDisplay.EnableHeadersVisualStyles = false;
            this.uxDisplay.Location = new System.Drawing.Point(0, 195);
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.Size = new System.Drawing.Size(531, 240);
            this.uxDisplay.TabIndex = 48;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "TOTAL FEE:";
            // 
            // uxFee
            // 
            this.uxFee.Location = new System.Drawing.Point(158, 153);
            this.uxFee.Name = "uxFee";
            this.uxFee.ReadOnly = true;
            this.uxFee.Size = new System.Drawing.Size(157, 20);
            this.uxFee.TabIndex = 51;
            // 
            // StudentEnrollmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(531, 435);
            this.Controls.Add(this.uxFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxStudents);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentEnrollmentView";
            this.Text = "Student Enrollment View";
            this.Load += new System.EventHandler(this.StudentEnrollmentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox uxStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uxDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxFee;
    }
}