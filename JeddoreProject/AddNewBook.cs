using System;
using System.Windows.Forms;
//added using for the static Validator class
//have to validate multiple textboxes for this form
using static JeddoreProject.Validator;

namespace JeddoreProject
{
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
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
            string closingMessage = "Are you sure you want to close the add new book form?";

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

        private void AddAndEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //call closingtheform ftn
            ClosingTheForm(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            try
            {
                //if - comic book was chosen in the cbo, and all of th textboxes are valid
                //using the Validator class helper ftns
                if (cboDescription.SelectedIndex == 0 && IsPresent(txtCode) && IsPresent(txtName)
                    && IsPresent(txtPrice) && IsPresent(txtInStock) && IsPresent(txtPages) &&
                    IsPresent(txtIssues) && IsDecimal(txtPrice) && IsInt32(txtPages) &&
                    IsInt32(txtInStock) && IsInt32(txtIssues))
                {
                    //create a new comicBookObj with the custom constructor
                    ComicBooks comicBookObj = new ComicBooks(txtCode.Text, cboDescription.Text,
                        decimal.Parse(txtPrice.Text), int.Parse(txtInStock.Text), txtName.Text,
                        int.Parse(txtPages.Text), int.Parse(txtIssues.Text));

                    //add this object to the allProducts list
                    allProducts.Add(comicBookObj);

                    //display message, reset the form controls, and focus on the top txtbox (code)
                    MessageBox.Show("New comic book has been added.", "Successful Addition");
                    txtCode.Text = "";
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtInStock.Text = "";
                    txtPages.Text = "";
                    txtIssues.Text = "";
                    txtCode.Focus();
                }

                //else if - graphic novel was chosen in the cbo
                else if (cboDescription.SelectedIndex == 1 && IsPresent(txtCode) && IsPresent(txtName)
                    && IsPresent(txtPrice) && IsPresent(txtInStock) && IsPresent(txtPages) &&
                    IsPresent(txtIssues) && IsDecimal(txtPrice) && IsInt32(txtPages) &&
                    IsInt32(txtInStock) && IsInt32(txtIssues))
                {
                    //create a new graphicNovelObj with the custom constructor
                    GraphicNovels graphicNovelObj = new GraphicNovels(txtCode.Text, cboDescription.Text,
                        decimal.Parse(txtPrice.Text), int.Parse(txtInStock.Text), txtName.Text,
                        int.Parse(txtPages.Text), int.Parse(txtIssues.Text));

                    //add this object to the allProducts list
                    allProducts.Add(graphicNovelObj);

                    //display message, reset the form controls, and focus on the top txtbox (code)
                    MessageBox.Show("New graphic novel has been added.", "Successful Addition");
                    txtCode.Text = "";
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtInStock.Text = "";
                    txtPages.Text = "";
                    txtIssues.Text = "";
                    txtCode.Focus();
                }
            }

            //catch
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddAndEditForm_Load(object sender, EventArgs e)
        {
            //suggestion - for the code for the next book to be the number of
            //books already in the allProducts list + 1 
            txtCode.Text = (allProducts.Count + 1).ToString();

            //select the first index of the cbo (for Comic Book)
            cboDescription.SelectedIndex = 0;

            //select second to top textbox (name)
            txtName.Select();
        }
    }
}
