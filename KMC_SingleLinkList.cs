/* ********************************************************************
 * Projct:      Customer Single Link List
 * File:        Single Link List class
 * Language:    C#
 * 
 * Desription:  This class will hold an unordered single link list.
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 09/23/2022 - initial writing
 * *******************************************************************/
using System;

namespace CustomerSingleLinkList
{
    internal class KMC_SingleLinkList
    {

        #region data
        #endregion data

        #region properties
        public KMC_Node Top { get; set; }    // pointer top of link list
        #endregion properties

        #region constructor
        public KMC_SingleLinkList()
        {
            Top = null;
        }
        #endregion constructor

        #region methods
        /// <summary>
        /// This function adds a customer at the beginning of
        /// the link list.
        /// </summary>
        /// <param name="lastname">Customer name</param>
        public void AddAtBeginning(String lastname)
        {
            // create a new node for the customer
            KMC_Node customer = new KMC_Node(lastname);

            // add the cutomer to the front of the list
            customer.Next = Top;
            Top = customer;
        }

        /// <summary>
        /// This function add a customer at the end of the 
        /// link list
        /// </summary>
        /// <param name="lastname">Customer name</param>
        public void AddAtEnd(String lastname)
        {
            // create a new node for the customer
            KMC_Node customer = new KMC_Node(lastname);

            // special case - empty list
            if (Top is null)
            {
                Top = customer;
            }
            else
            {
                // non-empty list, wlak down to find the end
                KMC_Node current = Top;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // found the end, insert here
                current.Next = customer;
            }
        }

        /// <summary>
        /// This routine will add the Cusomter at the desired position.
        /// If the position is greater than the length of the 
        /// link list, the customer will be added at the end.
        /// </summary>
        /// <param name="lastname"></param>
        /// <param name="position"></param>
        public void AddAtPosition(String lastname, int position)
        {
            KMC_Node current, previous;
            int count;

            // create the customer
            KMC_Node customer = new KMC_Node(lastname);

            // special case - empty list
            if (Top is null)
            {
                Top = customer;
            }
            else
            {
                // have current and previous chase down the link list
                current = Top.Next;
                previous = Top;
                count = 1;

                // walk down the list
                while (current != null && count < position)
                {
                    previous = current;
                    current = current.Next;
                    count++;
                }

                // why did we stop
                if (current is null)
                {
                    current = customer;
                }
                else
                {
                    customer.Next = current;
                    previous.Next = customer;
                }

            }
        }
        #endregion methods

    }
}
