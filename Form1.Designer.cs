namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.View = new System.Windows.Forms.Button();
            this.AddBudget = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.Catogre = new System.Windows.Forms.Label();
            this.Amont = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.TxtAmont = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtOtherCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.View);
            this.panel1.Controls.Add(this.AddBudget);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 878);
            this.panel1.TabIndex = 0;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.LightGray;
            this.View.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.Location = new System.Drawing.Point(61, 737);
            this.View.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(160, 73);
            this.View.TabIndex = 2;
            this.View.Text = "view";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.view_Click);
            // 
            // AddBudget
            // 
            this.AddBudget.BackColor = System.Drawing.Color.LightGray;
            this.AddBudget.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBudget.Location = new System.Drawing.Point(61, 528);
            this.AddBudget.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AddBudget.Name = "AddBudget";
            this.AddBudget.Size = new System.Drawing.Size(160, 73);
            this.AddBudget.TabIndex = 1;
            this.AddBudget.Text = "SetBudget";
            this.AddBudget.UseVisualStyleBackColor = false;
            this.AddBudget.Click += new System.EventHandler(this.AddBudget_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(301, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1622, 146);
            this.panel2.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(388, 390);
            this.Date.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(72, 31);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            // 
            // Catogre
            // 
            this.Catogre.AutoSize = true;
            this.Catogre.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catogre.Location = new System.Drawing.Point(1044, 404);
            this.Catogre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Catogre.Name = "Catogre";
            this.Catogre.Size = new System.Drawing.Size(106, 31);
            this.Catogre.TabIndex = 3;
            this.Catogre.Text = "Catogre";
            // 
            // Amont
            // 
            this.Amont.AutoSize = true;
            this.Amont.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amont.Location = new System.Drawing.Point(1587, 404);
            this.Amont.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Amont.Name = "Amont";
            this.Amont.Size = new System.Drawing.Size(96, 31);
            this.Amont.TabIndex = 4;
            this.Amont.Text = "Amont";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 460);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(495, 46);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CmbCategory
            // 
            this.CmbCategory.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            " Food",
            "Coffee",
            "Shopping",
            "Bills",
            "Other"});
            this.CmbCategory.Location = new System.Drawing.Point(1049, 467);
            this.CmbCategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(201, 39);
            this.CmbCategory.TabIndex = 6;
            this.CmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged_1);
            // 
            // TxtAmont
            // 
            this.TxtAmont.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAmont.Location = new System.Drawing.Point(1590, 460);
            this.TxtAmont.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtAmont.Name = "TxtAmont";
            this.TxtAmont.Size = new System.Drawing.Size(197, 46);
            this.TxtAmont.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(1157, 704);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(159, 69);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(995, 708);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(156, 65);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // TxtOtherCategory
            // 
            this.TxtOtherCategory.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOtherCategory.Location = new System.Drawing.Point(1314, 460);
            this.TxtOtherCategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtOtherCategory.Name = "TxtOtherCategory";
            this.TxtOtherCategory.Size = new System.Drawing.Size(184, 46);
            this.TxtOtherCategory.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 528);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1047, 542);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1589, 528);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 878);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOtherCategory);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtAmont);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Amont);
            this.Controls.Add(this.Catogre);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button AddBudget;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Catogre;
        private System.Windows.Forms.Label Amont;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.TextBox TxtAmont;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtOtherCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

