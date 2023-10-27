using System;
using System.Windows.Forms;
//added using for the static Validator class
//have to validate multiple textboxes for this form
using static JeddoreProject.Validator;

namespace JeddoreProject
{
    public partial class EditExistingBook : Form
    {
        public EditExistingBook()
        {
            InitializeComponent();
        }

        //overloaded/custom constructor for this form
        //getting the code, description, price, and instock amt sent in from the admin order form
        //when a new form is instantiated
        public EditExistingBook(string inCode, string inDescription, decimal inPrice, int inInStock)
        {
            InitializeComponent();

            //put these sent in Product properties into these controls
            lblCode.Text = inCode;
            lblDescription.Text = inDescription;
            txtPrice.Text = inPrice.ToString();
            txtInStock.Text = inInStock.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        /* Name: ClosingTheForm
        * Sent: Nothing
        * Returned: Nothing
        * This ftn handles what is done depending on whether the user selects yes or no 
        * after clicking on the exit button. */
        private void ClosingTheForm(FormClosingEventArgs e)
        {
            //string for closing message to user
            string closingMessage = "Are you sure you want to close the edit existing book form?";

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
        }

        private void EditExistingBook_Load(object sender, EventArgs e)
        {
            //focus on price txtbox
            txtPrice.Focus();
        }

        private void EditExistingBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            //call closingtheform ftn
            ClosingTheForm(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            try
            {
                //if - thre is a price and in stock present in those textboxes,
                //and if they are the correct datatype then
                if (IsPresent(txtPrice) && IsPresent(txtInStock) &&
                    IsDecimal(txtPrice) && IsInt32(txtInStock))
                {
                    //foreach loop thru the allProducts list
                    foreach (Products item in allProducts)
                    {
                        //if the item code and description matches what is in
                        //these two textboxes then
                        if (item.Code == lblCode.Text && item.Description
                            == lblDescription.Text)
                        {
                            //parse the price and instock txtboxes
                            //set the new item price and instock amt to the txtbox values
                            item.Price = decimal.Parse(txtPrice.Text);
                            item.InStock = int.Parse(txtInStock.Text);
                        }
                    }

                    //display msg
                    MessageBox.Show("Existing Book has been updated.", "Successful Edit");
                }
            }

            //catch
            catch (Exception ex)
            {
                //display msg
                MessageBox.Show(ex.Message);
            }
        }
    }
}
