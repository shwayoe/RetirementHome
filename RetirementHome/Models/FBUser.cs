using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetirementHome.Models
{
    public class FBUser
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PictureUrl { get; set; }
        public string Email { get; set; }
    }
}