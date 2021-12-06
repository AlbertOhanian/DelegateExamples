using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    public class Calculator
    {
        public int Calculate(Operation operation,int first,int second)
        {
            return operation(first, second);
        }
    }
}
