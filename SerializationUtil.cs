using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CustomerService
{
    /**
     * This is Generic Serilizer class usable for any object
     * You can use serialization and deserialization both in once
     * 
     */
    static class SerializationUtil<T>
    {
        static string lastError = "";

        /**
         * Generic serializer method allows to add any type
         * of data for serilization
         * 
         */
        public static Boolean serializer(T data, string path, string ID) 
        {
            string json = "";
            Boolean isUpdated = false;

            // The options variable sets up the parameters to make the Serialiszer 
            // format the JSON values indented on individual lines. They are easier
            // to read that way when the file is opened later in a text editor.
            var options = new JsonSerializerOptions()
            {
                    WriteIndented = true
            };

            // Create the JSON format record for the table
            json = JsonSerializer.Serialize(data, options);

            // Write the record to the table
            try
            {
                 StreamWriter writer = new StreamWriter(path + ID);
                 writer.Write(json);
                 writer.Close();  
                 isUpdated = true;
            }
            catch (Exception e)
            {
               // the record could not be written, but the catch stops the 
               // system crashing.
               lastError = "Could not write JSON text to the file. Error returned: \n\n" + e.Message;
            }
            return isUpdated;
        }

        /**
         * 
         * Deserialize each object and return as output to extract  
         * any object from the file
         * 
         */
        public static T deserializer(T data, string path, string ID)
        {
            lastError = "";
           
            // Open the JSON file, read to the end, and convert the JSON data to a single object
            // with named fields. This is called deserialising.            
            try
            {
                StreamReader reader = new StreamReader(path + ID);
                string json = reader.ReadToEnd();
                reader.Close();
              
                // The options variable sets up the parameters to make the DeSerialiszer 
                // case insensitive.
                var JsonOptions = new JsonSerializerOptions();
                JsonOptions.PropertyNameCaseInsensitive = true;
                data = JsonSerializer.Deserialize<T>(json, JsonOptions);                
            }
            catch (Exception e)
            {
                // the record was not found.
                lastError = e.Message;
            }
            return data;
        }
    }
}
