using InputHelperLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputHelperLibrary.Models
{
    public class Cell
    {
        public int Value { get; set; }
        public CellMarkerEnum CellMarker { get; set; }
    }
}
