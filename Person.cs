using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportApplication
{
    public static class Person
    {
        private static string firstName;
        private static string middleName;
        private static string lastName;
        private static string emailAddress;
        private static string occupation;
        private static string destination;
        private static string homeAddress;
        private static string phoneNumber;
        private static string dateOfBirth;

        private static string guardianName;
        private static string guardianAddress;
        private static string guardianPhone;

        private static int oldPassportNumber;
        private static string passportIssueDate;
        private static string passportExpiryDate;

        //PERSONAL INFORMATION
        public static string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public static string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public static string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public static string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public static string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public static string HomeAddress
        {
            get { return homeAddress; }
            set { homeAddress = value; }
        }

        public static string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public static string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public static string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }


        //GUARDIAN INFORMATION

        public static string GuardianName
        {
            get { return guardianName; }
            set { guardianName = value; }
        }

        public static string GuardianAddress
        {
            get { return guardianAddress; }
            set
            {
                guardianAddress = value;
            }
        }

        public static string GuardianPhone
        {
            get { return guardianPhone; }
            set { guardianPhone = value; }
        } 


        //OLO PASSPORT INFORMATION

        public static int PassportNumber
        {
            get { return oldPassportNumber; }
            set { oldPassportNumber = value; }
        }

        public static string PassportIssueDate
        {
            get { return passportIssueDate; }
            set { passportIssueDate = value; }  
        }

        public static string PassportExpiryDate
        {
            get { return passportExpiryDate; }
            set
            {
                passportExpiryDate = value;
            }   
        }
    
    }
}
