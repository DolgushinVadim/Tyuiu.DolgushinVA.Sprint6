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
using Tyuiu.DolgushinVA.Sprint6.Task4.V1.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task4.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_DVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_DVA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_DVA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_DVA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_DVA.ChartAreas[0].AxisY.Title = "Ocь Y";
                textBoxResult_DVA.Text = "";
                chartFunction_DVA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_DVA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_DVA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_DVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИП6-23-3 Долгушин Вадим Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSave_DVA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask4.txt";
                File.WriteAllText(path, textBoxResult_DVA.Text);
                DialogResult dialogResult = MessageBox.Show("Фaйл " + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообшение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                MessageBox.Show("Сбой при соxранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
