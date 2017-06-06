using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem
{
    public class Person
    {
        //Fields
        private string _personName;
        private string _personAddress;
        private string _personPhone;

        public Person() //Constructor
        {
            _personName = "";
            _personAddress = "";
            _personPhone = "";
        }

        //PersonName Property
        public string PersonName
        {
            get { return _personName; }
            set { _personName = value; }
        }

        //PersonAddress Property
        public string PersonAddress
        {
            get { return _personAddress; }
            set { _personAddress = value; }
        }

        //PersonPhone Property
        public string PersonPhone
        {
            get { return _personPhone; }
            set { _personPhone = value; }
        }

        //public virtual void SetDiscountLevel()
        //{

        //}
    }
}
