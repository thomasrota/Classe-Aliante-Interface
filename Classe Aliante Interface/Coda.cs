using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Interface
{
	namespace Aliante_Interfaccia
	{
		public class Coda : IComposite
		{
			private double _lunghezza;

			public double Lunghezza
			{
				get { return _lunghezza; }
				set
				{
					if (value >= 7F && value <= 12F)
						_lunghezza = value;
					else
						_lunghezza = 8F;
				}
			}

			public Coda()
			{
				Lunghezza = 0F;
			}

			public Coda(double lung)
			{
				Lunghezza = lung;
			}

			public Coda(Coda oldCoda)
			{
				Lunghezza = oldCoda.Lunghezza;
			}

			public override bool Equals(object obj)
			{
				if (!(obj is Coda) || obj == null)
				{
					return false;
				}

				Coda other = (Coda)obj;
				return Lunghezza == other.Lunghezza;
			}

			public void Aggiunta(IComposite component)
			{

			}

			public void Rimuovi(int index)
			{

			}

			public IComposite GetChild(int index)
			{
				return null;
			}

			public override string ToString()
			{
				return $"Lunghezza coda: {Lunghezza}";
			}

			public double Prezzo()
			{
				return Lunghezza * 30;
			}
		}
	}
}
