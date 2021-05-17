using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepAccount.Models
{
    public class PageViewModel
    {
        public Expenditure Expenditure { get; set; }
        public List<Expenditure> Expenditures { get; set; }
    }
}
