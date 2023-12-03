using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KrutikovaVP.Sprint6.Task3.V11.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 27, -15,14, 2, 27 },
                                                {-8, 14, -10, 33, 0 },
                                                    {1, 7, -11, -11, 23 },
                                                   { -13, -20, 15, 16, 34},
                                                {-3, 1, -1, 5, 1 } };

        private void buttonDone_KVP_Click(object sender, EventArgs e)
        {
            var sortedMtrx = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_KVP.ColumnCount = columns;
            dataGridViewResult_KVP.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_KVP.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_KVP.Rows[i].Cells[j].Value = Convert.ToString(sortedMtrx[i,j]);
                }
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length/rows;

            dataGridViewInPutData_KVP.ColumnCount = columns;
            dataGridViewInPutData_KVP.RowCount = rows;
            for(int i =0; i<columns; i++)
            {
                dataGridViewInPutData_KVP.Columns[i].Width = 25;
            }
            for (int i  = 0; i<rows; i++)
            {
                for (int j =0; j<columns; j++)
                {
                    dataGridViewInPutData_KVP.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonHelp_KVP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, вариант 11 выполнил студент группы АСОиУб-23-3 Крутикова Валерия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
