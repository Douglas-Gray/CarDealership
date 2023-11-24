namespace CarDealership
{
    partial class DealershipDeleteCar
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRegValidation = new System.Windows.Forms.Label();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(86, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCarReg
            // 
            this.txtCarReg.Location = new System.Drawing.Point(192, 167);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(100, 22);
            this.txtCarReg.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(208, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Delete";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblRegValidation
            // 
            this.lblRegValidation.AutoSize = true;
            this.lblRegValidation.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegValidation.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRegValidation.Location = new System.Drawing.Point(189, 192);
            this.lblRegValidation.Name = "lblRegValidation";
            this.lblRegValidation.Size = new System.Drawing.Size(0, 16);
            this.lblRegValidation.TabIndex = 9;
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Location = new System.Drawing.Point(83, 170);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(103, 16);
            this.lblCarReg.TabIndex = 10;
            this.lblCarReg.Text = "Car Registration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Delete Car\'s";
            // 
            // DealershipDeleteCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.lblRegValidation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCarReg);
            this.Controls.Add(this.btnExit);
            this.Name = "DealershipDeleteCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Car";
            this.Load += new System.EventHandler(this.DealershipDeleteCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRegValidation;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Label label1;
    }
}