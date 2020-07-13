using System.Collections.Generic;
using System.Windows.Forms;

namespace Butterflies_learn
{
	internal class Dodatkowe_Ustawienia
	{
		private readonly Dictionary<string, bool> Zadanie;
		private readonly string Jezyk;
		public Dodatkowe_Ustawienia(Dictionary<string, bool> Zadanie, string Jezyk)
		{
			this.Zadanie = Zadanie;
			this.Jezyk = Jezyk;
		}
		internal void Ustaw_Tekst(ref Label Zadanie_1, ref Label cena1, ref Label Zadanie_2, ref Label cena2)
		{
			if (Jezyk == "eng")
			{
				if (Zadanie["Unit_1"] == false)
				{
					Zadanie_1.Text = "Unit 1 -";
					cena1.Text = "Free";
				}
				else
				{
					Zadanie_1.Text = "Unit 1 -";
					cena1.Text = "Start";
				}
				if (Zadanie["Unit_2"] == false)
				{
					Zadanie_2.Text = "Unity 2 -";
					cena2.Text = "100";
				}
				else
				{
					Zadanie_2.Text = "Unity 2 -";
					cena2.Text = "Start";
				}
			}
		}
	}
}