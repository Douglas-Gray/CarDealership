namespace CarDealership
{
    partial class DealershipUpdate
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
            this.lblModelValidation = new System.Windows.Forms.Label();
            this.lblBrandValidation = new System.Windows.Forms.Label();
            this.lblRegValidation = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarBrand = new System.Windows.Forms.Label();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateCarBrand = new System.Windows.Forms.TextBox();
            this.txtUpdateCarModel = new System.Windows.Forms.TextBox();
            this.txtUpdateCarReg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentCarReg = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update Car";
            // 
            // lblModelValidation
            // 
            this.lblModelValidation.AutoSize = true;
            this.lblModelValidation.BackColor = System.Drawing.SystemColors.Control;
            this.lblModelValidation.ForeColor = System.Drawing.Color.Firebrick;
            this.lblModelValidation.Location = new System.Drawing.Point(387, 291);
            this.lblModelValidation.Name = "lblModelValidation";
            this.lblModelValidation.Size = new System.Drawing.Size(0, 16);
            this.lblModelValidation.TabIndex = 22;
            // 
            // lblBrandValidation
            // 
            this.lblBrandValidation.AutoSize = true;
            this.lblBrandValidation.BackColor = System.Drawing.SystemColors.Control;
            this.lblBrandValidation.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBrandValidation.Location = new System.Drawing.Point(387, 263);
            this.lblBrandValidation.Name = "lblBrandValidation";
            this.lblBrandValidation.Size = new System.Drawing.Size(0, 16);
            this.lblBrandValidation.TabIndex = 21;
            // 
            // lblRegValidation
            // 
            this.lblRegValidation.AutoSize = true;
            this.lblRegValidation.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegValidation.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRegValidation.Location = new System.Drawing.Point(387, 235);
            this.lblRegValidation.Name = "lblRegValidation";
            this.lblRegValidation.Size = new System.Drawing.Size(0, 16);
            this.lblRegValidation.TabIndex = 20;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(145, 291);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(117, 16);
            this.lblCarModel.TabIndex = 19;
            this.lblCarModel.Text = "Update Car Model";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(147, 263);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(115, 16);
            this.lblCarBrand.TabIndex = 18;
            this.lblCarBrand.Text = "Update Car Brand";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Location = new System.Drawing.Point(111, 235);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(151, 16);
            this.lblCarReg.TabIndex = 17;
            this.lblCarReg.Text = "Update Car Registration";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(295, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateCarBrand
            // 
            this.txtUpdateCarBrand.Location = new System.Drawing.Point(281, 260);
            this.txtUpdateCarBrand.Name = "txtUpdateCarBrand";
            this.txtUpdateCarBrand.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateCarBrand.TabIndex = 15;
            // 
            // txtUpdateCarModel
            // 
            this.txtUpdateCarModel.Location = new System.Drawing.Point(281, 288);
            this.txtUpdateCarModel.Name = "txtUpdateCarModel";
            this.txtUpdateCarModel.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateCarModel.TabIndex = 14;
            // 
            // txtUpdateCarReg
            // 
            this.txtUpdateCarReg.Location = new System.Drawing.Point(281, 232);
            this.txtUpdateCarReg.Name = "txtUpdateCarReg";
            this.txtUpdateCarReg.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateCarReg.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 32);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(387, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Current Car Registration";
            // 
            // txtCurrentCarReg
            // 
            this.txtCurrentCarReg.Location = new System.Drawing.Point(281, 134);
            this.txtCurrentCarReg.Name = "txtCurrentCarReg";
            this.txtCurrentCarReg.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentCarReg.TabIndex = 24;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(295, 172);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 25);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // DealershipUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 531);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentCarReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModelValidation);
            this.Controls.Add(this.lblBrandValidation);
            this.Controls.Add(this.lblRegValidation);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblCarBrand);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdateCarBrand);
            this.Controls.Add(this.txtUpdateCarModel);
            this.Controls.Add(this.txtUpdateCarReg);
            this.Controls.Add(this.btnExit);
            this.Name = "DealershipUpdate";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModelValidation;
        private System.Windows.Forms.Label lblBrandValidation;
        private System.Windows.Forms.Label lblRegValidation;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarBrand;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateCarBrand;
        private System.Windows.Forms.TextBox txtUpdateCarModel;
        private System.Windows.Forms.TextBox txtUpdateCarReg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentCarReg;
        private System.Windows.Forms.Button btnFind;
    }
}