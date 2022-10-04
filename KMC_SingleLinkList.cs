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
 * 0.2   KMC 09/29/2022 - added delete first
 *                      - added delete last
 *                      - added logic for delete by name
 * 0.3   KMC 10/03/2022 - finished logic for delete by name (spent around 4 hours on this
 *                      - only to figure out there was a deleteNode builtin...
 *                      - polished up logic for delete by name
 * 0.4   KMC 10/04/2022 - added DeleteNode method
 *                      - PROF QUESTION - When the pointer to your deleted node is out of scope, when does garbage collection delete it from memory?
 *                      - when the program ends? or as soon as the pointer goes out of scope?
 *                      - re-used DeleteNode method in delete first / delete last because of D.R.Y. Principle
 * 
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
        
        public int count;                    // will count nodes
        #endregion properties

        #region constructor
        public KMC_SingleLinkList()
        {
            Top = null;
            count = 0;
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
            count++;
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
                // non-empty list, walk down to find the end
                KMC_Node current = Top;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // found the end, insert here
                current.Next = customer;
            }
            count++;
        }

        /// <summary>
        /// This routine will add the Cusomter at the desired position.
        /// If the position is greater than the length of the 
        /// link list, the customer will be added at the end.
        /// </summary>
        /// <param name="lastname"></param>
        /// <param name="position"></param>
        
        // we did not finish this in class *********************************************
        public void AddAtPosition(String lastname, int position)
        {
            KMC_Node current, previous;
            //int count;

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

        /// <summary>
        /// This will delete the first node in the list no matter the value
        /// </summary>
        public void DeleteFirst()
        {
            // to prevent an error, do nothing on an empty list
            if (Top == null)
            {
                return;
            }
            // uses the delete method to delete the top-most node, and check for next
            DeleteNode(Top, null);
            count--;
        }
        /// <summary>
        /// This will delete the last node with any value in the link list
        /// </summary>
        public void DeleteLast()
        {
            // to prevent an error, do nothing on an empty list
            if (Top == null)
            {
                return;
            }

            KMC_Node nodeToDelete = Top, previous = null;

            while (nodeToDelete.Next != null)
            {
                previous = nodeToDelete;
                nodeToDelete = nodeToDelete.Next;
            }
            DeleteNode(nodeToDelete, previous);
            count--;
        }
        /// <summary>
        /// This will delete a customer by the name given by user
        /// </summary>
        /// <param name="lastname"></param>
        public void DeleteByName(String lastname)
        {
            if (Top == null)
            {
                return;
            }

            // set variables to null to mutate later
            KMC_Node nodeToDelete = Top, previous = null;

            // while there is a Next node, keep going
            while (nodeToDelete != null)
            {
                // break on match
                if (nodeToDelete.LastName == lastname)
                {
                    DeleteNode(nodeToDelete, previous);
                    count--;
                    break;
                }
                previous = nodeToDelete;
                nodeToDelete = nodeToDelete.Next;
            }
        }

        #endregion methods
        #region private methods
        /// <summary>
        /// This method will be used by other public methods to delete a node in the link list
        /// </summary>
        /// <param name="nodeToDelete"></param>
        private void DeleteNode(KMC_Node nodeToDelete, KMC_Node previous)
        {
            // if nodeToDelete is first node
            if (nodeToDelete == Top)
            {
                // set top to null (removing the first node)
                Top = null;

                // set next node to top, IF node exists
                if (nodeToDelete.Next != null)
                {
                    Top = nodeToDelete.Next;
                }
            }
            // if nodeToDelete is NOT first node, then previous exists
            else
            {
                // deletes current node
                previous.Next = null;

                // set next, IF node exists
                if (nodeToDelete.Next != null)
                {
                    previous.Next = nodeToDelete.Next;
                }
            }
        }
        #endregion private methods
    }

}
