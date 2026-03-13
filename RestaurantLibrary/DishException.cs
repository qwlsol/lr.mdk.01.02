using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class DishDataException : Exception
    {
        public int LineNumber { get; }

        public DishDataException(string message) : base(message)
        {
            LineNumber = 0;
        }

        public DishDataException(string message, int lineNumber) : base(message)
        {
            LineNumber = lineNumber;
        }

        public DishDataException(string message, int lineNumber, Exception innerException)
            : base(message, innerException)
        {
            LineNumber = lineNumber;
        }
    }
}
