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
        /// </summary>
        public class When_scanned_no_items
        {

            [Test]
            public void Then_total_is_0()
            {
               
                var totalPrice = 1;

                //assert
                Assert.That(totalPrice, Is.EqualTo(0));

            }
        }
    }
}
