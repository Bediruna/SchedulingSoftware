using System.Data;

namespace SchedulingSoftware.DataModels
{
    public class Customers
    {
        private static DataTable customersDataTable = new DataTable();            

        public static DataTable getAllPartsDataTable()
        {
            //If column does not exist, add column.
            if (!customersDataTable.Columns.Contains("ID")) { customersDataTable.Columns.Add("ID", typeof(int)); }
            if (!customersDataTable.Columns.Contains("Name")) { customersDataTable.Columns.Add("Name", typeof(string)); }
            if (!customersDataTable.Columns.Contains("Address")) { customersDataTable.Columns.Add("Address", typeof(string)); }
            if (!customersDataTable.Columns.Contains("Phone Number")) { customersDataTable.Columns.Add("Phone Number", typeof(string)); }

            return customersDataTable;

        }
    }
}
