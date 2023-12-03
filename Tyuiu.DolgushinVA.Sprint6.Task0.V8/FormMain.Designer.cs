
namespace Tyuiu.DolgushinVA.Sprint6.Task0.V8
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
            this.buttonDone_DVA = new System.Windows.Forms.Button();
            this.textBoxVarX_DVA = new System.Windows.Forms.TextBox();
            this.textBoxResult_DVA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_DVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_DVA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_DVA = new System.Windows.Forms.TextBox();
            this.groupBoxDataImput_DVA = new System.Windows.Forms.GroupBox();
            this.labelVarX_DVA = new System.Windows.Forms.Label();
            this.groupBoxDataOutput_DVA = new System.Windows.Forms.GroupBox();
            this.labelResult_DVA = new System.Windows.Forms.Label();
            this.buttonHelp_DVA = new System.Windows.Forms.Button();
            this.groupBoxTask_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DVA)).BeginInit();
            this.groupBoxDataImput_DVA.SuspendLayout();
            this.groupBoxDataOutput_DVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_DVA
            // 
            this.buttonDone_DVA.Location = new System.Drawing.Point(502, 394);
            this.buttonDone_DVA.Name = "buttonDone_DVA";
            this.buttonDone_DVA.Size = new System.Drawing.Size(125, 44);
            this.buttonDone_DVA.TabIndex = 0;
            this.buttonDone_DVA.Text = "Выполнить";
            this.buttonDone_DVA.UseVisualStyleBackColor = true;
            this.buttonDone_DVA.Click += new System.EventHandler(this.buttonDone_DVA_Click);
            // 
            // textBoxVarX_DVA
            // 
            this.textBoxVarX_DVA.Location = new System.Drawing.Point(6, 63);
            this.textBoxVarX_DVA.Name = "textBoxVarX_DVA";
            this.textBoxVarX_DVA.Size = new System.Drawing.Size(133, 22);
            this.textBoxVarX_DVA.TabIndex = 2;
            this.textBoxVarX_DVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_DVA_KeyPress);
            // 
            // textBoxResult_DVA
            // 
            this.textBoxResult_DVA.Location = new System.Drawing.Point(6, 63);
            this.textBoxResult_DVA.Name = "textBoxResult_DVA";
            this.textBoxResult_DVA.ReadOnly = true;
            this.textBoxResult_DVA.Size = new System.Drawing.Size(203, 22);
            this.textBoxResult_DVA.TabIndex = 3;
            // 
            // groupBoxTask_DVA
            // 
            this.groupBoxTask_DVA.Controls.Add(this.pictureBoxFormula_DVA);
            this.groupBoxTask_DVA.Controls.Add(this.textBoxTask_DVA);
            this.groupBoxTask_DVA.Location = new System.Drawing.Point(12, 28);
            this.groupBoxTask_DVA.Name = "groupBoxTask_DVA";
            this.groupBoxTask_DVA.Size = new System.Drawing.Size(615, 158);
            this.groupBoxTask_DVA.TabIndex = 4;
            this.groupBoxTask_DVA.TabStop = false;
            this.groupBoxTask_DVA.Text = "Условие:";
            // 
            // pictureBoxFormula_DVA
            // 
            this.pictureBoxFormula_DVA.Image = global::Tyuiu.DolgushinVA.Sprint6.Task0.V8.Properties.Resources.FormulaTask0;
            this.pictureBoxFormula_DVA.Location = new System.Drawing.Point(418, 38);
            this.pictureBoxFormula_DVA.Name = "pictureBoxFormula_DVA";
            this.pictureBoxFormula_DVA.Size = new System.Drawing.Size(167, 84);
            this.pictureBoxFormula_DVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_DVA.TabIndex = 3;
            this.pictureBoxFormula_DVA.TabStop = false;
            // 
            // textBoxTask_DVA
            // 
            this.textBoxTask_DVA.Location = new System.Drawing.Point(9, 21);
            this.textBoxTask_DVA.Multiline = true;
            this.textBoxTask_DVA.Name = "textBoxTask_DVA";
            this.textBoxTask_DVA.ReadOnly = true;
            this.textBoxTask_DVA.Size = new System.Drawing.Size(355, 131);
            this.textBoxTask_DVA.TabIndex = 2;
            this.textBoxTask_DVA.Text = "Найти значение выражения по формуле.";
            // 
            // groupBoxDataImput_DVA
            // 
            this.groupBoxDataImput_DVA.Controls.Add(this.labelVarX_DVA);
            this.groupBoxDataImput_DVA.Controls.Add(this.textBoxVarX_DVA);
            this.groupBoxDataImput_DVA.Location = new System.Drawing.Point(21, 274);
            this.groupBoxDataImput_DVA.Name = "groupBoxDataImput_DVA";
            this.groupBoxDataImput_DVA.Size = new System.Drawing.Size(278, 114);
            this.groupBoxDataImput_DVA.TabIndex = 5;
            this.groupBoxDataImput_DVA.TabStop = false;
            this.groupBoxDataImput_DVA.Text = "Ввод данных:";
            // 
            // labelVarX_DVA
            // 
            this.labelVarX_DVA.AutoSize = true;
            this.labelVarX_DVA.Location = new System.Drawing.Point(6, 34);
            this.labelVarX_DVA.Name = "labelVarX_DVA";
            this.labelVarX_DVA.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_DVA.TabIndex = 1;
            this.labelVarX_DVA.Text = "Переменная X:";
            // 
            // groupBoxDataOutput_DVA
            // 
            this.groupBoxDataOutput_DVA.Controls.Add(this.labelResult_DVA);
            this.groupBoxDataOutput_DVA.Controls.Add(this.textBoxResult_DVA);
            this.groupBoxDataOutput_DVA.Location = new System.Drawing.Point(412, 274);
            this.groupBoxDataOutput_DVA.Name = "groupBoxDataOutput_DVA";
            this.groupBoxDataOutput_DVA.Size = new System.Drawing.Size(215, 114);
            this.groupBoxDataOutput_DVA.TabIndex = 6;
            this.groupBoxDataOutput_DVA.TabStop = false;
            this.groupBoxDataOutput_DVA.Text = "Вывод данных:";
            // 
            // labelResult_DVA
            // 
            this.labelResult_DVA.AutoSize = true;
            this.labelResult_DVA.Location = new System.Drawing.Point(6, 34);
            this.labelResult_DVA.Name = "labelResult_DVA";
            this.labelResult_DVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_DVA.TabIndex = 4;
            this.labelResult_DVA.Text = "Результат:";
            // 
            // buttonHelp_DVA
            // 
            this.buttonHelp_DVA.Location = new System.Drawing.Point(446, 394);
            this.buttonHelp_DVA.Name = "buttonHelp_DVA";
            this.buttonHelp_DVA.Size = new System.Drawing.Size(52, 44);
            this.buttonHelp_DVA.TabIndex = 7;
            this.buttonHelp_DVA.Text = "?";
            this.buttonHelp_DVA.UseVisualStyleBackColor = true;
            this.buttonHelp_DVA.Click += new System.EventHandler(this.buttonHelp_DVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.buttonHelp_DVA);
            this.Controls.Add(this.groupBoxDataOutput_DVA);
            this.Controls.Add(this.groupBoxDataImput_DVA);
            this.Controls.Add(this.groupBoxTask_DVA);
            this.Controls.Add(this.buttonDone_DVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 8 | Долгушин В. А.";
            this.groupBoxTask_DVA.ResumeLayout(false);
            this.groupBoxTask_DVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DVA)).EndInit();
            this.groupBoxDataImput_DVA.ResumeLayout(false);
            this.groupBoxDataImput_DVA.PerformLayout();
            this.groupBoxDataOutput_DVA.ResumeLayout(false);
            this.groupBoxDataOutput_DVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_DVA;
        private System.Windows.Forms.TextBox textBoxVarX_DVA;
        private System.Windows.Forms.TextBox textBoxResult_DVA;
        private System.Windows.Forms.GroupBox groupBoxTask_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataImput_DVA;
        private System.Windows.Forms.Label labelVarX_DVA;
        private System.Windows.Forms.GroupBox groupBoxDataOutput_DVA;
        private System.Windows.Forms.Label labelResult_DVA;
        private System.Windows.Forms.TextBox textBoxTask_DVA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_DVA;
        private System.Windows.Forms.Button buttonHelp_DVA;
    }
}

