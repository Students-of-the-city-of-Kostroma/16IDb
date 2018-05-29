using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleLexer;


namespace Mathlibretest
{
    [TestClass]
    public class UnitTest1
    {
        void ChekTokens(IEnumerable<Token> src, params string[] val)
        { 
            List<Token> tokens = new List<Token>(src);
            Assert.AreEqual(val.Length, 2*tokens.Count); 
            for (int i=0; i<tokens.Count; i++)
            {
                Assert.AreEqual(val[2 * i], tokens[i].Type, "Несовпадение типа");
                Assert.AreEqual(val[2 * i + 1], tokens[i].Value, "Несовпадение значения");
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            Mathlexer l = new Mathlexer();
            ChekTokens(l.Tokenize("1 + 2"),
                "(literal)", "1",
                "(operator)", "+",
                "(literal)", "2"
                );
           

        }
    }
}
