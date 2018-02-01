using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMayflowerWeb.Models
{
    public class Person
    {
        private string firstName = "n/a";
        private string lastName = "n/a";
        private string mInitial = "n/a";
        private int id = -1;

        // These are accessor methods aka Properties
        // They are also called gets and sets or getters and setters

        public string FirstName
        {
            //this gets info from the object
            get
            {
                //this.variable points to variables at top
                return this.firstName;
            }
            //this changes the object's value
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

        public string MInitial
        {
            get
            {
                return this.mInitial;
            }
            set
            {
                this.mInitial = value;
            }
        }

        //Start of constructors

        //This is an empty constructor, replaces the invisible one
        public Person() { }
        public Person(int anId, string aLname, string aFname, string aMinitial)
        {
            this.id = anId;
            this.FirstName = aFname;
            this.LastName = aLname;
            this.MInitial = aMinitial;
        }

        public override string ToString()
        {
            string aMessage = "";
            aMessage += "ID: " + this.Id + " ";
            aMessage += "First Name: " + this.FirstName + " ";
            aMessage += "Middle Inital: " + this.MInitial + " ";
            aMessage += "Last Name: " + this.LastName + " ";

            return aMessage;
        }
    }
}