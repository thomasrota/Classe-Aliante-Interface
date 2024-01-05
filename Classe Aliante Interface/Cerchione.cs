using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Interface
{
	public class Cerchione : IComposite
	{
		private double _pollici;
		private string _materiale;

		public double Pollici
		{
			get { return _pollici; }
			set
			{
				if (value >= 15F && value <= 20)
					_pollici = value;
				else
					_pollici = 16F;
			}
		}

		public string Materiale
		{
			get { return _materiale; }
			set { _materiale = value; }
		}

		public Cerchione()
		{
			Pollici = 0F;
			Materiale = string.Empty;
		}

		public Cerchione(double pollici, string materiale)
		{
			Pollici = pollici;
			Materiale = materiale;
		}

		public Cerchione(Cerchione oldCerchione)
		{
			Pollici = oldCerchione.Pollici;
			Materiale = oldCerchione.Materiale;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Cerchione) || obj == null)
			{
				return false;
			}

			Cerchione other = (Cerchione)obj;
			return Pollici == other.Pollici && Materiale == other.Materiale;
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
			return $"Pollici: {Pollici}; Materiale cerchioni: {Materiale}";
		}

		public double Prezzo()
		{
			return Pollici * 1.5F;
		}
	}
}
