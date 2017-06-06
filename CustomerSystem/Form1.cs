using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Spencer Henze
//ITM 225
//Homework #9

namespace CustomerSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //accepts PrefferedCustomer object as an argument and assigns the entered values to its properties.
        private void GetCustomerInfo(PrefferredCustomer customer)
        {
            //temporary variable for values that will need to be parsed
            double totalPurchases;

            //Test to see if the entry can be parsed into a double. If it can, assign that value to the temporary variable and continue with the code inside
            if (double.TryParse(totalPurchasesTextBox.Text, out totalPurchases))
            {

                //get the customer's Name, address, and phone
                customer.PersonName = nameTextBox.Text;
                customer.PersonAddress = addressTextBox.Text;
                customer.PersonPhone = phoneTextBox.Text;

                //get the customer's customer number and mailing list info
                customer.CustNumber = custNoTextBox.Text;
                customer.MailingList = yesRadioButton.Checked;

                //get the customer's total expenditure
                customer.TotalPurchases = totalPurchases;
                //use the method in the PrefferedCustomer class to test the TotalPurchases property of the object to see what discount level they qualify for, then assign that value to the DiscountLevel Property.
                customer.DiscountLevel = customer.GetDiscountLevel(totalPurchases);
            }
            else //If the parse fails, then tell the user that the entry for total purchases needs to be fixed.
            {
                MessageBox.Show("Invalid entry for total purchases");
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {  
            //Make a new object from the PrefferedCustomer class
            PrefferredCustomer myPrefCustomer = new PrefferredCustomer();
            GetCustomerInfo(myPrefCustomer);

            if (myPrefCustomer.DiscountLevel != -1) //Make sure that the DiscountLevel property was able to be set before continuing to display the info. If it was set successfully, the value will not equal the default value of -1 that was assigned in the class's constructor
            {
                //Show the object's properties
                MessageBox.Show("New Preffered Customer added: \n\n   Name: " + myPrefCustomer.PersonName + "\n   Address: " + myPrefCustomer.PersonAddress + "\n   Phone: " + myPrefCustomer.PersonPhone + "\n\n   Customer Number: " + myPrefCustomer.CustNumber + "\n   Mailing List: " + myPrefCustomer.MailingList + "\n\n   Total Purchases: " + myPrefCustomer.TotalPurchases.ToString("c") + "\n   Discount Level: " + myPrefCustomer.DiscountLevel.ToString("P0"), "Success!");
                ClearFields();// to get ready for the next entry
                nameTextBox.Focus(); //Set the focus back to the Name box to facilitate next entry.
            }
            else //if DiscountLevel is -1 still, then it was not successfully set and the total purchases field should be cleared
            {
               totalPurchasesTextBox.Text = "";
            }

        }// end addCustomerButton_Click

        public void ClearFields()
        {
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            phoneTextBox.Text = "";
            custNoTextBox.Text = "";
            yesRadioButton.Checked = false;
            totalPurchasesTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
