using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Test
{
    [TestFixture]
    public class GIVEN_I_am_scanning
    {
        /// <summary>
        /// start with simplest test and make it fail (red) then make it just enough to pass
        /// BDD style syntax is used
        /// </summary>
        public class When_scanned_no_items
        {
            [Test]
            public void Then_total_is_0()
            {
                // Arrange
                var checkout = new Checkout();
                var totalPrice = checkout.GetTotalPrice();
                //assert
                Assert.That(totalPrice, Is.EqualTo(0));
            }
        }

        /// <summary>
        /// first item scanned and it's A
        /// </summary>
        [TestFixture] 
        public class When_scanned_oneItem_and_A
        {
            [Test]
            public void Then_total_is_50()
            {
                var checkout = new Checkout();
                checkout.Scan('A');
                var totalPrice = checkout.GetTotalPrice();
                //assert
                Assert.That(totalPrice, Is.EqualTo(50));
           }
        }

        /// <summary>
        /// Scanned item B
        /// </summary>
        [TestFixture]
        public class When_scanned_oneItem_and_B
        {
            [Test]
            public void Then_total_is_30()
            {
                var checkout = new Checkout();
                checkout.Scan('B');
                var totalPrice = checkout.GetTotalPrice();
                //assert
                Assert.That(totalPrice, Is.EqualTo(30));
            }
        }

        /// <summary>
        /// Scan A,B,C,D
        /// </summary>
        public class When_scanned_RandomItems
        {
            [TestCase("ABCD")]
            public void Then_total_is_115(string items)
            {
                var checkout = new Checkout();
                int totalPrice = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    checkout.Scan(items[i]);
                    totalPrice = checkout.GetTotalPrice();
                }
                // Assert
                Assert.AreEqual(totalPrice, 115);
            }
        }

        public class When_scanned_Three_A
        {
            [TestCase("AAA")]
            public void Then_total_is_130(string items)
            {
                var checkout = new Checkout();
                int totalPrice = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    checkout.Scan(items[i]);
                }
                totalPrice = checkout.GetTotalPrice();
                // Assert
                Assert.AreEqual(totalPrice, 130);
            }
        }
    }
}
