namespace CarDealership
{
    partial class DealershipNewCar
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
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.lblCarBrand = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblRegValidation = new System.Windows.Forms.Label();
            this.lblBrandValidation = new System.Windows.Forms.Label();
            this.lblModelValidation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(218, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCarReg
            // 
            this.txtCarReg.Location = new System.Drawing.Point(218, 159);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(100, 22);
            this.txtCarReg.TabIndex = 1;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(218, 215);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(100, 22);
            this.txtCarModel.TabIndex = 2;
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(218, 187);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(100, 22);
            this.txtCarBrand.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(218, 268);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Location = new System.Drawing.Point(98, 162);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(103, 16);
            this.lblCarReg.TabIndex = 5;
            this.lblCarReg.Text = "Car Registration";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(98, 190);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(67, 16);
            this.lblCarBrand.TabIndex = 6;
            this.lblCarBrand.Text = "Car Brand";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(98, 215);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(69, 16);
            this.lblCarModel.TabIndex = 7;
            this.lblCarModel.Text = "Car Model";
            // 
            // lblRegValidation
            // 
            this.lblRegValidation.AutoSize = true;
            this.lblRegValidation.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegValidation.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRegValidation.Location = new System.Drawing.Point(324, 162);
            this.lblRegValidation.Name = "lblRegValidation";
            this.lblRegValidation.Size = new System.Drawing.Size(0, 16);
            this.lblRegValidation.TabIndex = 8;
            // 
            // lblBrandValidation
            // 
            this.lblBrandValidation.AutoSize = true;
            this.lblBrandValidation.BackColor = System.Drawing.SystemColors.Control;
            this.lblBrandValidation.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBrandValidation.Location = new System.Drawing.Point(324, 190);
            this.lblBrandValidation.Name = "lblBrandValidation";
            this.lblBrandValidation.Size = new System.Drawing.Size(0, 16);
            this.lblBrandValidation.TabIndex = 9;
            // 
            // lblModelValidation
            // 
            this.lblModelValidation.AutoSize = true;
            this.lblModelValidation.BackColor = System.Drawing.SystemColors.Control;
            this.lblModelValidation.ForeColor = System.Drawing.Color.Firebrick;
            this.lblModelValidation.Location = new System.Drawing.Point(324, 218);
            this.lblModelValidation.Name = "lblModelValidation";
            this.lblModelValidation.Size = new System.Drawing.Size(0, 16);
            this.lblModelValidation.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add New Car";
            // 
            // DealershipNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModelValidation);
            this.Controls.Add(this.lblBrandValidation);
            this.Controls.Add(this.lblRegValidation);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblCarBrand);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarReg);
            this.Controls.Add(this.btnExit);
            this.Name = "DealershipNewCar";
            this.Text = "Dealership New Car";
            this.Load += new System.EventHandler(this.DealershipNewCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Label lblCarBrand;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblRegValidation;
        private System.Windows.Forms.Label lblBrandValidation;
        private System.Windows.Forms.Label lblModelValidation;
        private System.Windows.Forms.Label label1;
    }
}