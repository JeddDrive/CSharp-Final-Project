namespace JeddoreProject
{
    //public sealed derived class from Users
    public sealed class customer : Users
    {
        //default constructor - auto calls the base default constructor
        public customer() { }

        //custom constructor - calls the base default constructor
        public customer(string inUserid, string inPassword, string inName, string inAccess) :
            base(inUserid, inPassword, inName, inAccess)
        { }

    }
}
