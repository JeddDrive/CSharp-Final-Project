using System;

namespace JeddoreProject
{
    //derived class from Products
    //graphic novels - are usually like compilation/collection of multiple comic book issues in a row
    //usually a complete story or series with a clear beginning, middle, and end
    public sealed class GraphicNovels : Products
    {
        //need private int field for pages
        private int pages;

        //need private int field for issues
        private int issues;

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

        //Issues property - not auto implemented
        public int Issues
        {
            get
            {
                return issues;
            }

            //set with validation
            set
            {
                //call the checkissues ftn here, sending in the value (pass by ref)
                CheckIssues(ref value);

                //set the field here (not the property)
                issues = value;
            }
        }

        //default constructor - does nothing, base default constructor is called automatically
        public GraphicNovels() { }

        //custom constructor - everything sent in, calling the base custom constructor here too
        public GraphicNovels(string inCode, string inDescription, decimal inPrice, int inInStock,
            string inName, int inPages, int inIssues) : base(inCode, inDescription, inPrice, inInStock)
        {
            //set the fields sent into custom constructor
            Code = inCode;
            Description = inDescription;
            Price = inPrice;
            InStock = inInStock;
            Name = inName;
            Pages = inPages;
            Issues = inIssues;
        }

        /* Name: DisplayInfo
         * Sent: Nothing 
         * Returned: One string (with lambda)
         * This ftn returns a string of info about a graphic novel using lambda, which is 
         * formatted to be displayed in control such as a listbox. Overriding the DisplayInfo
         * ftn in the Products class. */
        public override string DisplayInfo() =>
                   String.Format("{0, -3}{1, -3}{2, -32}{3, -3}{4, -15}{5, -3}{6, -5}" +
                       "{7, -3}{8, -3}{9, -3}{10, -4}{11, -3}{12, -3}",
             Code, "", Name, "", Description, "", Price.ToString("c2"), "", InStock.ToString(),
             "", Pages.ToString(), "", Issues);

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
         * is 36 or greater. If not, set it to 36. */
        private void CheckPages(ref int pagesSent)
        {
            //if pages sent in is less than 36
            if (pagesSent < 36)
            {
                //set the pages amount to 36 then
                pagesSent = 36;
            }
        }

        /* Name: CheckIssues
         * Sent: One int (pass by ref)
         * Returned: Nothing
         * This ftn checks the number of issues sent in (int), will verify that the number of issues sent in 
         * is 2 or greater. If not, set it to 2. */
        private void CheckIssues(ref int issuesSent)
        {
            //if the number of issues sent in is less than 2
            if (issuesSent < 2)
            {
                //set the number of issues to 2 then
                issuesSent = 2;
            }
        }
    }
}
