namespace CustomerService
{
    partial class CustomerService
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.CustomerIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cusRequireTextBox = new System.Windows.Forms.TextBox();
            this.cusAddressTextBox = new System.Windows.Forms.TextBox();
            this.cusNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showCustomers = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.showCustomers);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.CustomerIDcomboBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cusRequireTextBox);
            this.tabPage1.Controls.Add(this.cusAddressTextBox);
            this.tabPage1.Controls.Add(this.cusNameTextBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Modify";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CustomerIDcomboBox
            // 
            this.CustomerIDcomboBox.FormattingEnabled = true;
            this.CustomerIDcomboBox.Location = new System.Drawing.Point(251, 45);
            this.CustomerIDcomboBox.Name = "CustomerIDcomboBox";
            this.CustomerIDcomboBox.Size = new System.Drawing.Size(275, 24);
            this.CustomerIDcomboBox.TabIndex = 10;
            this.CustomerIDcomboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCustomerID_SelectionChangeCommitted);
            this.CustomerIDcomboBox.TextChanged += new System.EventHandler(this.comboBoxCustomerID_TextChanged);
            this.CustomerIDcomboBox.Leave += new System.EventHandler(this.comboBoxCustomerID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Requirement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer ID";
            // 
            // cusRequireTextBox
            // 
            this.cusRequireTextBox.Location = new System.Drawing.Point(251, 202);
            this.cusRequireTextBox.Name = "cusRequireTextBox";
            this.cusRequireTextBox.Size = new System.Drawing.Size(275, 22);
            this.cusRequireTextBox.TabIndex = 4;
            this.cusRequireTextBox.TextChanged += new System.EventHandler(this.cusRequireTextBox_textchanged);
            // 
            // cusAddressTextBox
            // 
            this.cusAddressTextBox.Location = new System.Drawing.Point(251, 148);
            this.cusAddressTextBox.Name = "cusAddressTextBox";
            this.cusAddressTextBox.Size = new System.Drawing.Size(275, 22);
            this.cusAddressTextBox.TabIndex = 3;
            this.cusAddressTextBox.TextChanged += new System.EventHandler(this.cusAddressTextBox_textchanged);
            // 
            // cusNameTextBox
            // 
            this.cusNameTextBox.Location = new System.Drawing.Point(251, 98);
            this.cusNameTextBox.Name = "cusNameTextBox";
            this.cusNameTextBox.Size = new System.Drawing.Size(275, 22);
            this.cusNameTextBox.TabIndex = 2;
            this.cusNameTextBox.TextChanged += new System.EventHandler(this.cusNameTextBox_textchanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add or Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addOrUpdateButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 414);
            this.tabControl1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // showCustomers
            // 
            this.showCustomers.Location = new System.Drawing.Point(283, 15);
            this.showCustomers.Name = "showCustomers";
            this.showCustomers.Size = new System.Drawing.Size(179, 31);
            this.showCustomers.TabIndex = 1;
            this.showCustomers.Text = "Show Customers";
            this.showCustomers.UseVisualStyleBackColor = true;
            this.showCustomers.Click += new System.EventHandler(this.showCustomers_Click);
            // 
            // CustomerService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomerService";
            this.Text = "Customer Service";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusRequireTextBox;
        private System.Windows.Forms.TextBox cusAddressTextBox;
        private System.Windows.Forms.TextBox cusNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CustomerIDcomboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showCustomers;
    }
}

