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
            this.carsDataSet = new CarDealership.CarsDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new CarDealership.CarsDataSetTableAdapters.CarsTableAdapter();
            this.comboBoxBrands = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.btnAddNewCars = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            "All"});
            this.comboBoxBrands.Location = new System.Drawing.Point(99, 191);
            this.comboBoxBrands.Name = "comboBoxBrands";
            this.comboBoxBrands.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBrands.TabIndex = 1;
            this.comboBoxBrands.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrands_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Brands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Cars";
            // 
            // listBoxCar
            // 
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.ItemHeight = 16;
            this.listBoxCar.Location = new System.Drawing.Point(99, 258);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(293, 164);
            this.listBoxCar.TabIndex = 5;
            this.listBoxCar.SelectedIndexChanged += new System.EventHandler(this.listBoxCar_SelectedIndexChanged);
            // 
            // btnAddNewCars
            // 
            this.btnAddNewCars.Location = new System.Drawing.Point(417, 258);
            this.btnAddNewCars.Name = "btnAddNewCars";
            this.btnAddNewCars.Size = new System.Drawing.Size(140, 31);
            this.btnAddNewCars.TabIndex = 6;
            this.btnAddNewCars.Text = "Add new cars";
            this.btnAddNewCars.UseVisualStyleBackColor = true;
            this.btnAddNewCars.Click += new System.EventHandler(this.btnAddNewCars_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(417, 391);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(140, 31);
            this.btnDeleteCar.TabIndex = 7;
            this.btnDeleteCar.Text = "Delete Cars";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(417, 326);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(140, 31);
            this.btnUpdateCar.TabIndex = 8;
            this.btnUpdateCar.Text = "Update Cars";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(343, 191);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 43);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "↻";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DealershipHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 512);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnAddNewCars);
            this.Controls.Add(this.listBoxCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBrands);
            this.Name = "DealershipHome";
            this.Text = "Dealership Home";
            this.Load += new System.EventHandler(this.DealershipHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CarsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarsDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxBrands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.Button btnAddNewCars;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnRefresh;
    }
}

