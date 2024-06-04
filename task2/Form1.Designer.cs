namespace task2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ansLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(78, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "عدد دوم :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(168, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(168, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 43);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SumButton
            // 
            this.SumButton.BackColor = System.Drawing.Color.DarkOrange;
            this.SumButton.Enabled = false;
            this.SumButton.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SumButton.Location = new System.Drawing.Point(56, 153);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(55, 50);
            this.SumButton.TabIndex = 4;
            this.SumButton.Text = "+";
            this.SumButton.UseVisualStyleBackColor = false;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.DarkOrange;
            this.subButton.Enabled = false;
            this.subButton.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.subButton.Location = new System.Drawing.Point(117, 153);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(55, 50);
            this.subButton.TabIndex = 5;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // multiButton
            // 
            this.multiButton.BackColor = System.Drawing.Color.DarkOrange;
            this.multiButton.Enabled = false;
            this.multiButton.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.multiButton.Location = new System.Drawing.Point(178, 153);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(55, 50);
            this.multiButton.TabIndex = 6;
            this.multiButton.Text = "x";
            this.multiButton.UseVisualStyleBackColor = false;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.Color.DarkOrange;
            this.divButton.Enabled = false;
            this.divButton.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.divButton.Location = new System.Drawing.Point(239, 153);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(55, 50);
            this.divButton.TabIndex = 7;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.clearButton.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.clearButton.Location = new System.Drawing.Point(178, 209);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 50);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "پاک کن";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkOrange;
            this.exitButton.Font = new System.Drawing.Font("B Tabassom", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitButton.Location = new System.Drawing.Point(56, 209);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 50);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ansLable
            // 
            this.ansLable.AutoSize = true;
            this.ansLable.Font = new System.Drawing.Font("B Tabassom", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ansLable.Location = new System.Drawing.Point(22, 273);
            this.ansLable.Name = "ansLable";
            this.ansLable.Size = new System.Drawing.Size(0, 57);
            this.ansLable.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(351, 352);
            this.Controls.Add(this.ansLable);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Tabassom", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label ansLable;
    }
}

