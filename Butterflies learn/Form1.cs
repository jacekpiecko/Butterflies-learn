using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Butterflies_learn
{
	public partial class Butterflies_Learn : Form
	{
		/// <summary>
		/// przed właczeniem aplikacji
		/// </summary>
		public Butterflies_Learn()
		{

			InitializeComponent();
		}
		private readonly  Dictionary<string, bool> Instalacja_flag = new Dictionary<string, bool>();
		private  string jezyk = null;
		private readonly Dictionary<string, bool> Zadanie  = new Dictionary<string, bool>();
		private readonly int Cena = Properties.Settings.Default.Cena;

		private void Pokaz_ceny(bool Czy_pokazac)
		{
				Cena_ZA_Polski.Visible = Czy_pokazac;
				Cena_Za_Angielski.Visible = Czy_pokazac;
			
		}

		/// <summary>
		/// jak kliknie exit to wyłacza aplikację
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		/// <summary>
		/// jak klinie start to cię przenodzi do flag państw
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Start_Click(object sender, EventArgs e)
		{
			//pokazuje flagi
			Grupa_Menu_Flag.Visible = true;
			Pokaz_ceny(true);

			// ukrywa menu
			Grupa_Menu.Visible = false;
			//pokazuje cofny
			Cofny.Visible = true;
		}

		/// <summary>
		/// cofny
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Cofny_Click(object sender, EventArgs e)
		{
			if (Grupa_Menu_Flag.Visible == true)
			{
				// pokazuje menu
				Grupa_Menu.Visible = true;
				// ukrywa flagi
				Grupa_Menu_Flag.Visible = false;
				Pokaz_ceny(false);

				//ukrywa cofny
				Cofny.Visible = false;
			}
			else if (Lista_zadan.Visible == true)
			{
				Lista_zadan.Visible = false;
				Grupa_Menu_Flag.Visible = true;
				Pokaz_ceny(true);
				//zapisuje ustawawienia z angielskiego
				if(jezyk == "eng")
				{
					Properties.Settings.Default.Unity_1_kup = Zadanie["Unit_1"];
					Properties.Settings.Default.Unity_2_kup = Zadanie["Unit_2"];
					Properties.Settings.Default.Save();
				}
			}
		}


		/// <summary>
		/// jak kliniesz flagie angielską
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Start_ENG_Click(object sender, EventArgs e)
		{
			if(Cena_Za_Angielski.Text != "Start")
			{
				 if (Cena_Za_Angielski.Text == "Free")
				{
					Instalacja_flag["Kup_Ang"] = true;
					Cena_Za_Angielski.Text = "Start";
				}
				else
				{
					if(int.Parse(Cena_Za_Angielski.Text) <= int.Parse(Hajs.Text))
					{
						Instalacja_flag["Kup_Ang"] = true;
						Cena_Za_Angielski.Text = "Start";
						Hajs.Text = (int.Parse(Hajs.Text) - int.Parse(Cena_Za_Angielski.Text)).ToString();
					}
				}
			}
			else
			{
				Lista_zadan.Visible = true;
				Grupa_Menu_Flag.Visible = false;
				Pokaz_ceny(false);

				jezyk = "eng";
				Zadanie["Unit_1"] = Properties.Settings.Default.Unity_1_kup;
				Zadanie["Unit_2"] = Properties.Settings.Default.Unity_2_kup;

				Dodatkowe_Ustawienia dodatkowe_Ustawienia = new Dodatkowe_Ustawienia(Zadanie, jezyk);
				dodatkowe_Ustawienia.Ustaw_Tekst(ref Zadanie_1, ref Zadanie_1_cena, ref  Zadanie_2, ref Zadanie_2_cena);
			}
			
		}
		/// <summary>
		// początkowie łatowanie
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Butterflies_Learn_Load(object sender, EventArgs e)
		{
			//odczytuje waltorzy z fl
			Instalacja_flag["Kup_Ang"] = Properties.Settings.Default.Kuponie_angielski;
			Instalacja_flag["Kup_Pol"] = Properties.Settings.Default.Kuponie_Polska;

			// Ustawnia cenie postawową
			#region cena
			if (Cena == 0)
			{
				Cena_Za_Angielski.Text = "free";
			}
			#endregion

			//ustawia kuponie flagi
			#region kuponie
			//ustawia cenie angielskiego
			if (Instalacja_flag["Kup_Ang"] == true)
				Cena_Za_Angielski.Text = "Start";
			else if (Cena > 0)
				Cena_Za_Angielski.Text = (Cena* 500).ToString();
			else
				Cena_Za_Angielski.Text = "Free";

			#endregion

			//ustawia hajs
			Hajs.Text = Properties.Settings.Default.Pieniadzie;
		}

		/// <summary>
		/// Zapisuje ustawienia
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Butterflies_Learn_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.Kuponie_angielski =  Instalacja_flag["Kup_Ang"];
			Properties.Settings.Default.Kuponie_Polska = Instalacja_flag["Kup_Pol"];
			Properties.Settings.Default.Pieniadzie = Hajs.Text;
			Properties.Settings.Default.Save();
		}
		/// <summary>
		/// pierwsze zadanie
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Zadanie_1_Click(object sender, EventArgs e)
		{

		}
	}
}
