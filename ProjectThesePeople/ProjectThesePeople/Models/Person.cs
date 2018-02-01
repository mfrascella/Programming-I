// Written by Maria Frascella
// 1/23/18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectThesePeople.Models
{
    public class Person
    {
        // private properties
        private string firstName = "n/a";
        private string lastName = "n/a";
        private string middleName = "n/a";
        private int id = -1;

        // public gets and sets
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            //set
            //{
            //    this.id = value;
            //}
        }

        public override string ToString()
        {
            string message = "";
            message += "First Name: " + this.FirstName + "<br />";
            message += "Middle Name: " + this.MiddleName + "<br />";
            message += "Last Name: " + this.LastName + "<br />";
            message += "ID: " + this.Id + "<br /><br />";

            return message;
        }
    }
}