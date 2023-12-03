using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KrutikovaVP.Sprint6.Task2.V10.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KVP_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KVP.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KVP.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_KVP.Titles.Add("График функции f(x)");

                this.chartFunction_KVP.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KVP.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i<=len-1; i++)
                {
                    this.dataGridViewFunction_KVP.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_KVP.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void buttonDone_KVP_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KVP.BackColor = Color.Blue;
        }

        private void buttonDone_KVP_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KVP.BackColor = Color.Red;
        }

        private void buttonDone_KVP_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KVP.BackColor = Color.Green;
        }

        private void buttonInfo_KVP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, вариант 10 выполнил студент группы АСОиУб-23-3 Крутикова Валерия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

        
    }
