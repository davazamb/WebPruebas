using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetAlertWeb.Models
{
    public class OrderFood
    {
        [Key]
        public int OrderID
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please enter OrderCode")]
        public string OrderCode
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please enter OrderPrice")]
        public string OrderPrice
        {
            get;
            set;
        }

    }
}