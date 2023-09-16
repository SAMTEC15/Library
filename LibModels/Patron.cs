using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class Patron
    {
        public string patronFname {  get; set; }
        public string patronLname { get; set; }
        public string dateOfBirth { get; set; } 
        public string email { get; set; }
        public string number { get; set; }
        public string qualification { get; set; }
        public string password { get; set; }
        

        public Patron(string PatronfName, string PatronlName, string DateOfBirth, string Email, string PNumber, string Qualification, string Password)
        {
            patronFname = PatronfName;
            patronLname = PatronlName;
            dateOfBirth = DateOfBirth;
            email = Email;
            number = PNumber;
            qualification = Qualification;
            password = Password;
            
        }

        public string GetpatronFame(string PatronName)
        {
            return patronFname;
        }
        public string GetpatronLname(string PatronName)
        {
            return patronLname;
        }
        public string GetId(string DateOfBirth)
        {
            return dateOfBirth;
        }        
        public string GetPassword()
        {
            return password;
        }
        public string GetEmail()
        {
            return email;
        }
        public string GetPhoneNumber()
        {
            return number;
        }
        public string GetQualitication()
        {
            return qualification;
        }
    }
}
