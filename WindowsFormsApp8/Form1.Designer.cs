namespace WindowsFormsApp8
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
            this.btnCar = new System.Windows.Forms.Button();
            this.btnVanet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(285, 39);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(115, 37);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "Car";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnVanet
            // 
            this.btnVanet.Location = new System.Drawing.Point(285, 130);
            this.btnVanet.Name = "btnVanet";
            this.btnVanet.Size = new System.Drawing.Size(115, 44);
            this.btnVanet.TabIndex = 1;
            this.btnVanet.Text = "Vanet";
            this.btnVanet.UseVisualStyleBackColor = true;
            this.btnVanet.Click += new System.EventHandler(this.btnVanet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 502);
            this.Controls.Add(this.btnVanet);
            this.Controls.Add(this.btnCar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnVanet;
    }
}

