namespace Tyuiu.KrutikovaVP.Sprint6.Task5.V27
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelInPutData_KVP = new System.Windows.Forms.Panel();
            this.buttonOpenFile_KVP = new System.Windows.Forms.Button();
            this.buttonHelp_KVP = new System.Windows.Forms.Button();
            this.buttonDone_KVP = new System.Windows.Forms.Button();
            this.groupBoxConditionTask_KVP = new System.Windows.Forms.GroupBox();
            this.textBoxConditionTask_KVP = new System.Windows.Forms.TextBox();
            this.panelOutPutData_KVP = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_KVP = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_KVP = new System.Windows.Forms.DataGridView();
            this.panelDiagr_KVP = new System.Windows.Forms.Panel();
            this.chartDiagr_KVP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterChangeSize_KVP = new System.Windows.Forms.Splitter();
            this.ColumnNumOfEl_KVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnResult_KVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInPutData_KVP.SuspendLayout();
            this.groupBoxConditionTask_KVP.SuspendLayout();
            this.panelOutPutData_KVP.SuspendLayout();
            this.groupBoxOutPutData_KVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KVP)).BeginInit();
            this.panelDiagr_KVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagr_KVP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInPutData_KVP
            // 
            this.panelInPutData_KVP.Controls.Add(this.buttonOpenFile_KVP);
            this.panelInPutData_KVP.Controls.Add(this.buttonHelp_KVP);
            this.panelInPutData_KVP.Controls.Add(this.buttonDone_KVP);
            this.panelInPutData_KVP.Controls.Add(this.groupBoxConditionTask_KVP);
            this.panelInPutData_KVP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInPutData_KVP.Location = new System.Drawing.Point(0, 0);
            this.panelInPutData_KVP.Name = "panelInPutData_KVP";
            this.panelInPutData_KVP.Size = new System.Drawing.Size(784, 100);
            this.panelInPutData_KVP.TabIndex = 0;
            // 
            // buttonOpenFile_KVP
            // 
            this.buttonOpenFile_KVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFile_KVP.Location = new System.Drawing.Point(589, 22);
            this.buttonOpenFile_KVP.Name = "buttonOpenFile_KVP";
            this.buttonOpenFile_KVP.Size = new System.Drawing.Size(91, 57);
            this.buttonOpenFile_KVP.TabIndex = 1;
            this.buttonOpenFile_KVP.Text = "Открыть файл";
            this.buttonOpenFile_KVP.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KVP.Click += new System.EventHandler(this.buttonOpenFile_KVP_Click);
            // 
            // buttonHelp_KVP
            // 
            this.buttonHelp_KVP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KVP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_KVP.Location = new System.Drawing.Point(686, 22);
            this.buttonHelp_KVP.Name = "buttonHelp_KVP";
            this.buttonHelp_KVP.Size = new System.Drawing.Size(86, 57);
            this.buttonHelp_KVP.TabIndex = 1;
            this.buttonHelp_KVP.Text = "Справка";
            this.buttonHelp_KVP.UseVisualStyleBackColor = false;
            this.buttonHelp_KVP.Click += new System.EventHandler(this.buttonHelp_KVP_Click);
            // 
            // buttonDone_KVP
            // 
            this.buttonDone_KVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_KVP.Location = new System.Drawing.Point(493, 22);
            this.buttonDone_KVP.Name = "buttonDone_KVP";
            this.buttonDone_KVP.Size = new System.Drawing.Size(90, 57);
            this.buttonDone_KVP.TabIndex = 1;
            this.buttonDone_KVP.Text = "Выполнить";
            this.buttonDone_KVP.UseVisualStyleBackColor = false;
            this.buttonDone_KVP.Click += new System.EventHandler(this.buttonDone_KVP_Click);
            // 
            // groupBoxConditionTask_KVP
            // 
            this.groupBoxConditionTask_KVP.Controls.Add(this.textBoxConditionTask_KVP);
            this.groupBoxConditionTask_KVP.Location = new System.Drawing.Point(3, 3);
            this.groupBoxConditionTask_KVP.Name = "groupBoxConditionTask_KVP";
            this.groupBoxConditionTask_KVP.Size = new System.Drawing.Size(484, 94);
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
            this.textBoxConditionTask_KVP.Size = new System.Drawing.Size(472, 69);
            this.textBoxConditionTask_KVP.TabIndex = 0;
            this.textBoxConditionTask_KVP.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView. Вывести " +
    "все числа не кратные 5. Построить диаграмму по этим значениям.";
            // 
            // panelOutPutData_KVP
            // 
            this.panelOutPutData_KVP.Controls.Add(this.groupBoxOutPutData_KVP);
            this.panelOutPutData_KVP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPutData_KVP.Location = new System.Drawing.Point(0, 100);
            this.panelOutPutData_KVP.Name = "panelOutPutData_KVP";
            this.panelOutPutData_KVP.Size = new System.Drawing.Size(200, 311);
            this.panelOutPutData_KVP.TabIndex = 0;
            // 
            // groupBoxOutPutData_KVP
            // 
            this.groupBoxOutPutData_KVP.Controls.Add(this.dataGridViewResult_KVP);
            this.groupBoxOutPutData_KVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_KVP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_KVP.Name = "groupBoxOutPutData_KVP";
            this.groupBoxOutPutData_KVP.Size = new System.Drawing.Size(200, 311);
            this.groupBoxOutPutData_KVP.TabIndex = 0;
            this.groupBoxOutPutData_KVP.TabStop = false;
            this.groupBoxOutPutData_KVP.Text = "Вывод данных:";
            // 
            // dataGridViewResult_KVP
            // 
            this.dataGridViewResult_KVP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewResult_KVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KVP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumOfEl_KVP,
            this.columnResult_KVP});
            this.dataGridViewResult_KVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_KVP.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_KVP.Name = "dataGridViewResult_KVP";
            this.dataGridViewResult_KVP.ReadOnly = true;
            this.dataGridViewResult_KVP.RowHeadersVisible = false;
            this.dataGridViewResult_KVP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_KVP.Size = new System.Drawing.Size(194, 292);
            this.dataGridViewResult_KVP.TabIndex = 0;
            // 
            // panelDiagr_KVP
            // 
            this.panelDiagr_KVP.Controls.Add(this.chartDiagr_KVP);
            this.panelDiagr_KVP.Controls.Add(this.splitterChangeSize_KVP);
            this.panelDiagr_KVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiagr_KVP.Location = new System.Drawing.Point(200, 100);
            this.panelDiagr_KVP.Name = "panelDiagr_KVP";
            this.panelDiagr_KVP.Size = new System.Drawing.Size(584, 311);
            this.panelDiagr_KVP.TabIndex = 0;
            // 
            // chartDiagr_KVP
            // 
            chartArea5.Name = "ChartArea1";
            this.chartDiagr_KVP.ChartAreas.Add(chartArea5);
            this.chartDiagr_KVP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartDiagr_KVP.Legends.Add(legend5);
            this.chartDiagr_KVP.Location = new System.Drawing.Point(3, 0);
            this.chartDiagr_KVP.Name = "chartDiagr_KVP";
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartDiagr_KVP.Series.Add(series5);
            this.chartDiagr_KVP.Size = new System.Drawing.Size(581, 311);
            this.chartDiagr_KVP.TabIndex = 1;
            this.chartDiagr_KVP.Text = "chart1";
            // 
            // splitterChangeSize_KVP
            // 
            this.splitterChangeSize_KVP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitterChangeSize_KVP.Location = new System.Drawing.Point(0, 0);
            this.splitterChangeSize_KVP.Name = "splitterChangeSize_KVP";
            this.splitterChangeSize_KVP.Size = new System.Drawing.Size(3, 311);
            this.splitterChangeSize_KVP.TabIndex = 0;
            this.splitterChangeSize_KVP.TabStop = false;
            // 
            // ColumnNumOfEl_KVP
            // 
            this.ColumnNumOfEl_KVP.HeaderText = "";
            this.ColumnNumOfEl_KVP.Name = "ColumnNumOfEl_KVP";
            this.ColumnNumOfEl_KVP.ReadOnly = true;
            this.ColumnNumOfEl_KVP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNumOfEl_KVP.Width = 50;
            // 
            // columnResult_KVP
            // 
            this.columnResult_KVP.HeaderText = "";
            this.columnResult_KVP.Name = "columnResult_KVP";
            this.columnResult_KVP.ReadOnly = true;
            this.columnResult_KVP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnResult_KVP.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panelDiagr_KVP);
            this.Controls.Add(this.panelOutPutData_KVP);
            this.Controls.Add(this.panelInPutData_KVP);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 27 | Крутикова В. П.";
            this.panelInPutData_KVP.ResumeLayout(false);
            this.groupBoxConditionTask_KVP.ResumeLayout(false);
            this.groupBoxConditionTask_KVP.PerformLayout();
            this.panelOutPutData_KVP.ResumeLayout(false);
            this.groupBoxOutPutData_KVP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KVP)).EndInit();
            this.panelDiagr_KVP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagr_KVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInPutData_KVP;
        private System.Windows.Forms.Panel panelOutPutData_KVP;
        private System.Windows.Forms.Panel panelDiagr_KVP;
        private System.Windows.Forms.GroupBox groupBoxConditionTask_KVP;
        private System.Windows.Forms.TextBox textBoxConditionTask_KVP;
        private System.Windows.Forms.Splitter splitterChangeSize_KVP;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KVP;
        private System.Windows.Forms.DataGridView dataGridViewResult_KVP;
        private System.Windows.Forms.Button buttonOpenFile_KVP;
        private System.Windows.Forms.Button buttonHelp_KVP;
        private System.Windows.Forms.Button buttonDone_KVP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagr_KVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumOfEl_KVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnResult_KVP;
    }
}

