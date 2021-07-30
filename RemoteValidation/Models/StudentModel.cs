using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RemoteValidation.Models
{
    public class StudentModel
    {
        public string Name { get; set; }
        [Remote("IsEmailExist", "Student", ErrorMessage = "Email Already Exist. Please choose another email.")]
        public string Email { get; set; }
    }
}
