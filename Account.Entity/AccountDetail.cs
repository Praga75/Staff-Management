using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Entity
{
    public class AccountDetail
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string MailId { get; set; }
        public string DateOfBirth { get; set; }
        public long MobileNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }

        public AccountDetail (string userName,string password,string name,string mailId,string dateOfBirth,long mobileNumber,string gender,string address,string nationality)
        {
            this.UserName = userName;
            this.Password = password;
            this.Name = name;
            this.MailId = mailId;
            this.DateOfBirth = dateOfBirth;
            this.MobileNumber = mobileNumber;
            this.Gender = gender;
            this.Address = address;
            this.Nationality = nationality;
        }

    }
}
