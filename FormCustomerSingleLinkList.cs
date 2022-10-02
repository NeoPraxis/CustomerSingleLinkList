﻿/* ********************************************************************
 * Projct:      Customer Single Link List
 * File:        Customer Single Link List
 * Language:    C#
 * 
 * Desription:  This program will track a list of customers using a 
 *              single link list.
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 09/21/2022 - initial writing
 * 0.2   KMC 09/26/2022 - added UI
 *                      - code Add Begin button
 * *******************************************************************/
using System;
using System.Windows.Forms;

namespace CustomerSingleLinkList
{
    public partial class FormCustomerSingleLinkList : Form
    {

        #region data
        KMC_SingleLinkList CustomerList = new KMC_SingleLinkList();
        # endregion data

        #region properties
        #endregion properties

        #region constrcutor
        public FormCustomerSingleLinkList()
        {
            InitializeComponent();
        }
        #endregion constructor

        #region events
        /// <summary>
        /// This routine will read the Customer name from the form 
        /// and add it to the link list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBegin_Click(object sender, EventArgs e)
        {
            // get the customer from the the textbox
            String customerName = textBoxCustomer.Text.Trim();

            // add the customer to the link list
            CustomerList.AddAtBeginning(customerName);

            // display the customer list
            DisplayCustomerList(listBoxCustomerList);
        }
        #endregion events

        #region methods
        /// <summary>
        /// Display the Customer List in the desired ListBox
        /// </summary>
        /// <param name="thisListBox"></param>
        public void DisplayCustomerList(ListBox thisListBox)
        {
            // clear the list box
            thisListBox.Items.Clear();

            // iterate through the link list
            // displaying each item in the listbox
            // this is the wrong way to do this!!!
            KMC_Node current = CustomerList.Top;
            // while there is more data
            while (current != null)
            {
                // display the customer name
                thisListBox.Items.Add(current.LastName);
                // move to the next customer
                current = current.Next;
            }

        }
        #endregion methods

    }
}
