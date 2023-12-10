using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KrutikovaVP.Sprint6.Task5.V27.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V27.txt";

        private void buttonDone_KVP_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KVP.ColumnCount = 2;
            dataGridViewResult_KVP.Columns[0].Width = 20;
            dataGridViewResult_KVP.Columns[1].Width = 50;

            this.chartDiagr_KVP.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagr_KVP.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagr_KVP.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i =0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KVP.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiagr_KVP.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_KVP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KVP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5, вариант 27 выполнил студент группы АСОиУб-23-3 Крутикова Валерия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
    
}
