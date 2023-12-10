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
using Tyuiu.KrutikovaVP.Sprint6.Task6.V26.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_KVP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KVP.ShowDialog();
            openFilePath = openFileDialogTask_KVP.FileName;
            textBoxLoadFromFile_KVP.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_KVP.Text = groupBoxOutPutData_KVP.Text + " " + openFileDialogTask_KVP.FileName;
            buttonDone_KVP.Enabled = true;
        }

        private void buttonDone_KVP_Click(object sender, EventArgs e)
        {
            textBoxResult_KVP.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KVP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
