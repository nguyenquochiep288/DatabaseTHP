using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_AspNetUsers : AspNetUsers
    {

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string MA { get; set; }
        public string NAME { get; set; }

        public string MA_NHOMQUYEN { get; set; }
        public string NAME_NHOMQUYEN { get; set; }
    }
}