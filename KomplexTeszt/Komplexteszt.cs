using System;
using KomplexPr;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomplexTeszt
{
	[TestClass]
	public class KomplexTeszt
	{
		[TestMethod]
		[TestCategory("Konstruktor")]
		public void KonstruktorTeszt()
		{
		    Komplex Komplex = new Komplex(1, 2);
			Assert.IsNotNull(Komplex);
		}

		[TestMethod]
		[TestCategory("ToString")]
		public void ToStringTeszt()
		{
			var Komplex = new Komplex(1, 2);
			var s = Komplex.ToString();
			var ElvártÉrték = "1+i*2";
			Assert.AreEqual(ElvártÉrték, s);
		}

		[TestMethod]
		[TestCategory("Equals")]
		public void EqualsTeszt_1()
		{
			var a = new Komplex(1, 2);
			var b = new Komplex(1, 2);
			var AktÉrték = a.Equals(b);
			Assert.AreEqual(true, AktÉrték);
		}
		[TestMethod]
		[TestCategory("Equals")]
		public void EqualsTeszt_2()
		{
			var a = new Komplex(1, 2);
			Komplex b = null;
			var AktÉrték = a.Equals(b);
			Assert.AreEqual(false, AktÉrték);
		}
		[TestMethod]
		[TestCategory("Equals")]
		public void EqualsTeszt_3()
		{
			var a = new Komplex(1, 2);
			var b = 5;
			var AktÉrték = a.Equals(b);
			Assert.AreEqual(false, AktÉrték);
		}

		[TestMethod]
		[TestCategory("==")]
		public void op_Equality_Teszt_1()
		{
			var a = new Komplex(1, 2);
			var b = new Komplex(1, 2);
			var AktÉrték = (a == b);
			Assert.AreEqual(true, AktÉrték);
		}
	}
	

}
