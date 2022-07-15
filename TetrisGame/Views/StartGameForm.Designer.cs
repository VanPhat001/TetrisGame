namespace TetrisGame.Views
{
    partial class StartGameForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelStart = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelRestart = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelBack = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanelBoard = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableModel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableModel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableModel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanelBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStart,
            this.toolStripLabelRestart,
            this.toolStripLabelBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(969, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelStart
            // 
            this.toolStripLabelStart.Name = "toolStripLabelStart";
            this.toolStripLabelStart.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabelStart.Text = "Start";
            this.toolStripLabelStart.Click += new System.EventHandler(this.toolStripLabelStart_Click);
            // 
            // toolStripLabelRestart
            // 
            this.toolStripLabelRestart.Name = "toolStripLabelRestart";
            this.toolStripLabelRestart.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabelRestart.Text = "Restart";
            this.toolStripLabelRestart.Click += new System.EventHandler(this.toolStripLabelRestart_Click);
            // 
            // toolStripLabelBack
            // 
            this.toolStripLabelBack.Name = "toolStripLabelBack";
            this.toolStripLabelBack.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabelBack.Text = "Back";
            this.toolStripLabelBack.Click += new System.EventHandler(this.toolStripLabelBack_Click);
            // 
            // tableLayoutPanelBoard
            // 
            this.tableLayoutPanelBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelBoard.ColumnCount = 1;
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanelBoard.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanelBoard.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanelBoard.Name = "tableLayoutPanelBoard";
            this.tableLayoutPanelBoard.RowCount = 1;
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanelBoard.Size = new System.Drawing.Size(735, 410);
            this.tableLayoutPanelBoard.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(727, 402);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableModel2);
            this.panel1.Controls.Add(this.tableModel3);
            this.panel1.Controls.Add(this.tableModel1);
            this.panel1.Location = new System.Drawing.Point(753, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 408);
            this.panel1.TabIndex = 2;
            // 
            // tableModel1
            // 
            this.tableModel1.ColumnCount = 1;
            this.tableModel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableModel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableModel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableModel1.Location = new System.Drawing.Point(0, 0);
            this.tableModel1.Name = "tableModel1";
            this.tableModel1.RowCount = 1;
            this.tableModel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableModel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableModel1.Size = new System.Drawing.Size(204, 114);
            this.tableModel1.TabIndex = 0;
            // 
            // tableModel3
            // 
            this.tableModel3.ColumnCount = 1;
            this.tableModel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableModel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableModel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableModel3.Location = new System.Drawing.Point(0, 300);
            this.tableModel3.Name = "tableModel3";
            this.tableModel3.RowCount = 1;
            this.tableModel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableModel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableModel3.Size = new System.Drawing.Size(204, 108);
            this.tableModel3.TabIndex = 1;
            // 
            // tableModel2
            // 
            this.tableModel2.ColumnCount = 1;
            this.tableModel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableModel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableModel2.Location = new System.Drawing.Point(0, 152);
            this.tableModel2.Name = "tableModel2";
            this.tableModel2.RowCount = 1;
            this.tableModel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableModel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableModel2.Size = new System.Drawing.Size(204, 108);
            this.tableModel2.TabIndex = 2;
            // 
            // StartGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanelBoard);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StartGameForm";
            this.Text = "StartGameForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanelBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRestart;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoard;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableModel2;
        private System.Windows.Forms.TableLayoutPanel tableModel3;
        private System.Windows.Forms.TableLayoutPanel tableModel1;
    }
}