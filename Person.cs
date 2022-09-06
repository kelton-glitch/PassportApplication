using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportApplication
{
    public class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string emailAddress;
        private string occupation;
        private string destination;
        private string homeAddress;
        private int phoneNumber;
        private string dateOfBirth;

        private string guardianName;
        private string guardianAddress;
        private string guardianPhone;

        private int oldPassportNumber;
        private string passportIssueDate;
        private string passportExpiryDate;

        //PERSONAL INFORMATION
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string HomeAddress
        {
            get { return homeAddress; }
            set { homeAddress = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }


        //GUARDIAN INFORMATION

        public string GuardianName
        {
            get { return guardianName; }
            set { guardianName = value; }
        }

        public string GuardianAddress
        {
            get { return guardianAddress; }
            set
            {
                guardianAddress = value;
            }
        }

        public string GuardianPhone
        {
            get { return guardianPhone; }
            set { guardianPhone = value; }
        } 


        //OLO PASSPORT INFORMATION

        public int PassportNumber
        {
            get { return oldPassportNumber; }
            set { oldPassportNumber = value; }
        }

        public string PassportIssueDate
        {
            get { return passportIssueDate; }
            set { passportIssueDate = value; }  
        }

        public string PassportExpiryDate
        {
            get { return passportExpiryDate; }
            set
            {
                passportExpiryDate = value;
            }   
        }
    
    }
}
