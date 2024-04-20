namespace WindowsFormsApp4
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
            this.btnShow = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtkh = new System.Windows.Forms.TextBox();
            this.txtbaghi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(600, 236);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(131, 42);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "اجرا";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(583, 44);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(172, 34);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(583, 130);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(172, 34);
            this.txtNum2.TabIndex = 2;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(583, 328);
            this.txtSum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(172, 34);
            this.txtSum.TabIndex = 3;
            // 
            // txtkh
            // 
            this.txtkh.Location = new System.Drawing.Point(583, 409);
            this.txtkh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtkh.Name = "txtkh";
            this.txtkh.Size = new System.Drawing.Size(172, 34);
            this.txtkh.TabIndex = 4;
            // 
            // txtbaghi
            // 
            this.txtbaghi.Location = new System.Drawing.Point(583, 482);
            this.txtbaghi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtbaghi.Name = "txtbaghi";
            this.txtbaghi.Size = new System.Drawing.Size(172, 34);
            this.txtbaghi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 556);
            this.Controls.Add(this.txtbaghi);
            this.Controls.Add(this.txtkh);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnShow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtkh;
        private System.Windows.Forms.TextBox txtbaghi;
    }
}

