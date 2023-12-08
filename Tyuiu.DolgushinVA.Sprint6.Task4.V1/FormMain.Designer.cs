
namespace Tyuiu.DolgushinVA.Sprint6.Task4.V1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_DVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DVA = new System.Windows.Forms.TextBox();
            this.groupBoxDataOutput_DVA = new System.Windows.Forms.GroupBox();
            this.chartFunction_DVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_DVA = new System.Windows.Forms.Label();
            this.textBoxResult_DVA = new System.Windows.Forms.TextBox();
            this.groupBoxDataInput_DVA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_DVA = new System.Windows.Forms.Label();
            this.labelStartStep_DVA = new System.Windows.Forms.Label();
            this.textBoxStopStep_DVA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_DVA = new System.Windows.Forms.TextBox();
            this.buttonDone_DVA = new System.Windows.Forms.Button();
            this.buttonSave_DVA = new System.Windows.Forms.Button();
            this.buttonHelp_DVA = new System.Windows.Forms.Button();
            this.groupBoxTask_DVA.SuspendLayout();
            this.groupBoxDataOutput_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DVA)).BeginInit();
            this.groupBoxDataInput_DVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_DVA
            // 
            this.groupBoxTask_DVA.Controls.Add(this.textBoxTask_DVA);
            this.groupBoxTask_DVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_DVA.Name = "groupBoxTask_DVA";
            this.groupBoxTask_DVA.Size = new System.Drawing.Size(475, 88);
            this.groupBoxTask_DVA.TabIndex = 0;
            this.groupBoxTask_DVA.TabStop = false;
            this.groupBoxTask_DVA.Text = "Условие:";
            // 
            // textBoxTask_DVA
            // 
            this.textBoxTask_DVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_DVA.Multiline = true;
            this.textBoxTask_DVA.Name = "textBoxTask_DVA";
            this.textBoxTask_DVA.ReadOnly = true;
            this.textBoxTask_DVA.Size = new System.Drawing.Size(463, 58);
            this.textBoxTask_DVA.TabIndex = 0;
            this.textBoxTask_DVA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохрать в файл OutPutFileTask.txt по нажатию к" +
    "нопки.";
            // 
            // groupBoxDataOutput_DVA
            // 
            this.groupBoxDataOutput_DVA.Controls.Add(this.chartFunction_DVA);
            this.groupBoxDataOutput_DVA.Controls.Add(this.labelResult_DVA);
            this.groupBoxDataOutput_DVA.Controls.Add(this.textBoxResult_DVA);
            this.groupBoxDataOutput_DVA.Location = new System.Drawing.Point(12, 106);
            this.groupBoxDataOutput_DVA.Name = "groupBoxDataOutput_DVA";
            this.groupBoxDataOutput_DVA.Size = new System.Drawing.Size(1209, 525);
            this.groupBoxDataOutput_DVA.TabIndex = 1;
            this.groupBoxDataOutput_DVA.TabStop = false;
            this.groupBoxDataOutput_DVA.Text = "Вывод данных:";
            // 
            // chartFunction_DVA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_DVA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_DVA.Legends.Add(legend1);
            this.chartFunction_DVA.Location = new System.Drawing.Point(310, 18);
            this.chartFunction_DVA.Name = "chartFunction_DVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_DVA.Series.Add(series1);
            this.chartFunction_DVA.Size = new System.Drawing.Size(886, 507);
            this.chartFunction_DVA.TabIndex = 2;
            this.chartFunction_DVA.Text = "chart1";
            // 
            // labelResult_DVA
            // 
            this.labelResult_DVA.AutoSize = true;
            this.labelResult_DVA.Location = new System.Drawing.Point(6, 18);
            this.labelResult_DVA.Name = "labelResult_DVA";
            this.labelResult_DVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_DVA.TabIndex = 1;
            this.labelResult_DVA.Text = "Результат:";
            // 
            // textBoxResult_DVA
            // 
            this.textBoxResult_DVA.Location = new System.Drawing.Point(6, 43);
            this.textBoxResult_DVA.Multiline = true;
            this.textBoxResult_DVA.Name = "textBoxResult_DVA";
            this.textBoxResult_DVA.ReadOnly = true;
            this.textBoxResult_DVA.Size = new System.Drawing.Size(274, 476);
            this.textBoxResult_DVA.TabIndex = 0;
            // 
            // groupBoxDataInput_DVA
            // 
            this.groupBoxDataInput_DVA.Controls.Add(this.labelStopStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.labelStartStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.textBoxStopStep_DVA);
            this.groupBoxDataInput_DVA.Controls.Add(this.textBoxStartStep_DVA);
            this.groupBoxDataInput_DVA.Location = new System.Drawing.Point(493, 12);
            this.groupBoxDataInput_DVA.Name = "groupBoxDataInput_DVA";
            this.groupBoxDataInput_DVA.Size = new System.Drawing.Size(294, 88);
            this.groupBoxDataInput_DVA.TabIndex = 2;
            this.groupBoxDataInput_DVA.TabStop = false;
            this.groupBoxDataInput_DVA.Text = "Ввод данных:";
            // 
            // labelStopStep_DVA
            // 
            this.labelStopStep_DVA.AutoSize = true;
            this.labelStopStep_DVA.Location = new System.Drawing.Point(185, 30);
            this.labelStopStep_DVA.Name = "labelStopStep_DVA";
            this.labelStopStep_DVA.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_DVA.TabIndex = 3;
            this.labelStopStep_DVA.Text = "Конец шага:";
            // 
            // labelStartStep_DVA
            // 
            this.labelStartStep_DVA.AutoSize = true;
            this.labelStartStep_DVA.Location = new System.Drawing.Point(6, 30);
            this.labelStartStep_DVA.Name = "labelStartStep_DVA";
            this.labelStartStep_DVA.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_DVA.TabIndex = 2;
            this.labelStartStep_DVA.Text = "Старт шага:";
            // 
            // textBoxStopStep_DVA
            // 
            this.textBoxStopStep_DVA.Location = new System.Drawing.Point(188, 50);
            this.textBoxStopStep_DVA.Name = "textBoxStopStep_DVA";
            this.textBoxStopStep_DVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopStep_DVA.TabIndex = 1;
            // 
            // textBoxStartStep_DVA
            // 
            this.textBoxStartStep_DVA.Location = new System.Drawing.Point(6, 50);
            this.textBoxStartStep_DVA.Name = "textBoxStartStep_DVA";
            this.textBoxStartStep_DVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_DVA.TabIndex = 0;
            // 
            // buttonDone_DVA
            // 
            this.buttonDone_DVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DVA.Location = new System.Drawing.Point(803, 30);
            this.buttonDone_DVA.Name = "buttonDone_DVA";
            this.buttonDone_DVA.Size = new System.Drawing.Size(133, 61);
            this.buttonDone_DVA.TabIndex = 3;
            this.buttonDone_DVA.Text = "Выполнить";
            this.buttonDone_DVA.UseVisualStyleBackColor = false;
            this.buttonDone_DVA.Click += new System.EventHandler(this.buttonDone_DVA_Click);
            // 
            // buttonSave_DVA
            // 
            this.buttonSave_DVA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave_DVA.Location = new System.Drawing.Point(951, 30);
            this.buttonSave_DVA.Name = "buttonSave_DVA";
            this.buttonSave_DVA.Size = new System.Drawing.Size(120, 61);
            this.buttonSave_DVA.TabIndex = 4;
            this.buttonSave_DVA.Text = "Сохранить";
            this.buttonSave_DVA.UseVisualStyleBackColor = false;
            this.buttonSave_DVA.Click += new System.EventHandler(this.buttonSave_DVA_Click);
            // 
            // buttonHelp_DVA
            // 
            this.buttonHelp_DVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_DVA.Location = new System.Drawing.Point(1086, 30);
            this.buttonHelp_DVA.Name = "buttonHelp_DVA";
            this.buttonHelp_DVA.Size = new System.Drawing.Size(122, 61);
            this.buttonHelp_DVA.TabIndex = 5;
            this.buttonHelp_DVA.Text = "Справка";
            this.buttonHelp_DVA.UseVisualStyleBackColor = false;
            this.buttonHelp_DVA.Click += new System.EventHandler(this.buttonHelp_DVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 643);
            this.Controls.Add(this.buttonHelp_DVA);
            this.Controls.Add(this.buttonSave_DVA);
            this.Controls.Add(this.buttonDone_DVA);
            this.Controls.Add(this.groupBoxDataInput_DVA);
            this.Controls.Add(this.groupBoxDataOutput_DVA);
            this.Controls.Add(this.groupBoxTask_DVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 1 | Долгушин В. А.";
            this.groupBoxTask_DVA.ResumeLayout(false);
            this.groupBoxTask_DVA.PerformLayout();
            this.groupBoxDataOutput_DVA.ResumeLayout(false);
            this.groupBoxDataOutput_DVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DVA)).EndInit();
            this.groupBoxDataInput_DVA.ResumeLayout(false);
            this.groupBoxDataInput_DVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataOutput_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataInput_DVA;
        private System.Windows.Forms.TextBox textBoxTask_DVA;
        private System.Windows.Forms.Label labelStopStep_DVA;
        private System.Windows.Forms.Label labelStartStep_DVA;
        private System.Windows.Forms.TextBox textBoxStopStep_DVA;
        private System.Windows.Forms.TextBox textBoxStartStep_DVA;
        private System.Windows.Forms.Label labelResult_DVA;
        private System.Windows.Forms.TextBox textBoxResult_DVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DVA;
        private System.Windows.Forms.Button buttonDone_DVA;
        private System.Windows.Forms.Button buttonSave_DVA;
        private System.Windows.Forms.Button buttonHelp_DVA;
    }
}

