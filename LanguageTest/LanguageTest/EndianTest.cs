using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LanguageTest
{
    [TestClass]
    public class EndianTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            byte[] bytes = { 0, 0, 0, 25 };

            // If the system architecture is little-endian (that is, little end first), 
            // reverse the byte array. 
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            int i = BitConverter.ToInt32(bytes, 0);
            Console.WriteLine("int: {0}", i);
            // Output: int: 25

            bytes = BitConverter.GetBytes(25);
            Console.WriteLine("byte array: " + BitConverter.ToString(bytes));
        }

        [TestMethod]
        public void TestMethod2()
        {
            byte[] bytes = BitConverter.GetBytes(25);
            Console.WriteLine("byte array: " + BitConverter.ToString(bytes));
        }
    }
}
