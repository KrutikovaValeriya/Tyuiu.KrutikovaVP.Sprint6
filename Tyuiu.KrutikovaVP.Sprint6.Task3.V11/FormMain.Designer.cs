namespace Tyuiu.KrutikovaVP.Sprint6.Task3.V11
{
    partial class FormMain
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
            this.groupBoxConditionTask_KVP = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxConditionTask_KVP = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxOutPutData_KVP = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_KVP = new System.Windows.Forms.DataGridView();
            this.labelResult_KVP = new System.Windows.Forms.Label();
            this.buttonDone_KVP = new System.Windows.Forms.Button();
            this.buttonHelp_KVP = new System.Windows.Forms.Button();
            this.dataGridViewInPutData_KVP = new System.Windows.Forms.DataGridView();
            this.groupBoxConditionTask_KVP.SuspendLayout();
            this.groupBoxOutPutData_KVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_KVP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConditionTask_KVP
            // 
            this.groupBoxConditionTask_KVP.Controls.Add(this.dataGridViewInPutData_KVP);
            this.groupBoxConditionTask_KVP.Controls.Add(this.textBoxConditionTask_KVP);
            this.groupBoxConditionTask_KVP.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConditionTask_KVP.Name = "groupBoxConditionTask_KVP";
            this.groupBoxConditionTask_KVP.Size = new System.Drawing.Size(429, 212);
            this.groupBoxConditionTask_KVP.TabIndex = 0;
            this.groupBoxConditionTask_KVP.TabStop = false;
            this.groupBoxConditionTask_KVP.Text = "Условие";
            // 
            // textBoxConditionTask_KVP
            // 
            this.textBoxConditionTask_KVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConditionTask_KVP.Location = new System.Drawing.Point(6, 19);
            this.textBoxConditionTask_KVP.Multiline = true;
            this.textBoxConditionTask_KVP.Name = "textBoxConditionTask_KVP";
            this.textBoxConditionTask_KVP.ReadOnly = true;
            this.textBoxConditionTask_KVP.Size = new System.Drawing.Size(216, 143);
            this.textBoxConditionTask_KVP.TabIndex = 0;
            this.textBoxConditionTask_KVP.Text = "Дана матрица 5 на 5\r\n27  -15  14   2  27\r\n -8  14 -10  33   0\r\n  1   7  -11 -11  " +
    "23\r\n-13 -20 15 -16  34\r\n  -3   1   -1    5    1\r\nВыполнить сортировку по возраст" +
    "анию в первом столбце.";
            // 
            // groupBoxOutPutData_KVP
            // 
            this.groupBoxOutPutData_KVP.Controls.Add(this.labelResult_KVP);
            this.groupBoxOutPutData_KVP.Controls.Add(this.dataGridViewResult_KVP);
            this.groupBoxOutPutData_KVP.Location = new System.Drawing.Point(447, 12);
            this.groupBoxOutPutData_KVP.Name = "groupBoxOutPutData_KVP";
            this.groupBoxOutPutData_KVP.Size = new System.Drawing.Size(192, 185);
            this.groupBoxOutPutData_KVP.TabIndex = 1;
            this.groupBoxOutPutData_KVP.TabStop = false;
            this.groupBoxOutPutData_KVP.Text = "Вывод данных";
            // 
            // dataGridViewResult_KVP
            // 
            this.dataGridViewResult_KVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KVP.ColumnHeadersVisible = false;
            this.dataGridViewResult_KVP.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewResult_KVP.Name = "dataGridViewResult_KVP";
            this.dataGridViewResult_KVP.ReadOnly = true;
            this.dataGridViewResult_KVP.RowHeadersVisible = false;
            this.dataGridViewResult_KVP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewResult_KVP.Size = new System.Drawing.Size(180, 146);
            this.dataGridViewResult_KVP.TabIndex = 0;
            // 
            // labelResult_KVP
            // 
            this.labelResult_KVP.AutoSize = true;
            this.labelResult_KVP.Location = new System.Drawing.Point(6, 17);
            this.labelResult_KVP.Name = "labelResult_KVP";
            this.labelResult_KVP.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KVP.TabIndex = 1;
            this.labelResult_KVP.Text = "Результат:";
            // 
            // buttonDone_KVP
            // 
            this.buttonDone_KVP.Location = new System.Drawing.Point(547, 203);
            this.buttonDone_KVP.Name = "buttonDone_KVP";
            this.buttonDone_KVP.Size = new System.Drawing.Size(86, 21);
            this.buttonDone_KVP.TabIndex = 2;
            this.buttonDone_KVP.Text = "Выполнить";
            this.buttonDone_KVP.UseVisualStyleBackColor = true;
            this.buttonDone_KVP.Click += new System.EventHandler(this.buttonDone_KVP_Click);
            // 
            // buttonHelp_KVP
            // 
            this.buttonHelp_KVP.Location = new System.Drawing.Point(447, 203);
            this.buttonHelp_KVP.Name = "buttonHelp_KVP";
            this.buttonHelp_KVP.Size = new System.Drawing.Size(24, 21);
            this.buttonHelp_KVP.TabIndex = 2;
            this.buttonHelp_KVP.Text = "?";
            this.buttonHelp_KVP.UseVisualStyleBackColor = true;
            this.buttonHelp_KVP.Click += new System.EventHandler(this.buttonHelp_KVP_Click);
            // 
            // dataGridViewInPutData_KVP
            // 
            this.dataGridViewInPutData_KVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_KVP.ColumnHeadersVisible = false;
            this.dataGridViewInPutData_KVP.Location = new System.Drawing.Point(239, 33);
            this.dataGridViewInPutData_KVP.Name = "dataGridViewInPutData_KVP";
            this.dataGridViewInPutData_KVP.ReadOnly = true;
            this.dataGridViewInPutData_KVP.RowHeadersVisible = false;
            this.dataGridViewInPutData_KVP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewInPutData_KVP.Size = new System.Drawing.Size(184, 146);
            this.dataGridViewInPutData_KVP.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 232);
            this.Controls.Add(this.buttonHelp_KVP);
            this.Controls.Add(this.buttonDone_KVP);
            this.Controls.Add(this.groupBoxOutPutData_KVP);
            this.Controls.Add(this.groupBoxConditionTask_KVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 11 | Крутикова В. П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxConditionTask_KVP.ResumeLayout(false);
            this.groupBoxConditionTask_KVP.PerformLayout();
            this.groupBoxOutPutData_KVP.ResumeLayout(false);
            this.groupBoxOutPutData_KVP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_KVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditionTask_KVP;
        private System.Windows.Forms.TextBox textBoxConditionTask_KVP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KVP;
        private System.Windows.Forms.Label labelResult_KVP;
        private System.Windows.Forms.DataGridView dataGridViewResult_KVP;
        private System.Windows.Forms.Button buttonDone_KVP;
        private System.Windows.Forms.Button buttonHelp_KVP;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_KVP;
    }
}

