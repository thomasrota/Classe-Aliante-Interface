using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Interface
{
	public interface IComposite
	{
		void Aggiunta(IComposite componente);

		void Rimuovi(int indice);

		IComposite GetChild(int indice);

		bool Equals(object obj);

		string ToString();

		double Prezzo();
	}
}
