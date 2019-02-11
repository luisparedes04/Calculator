using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    public interface ICalculator
    {
        // Interface Methods

        void Add(decimal displayValue);
        void Substract(decimal displayValue);
        void Multiply(decimal displayValue);
        void Divide(decimal displayValue);
        void Equals();
        void Equals(decimal displayValue);
        void Clear();
    }
}
