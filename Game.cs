using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SGame;




namespace SGame
{

    class Game
    {
       
        Random random = new Random();

        public DataGridView DGV1 { get; set; }

        public int[,] array = new int[9, 9];
        public int[,] solve = new int[9,9];

        public int Count = 37;

        public Game()
        {
            
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                }
            }
        }

        public Game(DataGridView DGV)
            : this()
        {
            this.DGV1 = DGV;
            Permutation();
        }

        public void Permutation()
        {
            PermFunc.Mix(array);
            solve = Copy(array, solve);
            DeleteCell();
            ShowIt(array);
        }
        public void DeleteCell()
        {
            int DeleteCount = 81 - Count;
            bool[,] Checked = new bool[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Checked[i, j] = false;
                }
            }

            for (int i = 0; i < DeleteCount; i++)
            {
                int a = random.Next(0, 9);
                int b = random.Next(0, 9);
                if (Checked[a, b] == false)
                {
                    array[a, b] = 0;
                    Checked[a, b] = true;
                }
                else
                {
                    DeleteCount += 1;
                }
            }
        }

        public void ShowIt(int[,] show)
        {
            for (int i = 0; i <9 ;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (show[i, j] == 0) 
                        DGV1[j, i].Value = "";
                    else
                      DGV1[j, i].Value = show[i, j];
                }
            }
        }

        public void Save()
        {
            string txt = "";

            string temp;
            int dec;

            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
            sfd.Filter = "Sudoku Files (*.sdk)|*.sdk";
            sfd.AddExtension = true;
            sfd.OverwritePrompt = true;
            sfd.Title = "Save Sudoku file";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    temp = (DGV1[i, j].Value.ToString());
                    if (temp == "")
                    {
                        temp = "0";
                    }
                    dec = Convert.ToInt32(temp);
                    if (dec == 0)
                    { txt += "0"; }
                    else
                    { txt += DGV1[i, j].Value.ToString(); }
                }
            }

            System.Windows.Forms.DialogResult r = sfd.ShowDialog();

            try
            {
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, txt);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error saving sudoku file!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Open()
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Filter = "Sudoku Files (*.sdk)|*.sdk";
            ofd.Multiselect = false;
            ofd.Title = "Open sudoku file";

            System.Windows.Forms.DialogResult r = ofd.ShowDialog();

            try
            {
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    string txt = System.IO.File.ReadAllText(ofd.FileName);

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            DGV1[j, i].Value = 0;
                        }
                    }
                    int a = 0;
                    int b = 0;
                    for (int i = 0; i < txt.Length; i++)
                    {
                        string ss = txt[i].ToString();
                        int vl = 0;
                        if (int.TryParse(ss, out vl))
                        {
                            a = (i / 9);
                            b = i % 9;
                            array[a, b] = vl;
                        }
                    }
                    ShowIt(array);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error opening sudoku file!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public int SetValue(int[,] mass, int i, int j)
        {
            string temp = "";
            int one = 0;
            if (DGV1[j, i].Value == null) 
                return one;

            temp = DGV1[j, i].Value.ToString();
                 if (temp == "")
                      temp = "0";

            one = Convert.ToInt32(temp);
            return one;
        }

        public bool NewValidate()
        {
            int[,] mass = new int[9, 9];

            int one = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    one = SetValue(mass, i, j);
                    mass[i, j] = one;
                }
            }
            if (!VerifyRows(mass))
                return false;
            if (!VeryfyColumns(mass))
                return false;
            if (!VeryfySquares(mass))
                return false;
            return true;
        }

        private bool VeryfySquares(int[,] mass)
        {
            int val = 0;
            for (int n = 0; n < 3; n++)
            {
                for (int m = 0; m < 3; m++)
                {
                    List<int> list = new List<int>(9);
                    for (int i = 0 + n * 3; i < 3 + n * 3; i++)
                    {
                        for (int j = 0 + 3 * m; j < 3 + 3 * m; j++)
                        {
                            val = mass[i, j];
                            if (val == 0)
                            {
                                continue;
                            }
                            if (list.Contains(val))
                            {
                                MessageBox.Show(val.ToString());
                                return false;
                            }

                            else
                                list.Add(val);
                        }
                    }
                }
            }
            return true;
        }

        public bool VerifyRows(int[,] mass)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = j + 1; k < 9; k++)
                    {
                        if (mass[i, j] == 0 | mass[i, k] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (mass[i, j] == mass[i, k])
                            {
                                MessageBox.Show(mass[i,j].ToString());
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool VeryfyColumns(int[,] mass)
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = j + 1; k < 9; k++)
                    {
                        if (mass[j, i] == 0 | mass[k, i] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (mass[j, i] == mass[k, i])
                            {
                                MessageBox.Show(mass[j, i].ToString());
                                return false;
                            }
                        }
                    }


                }
            }
            return true;
        }

        public bool CancelGame()
        {
            int[,] mass = new int[9, 9];

            int one = 0;
            if (!NewValidate())
            {
                return false;
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        one = SetValue(mass, i, j);
                        if (one==0)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public void Solse()
        {
            ShowIt(solve);
        }

        public int[,] Copy(int[,] array, int[,] solve)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    solve[i, j] = array[i, j];
                }
            }
            return solve;
        }
    }
}


        
    /*    public bool Validate()
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                List<int> obj = new List<int>(9);
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!Validate(cell, obj))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
      
        public bool Validate(DataGridViewCell cell, List<int> obj)
        {
            string temp;
            int v;

            if (cell.Value.ToString()==null)
            {
                return true;   
            }
            if ((cell.Value.ToString() != ""))
            {
                temp = cell.Value.ToString();
                v = Convert.ToInt32(temp);
                if (obj.Contains(v))
                    return false;
                else
                    obj.Add(v);
            }
            return true;
        }*/
       
