using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class Utilities {

        public BaseTest objBaseTest;

    public Utilities(BaseTest objBaseTest)
    {
        this.objBaseTest = objBaseTest;
    }

        public void logReporter(String strPassMsg, bool blnResult)
        {
            Console.WriteLine("StepDescription----> " + strPassMsg);
            Assert.IsTrue(blnResult);

        }

        public void logReporter(String strPassMsg,String inputValue, bool blnResult)
        {
            Console.WriteLine("StepDescription----> "+"||"+ inputValue+ "||"+  strPassMsg);
            Assert.IsTrue(blnResult);

        }

        public void logReporter(String strPassMsg, String actualValue, String expectedValue, bool blnResult)
        {
            Console.WriteLine("StepDescription----> " + "||"+ actualValue +"||" + strPassMsg+ "||"+expectedValue+"||");
            Assert.IsTrue(blnResult);

        }

    }
}
