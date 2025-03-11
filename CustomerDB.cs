using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerService
{
    internal class CustomerDB
    {
        private string lastError = "";
        private string directoryName = "";
        private string tableName = "";
        private string directoryPath = "";
        
        public CustomerDB() 
        {
            /*
             * Locate the database folder so that the JSON-format data table can
             * be accessed. It is always located in the bin/Debug folder for
             * the project.            
             */
            directoryName = Directory.GetCurrentDirectory();

            // Specify the name of the subdirectory that will
            // store the data by setting the tableName variable.
            tableName = "customer";
            
            directoryPath = directoryName + "\\Database\\" + tableName + "\\";
            
            // If the database and table does not exist then create a new one.
            if (!Directory.Exists(directoryPath))
            {
                try
                {
                    Directory.CreateDirectory(directoryPath);
                }
                catch
                {
                    lastError = "Cannot create database in directory " + directoryName;
                }
            }
                     
        }

        /**
         * This function updates an existing record or creates a new one.
         * Before calling this function, the calling form needs to update
         * each of the data fields.
         */
        public Boolean customerAddorUpdate(Customer customer)
        {
            return SerializationUtil<Customer>.serializer(customer, directoryPath, customer.customerID);                
        }

        /**
         * Reads the specified record from the database table and unpacks the data in the
         * record if it is found. If the record is not found, all the database entries are
         * automatically set blank so a new record can be created by the program later
         * if necessary.         
         */
        public Customer customerRead(string ID)
        {
            Customer customer = null;
            return SerializationUtil<Customer>.deserializer(customer, directoryPath, ID);
        }

        /**
         * Load all data from Json files and return as
         * Customer List to display in the table
         * 
         */
        public List<Customer> loadDataFromFiles()
        {
            List<Customer> customerList = new List<Customer>();
            if (Directory.Exists(directoryPath))
            {
                string[] fileList = Directory.GetFiles(directoryPath);   
                //Deserialize file by file and extract the content 
                foreach (string file in fileList)
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(file);
                        Customer customer = JsonSerializer.Deserialize<Customer>(jsonContent);
                        if (customer != null)
                        {
                            customerList.Add(customer);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading file {file}: {ex.Message}");
                    }
                    
                }
            }
            return customerList;
        }

       
        /**
         * Returns a string array containing the Customer IDs of all  the records in the table.
         * This can be used to make a list to display in a ListBox or in a ComboBox.
         */
        public string[] getCustomerIDs()
        {
            string[] recordList = Directory.GetFiles(directoryPath);

            for (int item = 0; item < recordList.Length; item++)
            {
                // Extract just the file name from the list of files                
                recordList[item] = Path.GetFileName(recordList[item]);
            }
            return recordList;
        }

        /**
         * 
         * Delete customer details and return true
         * for successfully deleted
         * 
         */
        public Boolean deleteCustomer(String ID)
        {
            Boolean isDeleted = false;
            if(File.Exists(directoryPath + ID))
            {
                File.Delete(directoryPath + ID);
                isDeleted = true;
            }
            return isDeleted;
        }

    }
}
