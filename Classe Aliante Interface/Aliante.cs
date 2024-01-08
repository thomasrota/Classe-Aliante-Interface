using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Interface
{
	public class Aliante : IComposite
    {
        private List<IComposite> _componenti;

        public List<IComposite> IComposites
        {
            get { return _componenti; }
            set { _componenti = value; }
        }

        public Aliante()
        {
            IComposites = new List<IComposite>();
        }

        public Aliante(List<IComposite> componenti)
        {
            IComposites = componenti;
        }

        public Aliante(Aliante oldAliante)
        {
            IComposites = oldAliante.IComposites;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aliante) || obj == null)
            {
                return false;
            }

            Aliante other = (Aliante)obj;
            if (IComposites.Count != other.IComposites.Count)
            {
                return false;
            }

            for (int i = 0; i < IComposites.Count; i++)
            {
                if (!IComposites[i].Equals(other.IComposites[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
	        return base.GetHashCode();
        }

		public void Aggiunta(IComposite componente)
        {
            IComposites.Add(componente);
        }

        public void Rimuovi(int indice)
        {
            IComposites.RemoveAt(indice);
        }

        public IComposite GetChild(int indice)
        {
            if (IComposites.Count > indice)
            {
                return IComposites[indice];
            }

            return null;
        }

        public override string ToString()
        {
            string s = "";

            foreach (var componente in IComposites)
            {
                s += componente.ToString();
            }

            return s;
        }

        public double Prezzo()
        {
            double tot = 0;

            foreach (var componente in IComposites)
            {
                tot += componente.Prezzo();
            }

            return tot;
        }
    }
}
