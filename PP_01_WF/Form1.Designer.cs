﻿namespace PP_01_WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Result_Integral = new System.Windows.Forms.Button();
            this.LB_Result_Integral = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Result_Integral
            // 
            this.Btn_Result_Integral.Location = new System.Drawing.Point(302, 7);
            this.Btn_Result_Integral.Name = "Btn_Result_Integral";
            this.Btn_Result_Integral.Size = new System.Drawing.Size(75, 23);
            this.Btn_Result_Integral.TabIndex = 0;
            this.Btn_Result_Integral.Text = "Посчитать";
            this.Btn_Result_Integral.UseVisualStyleBackColor = true;
            this.Btn_Result_Integral.Click += new System.EventHandler(this.button1_Click);
            // 
            // LB_Result_Integral
            // 
            this.LB_Result_Integral.AutoSize = true;
            this.LB_Result_Integral.Location = new System.Drawing.Point(137, 12);
            this.LB_Result_Integral.Name = "LB_Result_Integral";
            this.LB_Result_Integral.Size = new System.Drawing.Size(0, 13);
            this.LB_Result_Integral.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Значение интегралла:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Result_Integral);
            this.Controls.Add(this.Btn_Result_Integral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Result_Integral;
        private System.Windows.Forms.Label LB_Result_Integral;
        private System.Windows.Forms.Label label1;
    }
}

