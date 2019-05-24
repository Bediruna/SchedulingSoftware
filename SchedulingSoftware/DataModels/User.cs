namespace SchedulingSoftware.DataModels
{
    public class User
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
        
        public User()
        {
            username = string.Empty;
        }

        public User(string _username, string _password)
        {
            username = _username;
            password = _password;
            active = true;
        }
    }
}
