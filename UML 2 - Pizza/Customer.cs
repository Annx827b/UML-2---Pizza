using System;
using System.Collections.Generic;
using System.Text;

namespace UML_2___Pizza
{
    public class Customer
    {
        #region Instance Fields

        private int _numberOfCustomer;
        private string _nameOfCustomer;
        private string _customerCity;
        private int _customerPostalCode;
        private string _customerStreetName;
        private int _customerHouseNumber;
        private int _phoneNumberOfCustomer;
        private string _emailOfCustomer;

        #endregion

        #region Constructor
        public Customer(int numberOfCustomer, string nameOfCustomer, string customerCity, int customerPostalCode, string customerStreetName, int customerHouseNumber,  int phoneNumberOfCustomer, string emailOfCustomer)
        {
            _numberOfCustomer = numberOfCustomer;
            _nameOfCustomer = nameOfCustomer;
            _customerCity = customerCity;
            _customerPostalCode = customerPostalCode;
            _customerStreetName = customerStreetName;
            _customerHouseNumber = customerHouseNumber;
            _phoneNumberOfCustomer = phoneNumberOfCustomer;
            _emailOfCustomer = emailOfCustomer;
        }
        #endregion

        #region Properties

        public int NumberOfCustomer
        {
            get { return _numberOfCustomer; }
            set { _numberOfCustomer = value; }
        }

        public string NameOfCustomer
        {
            get { return _nameOfCustomer; }
            set { _nameOfCustomer = value; }
        }

        public string CustomerCity
        {
            get { return _customerCity; }
            set { _customerCity = value; }
        }

        public int CustomerPostalCode
        {
            get { return _customerPostalCode; }
            set { _customerPostalCode = value; }
        }

        public string CustomerStreetName
        {
            get { return _customerStreetName; }
            set { _customerStreetName = value; }
        }

        public int CustomerHouseNumber
        {
            get { return _customerHouseNumber; }
            set { _customerHouseNumber = value; }
        }

        public int PhoneNumberOfCustomer
        {
            get { return _phoneNumberOfCustomer; }
            set { _phoneNumberOfCustomer = value; }
        }

        public string EmailOfCustomer
        {
            get { return _emailOfCustomer; }
            set { _emailOfCustomer = value; }
        }

        #endregion

        #region Methods
        #endregion

    }
}

