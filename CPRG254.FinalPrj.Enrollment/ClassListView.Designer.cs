namespace CPRG254.FinalPrj.Enrollment
{
    partial class ClassListView
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
            this.uxCourses = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxSection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDisplay = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCourses
            // 
            this.uxCourses.FormattingEnabled = true;
            this.uxCourses.Location = new System.Drawing.Point(186, 73);
            this.uxCourses.Name = "uxCourses";
            this.uxCourses.Size = new System.Drawing.Size(262, 21);
            this.uxCourses.TabIndex = 51;
            this.toolTip1.SetToolTip(this.uxCourses, "Select a course");
            this.uxCourses.SelectedIndexChanged += new System.EventHandler(this.uxCourses_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(239, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 25);
            this.label11.TabIndex = 50;
            this.label11.Text = "CLASS LIST INFO VIEW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Section:";
            // 
            // uxSection
            // 
            this.uxSection.FormattingEnabled = true;
            this.uxSection.Location = new System.Drawing.Point(186, 128);
            this.uxSection.Name = "uxSection";
            this.uxSection.Size = new System.Drawing.Size(306, 21);
            this.uxSection.TabIndex = 53;
            this.toolTip1.SetToolTip(this.uxSection, "Select a course section");
            this.uxSection.SelectedIndexChanged += new System.EventHandler(this.uxSection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Course:";
            // 
            // uxDisplay
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
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
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.uxDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxDisplay.Location = new System.Drawing.Point(0, 190);
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.Size = new System.Drawing.Size(677, 228);
            this.uxDisplay.TabIndex = 55;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // ClassListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(677, 418);
            this.Controls.Add(this.uxDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxSection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxCourses);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClassListView";
            this.Text = "Class List View";
            this.Load += new System.EventHandler(this.ClassListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxCourses;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uxSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView uxDisplay;
    }
}