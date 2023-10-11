using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KomplexPr;

namespace KomplexTeszt
{
    [TestFixture]
    internal class NTeszt
    {
        [Test]
        public void KonstruktorNTeszt()
        {
            Assert.IsNotNull(
            new Komplex(1, 2));
        }
    }


}
