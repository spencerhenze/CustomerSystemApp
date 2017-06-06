using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem
{
    public class Customer : Person
    {

        //new fields
        public string _custNumber { get; set; }
        public bool _mailingList { get; set; }

        public Customer() //constructor
        {
            _custNumber = "";
            _mailingList = false;
        }

        //Properties
        public string CustNumber
        {
            get { return _custNumber; }
            set { _custNumber = value; }
        }

        public bool MailingList
        {
            get { return _mailingList; }
            set { _mailingList = value; }
        }
    }
}
