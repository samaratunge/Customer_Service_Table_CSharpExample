using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerService
{
    public partial class CustomerService : Form
    {
        CustomerDB customerDB;
        Customer customer;
        Boolean creating = false;
        string customerID = "";

        public CustomerService()
        {
            InitializeComponent();
            customerDB = new CustomerDB();
            customer = new Customer();

            CustomerIDcomboBox.Items.Clear();
            string[] fileList = customerDB.getCustomerIDs();
            CustomerIDcomboBox.Items.AddRange(fileList);
        }

        private void addOrUpdateButton_Click(object sender, EventArgs e)
        {
            customer.customerID = CustomerIDcomboBox.Text.Trim(); 
            customer.customerName = cusNameTextBox.Text.Trim();
            customer.customerAddress = cusAddressTextBox.Text.Trim(); 
            customer.customerRequirement = cusRequireTextBox.Text.Trim();
            //Call the method in my Customer DB (Data Access class)
            customerDB.customerAddorUpdate(customer);
            
            CustomerIDcomboBox.Text = "";
            cusNameTextBox.Text = "";
            cusAddressTextBox.Text = "";
            cusRequireTextBox.Text = "";
            CustomerIDcomboBox.Items.Clear();
            //Add Ids again to for next selection
            CustomerIDcomboBox.Items.AddRange(customerDB.getCustomerIDs());
        }
        private void cusNameTextBox_textchanged(object sender, EventArgs e)
        {
            customer.customerName = cusNameTextBox.Text.Trim();
        }
        private void cusAddressTextBox_textchanged(object sender, EventArgs e)
        {
            customer.customerAddress = cusAddressTextBox.Text.Trim();
        }

        private void cusRequireTextBox_textchanged(object sender, EventArgs e)
        {
            customer.customerRequirement = cusRequireTextBox.Text.Trim();
        }

        private void comboBoxCustomerID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DialogResult result;
            Customer readCustomer = null;

                try
                {
                    customerID = CustomerIDcomboBox.SelectedItem.ToString();
                }
                catch
                {
                    customerID = "";
                }

                if (customerID != "")
                {
                    readCustomer = customerDB.customerRead(customerID);
                    if (readCustomer != null)
                    {
                        cusNameTextBox.Text = readCustomer.customerName;
                        cusAddressTextBox.Text = readCustomer.customerAddress;
                        cusRequireTextBox.Text = readCustomer.customerRequirement;
                    }
                    else
                    {
                        result = MessageBox.Show("Click Yes to create a new customer",
                                                 "Customer does not exist",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            
                            cusNameTextBox.Focus();

                        }
                        else
                        {
                            CustomerIDcomboBox.Text = "";
                            CustomerIDcomboBox.Focus();
                        }
                    }
                }
                else
                {
                    CustomerIDcomboBox.Focus();
                }            
        }

        private void comboBoxCustomerID_TextChanged(object sender, EventArgs e)
        {
            customerID = CustomerIDcomboBox.Text.Trim();
            customer.customerID = customerID;
        }

        private void comboBoxCustomerID_Leave(object sender, EventArgs e)
        {
            DialogResult result;
            Customer readCustomer = null;

                customerID = CustomerIDcomboBox.Text;
                if (customerID != "")
                {
                    readCustomer = customerDB.customerRead(customerID);
                    if (readCustomer != null)
                    {
                        cusNameTextBox.Text = readCustomer.customerName;
                        cusAddressTextBox.Text = readCustomer.customerAddress;
                        cusRequireTextBox.Text = readCustomer.customerRequirement;
                    }
                    else
                    {
                        result = MessageBox.Show("Click Yes to create a new customer",
                                                 "Customer does not exist",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            //creating = true;
                            cusNameTextBox.Text = "";
                            cusAddressTextBox.Text = "";
                            cusRequireTextBox.Text = "";
                            cusNameTextBox.Focus();
                        }
                        else
                        {
                            CustomerIDcomboBox.Text = "";
                            CustomerIDcomboBox.Focus();
                        }
                    }
                }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            customerID = CustomerIDcomboBox.Text.Trim();
            if(customerID != null)
            {
                //Use Customer ID to delete
                customerDB.deleteCustomer(customerID);                
            }
            CustomerIDcomboBox.Text = "";
            CustomerIDcomboBox.Items.Clear();
            //Delete and refresh the items
            CustomerIDcomboBox.Items.AddRange(customerDB.getCustomerIDs());
            cusNameTextBox.Text = "";
            cusAddressTextBox.Text = "";
            cusRequireTextBox.Text = "";
            CustomerIDcomboBox.Focus();
        }

        private void showCustomers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingList<Customer>(customerDB.loadDataFromFiles());

        }
    }
}
