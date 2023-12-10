
namespace Tyuiu.DolgushinVA.Sprint6.Task5.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_DVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DVA = new System.Windows.Forms.TextBox();
            this.groupBoxDataOutput_DVA = new System.Windows.Forms.GroupBox();
            this.chartDiag_DVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_DVA = new System.Windows.Forms.Label();
            this.dataGridViewNums_DVA = new System.Windows.Forms.DataGridView();
            this.buttonDone_DVA = new System.Windows.Forms.Button();
            this.buttonOpenFile_DVA = new System.Windows.Forms.Button();
            this.buttonHelp_DVA = new System.Windows.Forms.Button();
            this.groupBoxTask_DVA.SuspendLayout();
            this.groupBoxDataOutput_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_DVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_DVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DVA
            // 
            this.groupBoxTask_DVA.Controls.Add(this.textBoxTask_DVA);
            this.groupBoxTask_DVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_DVA.Name = "groupBoxTask_DVA";
            this.groupBoxTask_DVA.Size = new System.Drawing.Size(515, 81);
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
            this.textBoxTask_DVA.Size = new System.Drawing.Size(503, 54);
            this.textBoxTask_DVA.TabIndex = 0;
            this.textBoxTask_DVA.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView\r\nвсе числа, " +
    "кратные 5, и построить диаграмму по этим значениям.";
            // 
            // groupBoxDataOutput_DVA
            // 
            this.groupBoxDataOutput_DVA.Controls.Add(this.chartDiag_DVA);
            this.groupBoxDataOutput_DVA.Controls.Add(this.labelResult_DVA);
            this.groupBoxDataOutput_DVA.Controls.Add(this.dataGridViewNums_DVA);
            this.groupBoxDataOutput_DVA.Location = new System.Drawing.Point(12, 99);
            this.groupBoxDataOutput_DVA.Name = "groupBoxDataOutput_DVA";
            this.groupBoxDataOutput_DVA.Size = new System.Drawing.Size(886, 507);
            this.groupBoxDataOutput_DVA.TabIndex = 1;
            this.groupBoxDataOutput_DVA.TabStop = false;
            this.groupBoxDataOutput_DVA.Text = "Ввод данных:";
            // 
            // chartDiag_DVA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDiag_DVA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDiag_DVA.Legends.Add(legend3);
            this.chartDiag_DVA.Location = new System.Drawing.Point(151, 41);
            this.chartDiag_DVA.Name = "chartDiag_DVA";
            this.chartDiag_DVA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDiag_DVA.Series.Add(series3);
            this.chartDiag_DVA.Size = new System.Drawing.Size(717, 460);
            this.chartDiag_DVA.TabIndex = 2;
            this.chartDiag_DVA.Text = "chart1";
            // 
            // labelResult_DVA
            // 
            this.labelResult_DVA.AutoSize = true;
            this.labelResult_DVA.Location = new System.Drawing.Point(6, 21);
            this.labelResult_DVA.Name = "labelResult_DVA";
            this.labelResult_DVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_DVA.TabIndex = 1;
            this.labelResult_DVA.Text = "Результат:";
            // 
            // dataGridViewNums_DVA
            // 
            this.dataGridViewNums_DVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_DVA.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewNums_DVA.Name = "dataGridViewNums_DVA";
            this.dataGridViewNums_DVA.RowHeadersVisible = false;
            this.dataGridViewNums_DVA.RowHeadersWidth = 51;
            this.dataGridViewNums_DVA.RowTemplate.Height = 24;
            this.dataGridViewNums_DVA.Size = new System.Drawing.Size(139, 460);
            this.dataGridViewNums_DVA.TabIndex = 0;
            // 
            // buttonDone_DVA
            // 
            this.buttonDone_DVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DVA.Location = new System.Drawing.Point(533, 33);
            this.buttonDone_DVA.Name = "buttonDone_DVA";
            this.buttonDone_DVA.Size = new System.Drawing.Size(121, 60);
            this.buttonDone_DVA.TabIndex = 2;
            this.buttonDone_DVA.Text = "Выпонить";
            this.buttonDone_DVA.UseVisualStyleBackColor = false;
            this.buttonDone_DVA.Click += new System.EventHandler(this.buttonDone_DVA_Click);
            // 
            // buttonOpenFile_DVA
            // 
            this.buttonOpenFile_DVA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenFile_DVA.Location = new System.Drawing.Point(677, 33);
            this.buttonOpenFile_DVA.Name = "buttonOpenFile_DVA";
            this.buttonOpenFile_DVA.Size = new System.Drawing.Size(100, 60);
            this.buttonOpenFile_DVA.TabIndex = 3;
            this.buttonOpenFile_DVA.Text = "Открыть файл";
            this.buttonOpenFile_DVA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_DVA.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonHelp_DVA
            // 
            this.buttonHelp_DVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_DVA.Location = new System.Drawing.Point(800, 33);
            this.buttonHelp_DVA.Name = "buttonHelp_DVA";
            this.buttonHelp_DVA.Size = new System.Drawing.Size(98, 60);
            this.buttonHelp_DVA.TabIndex = 4;
            this.buttonHelp_DVA.Text = "Справка";
            this.buttonHelp_DVA.UseVisualStyleBackColor = false;
            this.buttonHelp_DVA.Click += new System.EventHandler(this.buttonHelp_DVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 618);
            this.Controls.Add(this.buttonHelp_DVA);
            this.Controls.Add(this.buttonOpenFile_DVA);
            this.Controls.Add(this.buttonDone_DVA);
            this.Controls.Add(this.groupBoxDataOutput_DVA);
            this.Controls.Add(this.groupBoxTask_DVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 26 | Долгушин В. А.";
            this.groupBoxTask_DVA.ResumeLayout(false);
            this.groupBoxTask_DVA.PerformLayout();
            this.groupBoxDataOutput_DVA.ResumeLayout(false);
            this.groupBoxDataOutput_DVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_DVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_DVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DVA;
        private System.Windows.Forms.TextBox textBoxTask_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataOutput_DVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_DVA;
        private System.Windows.Forms.Label labelResult_DVA;
        private System.Windows.Forms.DataGridView dataGridViewNums_DVA;
        private System.Windows.Forms.Button buttonDone_DVA;
        private System.Windows.Forms.Button buttonOpenFile_DVA;
        private System.Windows.Forms.Button buttonHelp_DVA;
    }
}

