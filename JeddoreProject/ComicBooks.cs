using System;

namespace JeddoreProject
{
    //derived class from Products
    //Comic Books - are usually single issue (shorter than graphic novels), and associated with an issue number
    public sealed class ComicBooks : Products
    {
        //need private int field for pages
        private int pages;

        //need private int field for issues
        private int issueNumber;

        //auto implemented property (Name) 
        public string Name { get; set; }

        //Pages property - not auto implemented
        public int Pages
        {
            get
            {
                return pages;
            }

            //set with validation
            set
            {
                //call the checkpages ftn here, sending in the value (pass by ref)
                CheckPages(ref value);

                //set the field here (not the property)
                pages = value;
            }
        }

        //IssueNumber property - not auto implemented
        public int IssueNumber
        {
            get
            {
                return issueNumber;
            }

            //set with validation
            set
            {
                //call the checkissuenumber ftn here, sending in the value (pass by ref)
                CheckIssueNumber(ref value);

                //set the field here (not the property)
                issueNumber = value;
            }
        }

        //default constructor - does nothing, base default constructor is called automatically
        public ComicBooks() { }

        //custom constructor - everything sent in, calling the base custom constructor here too
        public ComicBooks(string inCode, string inDescription, decimal inPrice, int inInStock,
            string inName, int inPages, int inIssueNumber) : base(inCode, inDescription, inPrice, inInStock)
        {
            //set the fields sent into custom constructor
            Code = inCode;
            Description = inDescription;
            Price = inPrice;
            InStock = inInStock;
            Name = inName;
            Pages = inPages;
            IssueNumber = inIssueNumber;
        }

        /* Name: DisplayInfo
         * Sent: Nothing 
         * Returned: One string (with lambda)
         * This ftn returns a string of info about a comic book using lambda, which is 
         * formatted to be displayed in control such as a listbox. Overriding the DisplayInfo
         * ftn in the Products class. */
        public override string DisplayInfo() =>
                   String.Format("{0, -3}{1, -3}{2, -34}{3, -3}{4, -13}{5, -3}{6, -6}" +
                       "{7, -3}{8, -3}{9, -3}{10, -4}{11, -3}{12, -4}",
             Code, "", Name, "", Description, "", Price.ToString("c2"), "", InStock.ToString(),
             "", Pages.ToString(), "", IssueNumber);

        /* Name: DisplayCartItems
         * Sent: Nothing 
         * Returned: One string (with lambda)
         * This ftn returns a string of info about a comic book using lambda, which is 
         * formatted to be displayed in the combobox for cart items. Overriding the 
         * DisplayCartItems ftn in the Products class. */
        public override string DisplayCartItems() =>
            String.Format("{0, -34}{1, -2}{2, -5}",
                Name, " ", Price.ToString("c2"));

        /* Name: CheckPages
         * Sent: One int (pass by ref)
         * Returned: Nothing
         * This ftn checks the pages sent in (int), will verify that the pages amount sent in 
         * is 8 or greater. If not, set it to 8. */
        private void CheckPages(ref int pagesSent)
        {
            //if pages sent in is less than 8
            if (pagesSent < 8)
            {
                //set the pages amount to 8 then
                pagesSent = 8;
            }
        }

        /* Name: CheckIssueNumber
         * Sent: One int (pass by ref)
         * Returned: Nothing
         * This ftn checks the issue number sent in (int), will verify that the issue number sent in 
         * is 1 or greater. If not, set it to 1. */
        private void CheckIssueNumber(ref int issueNumSent)
        {
            //if the issue number sent in is less than 1
            if (issueNumSent < 1)
            {
                //set the issue number to 1 then
                issueNumSent = 1;
            }
        }
    }
}
