
namespace Tyuiu.DolgushinVA.Sprint6.Task7.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.groupBoxInfo_DVA = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelInfo_DVA = new System.Windows.Forms.Label();
            this.buttonOK_DVA = new System.Windows.Forms.Button();
            this.groupBoxInfo_DVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo_DVA
            // 
            this.groupBoxInfo_DVA.Controls.Add(this.labelInfo_DVA);
            this.groupBoxInfo_DVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo_DVA.Name = "groupBoxInfo_DVA";
            this.groupBoxInfo_DVA.Size = new System.Drawing.Size(428, 194);
            this.groupBoxInfo_DVA.TabIndex = 0;
            this.groupBoxInfo_DVA.TabStop = false;
            // 
            // labelInfo_DVA
            // 
            this.labelInfo_DVA.AutoSize = true;
            this.labelInfo_DVA.Location = new System.Drawing.Point(6, 18);
            this.labelInfo_DVA.Name = "labelInfo_DVA";
            this.labelInfo_DVA.Size = new System.Drawing.Size(357, 153);
            this.labelInfo_DVA.TabIndex = 0;
            this.labelInfo_DVA.Text = resources.GetString("labelInfo_DVA.Text");
            // 
            // buttonOK_DVA
            // 
            this.buttonOK_DVA.Location = new System.Drawing.Point(347, 212);
            this.buttonOK_DVA.Name = "buttonOK_DVA";
            this.buttonOK_DVA.Size = new System.Drawing.Size(93, 32);
            this.buttonOK_DVA.TabIndex = 1;
            this.buttonOK_DVA.Text = "OK";
            this.buttonOK_DVA.UseVisualStyleBackColor = true;
            this.buttonOK_DVA.Click += new System.EventHandler(this.buttonOK_DVA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 256);
            this.Controls.Add(this.buttonOK_DVA);
            this.Controls.Add(this.groupBoxInfo_DVA);
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.groupBoxInfo_DVA.ResumeLayout(false);
            this.groupBoxInfo_DVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_DVA;
        private System.Windows.Forms.Label labelInfo_DVA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonOK_DVA;
    }
}