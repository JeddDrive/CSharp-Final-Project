using JeddoreLab4;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
//added using for the static Validator class
using static JeddoreProject.Validator;

namespace JeddoreProject
{
    public partial class CustomerOrdersForm : Form
    {
        public CustomerOrdersForm()
        {
            InitializeComponent();
        }

        //private class level list for items added to customer's cart
        private List<Products> cartProducts = new List<Products>();

        private void CustomerOrdersForm_Load(object sender, EventArgs e)
        {
            //call setupform ftn
            SetupForm();

            //call refreshform ftn
            RefreshForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void CustomerOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //call closingtheform ftn
            ClosingTheForm(e);
        }


        /* Name: ClosingTheForm
         * Sent: Nothing
         * Returned: Nothing
         * This ftn handles what is done depending on whether the user selects yes or no 
         * after clicking on the exit button. */
        private void ClosingTheForm(FormClosingEventArgs e)
        {
            //string for closing message to user
            string closingMessage = "Are you sure you want to close the customer orders form?";

            //string for msgbox title
            string messageTitle = "Close Form";

            //show messagebox to user
            //msgbox - yes and no buttons only, and a question mark picture added to it too
            DialogResult btnValueReturned = MessageBox.Show(closingMessage, messageTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if - user selects the no btn
            if (btnValueReturned == DialogResult.No)
            {
                //then cancel the form close
                e.Cancel = true;
            }

            //else - user selects the yes btn
            else
            {
                //save the list of all products to the xml file with this method
                //instock amountt, etc. should be updated for the next customer/user
                ProductsDB.SaveProducts(allProducts);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //if at least one item in cart list then
            if (cartProducts.Count > 0)
            {
                //string for msgbox title
                string messageTitle = "";

                //string for closing message to user
                string closingMessage = "Are you sure you want to order these " + cartProducts.Count +
                    " items for " + lblOrderTotal.Text + "?";

                //if one item in cart list exactly then
                if (cartProducts.Count == 1)
                {
                    //title should reflect for only 1 singular item in cart
                    messageTitle = "Order Item";
                }

                //else - multiple items in cart list
                else
                {
                    //title should reflect for multiple items in cart
                    messageTitle = "Order Items";
                }

                //show messagebox to user
                //msgbox - yes and no buttons only, and a question mark picture added to it too
                DialogResult btnValueReturned = MessageBox.Show(closingMessage, messageTitle,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //if - user selects the yes btn
                if (btnValueReturned == DialogResult.Yes)
                {
                    //remove all items from the cartProducts list
                    cartProducts.Clear();

                    //call refreshform function
                    RefreshForm();
                }
            }

            //else - zero items in cart list
            else
            {
                MessageBox.Show("Your cart must contain at least one item for an order.", "No Cart Items");
            }
        }

        /* Name: SetupForm
         * Sent: Nothing
         * Returned: Nothing
         * This ftn fills the allProducts list with data from the .xml file with the help of 
         * the GetProducts() method in ProductsDB. */
        private void SetupForm()
        {
            //all products from the JeddoreProducts.xml file
            //will be added to this list
            allProducts = ProductsDB.GetProducts();
        }

        /* Name: RefreshForm
         * Sent: Nothing
         * Returned: Nothing
         * This ftn clears the listbox and combobox, then displays the appropriate 
         * info for both of them. It also displays and updates the order grand total amount. */
        private void RefreshForm()
        {
            //decimal for order total amount
            decimal orderTotal = 0m;

            //clear the listbox and combobox
            lstBooks.Items.Clear();
            cboCartBooks.Items.Clear();

            //foreach loop thru the allProducts list
            //for all products (includes objs from the derived classes)
            foreach (Products item in allProducts)
            {
                //display comic book data to the listbox with displayinfo
                lstBooks.Items.Add(item.DisplayInfo());
            }

            //foreach loop thru the cartProducts list
            foreach (Products item in cartProducts)
            {
                //display comic book data to the cbobox with DisplayCartItems
                cboCartBooks.Items.Add(item.DisplayCartItems());

                //add each item amount to the order grand total
                orderTotal += item.Price;
            }

            //display prices added up to the order total label, formatted as currency
            lblOrderTotal.Text = orderTotal.ToString("c2");
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            //if - valid lstbox index is selected
            if (cboCartBooks.SelectedIndex != -1)
            {
                Products selectedProduct = cartProducts[cboCartBooks.SelectedIndex];

                //remove the selected product from the cartProducts list at the cbo selected index
                cartProducts.RemoveAt(cboCartBooks.SelectedIndex);

                //Add 1 back to the in stock
                selectedProduct.InStock++;

                //call refreshform ftn
                RefreshForm();
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            //if - valid lstbox index is selected
            if (lstBooks.SelectedIndex != -1)
            {
                //declare Products account object and set it to the
                //index of the allProducts list that equals the selectedindex of the lstbox
                //doing this to no longer have to loop thru the entire accounts list
                Products selectedProduct = allProducts[lstBooks.SelectedIndex];

                //if the selectedProduct has at least 1 in stock
                if (selectedProduct.InStock >= 1)
                {
                    //add the selected product to the cartProducts list
                    cartProducts.Add(selectedProduct);

                    //remove 1 from the in stock
                    selectedProduct.InStock--;

                    //call refreshform ftn
                    RefreshForm();
                }

                //else - selectedProduct has zero in stock
                else
                {
                    MessageBox.Show("Sorry, that comic book is currently out of stock!", "Out of Stock");
                }
            }
        }

        /* Name: CompareProductPrices
         * Sent: Two Products
         * Returned: Nothing
         * This ftn compares the prices of two products, and displays a message as to whether the
         * one being compared to is a lower price, higher price, or the same price. */
        private void CompareProductPrices(Products productOne, Products productTwo)
        {
            //declare an int var, to store the int that is returned from CompareTo()
            int result = productOne.CompareTo(productTwo);

            //if a -1 was returned
            if (result == -1)
            {
                //display msg that productOne is cheaper
                MessageBox.Show("Product One Code: " + productOne.Code + " (" + productOne.Price.ToString("c2") + ")" +
                    " is cheaper than Product Two Code: " + productTwo.Code + " (" +
                    productTwo.Price.ToString("c2") + ")", "Price Comparison Successful");
            }

            //else if a 1 was returned
            else if (result == 1)
            {
                MessageBox.Show("Product One Code: " + productOne.Code + " (" + productOne.Price.ToString("c2") + ")" +
                " is more expensive than Product Two Code: " + productTwo.Code + " (" +
                productTwo.Price.ToString("c2") + ")", "Price Comparison Successful");
            }

            //else - a 0 was returned
            else
            {
                MessageBox.Show("Product One Code: " + productOne.Code + " (" + productOne.Price.ToString("c2") + ")" +
                " is the same price as Product Two Code: " + productTwo.Code + " (" +
                productTwo.Price.ToString("c2") + ")", "Price Comparison Successful");
            }
        }

        //must add "async" keyword after the private access modifier
        private async void btnCompare_Click(object sender, EventArgs e)
        {
            //set the listbox selectionmode property to multisimple
            //this allows for multiple selections
            lstBooks.SelectionMode = SelectionMode.MultiSimple;

            //display msg to user
            MessageBox.Show("Select two books and their prices will be compared. " +
                "\nYou have 5 seconds to select two.", "Selection Instructions");

            //give the user 5 seconds to select 2 books from the lstbox
            await Task.Delay(5000);

            //if - two indices selected from the lstbox
            if (lstBooks.SelectedIndices.Count == 2)
            {
                //declare these 2 product objects down here in this block of code, not above the if
                //set Products pOne to the first selected index
                Products pOne = allProducts[lstBooks.SelectedIndices[0]];

                //set Products pTwo to the second selected index
                Products pTwo = allProducts[lstBooks.SelectedIndices[1]];

                //call CompareProductPrices, sending in the two products
                CompareProductPrices(pOne, pTwo);

            }

            //reset the lstbox SelectionMode property back to One (for a singular selection)
            lstBooks.SelectionMode = SelectionMode.One;
        }

    }
}
