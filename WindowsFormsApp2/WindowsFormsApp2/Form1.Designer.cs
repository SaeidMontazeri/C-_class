namespace WindowsFormsApp2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTol = new System.Windows.Forms.TextBox();
            this.txtArz = new System.Windows.Forms.TextBox();
            this.txtMohit = new System.Windows.Forms.TextBox();
            this.txtMasahat = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "طول:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "عرض:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "محیط:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "مساحت";
            // 
            // txtTol
            // 
            this.txtTol.Location = new System.Drawing.Point(265, 47);
            this.txtTol.Name = "txtTol";
            this.txtTol.Size = new System.Drawing.Size(100, 22);
            this.txtTol.TabIndex = 4;
            // 
            // txtArz
            // 
            this.txtArz.Location = new System.Drawing.Point(265, 110);
            this.txtArz.Name = "txtArz";
            this.txtArz.Size = new System.Drawing.Size(100, 22);
            this.txtArz.TabIndex = 5;
            // 
            // txtMohit
            // 
            this.txtMohit.Location = new System.Drawing.Point(265, 274);
            this.txtMohit.Name = "txtMohit";
            this.txtMohit.Size = new System.Drawing.Size(100, 22);
            this.txtMohit.TabIndex = 6;
            // 
            // txtMasahat
            // 
            this.txtMasahat.Location = new System.Drawing.Point(265, 357);
            this.txtMasahat.Name = "txtMasahat";
            this.txtMasahat.Size = new System.Drawing.Size(100, 22);
            this.txtMasahat.TabIndex = 7;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(265, 198);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "محاسبه";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtMasahat);
            this.Controls.Add(this.txtMohit);
            this.Controls.Add(this.txtArz);
            this.Controls.Add(this.txtTol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTol;
        private System.Windows.Forms.TextBox txtArz;
        private System.Windows.Forms.TextBox txtMohit;
        private System.Windows.Forms.TextBox txtMasahat;
        private System.Windows.Forms.Button btnShow;
    }
}

