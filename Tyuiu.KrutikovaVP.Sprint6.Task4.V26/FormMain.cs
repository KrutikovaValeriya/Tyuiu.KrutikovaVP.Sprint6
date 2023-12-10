using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KrutikovaVP.Sprint6.Task4.V26.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task4.V26
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

                this.chartFunction_KVP.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KVP.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_KVP.Text = "";

                chartFunction_KVP.Series[0].Points.Clear();
                for (int i = 0; i<= len - 1; i++)
                {
                    this.chartFunction_KVP.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KVP.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
                
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSaveData_KVP_Click(object sender, EventArgs e)
        {
            try
            { 
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V26.txt";
                File.WriteAllText(path, textBoxResult_KVP.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_KVP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4, вариант 26 выполнил студент группы АСОиУб-23-3 Крутикова Валерия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
