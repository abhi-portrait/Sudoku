using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGame
{

    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
            this.Text = "SUDOKU";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Build();
            game = new Game(DGV1);
            //  game.DGV = DGV1;
            DGV1.Invalidate();
            this.SizeChanged += new EventHandler(Form1_SizeChanged);
        }

        public void Build()
        {
            DGV1.AllowUserToAddRows = false;
            DGV1.AllowUserToDeleteRows = false;
            DGV1.AllowUserToResizeColumns = false;
            DGV1.AllowUserToResizeRows = false;
            DGV1.RowHeadersVisible = false;
            DGV1.ColumnHeadersVisible = false;
            DGV1.ScrollBars = ScrollBars.None;
            DGV1.GridColor = Color.Black;
            DGV1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV1.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV1.ColumnCount = 9;
            DGV1.Rows.Add(9);
            DGV1.MultiSelect = false;                                

            for (int i = 0; i < 9; i++)
            {
                DataGridViewColumn column = DGV1.Columns[i];
                column.Width = (int)(DGV1.Width / 9f);
                DataGridViewRow row = DGV1.Rows[i];
                row.Height = (int)(DGV1.Height / 9f);
            }
            DGV1.Width = DGV1.Columns[1].Width * 9;         

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    DGV1.Rows[i].Cells[j].Style.BackColor = Color.LightCyan; 
                }

            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    DGV1.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    DGV1.Rows[j].Cells[i].Style.BackColor = Color.LightBlue;
                }

            }

            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    DGV1.Rows[i].Cells[j].Style.BackColor = Color.LightCyan;
                    //DGV1.Rows[j].Cells[i].Style.BackColor = Color.LightBlue;
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game(DGV1);
            HistoryList.Items.Clear();
        }

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                game.DGV1 = DGV1;
                bool val = game.NewValidate();
                if (val == false)
                    MessageBox.Show("Wrong!");
                else
                    MessageBox.Show("Right");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (game == null)
                game = new Game(DGV1);

            game.Open();
            HistoryList.Items.Clear();
            DGV1.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (game != null)
                game.Save();
        }

        private void ColumnResize(int arrayLenght)
        {
           
            for (int i = 0; i < arrayLenght; i++)
            {
                DataGridViewColumn column = DGV1.Columns[i];
                column.Width = (int)(DGV1.Width / 9f);
                DataGridViewRow row = DGV1.Rows[i];
                row.Height = (int)(DGV1.Height / 9f);
            }

             
            foreach (DataGridViewColumn c in DGV1.Columns)
            {
                float w = DGV1.Width;
                double s = (double)Math.Round(16 * w / 324) * 1.5;
                float s_f = (float)s;
                c.DefaultCellStyle.Font = new Font("Arial", s_f, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewRow c in DGV1.Rows)
            {
                float w = DGV1.Height;
                double s = (double)Math.Round(16 * w / 324) * 1.5;
                float s_f = (float)s;
                c.DefaultCellStyle.Font = new Font("Arial", s_f, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            DGV1.CurrentCell.Value = null;
            e.Control.KeyPress += delegate(object pressSender, KeyPressEventArgs pressE)
           {
                if (!Char.IsDigit(pressE.KeyChar) && !Char.IsControl(pressE.KeyChar))
                {
                    if (pressE.KeyChar == '0' | pressE.KeyChar == '1' | pressE.KeyChar == '2' | pressE.KeyChar == '3' |
                        pressE.KeyChar == '4' | pressE.KeyChar == '5' | pressE.KeyChar == '6' |
                        pressE.KeyChar == '7' | pressE.KeyChar == '8' | pressE.KeyChar > '9')
                        pressE.Handled = true;
                }
                else
                {
                    pressE.Handled = false;
                }
            };

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                game.DGV1 = DGV1;
                bool val = game.CancelGame();
                if (val == false)
                    MessageBox.Show("Wrong!");
                else
                {
                    MessageBox.Show("You win!");
                  //  game.Save();
                }
            }
        }

        protected void Form1_SizeChanged(object sender, EventArgs e)
        {
            DGV1.Height = (int)(this.Height / 9) * 9 - 99;
            DGV1.Width = DGV1.Height;
            this.InfoPanel.Location = new Point(DGV1.Width+45, 37);           
            ColumnResize(9);
        }

        private void DGV1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //MessageBox.Show("OK");  
            HistoryList.Items.Add(String.Format("({0}, {1})", e.RowIndex + 1, e.ColumnIndex + 1));
        }

        private void solveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                game.DGV1 = DGV1;
                game.Solse();
                MessageBox.Show("Solved!");
            }
        }
    }

}

