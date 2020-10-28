using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarCipher;

namespace CeaserCipherTests
{
    [TestClass]
    public class CeasarCipherTests
    {
        [TestMethod]
        public void TestCaesarCipherEncription()
        {
            string message = "testz";
            int key = 2;
            string expectedResult = "VGUVB";

            string result = CaesarCipher.CaesarCipher.EncryptionCaesar(message, key);

            if (!result.Equals(expectedResult, StringComparison.CurrentCultureIgnoreCase))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCaesarCipherDecription()
        {
            string message = "TESTZ";
            int key = 2;
            string encMessage = "vguvb";

            string messageDec = CaesarCipher.CaesarCipher.DecryptionCaesar(encMessage, key);

            if (!messageDec.Equals(message,StringComparison.CurrentCultureIgnoreCase))
            {
                Assert.Fail();
            }
        }
    }
}
