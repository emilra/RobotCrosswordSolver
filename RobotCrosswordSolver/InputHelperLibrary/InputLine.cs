using InputHelperLibrary.Enums;
using InputHelperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputHelperLibrary
{
    public static class InputLine
    {
        public static Row GetRow(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException();
            }
            var splitInput = input.Split(' ');
            var cells = splitInput[0];
            int? total = null;
            if (splitInput.Length > 1)
            {
                total = int.Parse(input.Split(' ')[1]);
            }

            var cellsToAdd = new List<Cell>();

            foreach (var c in cells.ToCharArray())
            {
                var cell = new Cell
                {
                    Value = int.Parse(c.ToString()),
                    CellMarker = CellMarkerEnum.Unset
                };
                cellsToAdd.Add(cell);
            }

            return new Row
            {
                Cells = cellsToAdd,
                Total = total
            };
        }
    }
}
