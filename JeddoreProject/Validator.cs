using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JeddoreProject
{
    //public static class for data validation
    public static class Validator
    {
        //public class level list of products called allProducts
        //list will be accessed from multiple other forms
        public static List<Products> allProducts = new List<Products>();

        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /* Name: IsPresent
         * Sent: Boolean
         * Returned: One Textbox
         * This ftn checks if there is text inside a textbox sent in, and returns a true
         * or a false depending on if there is.*/
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                //uses the textbox tag property here in the msgbox
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }


        /* Name: IsDecimal
         * Sent: Boolean
         * Returned: One Textbox
         * This ftn checks if there is a valid decimal value inside a textbox sent in, and returns a true
         * or a false depending on if there is.*/
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                //uses the textbox tag property here in the msgbox
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        /* Name: IsInt32
         * Sent: Boolean
         * Returned: One Textbox
         * This ftn checks if there is a valid int32 value inside a textbox sent in, and returns a true
         * or a false depending on if there is.*/
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                //uses the textbox tag property here in the msgbox
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        /* Name: IsWithinRange
         * Sent: Boolean
         * Returned: One Textbox, two decimals
         * This ftn checks if there is a valid decimal value inside a textbox sent in and that it is 
         * between a certain range, and returns a true or a false depending on if it is. */
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                //uses the textbox tag property here in the msgbox
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
