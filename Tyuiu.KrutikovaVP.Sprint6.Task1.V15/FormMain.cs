using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KrutikovaVP.Sprint6.Task1.V15.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task1.V15
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
                int startStep = Convert.ToInt32(textBoxVarStartStep_KVP.Text);
                int stopStep = Convert.ToInt32(textBoxVarStopStep_KVP.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                string strLine;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KVP.Text = "";
                textBoxResult_KVP.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KVP.AppendText("|    X     +   f(x)   +" + Environment.NewLine);
                textBoxResult_KVP.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  | ", startStep, valueArray[i]);
                    textBoxResult_KVP.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_KVP.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KVP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1, вариант 15 выполнил студент группы АСОиУб-23-3 Крутикова Валерия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
