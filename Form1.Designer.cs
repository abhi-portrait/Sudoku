namespace SGame
{
    partial class Form1
    {
        /// <summary>
        
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
       
        /// </summary>

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
       
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаГраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевіритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирішитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаГраToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.перевіритиToolStripMenuItem,
            this.завершитиToolStripMenuItem,
            this.вирішитиToolStripMenuItem,
            this.вийтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            
            // 
            this.новаГраToolStripMenuItem.Name = "новаГраToolStripMenuItem";
            this.новаГраToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.новаГраToolStripMenuItem.Text = "New game";
            this.новаГраToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
          
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.зберегтиToolStripMenuItem.Text = "Save";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.відкритиToolStripMenuItem.Text = "Open";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
           
            // 
            this.перевіритиToolStripMenuItem.Name = "перевіритиToolStripMenuItem";
            this.перевіритиToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.перевіритиToolStripMenuItem.Text = "Verify";
            this.перевіритиToolStripMenuItem.Click += new System.EventHandler(this.verifyToolStripMenuItem_Click);
            // 
            
            // 
            this.завершитиToolStripMenuItem.Name = "завершитиToolStripMenuItem";
            this.завершитиToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.завершитиToolStripMenuItem.Text = "Finish";
            this.завершитиToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            
            // 
            this.вирішитиToolStripMenuItem.Name = "вирішитиToolStripMenuItem";
            this.вирішитиToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.вирішитиToolStripMenuItem.Text = "Solve";
            this.вирішитиToolStripMenuItem.Click += new System.EventHandler(this.solveToolStripMenuItem_Click);
            // 
            
            // 
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вийтиToolStripMenuItem.Text = "Close";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // DGV1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.NullValue = null;
            this.DGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.Location = new System.Drawing.Point(19, 37);
            this.DGV1.Margin = new System.Windows.Forms.Padding(10);
            this.DGV1.MinimumSize = new System.Drawing.Size(324, 324);
            this.DGV1.Name = "DGV1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV1.RowTemplate.DefaultCellStyle.Format = "N0";
            this.DGV1.RowTemplate.DefaultCellStyle.NullValue = null;
            this.DGV1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV1.Size = new System.Drawing.Size(324, 324);
            this.DGV1.TabIndex = 0;
            this.DGV1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DGV1_CellBeginEdit);
            this.DGV1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // HistoryList
            // 
            this.HistoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryList.FormattingEnabled = true;
            this.HistoryList.ItemHeight = 24;
            this.HistoryList.Location = new System.Drawing.Point(0, 22);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(103, 292);
            this.HistoryList.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.HistoryList);
            this.InfoPanel.Location = new System.Drawing.Point(368, 37);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(72, 332);
            this.InfoPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moves:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 376);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(480, 415);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаГраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевіритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитиToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.ListBox HistoryList;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem вирішитиToolStripMenuItem;
    }
}

