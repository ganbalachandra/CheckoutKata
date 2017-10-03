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

        [TestFixture] //2nd checkout
        public class When_scanned_oneItem_and_A
        {
            [Test]
            public void Then_total_is_50()
            {
                var checkout = new Checkout();
                var totalPrice = checkout.GetTotalPrice();
                //assert
                Assert.That(totalPrice, Is.EqualTo(50));

           }
        }
    }
}
