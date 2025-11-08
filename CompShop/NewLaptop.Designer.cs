namespace CompShop
{
    partial class NewLaptop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBrand = new Label();
            txtBrand = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblProcessor = new Label();
            txtProcessor = new TextBox();
            lblMemory = new Label();
            txtMemory = new TextBox();
            lblHarddisk = new Label();
            txtHardDisk = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnRetrieve = new Button();
            dataGridView = new DataGridView();
            btnGenerateReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(89, 89);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(38, 15);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Brand";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(164, 86);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(191, 23);
            txtBrand.TabIndex = 1;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(89, 128);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(164, 125);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(191, 23);
            txtModel.TabIndex = 3;
            // 
            // lblProcessor
            // 
            lblProcessor.AutoSize = true;
            lblProcessor.Location = new Point(89, 169);
            lblProcessor.Name = "lblProcessor";
            lblProcessor.Size = new Size(58, 15);
            lblProcessor.TabIndex = 4;
            lblProcessor.Text = "Processor";
            // 
            // txtProcessor
            // 
            txtProcessor.Location = new Point(164, 166);
            txtProcessor.Name = "txtProcessor";
            txtProcessor.Size = new Size(191, 23);
            txtProcessor.TabIndex = 5;
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.Location = new Point(436, 90);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(52, 15);
            lblMemory.TabIndex = 6;
            lblMemory.Text = "Memory";
            // 
            // txtMemory
            // 
            txtMemory.Location = new Point(511, 86);
            txtMemory.Name = "txtMemory";
            txtMemory.Size = new Size(191, 23);
            txtMemory.TabIndex = 7;
            // 
            // lblHarddisk
            // 
            lblHarddisk.AutoSize = true;
            lblHarddisk.Location = new Point(436, 130);
            lblHarddisk.Name = "lblHarddisk";
            lblHarddisk.Size = new Size(58, 15);
            lblHarddisk.TabIndex = 8;
            lblHarddisk.Text = "Hard Disk";
            // 
            // txtHardDisk
            // 
            txtHardDisk.Location = new Point(511, 125);
            txtHardDisk.Name = "txtHardDisk";
            txtHardDisk.Size = new Size(191, 23);
            txtHardDisk.TabIndex = 9;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(436, 169);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(511, 166);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(191, 23);
            txtPrice.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(164, 226);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Location = new Point(270, 226);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(75, 23);
            btnRetrieve.TabIndex = 13;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.UseVisualStyleBackColor = true;
            btnRetrieve.Click += btnRetrieve_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(30, 288);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(744, 150);
            dataGridView.TabIndex = 14;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(373, 226);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(142, 23);
            btnGenerateReport.TabIndex = 15;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += button1_Click;
            // 
            // NewLaptop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerateReport);
            Controls.Add(dataGridView);
            Controls.Add(btnRetrieve);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtHardDisk);
            Controls.Add(lblHarddisk);
            Controls.Add(txtMemory);
            Controls.Add(lblMemory);
            Controls.Add(txtProcessor);
            Controls.Add(lblProcessor);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtBrand);
            Controls.Add(lblBrand);
            Name = "NewLaptop";
            Text = "NewLaptop";
            Load += NewLaptop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrand;
        private TextBox txtBrand;
        private Label lblModel;
        private TextBox txtModel;
        private Label lblProcessor;
        private TextBox txtProcessor;
        private Label lblMemory;
        private TextBox txtMemory;
        private Label lblHarddisk;
        private TextBox txtHardDisk;
        private Label lblPrice;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnRetrieve;
        private DataGridView dataGridView;
        private Button btnGenerateReport;
    }
}
