using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Int32;

namespace KeepAccount.Models
{
    public class Expenditure
    {
        [Required(ErrorMessage = "* Date is required")]
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "* Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "* Type is required")]
        public string Type { get; set; }
        [Required(ErrorMessage = "* Amount is required")]
        [Range(1, MaxValue, ErrorMessage = "* Amount needs to more than 0")]
        public int? Amount { get; set; }
        public string Note { get; set; }
    }
}
