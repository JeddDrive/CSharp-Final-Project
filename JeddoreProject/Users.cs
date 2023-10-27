namespace JeddoreProject
{
    //public abstract class - can inherit, but can't instantiate
    public abstract class Users
    {
        //auto-implemented properties
        public string Userid { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Access { get; set; }

        //default constructor - does nothing
        public Users() { }

        //custom constructor - everything sent in
        public Users(string inUserid, string inPassword, string inName, string inAccess)
        {
            //set the fields sent into custom constructor
            Userid = inUserid;
            Password = inPassword;
            Name = inName;
            Access = inAccess;
        }
    }
}
