using System;
using System.Windows.Forms;

using Eng;

using Kontorla;

using PLN;

namespace language_fast
{
	public partial class Form1 : Form
	{

		private Unit_1_eng unit_1_Eng;
		private Unit_1_eng_pl unit_1_Eng_Pl;
		private bool start_bool = false, rozmal = false, czowny = false, zmania = false, czy_kurs = false;
		private int liczba_punktu = 0, dobrze_napiszanie_słowa = 0, ile_dodakowy_hajs_dodac;
		private string nazwa_kraju;
		private byte życię = 3;
		private float czas = 15f;

		private string nazwa_unitu_2;
		private string nazwa_unitu_1_kurs;
		private string nazwa_unitu_1;
		private string teraz_jest_te_unit = null;

		private string[] kraje = new string[1];
		private string[] cena_kraju_numer = new string[1];
		private int[] cena_kraju = new int[1];
		private Kontorla_jezyka kontorla;

		public Form1()
		{
			// zmiana wielkości
			rozmal = true;
			Rozmial();

			InitializeComponent();

			unit_1_Eng = new Unit_1_eng();
			unit_1_Eng_Pl = new Unit_1_eng_pl();
			kontorla = new Kontorla_jezyka();
		}
		/// <summary>
		/// zmiania wielkości zapomowiać buttonia Pełny
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Rozmiar_ekranu(object sender, EventArgs e)
		{
			Rozmial();
		}
		/// <summary>
		/// medota do zmiany wielkości
		/// </summary>
		private void Rozmial()
		{
			//zmiana rozmaru ekranu
			if (rozmal == true) // max ekran
			{

				WindowState = System.Windows.Forms.FormWindowState.Maximized;

				//zmięna texture
				Pelny.Image = global::language_fast.Properties.Resources.pelny;

				//zmięna opcie zmiany ekranu
				rozmal = false;

				//czy ma dodać start
				if (start_bool == false)
				{
					Start1.Visible = false;
					Start.Visible = true;
				}
			}

			else if (rozmal == false)//min. ekranu
			{
				WindowState = System.Windows.Forms.FormWindowState.Normal;

				//zmięna textury7
				Pelny.Image = global::language_fast.Properties.Resources.nim;

				//zmięna opcie zmiany ekranu
				rozmal = true;

				//czy ma dodać start
				if (start_bool == false)
				{
					Start1.Visible = true;
					Start.Visible = false;
				}
			}
		}
		/// <summary>
		/// medota wyjścia lub cofniecia 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Exit_Click(object sender, EventArgs e)
		{
			// zakoncz
			if (start_bool == false)
			{
				Application.Exit();
			}

			// do menu
			if (start_bool == true && czowny == false && zmania == false)
			{
				//zmiana strat gry
				if (rozmal == true) Start1.Visible = true;
				else if (rozmal == false) Start.Visible = true;

				//visible is off
				Pl.Visible = false;
				Eng.Visible = false;
				start_bool = false;

				//cena visible is off
				cena_kraju_eng.Visible = false;
				cena_kraju_pl.Visible = false;
			}

			//do flagi kraju
			else if (start_bool == true && czowny == true && zmania == false)
			{
				//unity visible is off
				Unity_1.Visible = false;
				Unit_1_kurs.Visible = false;
				Unit_2.Visible = false;

				Slownik.Visible = false;

				//zmiania cofnienia
				czowny = false;

				//flagi is visible
				Pl.Visible = true;
				Eng.Visible = true;

				//cena is visible
				cena_kraju_eng.Visible = true;
				cena_kraju_pl.Visible = true;
			}

			//do unitu
			else if (start_bool == true && czowny == true && zmania == true)
			{
				//visible is off
				Inny_jezyk.Visible = false;
				Domyszni_jezyk.Visible = false;
				Sprawc.Visible = false;
				Zmania_jezyka.Visible = false;
				Liczba_Punktu.Visible = false;
				Czas.Visible = false;
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
				pictureBox3.Visible = false;
				dodawanie_hajsu.Visible = false;

				//zmiana cofnienia
				zmania = false;

				//unit Visible is true
				Unit_2.Visible = true;
				Unity_1.Visible = true;

				Slownik.Visible = true;

				//restart
				teraz_jest_te_unit = null;
				Zmania_jezyka.Text = "";
				liczba_punktu = 0;

				//dodawanie hajsu
				hajs.Text = (Convert.ToInt32(hajs.Text) + Convert.ToInt32(dodawanie_hajsu.Text)).ToString();
				//resat dodakowy hajsu
				dodawanie_hajsu.Text = "0";
			}
		}
		/// <summary>
		/// start nauki
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Start_Click(object sender, EventArgs e)
		{
			//start
			Start1.Visible = false;
			Start.Visible = false;

			//flaga visible 
			Pl.Visible = true;
			Eng.Visible = true;

			cena_kraju_pl.Visible = true;
			cena_kraju_eng.Visible = true;

			//zmięna opcie cofania
			start_bool = true;

		}
		/// <summary>
		/// kiedy naciskamy Enter to przechodzi dalej
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Zmania_jezyka_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Sprawć_wynik();
			}
		}
		/// <summary>
		/// obliczas czas do konca 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Timer1_Tick(object sender, EventArgs e)
		{

			//czas o 100ms
			if (czas > 0.1f)
			{
				czas -= 0.19f;
				Czas.Text = (czas.ToString() + "000").Remove(4);
			}
			else if (czas < 0.1f)
			{
				Czas.Text = "0";
				czas = 15f;
				timer1.Enabled = false;
				życię = 1;
				Inny_jezyk.Text = unit_1_Eng.Slowa(kontorla.random);
				Zycie();
			}
		}
		/// <summary>
		/// start gry Unit 1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Unit_1_kurs_Click(object sender, EventArgs e)
		{

			//restart
			Liczba_Punktu.Text = "0";
			//właca gre
			Start_gry();

			//random słowo
			kontorla.Radmon_Zmana(nazwa_kraju, nazwa_unitu_1_kurs, ref Domyszni_jezyk, ref Inny_jezyk, ref Liczba_Punktu);
		}
		/// <summary>
		/// button do sprawdzania
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Sprawc_Click(object sender, EventArgs e)
		{
			Sprawć_wynik();
		}
		/// <summary>
		/// medota do sprawdzania
		/// </summary>
		private void Sprawć_wynik()
		{
			if (czy_kurs == false)
			{
				//sprawca czy do dobrze jest napiszany zdanie lub słowo
				if (kontorla.random_slowa == 0)
				{
					if (Zmania_jezyka.Text.Trim() == unit_1_Eng.Slowa(kontorla.random).Trim())
					{
						liczba_punktu += 1;
						Liczba_Punktu.Text = liczba_punktu.ToString();
					}
					else if (Zmania_jezyka.Text.Trim() != unit_1_Eng.Slowa(kontorla.random).Trim())
					{
						liczba_punktu -= 1;
						Liczba_Punktu.Text = liczba_punktu.ToString();
						Inny_jezyk.Text = unit_1_Eng.Slowa(kontorla.random);
						Zycie();
					}
				}
				else if (kontorla.random_slowa == 1)
				{
					if (Zmania_jezyka.Text.Trim() == unit_1_Eng.Zdania(kontorla.random).Trim())
					{
						liczba_punktu += 1;
						Liczba_Punktu.Text = liczba_punktu.ToString();
					}
					else if (Zmania_jezyka.Text.Trim() != unit_1_Eng.Zdania(kontorla.random).Trim())
					{
						liczba_punktu -= 1;
						Liczba_Punktu.Text = liczba_punktu.ToString();
						Inny_jezyk.Text = unit_1_Eng.Zdania(kontorla.random);
						Zycie();
					}
				}
				else if (kontorla.random_slowa == 2)
				{
					if (Zmania_jezyka.Text.Trim() == unit_1_Eng.Slowa_dodakowie(kontorla.random).Trim())
					{
						liczba_punktu += 1;
						Liczba_Punktu.Text = liczba_punktu.ToString();
						dobrze_napiszanie_słowa += 1;
					}
					else if (Zmania_jezyka.Text.Trim() != unit_1_Eng.Slowa_dodakowie(kontorla.random).Trim())
					{
						liczba_punktu -= 1;
						Liczba_Punktu.Text = liczba_punktu.ToString();
						Inny_jezyk.Text = unit_1_Eng.Slowa_dodakowie(kontorla.random);
						Zycie();
					}
				}

				Zmania_jezyka.Text = "";

				//sprawca czy punkt śa zmięcze od 0 jak tak to zabija
				if (liczba_punktu < 0)
				{
					życię = 1;
					Zycie();
					return;
				}

				//od nowa
				Zmiana_czasu();
				kontorla.Radmon_Zmana(nazwa_kraju, teraz_jest_te_unit, ref Domyszni_jezyk, ref Inny_jezyk, ref Liczba_Punktu);

			}
			else if (czy_kurs == true)
			{
				//sprawca czy do dobrze jest napiszany zdanie lub słowo
				if (Zmania_jezyka.Text.Trim() == unit_1_Eng.Slowa(kontorla.random).Trim())
				{
					liczba_punktu += 1;
					Liczba_Punktu.Text = liczba_punktu.ToString();
				}
				else if (Zmania_jezyka.Text.Trim() != unit_1_Eng.Slowa(kontorla.random).Trim())
				{
					liczba_punktu -= 1;
					Liczba_Punktu.Text = liczba_punktu.ToString();
					Inny_jezyk.Text = unit_1_Eng.Slowa(kontorla.random);
					Zycie();
				}

				Zmania_jezyka.Text = "";

				//sprawca czy punkt śa zmięcze od 0 jak tak to zabija
				if (liczba_punktu < 0)
				{
					życię = 1;
					Zycie();
					return;
				}

				//od nowa
				Zmiana_czasu();
				kontorla.Radmon_Zmana(nazwa_kraju, teraz_jest_te_unit, ref Domyszni_jezyk, ref Inny_jezyk, ref Liczba_Punktu);
			}
		}
		/// <summary>
		/// metoda do zmiany czasu
		/// </summary>
		private void Zmiana_czasu()
		{
			// włacza czas
			if (timer1.Enabled == false)
			{
				timer1.Enabled = true;
			}

			//zmięna czas od liczby punkitu
			if (Convert.ToInt32(Liczba_Punktu.Text) <= 10)
			{
				czas = 18f;
				dodawanie_hajsu.Text = "0";
			}
			else if (Convert.ToInt32(Liczba_Punktu.Text) <= 20 && Convert.ToInt32(Liczba_Punktu) > 10)
			{
				czas = 15f;
				dodawanie_hajsu.Text = "10";
			}
			else if (Convert.ToInt32(Liczba_Punktu.Text) > 20)
			{
				czas = 13f;
				dodawanie_hajsu.Text = "20";
			}

			// dodaje dodakowy hajs
			for (int a = 0; !(dobrze_napiszanie_słowa <= a); a++)
			{
				dodawanie_hajsu.Text = (Convert.ToInt32(dodawanie_hajsu.Text) + ile_dodakowy_hajs_dodac).ToString();
			}
		}

		/// <summary>
		/// medota do życia
		/// </summary>
		private void Zycie()
		{
			//życie 3 i śmierć
			if (życię == 1)
			{
				//start gry Visible is off
				Inny_jezyk.Visible = false;
				Domyszni_jezyk.Visible = false;
				Sprawc.Visible = false;
				Zmania_jezyka.Visible = false;
				Liczba_Punktu.Visible = false;
				timer1.Enabled = false;
				Czas.Visible = false;
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
				pictureBox3.Visible = false;
				zmania = false;
				dodawanie_hajsu.Visible = false;

				//Visible Unit
				Unity_1.Visible = true;
				Unit_1_kurs.Visible = true;
				Unit_2.Visible = true;

				Slownik.Visible = true;

				//liczba żyć jak zginieć
				życię = 3;

				//reset
				czy_kurs = false;
				teraz_jest_te_unit = null;
				Zmania_jezyka.Text = "";
				pictureBox1.Image = global::language_fast.Properties.Resources.serce;
				pictureBox2.Image = global::language_fast.Properties.Resources.serce;
				liczba_punktu = 0;

				//dodawanie hajsu
				hajs.Text = (Convert.ToInt32(hajs.Text) + Convert.ToInt32(dodawanie_hajsu.Text)).ToString();
				//resetowanie hajsu w poczas gry
				dodawanie_hajsu.Text = "0";
			}

			//życie 2
			else if (życię == 2) { pictureBox1.Image = global::language_fast.Properties.Resources.serce2; życię--; }

			//życie 1
			else if (życię == 3) { pictureBox2.Image = global::language_fast.Properties.Resources.serce2; życię--; }
		}

		/// <summary>
		/// medota do startu gry
		/// </summary>
		private void Start_gry()
		{
			//włacza gre
			Domyszni_jezyk.Visible = true;
			Sprawc.Visible = true;
			Zmania_jezyka.Visible = true;
			pictureBox1.Visible = true;
			pictureBox2.Visible = true;
			pictureBox3.Visible = true;
			Liczba_Punktu.Visible = true;
			Inny_jezyk.Visible = true;
			Czas.Visible = true;
			dodawanie_hajsu.Visible = true;

			//unit visible is off
			Unity_1.Visible = false;
			Unit_1_kurs.Visible = false;
			Unit_2.Visible = false;

			Slownik.Visible = false;

			//zmięna opcie cofania
			zmania = true;
		}

		private void Inne_ceny_kraju(int cena_metoda)
		{

		}// inny ceny kraju 
		/// <summary>
		/// przechodzi do menu angielskiego
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Eng_Click(object sender, EventArgs e)
		{
			int b = 0;

			//daje cenie
			if (kraje[0] != "free")
			{
				cena_kraju_numer[0] = "free";
				kraje[0] = "Eng";
				cena_kraju[0] = 1000;
			}
			else if (kraje[0] == "free")
			{
				foreach (string a in cena_kraju_numer)
				{
					if (a == "free") continue;

					b++;
					if (kraje[b] == "Eng")
					{
						break;
					}
					else if (a == null && Convert.ToInt32(hajs.Text) >= cena_kraju[b - 1])
					{
						cena_kraju_numer[b] = cena_kraju[b - 1].ToString();
						kraje[b] = "Eng";
						cena_kraju[b] = cena_kraju[b - 1] * 10;
						Inne_ceny_kraju(cena_kraju[b]);
					}
					else if (a == null && Convert.ToInt32(hajs.Text) < cena_kraju[b - 1])
					{
						cena_kraju_eng.Text = "za mało hajsu";
						return;
					}

				}
			}

			//flaga visible is off
			Pl.Visible = false;
			Eng.Visible = false;

			//zmięna cofniecie
			czowny = true;

			//daje nazwe i unit kraju
			nazwa_kraju = "eng";
			Nazwa(nazwa_kraju);

			//Visible Unitt
			Unity_1.Visible = true;
			Unit_1_kurs.Visible = true;
			Unit_2.Visible = true;

			Slownik.Visible = true;

			//cena Visible is off 
			cena_kraju_eng.Visible = false;
			cena_kraju_pl.Visible = false;
		}

		private void Nazwa(string kraj)
		{
			int b = 0;

			if (kraj == "eng")
			{
				// sprawć gdzie jest angielski
				foreach (string a in kraje)
				{
					if (a == "Eng")
					{
						break;
					}
					b++;
				}

				//czy angielski jest darmowy
				if (cena_kraju_numer[b] == "free")
				{
					//unit 1
					Unity_1.Text = "Unit 1 - " + cena_kraju_numer[b];
					nazwa_unitu_1 = "Unit 1";
					ile_dodakowy_hajs_dodac = 10;

					//Unity kurs
					Unit_1_kurs.Text = "Unit 1 kurs - " + cena_kraju_numer[b];
					nazwa_unitu_1_kurs = "Unit 1 kurs";

					//unit 2
					Unit_2.Text = "Unit 2  - " + (1000 / 10).ToString();
					nazwa_unitu_2 = "Unit 2";

					//słownik
					Slownik.Text += "1000";
				}
				// jak nie to zrob to
				else if (cena_kraju_numer[b] != "free")
				{
					//unit 1
					Unity_1.Text = "Unit 1 - " + cena_kraju_numer[b];
					nazwa_unitu_1 = "Unit 1";
					ile_dodakowy_hajs_dodac = cena_kraju[b - 1];

					Unit_1_kurs.Text = "Unit 1 kurs - " + cena_kraju_numer[b];
					nazwa_unitu_1_kurs = "Unit 1";

					//unit 2
					Unit_2.Text = "Unit 2 - " + (cena_kraju[b] / 10).ToString();
					nazwa_unitu_2 = "Unit 2";

					//słownik
					Slownik.Text += cena_kraju[b].ToString();
				}
			}
		}

		/// <summary>
		/// włacza unit 1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Unity_1_Click(object sender, EventArgs e)
		{
			//restart
			Liczba_Punktu.Text = "0";
			//właca gre
			Start_gry();

			//random słowo 
			kontorla.Radmon_Zmana(nazwa_kraju, nazwa_unitu_2, ref Domyszni_jezyk, ref Inny_jezyk, ref Liczba_Punktu);
		}
		/// <summary>
		/// włacza unit 1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Unit_2_Click(object sender, EventArgs e)
		{
			//restart
			Liczba_Punktu.Text = "0";
			//właca gre
			Start_gry();

			//random słowo 
			kontorla.Radmon_Zmana(nazwa_kraju, nazwa_unitu_2, ref Domyszni_jezyk, ref Inny_jezyk, ref Liczba_Punktu);
		}

	}
}
