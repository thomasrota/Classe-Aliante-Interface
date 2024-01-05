using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Interface
{
	public class Fusoliera : IComposite
	{
		private double _lunghezza;
		private string _materiale;

		public double Lunghezza
		{
			get { return _lunghezza; }
			set
			{
				if (value >= 75F)
					_lunghezza = value;
				else
					_lunghezza = 75F;
			}
		}

		public string Materiale
		{
			get { return _materiale; }
			set { _materiale = value; }
		}

		public Fusoliera()
		{
			Lunghezza = 0F;
			Materiale = string.Empty;
		}

		public Fusoliera(double _lunghezza, string materiale)
		{
			Lunghezza = _lunghezza;
			Materiale = materiale;
		}

		public Fusoliera(Fusoliera oldFusoliera)
		{
			Lunghezza = oldFusoliera.Lunghezza;
			Materiale = oldFusoliera.Materiale;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Fusoliera) || obj == null)
			{
				return false;
			}

			Fusoliera other = (Fusoliera)obj;
			return Lunghezza == other.Lunghezza && Materiale == other.Materiale;
		}

		public void Aggiunta(IComposite componente)
		{

		}

		public void Rimuovi(int indice)
		{

		}

		public IComposite GetChild(int indice)
		{
			return null;
		}

		public override string ToString()
		{
			return $"Lunghezza fusoliera: {Lunghezza}; Materiale fusoliera: {Materiale}";
		}

		public double Prezzo()
		{
			return Lunghezza * 30F;
		}
	}

}
