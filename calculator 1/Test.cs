using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_1
{
    internal class Test
    {
        [Test]
       public void Add_TwoPlusTwo_ReturnsFour()
        {
          
            var calculator = new Calculator();
          Assert.That (calculator.Add(2, 2), Is.EqualTo(4));
        }
    }
}
