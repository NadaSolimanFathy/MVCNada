using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entities
{
    public class Person: BaseEntity
    {




        [Required(ErrorMessage = "user-name is required ")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Email is required ")]
        public string Email { get; set; }


        [Required(ErrorMessage = "password is required ")]
        public string Password { get; set; }


        [Range(11, 11, ErrorMessage = "Phone number must be 11 digits")]
        public string PhoneNumber { get; set; }

    }
}
