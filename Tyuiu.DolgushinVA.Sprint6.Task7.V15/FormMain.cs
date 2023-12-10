using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.DolgushinVA.Sprint6.Task7.V15.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int colums;
        static string openFilePath;
        public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_m = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_m[j]);
                }
            }
            return arrayValues;
        }
        private void buttonHelp_DVA_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }
        private void buttonDone_DVA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutMatrix_DVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_DVA.Enabled = true;
        }
        private void buttonSaveFile_DVA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_DVA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_DVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_DVA.ShowDialog();

            string path = saveFileDialogMatrix_DVA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_DVA.RowCount;
            int colums = dataGridViewOutMatrix_DVA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOutMatrix_DVA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_DVA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_DVA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DVA.ShowDialog();
            openFilePath = openFileDialogTask_DVA.FileName;
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInMatrix_DVA.ColumnCount = colums;
            dataGridViewInMatrix_DVA.RowCount = rows;
            dataGridViewOutMatrix_DVA.ColumnCount = colums;
            dataGridViewOutMatrix_DVA.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInMatrix_DVA.Columns[i].Width = 25;
                dataGridViewOutMatrix_DVA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInMatrix_DVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_DVA.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_DVA.ColumnCount = 50;
            dataGridViewOutMatrix_DVA.ColumnCount = 50;
            dataGridViewOutMatrix_DVA.RowCount = 50;
            dataGridViewInMatrix_DVA.RowCount = 50;
        }
    }
}
