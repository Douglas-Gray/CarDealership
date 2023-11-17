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
            this.btnHome = new System.Windows.Forms.Button();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.lblCarBrand = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(167, 342);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(103, 32);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtCarReg
            // 
            this.txtCarReg.Location = new System.Drawing.Point(167, 135);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(100, 22);
            this.txtCarReg.TabIndex = 1;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(167, 191);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(100, 22);
            this.txtCarModel.TabIndex = 2;
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(167, 163);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(100, 22);
            this.txtCarBrand.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(167, 254);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Location = new System.Drawing.Point(58, 138);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(103, 16);
            this.lblCarReg.TabIndex = 5;
            this.lblCarReg.Text = "Car Registration";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(58, 166);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(67, 16);
            this.lblCarBrand.TabIndex = 6;
            this.lblCarBrand.Text = "Car Brand";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(58, 191);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(69, 16);
            this.lblCarModel.TabIndex = 7;
            this.lblCarModel.Text = "Car Model";
            // 
            // DealershipNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblCarBrand);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarReg);
            this.Controls.Add(this.btnHome);
            this.Name = "DealershipNewCar";
            this.Text = "DealershipNewCar";
            this.Load += new System.EventHandler(this.DealershipNewCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Label lblCarBrand;
        private System.Windows.Forms.Label lblCarModel;
    }
}