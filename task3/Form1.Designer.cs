namespace task3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.optxt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.calButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ansLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(44, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // optxt
            // 
            this.optxt.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.optxt.Location = new System.Drawing.Point(150, 26);
            this.optxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optxt.Name = "optxt";
            this.optxt.Size = new System.Drawing.Size(45, 43);
            this.optxt.TabIndex = 1;
            this.optxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.optxt.TextChanged += new System.EventHandler(this.optxt_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(201, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 43);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // calButton
            // 
            this.calButton.BackColor = System.Drawing.Color.DarkOrange;
            this.calButton.Enabled = false;
            this.calButton.Font = new System.Drawing.Font("B Tabassom", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.calButton.Location = new System.Drawing.Point(44, 76);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(257, 59);
            this.calButton.TabIndex = 3;
            this.calButton.Text = "محاسبه";
            this.calButton.UseVisualStyleBackColor = false;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.clearButton.Font = new System.Drawing.Font("B Tabassom", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.clearButton.Location = new System.Drawing.Point(173, 141);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(128, 59);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "پاک کن";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkOrange;
            this.exitButton.Font = new System.Drawing.Font("B Tabassom", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitButton.Location = new System.Drawing.Point(44, 141);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 59);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            this.label1.Visible = false;
            // 
            // ansLable
            // 
            this.ansLable.AutoSize = true;
            this.ansLable.Font = new System.Drawing.Font("B Tabassom", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ansLable.Location = new System.Drawing.Point(363, 17);
            this.ansLable.Name = "ansLable";
            this.ansLable.Size = new System.Drawing.Size(78, 52);
            this.ansLable.TabIndex = 7;
            this.ansLable.Text = "جواب";
            this.ansLable.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(516, 228);
            this.Controls.Add(this.ansLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.optxt);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("B Tabassom", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox optxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ansLable;
    }
}

