namespace JeddoreProject
{
    //public sealed derived class from Users
    public sealed class admin : Users
    {
        //default constructor - auto calls the base default constructor
        public admin() { }

        //custom constructor - calls the base default constructor
        public admin(string inUserid, string inPassword, string inName, string inAccess) :
            base(inUserid, inPassword, inName, inAccess)
        { }
    }
}
