using Classe_Aliante_Interface.Aliante_Interfaccia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Classe_Aliante_Interface
{
	public partial class Form1 : Form
	{
		public Aliante aliante;
		public Form1()
		{
			InitializeComponent();
			aliante = new Aliante();
		}
	}
}
