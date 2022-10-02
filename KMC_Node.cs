/* ********************************************************************
 * Projct:      Customer Single Link List
 * File:        Node class
 * Language:    C#
 * 
 * Desription:  This class will hold a node int he single link list.
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 09/21/2022 - initial writing
 * *******************************************************************/
using System;

namespace CustomerSingleLinkList
{
    internal class KMC_Node
    {

        #region data
        // data
        private String _lastName;           // customer last name
        //private KMC_Node _next;              // link the next node
        #endregion data

        #region properties
        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        // getters and setters
        // accessors and mutators

        public KMC_Node Next { get; set; }
        // shorthand notation

        #endregion properties

        #region constructor
        public KMC_Node(String lastname)
        {
            LastName = lastname;
            Next = null;
        }
        #endregion constructor


        #region methods
        #endregion methods

    }
}
