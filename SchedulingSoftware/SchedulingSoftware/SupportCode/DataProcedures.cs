using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using SchedulingSoftware.DataModels;

namespace SchedulingSoftware.SupportCode
{
    class DataProcedures
    {
        private const string server = "52.206.157.109";
        private const string database = "U056wS";
        private const string uid = "U056wS";
        private const string password = "53688430062";
        private const string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";" + "SslMode=None";


        //returns a boolean to verify that user has been registered.
        public bool registerUser(User userInfo)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO user(userName, password, active, createBy) VALUES(@username, @password, @active, @createdBy)";
                cmd.Parameters.AddWithValue("@username", userInfo.username);
                cmd.Parameters.AddWithValue("@password", userInfo.password);
                cmd.Parameters.AddWithValue("@active", 1);//Created user is active
                cmd.Parameters.AddWithValue("@createdBy", userInfo.username);
                cmd.ExecuteNonQuery();

            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                //Write exception with label to cosole for debugging
                Console.WriteLine("Exception thrown when registering user: " + ex);
                return false;
            }
            //Close connection regardless of whether the try case executes or not.
            finally
            {
                conn.Close();
            }

            return true;
        }

        public int verifyUser(User userInfo)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            int userId = -1;

            string returnedUserName;
            string returnedPassword;

            try
            {
                conn.Open();
                MySqlCommand checkUserNameCmd = conn.CreateCommand();
                checkUserNameCmd.CommandText = "SELECT EXISTS(SELECT userName FROM user WHERE userName = @username)";
                checkUserNameCmd.Parameters.AddWithValue("@username", userInfo.username);
                returnedUserName = checkUserNameCmd.ExecuteScalar().ToString();

                MySqlCommand checkPasswordCmd = conn.CreateCommand();
                checkPasswordCmd.CommandText = "SELECT EXISTS(SELECT password FROM user WHERE BINARY password = @password AND userName = @username)";//"BINARY" is used for case sensitivity in SQL queries
                checkPasswordCmd.Parameters.AddWithValue("@password", userInfo.password);
                checkPasswordCmd.Parameters.AddWithValue("@username", userInfo.username);
                returnedPassword = checkPasswordCmd.ExecuteScalar().ToString();



                if (returnedUserName == "1" && returnedPassword == "1")
                {
                    MySqlCommand returnUserIdCmd = conn.CreateCommand();
                    returnUserIdCmd.CommandText = "SELECT userId FROM user WHERE BINARY password = @password AND userName = @username";
                    returnUserIdCmd.Parameters.AddWithValue("@password", userInfo.password);
                    returnUserIdCmd.Parameters.AddWithValue("@username", userInfo.username);
                    userId = (int)returnUserIdCmd.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown verifying user: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return userId;
        }

        public CustomerInformation getCustomerInformation(int customerID)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            CustomerInformation custInfo = new CustomerInformation();

            try
            {
                conn.Open();
                string query = "SELECT customer.customerName, address.phone, address.address, address.address2, address.postalCode, city.city, country.country FROM customer " +
                    "LEFT JOIN address ON customer.addressId = address.addressId " +
                    "LEFT JOIN city ON address.cityId = city.cityId " +
                    "LEFT JOIN country ON city.countryId = country.countryId " +
                    "WHERE customer.customerId = @custId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@custId", customerID);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        custInfo.customerName = reader["customerName"].ToString();
                        custInfo.address = reader["address"].ToString();
                        custInfo.address2 = reader["address2"].ToString();
                        custInfo.city = reader["city"].ToString();
                        custInfo.postalCode = reader["postalCode"].ToString();
                        custInfo.country = reader["country"].ToString();
                        custInfo.phone = reader["phone"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown getting customer: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return custInfo;
        }

        public bool saveCustomerInformaion(CustomerInformation custInfo)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);

            bool success = false;

            try
            {
                conn.Open();
                string updateCommand =
                    "UPDATE customer SET customerName = @customerName WHERE customerId = @customerId; " +
                    "UPDATE address SET address = @address, address2 = @address2, postalCode = @postalCode, phone = @phone " +
                    "WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId); " +
                    "UPDATE city SET city = @city " +
                    "WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)); " +
                    "UPDATE country SET country = @country " +
                    "WHERE countryId = (SELECT countryId FROM city WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)))";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;
                cmd.Parameters.AddWithValue("@customerId", custInfo.customerID);
                cmd.Parameters.AddWithValue("@customerName", custInfo.customerName);
                cmd.Parameters.AddWithValue("@address", custInfo.address);
                cmd.Parameters.AddWithValue("@address2", custInfo.address2);
                cmd.Parameters.AddWithValue("@city", custInfo.city);
                cmd.Parameters.AddWithValue("@postalCode", custInfo.postalCode);
                cmd.Parameters.AddWithValue("@country", custInfo.country);
                cmd.Parameters.AddWithValue("@phone", custInfo.phone);
                cmd.ExecuteNonQuery();

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown saving customer: " + ex);
                success = false;
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

        public DataTable getCustomers()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            DataTable customersDataTable = new DataTable();

            //If column does not exist, add column.
            if (!customersDataTable.Columns.Contains("ID")) { customersDataTable.Columns.Add("ID", typeof(int)); }
            if (!customersDataTable.Columns.Contains("Name")) { customersDataTable.Columns.Add("Name", typeof(string)); }
            if (!customersDataTable.Columns.Contains("Phone Number")) { customersDataTable.Columns.Add("Phone Number", typeof(string)); }
            if (!customersDataTable.Columns.Contains("Address")) { customersDataTable.Columns.Add("Address", typeof(string)); }
            if (!customersDataTable.Columns.Contains("Address 2")) { customersDataTable.Columns.Add("Address 2", typeof(string)); }
            if (!customersDataTable.Columns.Contains("City")) { customersDataTable.Columns.Add("City", typeof(string)); }
            if (!customersDataTable.Columns.Contains("Postal Code")) { customersDataTable.Columns.Add("Postal Code", typeof(string)); }
            if (!customersDataTable.Columns.Contains("Country")) { customersDataTable.Columns.Add("Country", typeof(string)); }

            try
            {
                conn.Open();
                string query = "SELECT customer.customerId, customer.customerName, address.phone, address.address, address.address2, address.postalCode, city.city, country.country FROM customer " +
                    "LEFT JOIN address ON customer.addressId = address.addressId " +
                    "LEFT JOIN city ON address.cityId = city.cityId " +
                    "LEFT JOIN country ON city.countryId = country.countryId";
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        customersDataTable.Rows.Add(reader["customerId"], reader["customerName"], reader["phone"], reader["address"], reader["address2"], reader["city"], reader["postalCode"], reader["country"]);

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown getting customers: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return customersDataTable;

        }

        public bool addCustomer(Customer customer)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO customer(customerName, addressId, active, createdBy) VALUES(@customerName, @addressId, @active, @createdBy)";
                cmd.Parameters.AddWithValue("@customerName", customer.customerName);
                cmd.Parameters.AddWithValue("@addressId", customer.addressId);
                cmd.Parameters.AddWithValue("@active", 1);//Created user is active
                cmd.Parameters.AddWithValue("@createdBy", customer.createdBy);
                cmd.ExecuteNonQuery();

            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when adding customer: " + ex);
                return false;
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool deleteCustomer(int customerId)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM customer WHERE customerId = @customerId";
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.ExecuteNonQuery();

            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when deleting customer: " + ex);
                return false;
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }
            return true;
        }

        public int addAddress(Address address)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            int addressId = -1;

            try
            {

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO address(address, address2, cityId, postalCode, phone, createdBy) VALUES(@address, @address2, @cityId, @postalCode, @phone, @createdBy);" +
                    "SELECT addressId FROM address ORDER BY addressId DESC LIMIT 1"; //enter new address and return last entered address id.
                cmd.Parameters.AddWithValue("@address", address.address);
                cmd.Parameters.AddWithValue("@address2", address.address2);
                cmd.Parameters.AddWithValue("@cityId", address.cityId);
                cmd.Parameters.AddWithValue("@postalCode", address.postalCode);
                cmd.Parameters.AddWithValue("@phone", address.phone);
                cmd.Parameters.AddWithValue("@createdBy", address.createdBy);
                addressId = (int)cmd.ExecuteScalar();

            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when adding address: " + ex);
                addressId = -1;
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return addressId;
        }

        public int addCity(City city)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            int cityId = -1;

            try
            {

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO city(city, countryId, createdBy) VALUES(@city, @countryId, @createdBy);" +
                    "SELECT cityId FROM city ORDER BY cityId DESC LIMIT 1"; //enter new city and return last entered city id.
                cmd.Parameters.AddWithValue("@city", city.city);
                cmd.Parameters.AddWithValue("@countryId", city.countryId);
                cmd.Parameters.AddWithValue("@createdBy", city.createdBy);
                cityId = (int)cmd.ExecuteScalar();

            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when adding city: " + ex);
                cityId = -1;
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return cityId;
        }

        public int addCountry(Country country)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            int countryId = -1;

            try
            {

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO country(country, createdBy) VALUES(@country, @createdBy);" +
                    "SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
                cmd.Parameters.AddWithValue("@country", country.country);
                cmd.Parameters.AddWithValue("@createdBy", country.createdBy);
                countryId = (int)cmd.ExecuteScalar();

            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when adding country: " + ex);
                countryId = -1;
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return countryId;
        }

        public DataTable getAppointments(int customerId, int userId)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            DataTable appointmentsDataTable = new DataTable();

            //If column does not exist, add column.
            if (!appointmentsDataTable.Columns.Contains("ID")) { appointmentsDataTable.Columns.Add("ID", typeof(int)); }
            if (!appointmentsDataTable.Columns.Contains("Title")) { appointmentsDataTable.Columns.Add("Title", typeof(string)); }
            if (!appointmentsDataTable.Columns.Contains("Customer Name")) { appointmentsDataTable.Columns.Add("Customer Name", typeof(string)); }

            try
            {
                conn.Open();
                string query = "SELECT appointment.appointmentId, appointment.title, customer.customerName FROM appointment " +
                    "LEFT JOIN customer ON appointment.customerId = customer.customerId " +
                    "WHERE appointment.customerId = @customerId AND appointment.userId = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@userId", userId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        appointmentsDataTable.Rows.Add(reader["appointmentId"], reader["title"], reader["customerName"]);

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown getting appointments: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return appointmentsDataTable;

        }

        public int addAppointment(Appointment appt)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            int apptId = -1;

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end) VALUES(@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end);" +
                    "SELECT appointmentId FROM appointment ORDER BY appointmentId DESC LIMIT 1";
                cmd.Parameters.AddWithValue("@customerId", appt.customerId);
                cmd.Parameters.AddWithValue("@userId", appt.userId);
                cmd.Parameters.AddWithValue("@title", appt.title);
                cmd.Parameters.AddWithValue("@description", appt.description);
                cmd.Parameters.AddWithValue("@location", appt.location);
                cmd.Parameters.AddWithValue("@contact", appt.contact);
                cmd.Parameters.AddWithValue("@type", appt.type);
                cmd.Parameters.AddWithValue("@url", appt.url);
                cmd.Parameters.AddWithValue("@start", appt.start);
                cmd.Parameters.AddWithValue("@end", appt.end);
                apptId = (int)cmd.ExecuteScalar();
            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when adding appointment: " + ex);
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return apptId;
        }

        public Appointment getAppointmentInformation(int apptID)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            Appointment apptInfo = new Appointment();

            try
            {
                conn.Open();
                string query = "SELECT customerId, userId, title, description, location, contact, type, url, start, end FROM appointment WHERE appointmentId = @appointmentId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@appointmentId", apptID);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        apptInfo.customerId = (int)reader["customerId"];
                        apptInfo.userId = (int)reader["userId"];
                        apptInfo.title = reader["title"].ToString();
                        apptInfo.description = reader["description"].ToString();
                        apptInfo.location = reader["location"].ToString();
                        apptInfo.contact = reader["contact"].ToString();
                        apptInfo.type = reader["type"].ToString();
                        apptInfo.url = reader["url"].ToString();
                        apptInfo.start = Convert.ToDateTime(reader["start"]);
                        apptInfo.end = Convert.ToDateTime(reader["end"]);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown getting appointment: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return apptInfo;
        }

        public bool updateAppointment(Appointment apptInfo)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);

            bool success = false;

            try
            {
                conn.Open();
                string updateCommand =
                    "UPDATE appointment SET customerId = @customerId, userId = @userId, title = @title, description = @description, location = @location, " +
                    "contact = @contact, url = @url, start = @start, end = @end WHERE appointmentId = @appointmentId;";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;
                cmd.Parameters.AddWithValue("@appointmentId", apptInfo.appointmentId);
                cmd.Parameters.AddWithValue("@customerId", apptInfo.customerId);
                cmd.Parameters.AddWithValue("@userId", apptInfo.userId);
                cmd.Parameters.AddWithValue("@title", apptInfo.title);
                cmd.Parameters.AddWithValue("@description", apptInfo.description);
                cmd.Parameters.AddWithValue("@location", apptInfo.location);
                cmd.Parameters.AddWithValue("@contact", apptInfo.contact);
                cmd.Parameters.AddWithValue("@type", apptInfo.type);
                cmd.Parameters.AddWithValue("@url", apptInfo.url);
                cmd.Parameters.AddWithValue("@start", apptInfo.start);
                cmd.Parameters.AddWithValue("@end", apptInfo.end);
                cmd.ExecuteNonQuery();

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown saving customer: " + ex);
                success = false;
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

        public bool checkForOverlappingAppointments(DateTime apptStartTime, DateTime apptEndTime)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);

            bool overlap = false;

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT EXISTS(SELECT * FROM appointment WHERE start <= @end AND end >= @start)";
                cmd.Parameters.AddWithValue("@start", apptStartTime);
                cmd.Parameters.AddWithValue("@end", apptEndTime);

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    overlap = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown checking for overlapping appointments: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return overlap;
        }

        public bool deleteAppointment(int apptId)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                cmd.Parameters.AddWithValue("@appointmentId", apptId);
                cmd.ExecuteNonQuery();

            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when deleting appointment: " + ex);
                return false;
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }
            return true;
        }

        public void logUserActivity(string logText)
        {
            string logPath = @"C:\Users\baygun\logFile.txt";//<---- change directory
            if (!File.Exists(logPath))
            {
                var file = File.Create(logPath);
                file.Close();
                TextWriter textWriter = new StreamWriter(logPath);
                textWriter.WriteLine(logText);
                textWriter.Close();
            }
            else if (File.Exists(logPath))
            {
                using (var textWriter = new StreamWriter(logPath, true))
                {
                    textWriter.WriteLine(logText);
                }
            }
        }

        public List<Appointment> checkUserReminders(int userId)
        {
            List<Appointment> appts = new List<Appointment>();
            DateTime currentUtc = DateTime.UtcNow;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM appointment WHERE userId = @userId and TIMESTAMPDIFF(MINUTE, start, @currentTime) < 15";
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@currentTime", currentUtc);
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appts.Add(new Appointment()
                        {
                            customerId = (int)reader["customerId"],
                            title = reader["appointmentId"].ToString(),
                            description = reader["appointmentId"].ToString(),
                            location = reader["location"].ToString(),
                            contact = reader["contact"].ToString(),
                            type = reader["type"].ToString(),
                            url = reader["url"].ToString(),
                            start = Convert.ToDateTime(reader["start"]),
                            end = Convert.ToDateTime(reader["end"])
                        });
                    }
                }
            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when checking reminders: " + ex);
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return appts;
        }

        public List<Appointment> returnApptTypesByMonth(int userId, int month)
        {
            List<Appointment> appts = new List<Appointment>();
            DateTime currentUtc = DateTime.UtcNow;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT type FROM appointment WHERE userId = @userId and MONTH(start) = @month";
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appts.Add(new Appointment()
                        {
                            type = reader["type"].ToString()
                        });
                    }
                }
            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when returning appt types by month: " + ex);
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return appts;
        }
        public List<int> returnDistinctConsultantsWithAppts()
        {
            List<int> userIds = new List<int>();

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT userId FROM appointment";
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userIds.Add((int)reader["userId"]);
                    }
                }
            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when returning distinct consultants with appts: " + ex);
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return userIds;
        }
        public List<Appointment> returnAllConsultantsSchedule(int userId)
        {
            List<Appointment> appts = new List<Appointment>();
            DateTime currentUtc = DateTime.UtcNow;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT start, end FROM appointment WHERE userId = @userId";
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appts.Add(new Appointment()
                        {
                            userId = (int)reader["userId"],
                            start = Convert.ToDateTime(reader["start"]),
                            end = Convert.ToDateTime(reader["end"])
                        });
                    }
                }
            }
            //catches errors in case the above code fails
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown when returning consultant schedule: " + ex);
            }
            //Close connection regardless of whether the try block executes or not.
            finally
            {
                conn.Close();
            }

            return appts;
        }
    }
}
