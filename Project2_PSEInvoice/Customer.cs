/*'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Project #2 -- Customer
' Created by Laura Waite
' Date: 11/01/2020
' Project Name: PSE Invoice
' Class: CS 218
' Time: 2 hours 18 minutes (mostly video watching)
' Platform: PC, Windows 10, VS 2017
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Customer data class, pulled from customers.txt
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the student:
' Some of the code here is confusing and might not apply? 
' Classes are not covered this quarter, so code is taken from
' Lab 7 video instruction.
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;

namespace Project2_PSEInvoice
{
    /// <summary>
    /// Class       Customer
    /// File        Customer.cs
    /// Description Support class used by frmInvoice class.
    /// Author      Laura Waite
    /// Environment PC, Windows 10, VS 2017
    /// Date        11/01/2020
    /// Version     1.0.0
    /// History Log 
    /// </summary>
    /// 
    class Customer
    {
        // Declare class level variables
        private string name;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string account;
        private string lastRead;

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Default constructor to create new instance of Customer class
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public Customer()
        {
            name = address = city = state = zip = account= lastRead = string.Empty;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Overloaded constructor to create new instance of Customer class
        ' Parameter     name--string 
        ' Parameter     address--string
        ' Parameter     city--string
        ' Parameter     state--string
        ' Parameter     zip--string
        ' Parameter     lastRead--string
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public Customer(string name, string address, string city, string state, string zip, string account, string lastRead)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.account = account;
            this.lastRead = lastRead;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Customer()- overloaded copy constructor
        ' Description   Creates an instance of the Customer class-- copy of nextCustomer
        ' Parameter     nextCustomer--Customer 
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public Customer(Customer nextCustomer)
        {
            name = nextCustomer.name;
            address = nextCustomer.address;
            city = nextCustomer.city;
            state = nextCustomer.state;
            zip = nextCustomer.zip;
            account = nextCustomer.account;
            lastRead = nextCustomer.lastRead;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Method        Equals()
        ' Description   Overridden bool method to check if two customers are equal.
        '               Customers are considered equal if names and addresses match.
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(this.GetType().Equals(obj.GetType())))
            {
                return false;
            }
            Customer nextCustomer = (Customer)obj;
            if (this.name != nextCustomer.name && this.address != nextCustomer.address)
            {
                return false;
            }
            return true;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Method        ToString()
        ' Description   Overridden ToString method to display customer info.
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public override string ToString()
        {
            return "Prepared for:" + Environment.NewLine + name + 
                                     Environment.NewLine + address + 
                                     Environment.NewLine + city + ", " + state + " " + zip;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Method        GetHashCode()
        ' Description   Overridden GetHashCode.
        ' Return        hashCode--int
        ' Date          11/01/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Get and Set Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        public string LastRead
        {
            get { return lastRead; }
            set { lastRead = value; }
        }
    }
}
