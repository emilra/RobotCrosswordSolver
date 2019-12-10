using System;
using System.Collections.Generic;
using System.Text;

namespace InputHelperLibrary.Models
{
    public class Row
    {
        public IEnumerable<Cell> Cells { get; set; }
        public int? Total { get; set; }
    }
}
