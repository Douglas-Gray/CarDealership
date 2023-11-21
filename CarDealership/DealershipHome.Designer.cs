namespace CarDealership
{
    partial class DealershipHome
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.carsDataSet = new CarDealership.CarsDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new CarDealership.CarsDataSetTableAdapters.CarsTableAdapter();
            this.comboBoxBrands = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.btnAddNewCars = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(254, 178);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "CarsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxBrands
            // 
            this.comboBoxBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrands.FormattingEnabled = true;
            this.comboBoxBrands.Items.AddRange(new object[] {
            "All",
            "Honda",
            "Toyota",
            "Suzuki",
            "Mazda",
            "N/A Brand"});
            this.comboBoxBrands.Location = new System.Drawing.Point(36, 177);
            this.comboBoxBrands.Name = "comboBoxBrands";
            this.comboBoxBrands.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBrands.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Brands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Cars";
            // 
            // listBoxCar
            // 
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.ItemHeight = 16;
            this.listBoxCar.Location = new System.Drawing.Point(36, 244);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(293, 164);
            this.listBoxCar.TabIndex = 5;
            // 
            // btnAddNewCars
            // 
            this.btnAddNewCars.Location = new System.Drawing.Point(36, 451);
            this.btnAddNewCars.Name = "btnAddNewCars";
            this.btnAddNewCars.Size = new System.Drawing.Size(140, 31);
            this.btnAddNewCars.TabIndex = 6;
            this.btnAddNewCars.Text = "Add new cars";
            this.btnAddNewCars.UseVisualStyleBackColor = true;
            this.btnAddNewCars.Click += new System.EventHandler(this.btnAddNewCars_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(189, 451);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(140, 31);
            this.btnDeleteCar.TabIndex = 7;
            this.btnDeleteCar.Text = "Delete Cars";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // DealershipHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(677, 550);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnAddNewCars);
            this.Controls.Add(this.listBoxCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBrands);
            this.Controls.Add(this.btnSubmit);
            this.Name = "DealershipHome";
            this.Text = "Dealership Home";
            this.Load += new System.EventHandler(this.DealershipHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private CarsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarsDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxBrands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.Button btnAddNewCars;
        private System.Windows.Forms.Button btnDeleteCar;
    }
}

