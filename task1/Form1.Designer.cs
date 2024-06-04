namespace task1
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
            this.helloButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.helloLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(208, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(140, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 3;
            // 
            // helloButton
            // 
            this.helloButton.BackColor = System.Drawing.Color.DarkOrange;
            this.helloButton.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helloButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helloButton.Location = new System.Drawing.Point(353, 136);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(137, 46);
            this.helloButton.TabIndex = 4;
            this.helloButton.Text = "سلام";
            this.helloButton.UseVisualStyleBackColor = false;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.clearButton.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(196, 136);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 46);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "پاک کن";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ExitButton.Font = new System.Drawing.Font("B Tabassom", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Location = new System.Drawing.Point(37, 136);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(137, 46);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "خروج";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // helloLable
            // 
            this.helloLable.AutoSize = true;
            this.helloLable.Font = new System.Drawing.Font("B Tabassom", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helloLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helloLable.Location = new System.Drawing.Point(162, 203);
            this.helloLable.Name = "helloLable";
            this.helloLable.Size = new System.Drawing.Size(0, 46);
            this.helloLable.TabIndex = 7;
            this.helloLable.MouseLeave += new System.EventHandler(this.helloLable_MouseLeave);
            this.helloLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.helloLable_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(518, 277);
            this.Controls.Add(this.helloLable);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.helloButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Tabassom", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label helloLable;
    }
}

