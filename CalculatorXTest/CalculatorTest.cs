using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Calculator;

namespace CalculatorXTest
  
{ [TestFixture]
    public class CalculatorTest
    { 
    
    [Test]

        public void TestSumma()
    {
        Assert.AreEqual(CalculatorX.Summa(2, 3), 5);
          
   }
    [Test]

    public void TestSumma1()
    {
        Assert.AreEqual(CalculatorX.Summa(2, 2), 5);

    }
      
       

    }
}
