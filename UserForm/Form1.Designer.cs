namespace UserForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.treeSortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shellSortPrattBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shellSortPrattBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeSortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellSortPrattBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellSortPrattBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(41, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(726, 307);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "Результат";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "10",
            "10^2",
            "10^3",
            "10^4",
            "10^5",
            "10^6",
            "10^7",
            "10^8"});
            this.checkedListBox1.Location = new System.Drawing.Point(185, 337);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(77, 94);
            this.checkedListBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(281, 337);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(227, 95);
            this.listBox2.TabIndex = 10;
            // 
            // treeSortBindingSource
            // 
            this.treeSortBindingSource.DataSource = typeof(Algoritmen.TreeSort);
            // 
            // shellSortPrattBindingSource
            // 
            this.shellSortPrattBindingSource.DataSource = typeof(Algoritmen.ShellSortPratt);
            // 
            // shellSortPrattBindingSource1
            // 
            this.shellSortPrattBindingSource1.DataSource = typeof(Algoritmen.ShellSortPratt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 65);
            this.label1.TabIndex = 12;
            this.label1.Text = " * Выберите сортировки и диапазоны, которые \r\n    будут проверятся.\r\n\r\n * График " +
    "можно приближать и отдалять \r\n   левой кнопкой мыши";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeSortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellSortPrattBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellSortPrattBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource treeSortBindingSource;
        private System.Windows.Forms.BindingSource shellSortPrattBindingSource;
        private System.Windows.Forms.BindingSource shellSortPrattBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}

