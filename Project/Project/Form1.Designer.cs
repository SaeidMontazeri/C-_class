namespace Project
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.teacherTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.allBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entekhabVahedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database5DataSet = new Project.Database5DataSet();
            this.entekhab_VahedTableAdapter = new Project.Database5DataSetTableAdapters.Entekhab_VahedTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entekhabVahedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(824, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام درس :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.newBtn);
            this.panel1.Controls.Add(this.codeTxt);
            this.panel1.Controls.Add(this.locationTxt);
            this.panel1.Controls.Add(this.timeTxt);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.teacherTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 220);
            this.panel1.TabIndex = 1;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.editBtn.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editBtn.Location = new System.Drawing.Point(46, 150);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(137, 52);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "ویرایش";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteBtn.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteBtn.Location = new System.Drawing.Point(304, 150);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(137, 52);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.addBtn.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addBtn.Location = new System.Drawing.Point(553, 150);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 52);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "اضافه";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.newBtn.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.newBtn.Location = new System.Drawing.Point(800, 150);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(137, 52);
            this.newBtn.TabIndex = 10;
            this.newBtn.Text = "جدید";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // codeTxt
            // 
            this.codeTxt.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.codeTxt.Location = new System.Drawing.Point(25, 12);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(158, 43);
            this.codeTxt.TabIndex = 9;
            // 
            // locationTxt
            // 
            this.locationTxt.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.locationTxt.Location = new System.Drawing.Point(25, 73);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(463, 43);
            this.locationTxt.TabIndex = 8;
            // 
            // timeTxt
            // 
            this.timeTxt.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.timeTxt.Location = new System.Drawing.Point(650, 73);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(172, 43);
            this.timeTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameTxt.Location = new System.Drawing.Point(650, 13);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(172, 43);
            this.nameTxt.TabIndex = 6;
            // 
            // teacherTxt
            // 
            this.teacherTxt.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.teacherTxt.Location = new System.Drawing.Point(288, 11);
            this.teacherTxt.Name = "teacherTxt";
            this.teacherTxt.Size = new System.Drawing.Size(200, 43);
            this.teacherTxt.TabIndex = 5;
            this.teacherTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(494, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "مکان برگزرای :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(824, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "زمان برگزاری :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(189, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد ارائه :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(494, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام استاد :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.searchCombo);
            this.panel2.Controls.Add(this.allBtn);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.searchTxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(11, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 78);
            this.panel2.TabIndex = 14;
            // 
            // searchCombo
            // 
            this.searchCombo.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "کد ارائه",
            "نام درس",
            "نام استاد"});
            this.searchCombo.Location = new System.Drawing.Point(623, 19);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(183, 43);
            this.searchCombo.TabIndex = 14;
            // 
            // allBtn
            // 
            this.allBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.allBtn.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.allBtn.Location = new System.Drawing.Point(46, 13);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(137, 52);
            this.allBtn.TabIndex = 11;
            this.allBtn.Text = "همه";
            this.allBtn.UseVisualStyleBackColor = false;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.searchBtn.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBtn.Location = new System.Drawing.Point(233, 13);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(137, 52);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "جستجو";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchTxt.Location = new System.Drawing.Point(431, 19);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(172, 43);
            this.searchTxt.TabIndex = 7;
            this.searchTxt.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(812, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 43);
            this.label7.TabIndex = 3;
            this.label7.Text = "جستجو بر اساس :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Tabassom", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entekhabVahedBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("B Tabassom", 7.8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.Location = new System.Drawing.Point(12, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 300);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(840, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "*";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام درس";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.teacherDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.teacherDataGridViewTextBoxColumn.HeaderText = "نام استاد";
            this.teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.iDDataGridViewTextBoxColumn.HeaderText = "کد ارائه";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.timeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.timeDataGridViewTextBoxColumn.HeaderText = "زمان برگزاری";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 175;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.locationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.locationDataGridViewTextBoxColumn.HeaderText = "مکان برگزاری";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 225;
            // 
            // entekhabVahedBindingSource
            // 
            this.entekhabVahedBindingSource.DataMember = "Entekhab_Vahed";
            this.entekhabVahedBindingSource.DataSource = this.database5DataSet;
            // 
            // database5DataSet
            // 
            this.database5DataSet.DataSetName = "Database5DataSet";
            this.database5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entekhab_VahedTableAdapter
            // 
            this.entekhab_VahedTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1004, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Tabassom", 7.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entekhabVahedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox teacherTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database5DataSet database5DataSet;
        private System.Windows.Forms.BindingSource entekhabVahedBindingSource;
        private Database5DataSetTableAdapters.Entekhab_VahedTableAdapter entekhab_VahedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

