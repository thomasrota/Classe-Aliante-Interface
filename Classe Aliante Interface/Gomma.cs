using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Interface
{
	public class Gomma : IComposite
	{
		private double _altezza;
		private double _larghezza;
		private double _raggio;

		public double Altezza
		{
			get { return _altezza; }
			set
			{
				if (value >= 200F && value <= 400F)
					_altezza = value;
				else
					_altezza = 300F;
			}
		}

		public double Larghezza
		{
			get { return _larghezza; }
			set
			{
				if (value >= 200F && value <= 400F)
					_larghezza = value;
				else
					_larghezza = 300F;
			}
		}

		public double Raggio
		{
			get { return _raggio; }
			set
			{
				if (value >= 40F && value <= 60F)
					_raggio = value;
				else
					_raggio = 50F;
			}
		}

		public Gomma()
		{
			Altezza = 0F;
			Larghezza = 0F;
			Raggio = 0F;
		}

		public Gomma(double alt, double larg, double raggio)
		{
			Altezza = alt;
			Larghezza = larg;
			Raggio = raggio;
		}

		public Gomma(Gomma oldGomma)
		{
			Altezza = oldGomma.Altezza;
			Larghezza = oldGomma.Larghezza;
			Raggio = oldGomma.Raggio;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Gomma) || obj == null)
			{
				return false;
			}

			Gomma other = (Gomma)obj;
			return Altezza == other.Altezza && Larghezza == other.Larghezza && Raggio == other.Raggio;
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
			return $"Altezza: {Altezza}; Larghezza: {Larghezza}; Raggio: {Raggio}";
		}

		public double Prezzo()
		{
			return Altezza * Larghezza * Raggio * 10F;
		}
	}
}
