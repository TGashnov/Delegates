using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._2
{
    public class AlreadyExistsException: Exception
    {
        public string Value { get; set; }
        public int Position { get; set; }

        public AlreadyExistsException(string value, int position)
        {
            Value = value;
            Position = position;
        }
    }
}
