namespace WindowsFormsApp1
{
    partial class View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdvancedFilter = new System.Windows.Forms.Label();
            this.TxtDateFrom = new System.Windows.Forms.Label();
            this.TxtDateTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButSearch = new System.Windows.Forms.Button();
            this.DtpDateForm = new System.Windows.Forms.DateTimePicker();
            this.DtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 875);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1624, 146);
            this.panel2.TabIndex = 3;
            // 
            // AdvancedFilter
            // 
            this.AdvancedFilter.AutoSize = true;
            this.AdvancedFilter.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedFilter.Location = new System.Drawing.Point(365, 292);
            this.AdvancedFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdvancedFilter.Name = "AdvancedFilter";
            this.AdvancedFilter.Size = new System.Drawing.Size(190, 31);
            this.AdvancedFilter.TabIndex = 5;
            this.AdvancedFilter.Text = "AdvancedFilter";
            // 
            // TxtDateFrom
            // 
            this.TxtDateFrom.AutoSize = true;
            this.TxtDateFrom.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDateFrom.Location = new System.Drawing.Point(379, 407);
            this.TxtDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtDateFrom.Name = "TxtDateFrom";
            this.TxtDateFrom.Size = new System.Drawing.Size(176, 31);
            this.TxtDateFrom.TabIndex = 6;
            this.TxtDateFrom.Text = "TxtDateFrom";
            // 
            // TxtDateTo
            // 
            this.TxtDateTo.AutoSize = true;
            this.TxtDateTo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDateTo.Location = new System.Drawing.Point(379, 473);
            this.TxtDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtDateTo.Name = "TxtDateTo";
            this.TxtDateTo.Size = new System.Drawing.Size(145, 31);
            this.TxtDateTo.TabIndex = 7;
            this.TxtDateTo.Text = "TxtDateTo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 556);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // ButSearch
            // 
            this.ButSearch.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButSearch.Location = new System.Drawing.Point(614, 647);
            this.ButSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButSearch.Name = "ButSearch";
            this.ButSearch.Size = new System.Drawing.Size(219, 56);
            this.ButSearch.TabIndex = 14;
            this.ButSearch.Text = "Search";
            this.ButSearch.UseVisualStyleBackColor = true;
            this.ButSearch.Click += new System.EventHandler(this.ButSearch_Click);
            // 
            // DtpDateForm
            // 
            this.DtpDateForm.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateForm.Location = new System.Drawing.Point(587, 407);
            this.DtpDateForm.Margin = new System.Windows.Forms.Padding(4);
            this.DtpDateForm.Name = "DtpDateForm";
            this.DtpDateForm.Size = new System.Drawing.Size(298, 46);
            this.DtpDateForm.TabIndex = 15;
            // 
            // DtpDateTo
            // 
            this.DtpDateTo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateTo.Location = new System.Drawing.Point(587, 473);
            this.DtpDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.DtpDateTo.Name = "DtpDateTo";
            this.DtpDateTo.Size = new System.Drawing.Size(298, 46);
            this.DtpDateTo.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Amount,
            this.Category});
            this.dataGridView1.Location = new System.Drawing.Point(1143, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(513, 289);
            this.dataGridView1.TabIndex = 12;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 8;
            this.Data.Name = "Data";
            this.Data.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.Width = 150;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(1039, 502);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(804, 387);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 875);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.DtpDateTo);
            this.Controls.Add(this.DtpDateForm);
            this.Controls.Add(this.ButSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDateTo);
            this.Controls.Add(this.TxtDateFrom);
            this.Controls.Add(this.AdvancedFilter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AdvancedFilter;
        private System.Windows.Forms.Label TxtDateFrom;
        private System.Windows.Forms.Label TxtDateTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButSearch;
        private System.Windows.Forms.DateTimePicker DtpDateForm;
        private System.Windows.Forms.DateTimePicker DtpDateTo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}