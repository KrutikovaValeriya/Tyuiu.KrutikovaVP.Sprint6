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
using Tyuiu.KrutikovaVP.Sprint6.Task7.V28.Lib;
namespace Tyuiu.KrutikovaVP.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KVP.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KVP.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPutMatrix_KVP.ColumnCount = 50;
            dataGridViewOutPutMatrix_KVP.ColumnCount = 50;

            dataGridViewInPutMatrix_KVP.RowCount = 50;
            dataGridViewOutPutMatrix_KVP.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPutMatrix_KVP.Columns[i].Width = 25;
                dataGridViewOutPutMatrix_KVP.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_KVP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KVP.ShowDialog();
            openFilePath = openFileDialogTask_KVP.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPutMatrix_KVP.ColumnCount = colums;
            dataGridViewInPutMatrix_KVP.RowCount = rows;
            dataGridViewOutPutMatrix_KVP.ColumnCount = colums;
            dataGridViewOutPutMatrix_KVP.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInPutMatrix_KVP.Columns[i].Width = 25;
                dataGridViewOutPutMatrix_KVP.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPutMatrix_KVP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KVP.Enabled = true;
        }

        private void buttonDone_KVP_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutPutMatrix_KVP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_KVP.Enabled = true;
        }

        private void buttonSaveFile_KVP_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KVP.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KVP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KVP.ShowDialog();

            string path = saveFileDialogMatrix_KVP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutMatrix_KVP.RowCount;
            int columns = dataGridViewOutPutMatrix_KVP.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPutMatrix_KVP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPutMatrix_KVP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_KVP_MouseClick(object sender, MouseEventArgs e)
        {
            toolTipButton_KVP.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KVP_MouseClick(object sender, MouseEventArgs e)
        {
            toolTipButton_KVP.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KVP_MouseClick(object sender, MouseEventArgs e)
        {
            toolTipButton_KVP.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KVP_MouseClick(object sender, MouseEventArgs e)
        {
            toolTipButton_KVP.ToolTipTitle = "Справка";
        }

        private void buttonHelp_KVP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
