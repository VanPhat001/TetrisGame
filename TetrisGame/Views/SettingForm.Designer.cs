namespace TetrisGame.Views
{
    partial class SettingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRows = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRows = new System.Windows.Forms.TextBox();
            this.trackBarRows = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCols = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCols = new System.Windows.Forms.TextBox();
            this.trackBarCols = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSpeed = new System.Windows.Forms.TextBox();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRows)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCols)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.trackBarRows);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(39, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRows);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbRows);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(576, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 62);
            this.panel2.TabIndex = 2;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(91, 20);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(30, 22);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            // 
            // txbRows
            // 
            this.txbRows.Location = new System.Drawing.Point(12, 14);
            this.txbRows.Name = "txbRows";
            this.txbRows.Size = new System.Drawing.Size(52, 28);
            this.txbRows.TabIndex = 1;
            // 
            // trackBarRows
            // 
            this.trackBarRows.LargeChange = 1;
            this.trackBarRows.Location = new System.Drawing.Point(92, 5);
            this.trackBarRows.Name = "trackBarRows";
            this.trackBarRows.Size = new System.Drawing.Size(461, 45);
            this.trackBarRows.TabIndex = 2;
            this.trackBarRows.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.trackBarCols);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(39, 90);
            this.panel3.Margin = new System.Windows.Forms.Padding(30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 62);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCols);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txbCols);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(576, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 62);
            this.panel4.TabIndex = 2;
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(91, 20);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(30, 22);
            this.lblCols.TabIndex = 4;
            this.lblCols.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "/";
            // 
            // txbCols
            // 
            this.txbCols.Location = new System.Drawing.Point(12, 14);
            this.txbCols.Name = "txbCols";
            this.txbCols.Size = new System.Drawing.Size(52, 28);
            this.txbCols.TabIndex = 1;
            // 
            // trackBarCols
            // 
            this.trackBarCols.LargeChange = 1;
            this.trackBarCols.Location = new System.Drawing.Point(92, 5);
            this.trackBarCols.Name = "trackBarCols";
            this.trackBarCols.Size = new System.Drawing.Size(461, 45);
            this.trackBarCols.TabIndex = 2;
            this.trackBarCols.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Columns";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.trackBarSpeed);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(39, 155);
            this.panel5.Margin = new System.Windows.Forms.Padding(30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(722, 62);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblSpeed);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txbSpeed);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(576, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(146, 62);
            this.panel6.TabIndex = 2;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(91, 20);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(30, 22);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "/";
            // 
            // txbSpeed
            // 
            this.txbSpeed.Location = new System.Drawing.Point(12, 14);
            this.txbSpeed.Name = "txbSpeed";
            this.txbSpeed.Size = new System.Drawing.Size(52, 28);
            this.txbSpeed.TabIndex = 1;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 10;
            this.trackBarSpeed.Location = new System.Drawing.Point(92, 5);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(461, 45);
            this.trackBarSpeed.SmallChange = 10;
            this.trackBarSpeed.TabIndex = 2;
            this.trackBarSpeed.TickFrequency = 100;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(3, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Speed";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRows)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCols)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRows;
        private System.Windows.Forms.TrackBar trackBarRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCols;
        private System.Windows.Forms.TrackBar trackBarCols;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSpeed;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label9;
    }
}