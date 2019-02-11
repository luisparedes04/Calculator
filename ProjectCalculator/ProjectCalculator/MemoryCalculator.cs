using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    public class MemoryCalculator : Calculator
    {
        // Data Member
        private decimal memoryValue;

        //Property created just for testing purposes (Unit test)
        //public decimal MemoryValue { get => MemoryValue1; }
public decimal MemoryValue
        {
            get
            {
                return memoryValue;
            }

            set
            {
                memoryValue = value;
            }
        }

        //                                  Memory Calculator Methods
        // Memory Store
        // sets memory value to whatever is passed in
        public void MemoryStore(decimal displayValue)
        {
            this.MemoryValue = displayValue;
        }

        //Memory Recall
        // returns whatever the memory value is
        public decimal MemoryRecall()
        {
            return this.MemoryValue;
        }

        // Memory Add
        // adds whatever is passed in to the current memmory value
        public void MemoryAdd(decimal displayValue)
        {
            this.MemoryValue += displayValue;
        }

        // Memory Clear
        // Sets memory value to zero
        public void MemoryClear()
        {
            this.MemoryValue = 0;
        }
    }
}
