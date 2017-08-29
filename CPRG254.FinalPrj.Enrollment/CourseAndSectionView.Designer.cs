namespace CPRG254.FinalPrj.Enrollment
{
    partial class CourseAndSectionView
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
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDepartments = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uxDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(181, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(332, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "COURSE AND SECTION INFO VIEW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Department:";
            // 
            // uxDepartments
            // 
            this.uxDepartments.FormattingEnabled = true;
            this.uxDepartments.Location = new System.Drawing.Point(217, 106);
            this.uxDepartments.Name = "uxDepartments";
            this.uxDepartments.Size = new System.Drawing.Size(262, 21);
            this.uxDepartments.TabIndex = 48;
            this.toolTip1.SetToolTip(this.uxDepartments, "Select a department");
            this.uxDepartments.SelectedIndexChanged += new System.EventHandler(this.uxDepartments_SelectedIndexChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // uxDisplay
            // 
            this.uxDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxDisplay.Location = new System.Drawing.Point(0, 158);
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.Size = new System.Drawing.Size(649, 232);
            this.uxDisplay.TabIndex = 50;
            // 
            // CourseAndSectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(649, 390);
            this.Controls.Add(this.uxDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDepartments);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CourseAndSectionView";
            this.Text = "Course And Section View";
            this.Load += new System.EventHandler(this.CourseAndSectionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxDepartments;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView uxDisplay;
    }
}