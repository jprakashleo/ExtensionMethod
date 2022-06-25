using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace ExtensionMethod
{
    internal static class Extensions
    {

        public static string ToProperCase(this string input)
        {
            if (input.Length > 0)
            {
                return input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
            }
            return "";
        }

        //example of generic + extension
        //generic List to datatable.
        public static DataTable ToDatatable<T>(this List<T> input)
        {
            DataTable dt = new DataTable();
            //reading properties of class
            PropertyDescriptorCollection propertyDescriptor = TypeDescriptor.GetProperties(typeof(T));
            //adding each peroperty into dt column
            foreach (PropertyDescriptor property in propertyDescriptor)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }
            //loop for each row data
            foreach(var item in input)
            {
                DataRow drow = dt.NewRow();
                foreach(PropertyDescriptor property in propertyDescriptor)
                {
                    drow[property.Name] = property.GetValue(item) ?? DBNull.Value;  
                }
                dt.Rows.Add(drow);
            }
            return dt;
        } 
    }
}
