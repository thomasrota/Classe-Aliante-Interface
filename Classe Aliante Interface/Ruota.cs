using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Interface
{
	public class Ruota : IComposite
	{
		private Gomma _gomma;
		private Cerchione _cerchione;

		public Gomma Gomma
		{
			get { return _gomma; }
			set { _gomma = value; }
		}

		public Cerchione Cerchione
		{
			get { return _cerchione; }
			set { _cerchione = value; }
		}

		public Ruota()
		{
			Gomma = new Gomma();
			Cerchione = new Cerchione();
		}

		public Ruota(Cerchione cerchione, Gomma gomma)
		{
			Cerchione = cerchione;
			Gomma = gomma;
		}

		public Ruota(Ruota oldRuota)
		{
			Gomma = oldRuota.Gomma;
			Cerchione = oldRuota.Cerchione;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Ruota) || obj == null)
			{
				return false;
			}

			Ruota other = (Ruota)obj;
			return Gomma == other.Gomma && Cerchione == other.Cerchione;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}s
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
			return $"Dettagli gomma: {Gomma}; Dettagli cerchioni: {Cerchione}";
		}

		public double Prezzo()
		{
			return 0;
		}
	}
}