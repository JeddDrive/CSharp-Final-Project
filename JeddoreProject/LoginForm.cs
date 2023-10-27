using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JeddoreProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /* Name: Nicholas Jeddore
         * Due Date: April 5, 2023
         * Final Project: This program consists of multiple forms: a login form, customer orders 
         * form, admin orders form, add new book form, and an edit existing book form. This project is 
         * also something like an encapsulation or summary of all of the major concepts and topics 
         * covered over the course of this OOP course. */

        //private class level list of users called theUsers, starts as empty
        //list not accessible from any other forms
        private List<Users> allUsers = new List<Users>();

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            //call resetform ftn
            ResetForm();

            //call the readusers ftn
            //if this ftn returns a false then
            if (!ReadUsers(allUsers))
            {
                //display that there was an error
                MessageBox.Show("Error adding users from file into list of users.",
                    "List Error");
            }
        }

        /* Name: ResetForm
         * Sent: Nothing
         * Returned: Nothing
         * This ftn resets the controls for the login form. */
        private void ResetForm()
        {
            //clear out the textboxes
            txtUserID.Text = "";
            txtPassword.Text = "";

            //focus on top txtbox
            txtUserID.Focus();
        }

        /* Name: ReadUsers
         * Sent: List of Users
         * Returned: Boolean
         * This ftn uses and reads from an input file called JeddoreUsers.txt. There are 4 users
         * that will be placed in the allUsers list, with the help of a while loop. */
        private bool ReadUsers(List<Users> usersList)
        {
            //boolean for if file is good or bad
            bool goodFile = false;

            //want to put code for reading from input file in a try
            try
            {
                //read 4 users from this file
                //can use backslashes with the @ symbol here
                StreamReader usersFile = new StreamReader(@"..\..\JeddoreUsers.txt");

                //while loop (while not at end of stream)
                while (!(usersFile.EndOfStream))
                {
                    //creating a new admin
                    admin theAdmin = new admin(usersFile.ReadLine(), usersFile.ReadLine(),
                        usersFile.ReadLine(), usersFile.ReadLine());

                    //add admin obj to the users list
                    usersList.Add(theAdmin);

                    //creating a new customer #1 (cathy)
                    customer customerOne = new customer(usersFile.ReadLine(), usersFile.ReadLine(),
                         usersFile.ReadLine(), usersFile.ReadLine());

                    //add customer obj to the users list
                    usersList.Add(customerOne);

                    //creating new customer #2 (aaron)
                    customer customerTwo = new customer(usersFile.ReadLine(), usersFile.ReadLine(),
                         usersFile.ReadLine(), usersFile.ReadLine());

                    //add customer obj to the users list
                    usersList.Add(customerTwo);

                    //creating new customer #3 (nicholas)
                    customer customerThree = new customer(usersFile.ReadLine(), usersFile.ReadLine(),
                         usersFile.ReadLine(), usersFile.ReadLine());

                    //add customer obj to the users list
                    usersList.Add(customerThree);

                    //if - at end of .txt file, and also are now 4 users in the usersList then
                    if (usersFile.EndOfStream == true && usersList.Count == 4)
                    {
                        //set goodFile to true
                        goodFile = true;

                        //break from loop
                        break;
                    }

                } //end of while loop

                //close the input file
                usersFile.Close();

            } //end of try

            //catch exceptions
            catch (Exception)
            {
                //display that there was an error accessing the input file
                MessageBox.Show("Error accessing file: Could not find file '..\\..\\JeddoreUsers.txt'.",
                    "Unsuccessful Text File Read");
            }

            //return the boolean for good file
            return goodFile;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //int var for counter
            int counter = 0;

            //if - data present for both userID and password text
            if (Validator.IsPresent(txtUserID) && Validator.IsPresent(txtPassword))
            {
                //foreach loop thru all the users
                foreach (Users u in allUsers)
                {
                    //if the userID and password matches what it is in both textboxes then
                    if (txtUserID.Text == u.Userid && txtPassword.Text == u.Password)
                    {
                        //display msg
                        MessageBox.Show("Welcome to The Comic Store, " + u.Userid + "!", "Login Successful");

                        //if user is of the admin type then
                        if (u.GetType() == typeof(admin))
                        {
                            //create a new form based on AdminOrdersForm
                            AdminOrdersForm adminFormNew = new AdminOrdersForm();

                            //show the admin orders form as modal
                            adminFormNew.ShowDialog();

                            //break from loop
                            break;
                        }

                        //else - user is of the customer type then
                        else
                        {
                            //create a new form based on AdminOrdersForm
                            CustomerOrdersForm customerFormNew = new CustomerOrdersForm();

                            //show the admin orders form as modal
                            customerFormNew.ShowDialog();

                            //break from loop
                            break;
                        }
                    }

                    if (counter == allUsers.Count - 1)
                    {
                        //display msg
                        MessageBox.Show("Username and password is not a match.", "Login Unsuccessful");

                        //focus on password txtbox
                        txtPassword.Focus();
                    }

                    //add 1 to counter
                    counter++;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
