using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DolgushinVA.Sprint6.Task2.V9.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task2.V9
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

                this.chartFunction_DVA.Titles.Add("График функции");
                this.chartFunction_DVA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_DVA.ChartAreas[0].AxisY.Title = "Ocь Y";

                for (int i = 0; i < len - 1; i++)
                {
                    this.dataGridViewFunction_DVA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_DVA.Series[0].Points.AddXY(startStep, valueArray[i]);
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
            MessageBox.Show("Таск 2 выполнен студентом группы ИИП6-23-3 Долгушин Вадим", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
