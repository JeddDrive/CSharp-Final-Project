using System;

namespace JeddoreProject
{
    public abstract class Products : IComparable
    {
        //private field for Price
        private decimal price;

        //private field for InStock
        private int inStock;

        //two auto implemented properties
        public string Code { get; set; }
        public string Description { get; set; }

        //Price property - not auto implemented
        public decimal Price
        {
            get
            {
                return price;
            }

            //set with validation
            set
            {
                //call the checkprice ftn here, sending in the value (pass by ref)
                CheckPrice(ref value);

                //set the field here (not the property)
                price = value;
            }
        }

        //InStock property - Not auto implemented
        public int InStock
        {
            get
            {
                return inStock;
            }

            //set with validation
            set
            {
                //call the checkinstock ftn here, sending in the value (pass by ref)
                CheckInStock(ref value);

                //set the field here (not the property)
                inStock = value;
            }
        }

        //default constructor - does nothing
        public Products() { }

        //custom constructor - everything sent in
        public Products(string inCode, string inDescription, decimal inPrice, int inInStock)
        {
            //set the fields sent into custom constructor
            Code = inCode;
            Description = inDescription;
            Price = inPrice;
            InStock = inInStock;
        }

        /* Name: DisplayInfo
         * Sent: Nothing 
         * Returned: One String (with lambda)
         * This ftn returns a string of info about a product using lambda, which is 
         * formatted to be displayed in control such as a listbox. */
        public virtual string DisplayInfo() =>
                   String.Format("{0, -3}{1, -3}{2, -12}{3, -3}{4, -5}{5, -3}{6, -3}",
             Code, "", Description, "", Price.ToString("c2"), "", InStock.ToString());

        /* Name: DisplayCartItems
         * Sent: Nothing 
         * Returned: One string (with lambda)
         * This ftn returns a string of info about a product using lambda, which is 
         * formatted to be displayed in the combobox for cart items. */
        public virtual string DisplayCartItems() =>
            String.Format("{0, -3}{1, -2}{1, -5}",
                Code, " ", Price.ToString("c2"));

        /* Name: CheckPrice
         * Sent: One decimal (pass by ref)
         * Returned: Nothing
         * This ftn checks the price sent in (decimal), will verify that this price sent in 
         * is greater than 0. If not, set it to 4.99. */
        private void CheckPrice(ref decimal priceSent)
        {
            //if amount sent in, is less than or equal to 0 
            if (priceSent <= 0.0m)
            {
                //set the amount to 0 then
                priceSent = 4.99m;
            }
        }

        /* Name: CheckInStock
         * Sent: One int (pass by ref)
         * Returned: Nothing
         * This ftn checks the price sent in (int), will verify that the amount in stock sent in 
         * is greater than -1. If not, set it to 0. */
        private void CheckInStock(ref int stockSent)
        {
            //if stock sent in is less than 0
            if (stockSent < 0)
            {
                //set the stock amount to 0 then
                stockSent = 0;
            }
        }

        /* Name: CompareTo
         * Sent: One product
         * Returned: One int
         * This ftn returns an integer. This method was declared in the 
         * IComparable<Products> interface, but the code for this method 
           is implemented in a class such as this one. */
        public int CompareTo(Products product)
        {
            //int to be returned
            int returnedNum;

            //if product 1 price is less than product 2 price
            //comparing the product obj's sent in price with the one calling CompareTo()
            if (this.Price < product.Price)
            {
                returnedNum = -1;
            }

            //if product 1 price is higher than product 2 price
            else if (this.Price > product.Price)
            {
                returnedNum = 1;
            }

            //else - 2 products have the exact same price
            else
            {
                returnedNum = 0;
            }

            //return the int
            return returnedNum;
        }

        //overload the -- operator
        public static Products operator --(Products product)
        {
            //variable for discount amount (10%)
            const decimal DISCOUNTAMOUNT = 0.10m;

            //subtract 10% from the product's price
            product.price -= (product.price * DISCOUNTAMOUNT);

            return product;
        }
    }
}
