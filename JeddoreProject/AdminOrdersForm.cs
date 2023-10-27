using JeddoreLab4;
using System;
using System.Windows.Forms;
//added using for the static Validator class
using static JeddoreProject.Validator;

namespace JeddoreProject
{
    public partial class AdminOrdersForm : Form
    {
        public AdminOrdersForm()
        {
            InitializeComponent();
        }

        private void AdminOrdersForm_Load(object sender, EventArgs e)
        {
            //call setupform ftn
            SetupForm();

            //call refreshform ftn
            RefreshForm();
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
         * This ftn clears the listbox, then displays the appropriate info for it. */
        private void RefreshForm()
        {
            //clear the listbox and combobox
            lstBooks.Items.Clear();

            //foreach loop thru the allProducts list
            //for all products (includes objs from the derived classes)
            foreach (Products item in allProducts)
            {
                //display comic book data to the listbox with displayinfo
                lstBooks.Items.Add(item.DisplayInfo());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void AdminOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
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
            string closingMessage = "Are you sure you want to close the admin orders form?";

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
                //instock amount, etc. should be updated for the next customer/user
                ProductsDB.SaveProducts(allProducts);
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            //if - valid lstbox index is selected
            if (lstBooks.SelectedIndex != -1)
            {
                //declare Products account object and set it to the
                //index of the allProducts list that equals the selectedindex of the lstbox
                //doing this to no longer have to loop thru the entire accounts list
                Products selectedProduct = allProducts[lstBooks.SelectedIndex];

                //calling the -- overloaded operator to apply a quick 10% discount
                //to the product's price
                --selectedProduct;

                //call refreshform ftn
                RefreshForm();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            //if - valid lstbox index is selected
            if (lstBooks.SelectedIndex != -1)
            {
                //declare Products account object and set it to the
                //index of the allProducts list that equals the selectedindex of the lstbox
                //doing this to no longer have to loop thru the entire accounts list
                Products selectedProduct = allProducts[lstBooks.SelectedIndex];

                //remove product from the allProducts list
                allProducts.Remove(selectedProduct);

                //call refreshform ftn
                RefreshForm();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //create a new form based on AddAndEditForm - no parameters sent in
            AddNewBook addbookNewForm = new AddNewBook();

            //show the add and edit form as modal
            addbookNewForm.ShowDialog();

            //call refreshform ftn
            RefreshForm();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            //if - valid lstbox index is selected
            if (lstBooks.SelectedIndex != -1)
            {
                //declare Products account object and set it to the
                //index of the allProducts list that equals the selectedindex of the lstbox
                //doing this to no longer have to loop thru the entire accounts list
                Products selectedProduct = allProducts[lstBooks.SelectedIndex];

                //create a new form based on EditExistingForm (using a custom constructor)
                //sending in these 4 parameters that can be edited to this form
                EditExistingBook editBookNewForm = new EditExistingBook(selectedProduct.Code, selectedProduct.Description,
                    selectedProduct.Price, selectedProduct.InStock);

                //show the add and edit form as modal
                editBookNewForm.ShowDialog();

                //call refreshform ftn
                RefreshForm();
            }
        }

        /* Name: ClearBooks
         * Sent: Nothing
         * Returned: Nothing
         * This ftn clears the listbox (lstbooks) and allProducts list. */
        private void ClearBooks()
        {
            //clear the listbox
            lstBooks.Items.Clear();

            //clear/empty the list itself
            allProducts.Clear();
        }

        private void btnClearBooks_Click(object sender, EventArgs e)
        {
            //call clearbooks ftn
            ClearBooks();
        }

        private void btnReadNewBooks_Click(object sender, EventArgs e)
        {
            //if there are already orders in the allProducts list then
            if (allProducts.Count > 0)
            {
                //display a message and do nothing else
                MessageBox.Show("There are already books in the list. Must clear current list to read in new books.", "Comic Books and Graphic Novels");
            }

            //else
            else
            {
                //try
                try
                {
                    //show the ofd and return cancel or OK
                    DialogResult usersSelection = ofdProductsFile.ShowDialog();

                    //if user selects ok then
                    if (usersSelection == DialogResult.OK)
                    {
                        //call overloaded GetProducts from productsdb, sending in the filename/path from the ofd
                        //store each item/object originally from the .xml file in the allProducts list
                        allProducts = ProductsDB.GetProducts(ofdProductsFile.FileName);

                        //call refreshform ftn
                        RefreshForm();
                    }
                }

                //catch
                catch (Exception)
                {
                    //show general exception message to user
                    MessageBox.Show("Cannot read from file.", "File Error");
                }
            }
        }
    }
}
