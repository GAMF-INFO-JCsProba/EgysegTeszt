using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexPr
{
	public class Komplex
	{
		/// <summary>
		/// Valós rész.
		/// </summary>
		private double Valós;
		/// <summary>
		/// Képzetes rész.
		/// </summary>
		private double Képzetes;

		/// <summary>
		/// Konstruktor, inicializálja az adattagokat.
		/// </summary>
		/// <param name="Va">Valós rész.</param>
		/// <param name="Ké">Képzetes rész.</param>
		public Komplex(double Va, double Ké)
		{
			Valós = Va;
			Képzetes = Ké;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (!(obj is Komplex))
				return false;
			return Valós == ((Komplex)obj).Valós &&
						 Képzetes ==
						 ((Komplex)obj).Képzetes;
		}

		public override string ToString()
		{
			return Valós.ToString() + "+i*" +
				Képzetes.ToString();
		}
		public static bool operator !=(Komplex a,
																	 Komplex b)
		{
			return !(a == b);
		}

		public static bool operator ==(Komplex a,
			Komplex b)
		{
			if (ReferenceEquals(a, b))
				return true;
			if ((object)a == null || (object)b == null)
				return false;
			return a.Valós == b.Valós &&
						 a.Képzetes == b.Képzetes;
		}
	}

}
