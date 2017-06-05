using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPruebas1.Models
{
    public class ConditionWitRefFieldsDropdownList
    {
        public int id { get; set; }
        public string Field_Ref_Name { get; set; } // the dropdown list 
        public bool CoreField { get; set; } // the checkbox
        public DateTime DataType { get; set; }
    }
}