using System;
using System.Windows.Forms;

using Eng;

using language_fast.jezyk.eng;

using PLN
	;
namespace Kontorla
{
	public class Kontorla_jezyka
	{
		private readonly Unit_1_eng unit_1_Eng;
		private readonly Unit_1_eng_pl unit_1_Eng_Pl;
		private readonly Unit_2_eng_pl unit_2_Eng_Pl;
		private readonly Unit_2_eng unit_2_Eng;


		private int stara_Random = 0;
		private byte dalej = 1;
		//deklaracja Random;
		private readonly Random rd;
		private readonly string nazwa_kraju;

		public Kontorla_jezyka()
		{
			rd = new Random();
			unit_1_Eng = new Unit_1_eng();
			unit_1_Eng_Pl = new Unit_1_eng_pl();
			unit_2_Eng = new Unit_2_eng();
			unit_2_Eng_Pl = new Unit_2_eng_pl();
		}



		public int Random { get; set; }
		public int Random_slowa { get; set; }
		public void Radmon_Zmana(string kraj, string jaki_unit, ref Label Domyszni_jezyk, ref Label Inny_jezyk, ref Label domysli_liczba_punktuw)
		{


			//wyberanie języki
			if (kraj == "eng")
			{
				//wyberanie unit
				if (jaki_unit == "Unit 1")
				{

					//daje Randomowie opcje słowa
					Random_slowa = rd.Next(0, dalej);

					//opcje słowa
					if (Random_slowa == 0)
					{
						//Random zdanie i sprawdza czy zdanie nie jest takie samie
						do
						{
							Random = rd.Next(0, unit_1_Eng.liczba_slow + 1);
						} while (stara_Random != Random);

						//ustawia słowo
						stara_Random = Random;
						Domyszni_jezyk.Text = unit_1_Eng_Pl.Slowa(Random);
					}
					else if (Random_slowa == 2)
					{
						//Random zdanie i sprawdza czy zdanie nie jest takie samie
						do
						{
							Random = rd.Next(0, unit_1_Eng.liczba_zdan + 1);
						} while (stara_Random != Random);

						//ustawia słowo
						stara_Random = Random;
						Domyszni_jezyk.Text = unit_1_Eng_Pl.Zdania(Random);
					}
					else if (Random_slowa == 3)
					{
						//Random zdanie i sprawdza czy zdanie nie jest takie samie
						do
						{
							Random = rd.Next(0, unit_1_Eng.liczba_dodakowych_slow + 1);
						} while (stara_Random != Random);


						//ustawia słowo
						stara_Random = Random;
						Domyszni_jezyk.Text = unit_1_Eng_Pl.Slowa_dodakowie(Random);
					}

					//sprawc ile jest punktu
					if (domysli_liczba_punktuw.Text == "20" && dalej == 1) dalej++;
					else if (domysli_liczba_punktuw.Text == "40" && dalej == 2) dalej++;
					else if (dalej != 1 && Convert.ToInt32(domysli_liczba_punktuw) > 20) dalej--;
					else if (dalej != 2 && Convert.ToInt32(domysli_liczba_punktuw) > 40) dalej--;

					//spawca czy nie jest błąd
					if (Random_slowa == 0)
					{
						if (unit_1_Eng.Slowa(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + Random.ToString();
						else if (unit_1_Eng_Pl.Slowa(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + Random.ToString();
					}
					else if (Random_slowa == 1)
					{
						if (unit_1_Eng.Zdania(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + Random.ToString();
						else if (unit_1_Eng_Pl.Zdania(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + Random.ToString();
					}
					else if (Random_slowa == 2)
					{
						if (unit_1_Eng.Slowa_dodakowie(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + Random.ToString();
						else if (unit_1_Eng_Pl.Slowa_dodakowie(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + Random.ToString();
					}

					return;
				}
				if (jaki_unit == "Unit 1 kurs")
				{
				//opcje słowa

				od_nowa:

					//Random słowo
					Random = rd.Next(0, unit_1_Eng.liczba_slow + 1);

					//czy słowo jest takie sam jak tamte
					if (stara_Random == Random) goto od_nowa;

					//ustawia słowo
					stara_Random = Random;
					Domyszni_jezyk.Text = unit_1_Eng.Slowa(Random);
					Inny_jezyk.Text = unit_1_Eng_Pl.Slowa(Random);

					//spawca czy nie jest błąd
					if (unit_1_Eng.Slowa(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + Random.ToString();
					else if (unit_1_Eng_Pl.Slowa(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + Random.ToString();


					return;
				}
				else if (jaki_unit == "Unit 2")
				{
					//daje Randomowie opcje słowa
					Random_slowa = rd.Next(0, dalej);

					//opcje słowa
					if (Random_slowa == 0)
					{
					od_nowa:

						//Random słowo
						Random = rd.Next(0, unit_2_Eng.liczba_slow + 1);

						//czy słowo jest takie sam jak tamte
						if (stara_Random == Random) goto od_nowa;

						//ustawia słowo
						stara_Random = Random;
						Domyszni_jezyk.Text = unit_2_Eng_Pl.Slowa(Random);
					}
					else if (Random_slowa == 2)
					{
					od_nowa:

						//Random zdanie
						Random = rd.Next(0, unit_2_Eng.liczba_zdan + 1);

						//czy zdanie jest takie sam jak tamte
						if (stara_Random == Random) goto od_nowa;

						//ustawia słowo
						stara_Random = Random;
						Domyszni_jezyk.Text = unit_2_Eng_Pl.Zdania(Random);
					}
					else if (Random_slowa == 3)
					{
					od_nowa:

						//Random słowo
						Random = rd.Next(0, unit_2_Eng.liczba_dodakowych_slow + 1);

						//czy słowo jest takie sam jak tamte
						if (stara_Random == Random) goto od_nowa;

						//ustawia słowo
						stara_Random = Random;
						Domyszni_jezyk.Text = unit_2_Eng_Pl.Slowa_dodakowie(Random);
					}

					//sprawc ile jest punktu
					if (domysli_liczba_punktuw.Text == "20" && dalej == 1) dalej++;
					else if (domysli_liczba_punktuw.Text == "40" && dalej == 2) dalej++;
					else if (dalej != 2 && Convert.ToInt32(domysli_liczba_punktuw.Text) > 20) dalej--;
					else if (dalej != 3 && Convert.ToInt32(domysli_liczba_punktuw.Text) > 40) dalej--;

					//spawca czy nie jest błąd
					if (Random_slowa == 0)
					{
						if (unit_2_Eng.Slowa(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + Random.ToString();
						else if (unit_2_Eng_Pl.Slowa(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + Random.ToString();
					}
					else if (Random_slowa == 1)
					{
						if (unit_2_Eng.Zdania(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + Random.ToString();
						else if (unit_2_Eng_Pl.Zdania(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + Random.ToString();
					}
					else if (Random_slowa == 2)
					{
						if (unit_2_Eng.Slowa_dodakowie(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + Random.ToString();
						else if (unit_2_Eng_Pl.Slowa_dodakowie(Random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + Random.ToString();
					}

					return;
				}
				else
				{
					Domyszni_jezyk.Text = "błąd unitu " + nazwa_kraju + " 0002";
				}
			}
		}
	}
}
