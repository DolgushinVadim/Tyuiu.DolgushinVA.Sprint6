using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DolgushinVA.Sprint6.Task5.V26.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V26.txt";
        private void buttonDone_DVA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_DVA.ColumnCount = 2;
            dataGridViewNums_DVA.Columns[0].Width = 30;
            dataGridViewNums_DVA.Columns[1].Width = 70;
            this.chartDiag_DVA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiag_DVA.ChartAreas[0].AxisY.Title = "Ocb Y";
            chartDiag_DVA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_DVA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_DVA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_DVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИП6-23-3 Долгушин Вадим Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
