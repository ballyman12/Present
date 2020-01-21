using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Users
{
    public class User
    {
        [Display(Name = "Full name :")]
        public string Name { get; set; }
        [Display(Name = "Address :")]
        public string Address { get; set; }
        [Display(Name = "Phone :")]
        public int Phone { get; set; }
        [Display(Name = "Province :")]
        public Province Province { get; set; }
        [Display(Name = "Country :")]
        public string Country { get; set; }
        [Display(Name = "Zipcode :")]
        public string Zipcode { get; set; }
        [Display(Name = "Email :")]
        public string Email { get; set; }
        [Display(Name = "Gender :")]
        public Gender Gender { get; set; }
    }

    public enum Province
    {
        ChiangMai, 
        ChiangRai,
        Bangkok,
        Phuket,
        Phayao

    }

    public enum Gender
    {
        Male,
        Female
    }
}
