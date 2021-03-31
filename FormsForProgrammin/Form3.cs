using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
namespace FormsForProgrammin
{
    public partial class Form3 : Form
    {
        string rowCountForFirstMatrix;
        string columnCountForFirstMatrix;
        string rowCountForSecondMatrix;
        string columnCountForSecondMatrix;
        int[,] firstMatrix;
        int[,] secondMatrix;
        int[,] resultMatrix;
        const string firstMatrixFilePath = @"C:\Users\Sevka\source\repos\FormsForProgrammin\FormsForProgrammin\firstMatrix.txt";
        const string secondMatrixFilePath = @"C:\Users\Sevka\source\repos\FormsForProgrammin\FormsForProgrammin\SecondMatrix.txt";
        const char Seperator = ' ';
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();


            rowCountForFirstMatrix = Interaction.InputBox("Введіть, будь ласка, кількість рядків для першої матриці", "Кількість рядків");
            columnCountForFirstMatrix = Interaction.InputBox("Введіть, будь ласка, кількість стовпців для першої матриці", "Кількість стовпців");

            rowCountForSecondMatrix = Interaction.InputBox("Введіть, будь ласка, кількість рядків для другої матриці", "Кількість рядків");
            columnCountForSecondMatrix = Interaction.InputBox("Введіть, будь ласка, кількість стовпців для другої матриці", "Кількість стовпців");

            if(columnCountForFirstMatrix==rowCountForSecondMatrix&&rowCountForFirstMatrix!=columnCountForSecondMatrix)
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
            }
            if(rowCountForFirstMatrix == rowCountForSecondMatrix && columnCountForFirstMatrix == columnCountForSecondMatrix)
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            if(columnCountForFirstMatrix!=rowCountForSecondMatrix)
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            dataGridView1.RowCount = int.Parse(rowCountForFirstMatrix);
            dataGridView1.ColumnCount = int.Parse(columnCountForFirstMatrix);

            dataGridView2.RowCount = int.Parse(rowCountForSecondMatrix);
            dataGridView2.ColumnCount = int.Parse(columnCountForSecondMatrix);

            dataGridView3.RowCount = int.Parse(rowCountForFirstMatrix);
            dataGridView3.ColumnCount = int.Parse(columnCountForSecondMatrix);

            firstMatrix = new int[int.Parse(rowCountForFirstMatrix), int.Parse(columnCountForFirstMatrix)];
            secondMatrix = new int[int.Parse(rowCountForSecondMatrix), int.Parse(columnCountForSecondMatrix)];
            resultMatrix = new int[int.Parse(rowCountForFirstMatrix), int.Parse(columnCountForFirstMatrix)];

            
        }
        private void countMatrix()
        {
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    firstMatrix[i, j] = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }

            for (int i = 0; i <secondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    secondMatrix[i, j] = int.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            label1.Font = new Font(label1.Font.FontFamily, 20);
            this.label1.Location = new Point(379,120);
            countMatrix();

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = (int)firstMatrix[i, j] + (int)secondMatrix[i, j];
                    dataGridView3.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            label1.Font = new Font(label1.Font.FontFamily, 20);
            this.label1.Location = new Point(379, 120);
            countMatrix();

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = (int)firstMatrix[i, j] - (int)secondMatrix[i, j];
                    dataGridView3.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            label1.Font = new Font(label1.Font.FontFamily, 20);
            this.label1.Location = new Point(379, 120);
            countMatrix();

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < firstMatrix.GetLength(1); k++)
                    {
                        resultMatrix[i, j] += (int)firstMatrix[i, k] * (int)secondMatrix[k, j];
                        dataGridView3.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }
            }
        }

        private int[,] ReadArrayFromFile(string file)
        {
            StreamReader file_ = new StreamReader(file);
            string s = file_.ReadToEnd();
            file_.Close();
            string[] row = s.Split('\n');
            string[] column = row[0].Split(' ');
            int[,] a = new int[row.Length, column.Length];
            int t = 0;
            int n = 0;
            for (int i = 0; i < row.Length; i++)
            {
                column = row[i].Split(' ');
                for (int j = 0; j < column.Length; j++)
                {
                    t = Convert.ToInt32(column[j]);
                    a[i, j] = t;
                }
            }

            return a;
        }

        private void GetMatrixFromFile()
        {
            firstMatrix = ReadArrayFromFile(firstMatrixFilePath);
            dataGridView1.RowCount = firstMatrix.GetLength(0);
            dataGridView1.ColumnCount = firstMatrix.GetLength(1);
            secondMatrix = ReadArrayFromFile(secondMatrixFilePath);
            dataGridView2.RowCount = secondMatrix.GetLength(0);
            dataGridView2.ColumnCount = secondMatrix.GetLength(1);
            dataGridView3.RowCount = firstMatrix.GetLength(0);
            dataGridView3.ColumnCount = secondMatrix.GetLength(1);

            if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0) && firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
            }
            if (firstMatrix.GetLength(0)==secondMatrix.GetLength(0) && firstMatrix.GetLength(1) == secondMatrix.GetLength(1))
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                   dataGridView1.Rows[i].Cells[j].Value = firstMatrix[i, j];
                }
            }

            for (int i = 0; i < secondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = secondMatrix[i, j];
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            GetMatrixFromFile();
            resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            rowCountForFirstMatrix = Interaction.InputBox("Введіть, будь ласка, кількість рядків для першої матриці", "Кількість рядків");
            columnCountForFirstMatrix = Interaction.InputBox("Введіть, будь ласка, кількість стовпців для першої матриці", "Кількість стовпців");
            rowCountForSecondMatrix = Interaction.InputBox("Введіть, будь ласка, кількість рядків для другої матриці", "Кількість рядків");
            columnCountForSecondMatrix = Interaction.InputBox("Введіть, будь ласка, кількість стовпців для другої матриці", "Кількість стовпців");

            if (columnCountForFirstMatrix == rowCountForSecondMatrix && rowCountForFirstMatrix != columnCountForSecondMatrix)
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
            }
            if (rowCountForFirstMatrix == rowCountForSecondMatrix && columnCountForFirstMatrix == columnCountForSecondMatrix)
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            if (columnCountForFirstMatrix != rowCountForSecondMatrix)
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            dataGridView1.RowCount = int.Parse(rowCountForFirstMatrix);
            dataGridView1.ColumnCount = int.Parse(columnCountForFirstMatrix);

            dataGridView2.RowCount = int.Parse(rowCountForSecondMatrix);
            dataGridView2.ColumnCount = int.Parse(columnCountForSecondMatrix);

            dataGridView3.RowCount = int.Parse(rowCountForFirstMatrix);
            dataGridView3.ColumnCount = int.Parse(columnCountForSecondMatrix);

            firstMatrix = new int[int.Parse(rowCountForFirstMatrix), int.Parse(columnCountForFirstMatrix)];
            secondMatrix = new int[int.Parse(rowCountForSecondMatrix), int.Parse(columnCountForSecondMatrix)];
            resultMatrix = new int[int.Parse(rowCountForFirstMatrix), int.Parse(columnCountForFirstMatrix)];

            Random r = new Random();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    firstMatrix[i, j] = r.Next(3, 10);
                    dataGridView1.Rows[i].Cells[j].Value = firstMatrix[i, j];
                }
            }

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    secondMatrix[i, j] = r.Next(3, 10);
                    dataGridView2.Rows[i].Cells[j].Value = secondMatrix[i, j];
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Чи ви впевнені що хочете вийти?",
        "Увага!",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    } 








}
    

