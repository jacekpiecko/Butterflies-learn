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
        private Unit_1_eng unit_1_Eng;
        private Unit_1_eng_pl unit_1_Eng_Pl;
        private Unit_2_eng_pl unit_2_Eng_Pl;
        private Unit_2_eng unit_2_Eng;


        private string teraz_jest_te_unit = null;
        private int stara_random = 0;
        private byte życię = 3;
        private byte dalej = 1;
        private int liczba_punktu = 0;
        private bool czy_kurs = false;
        //deklaracja Random;
        private Random rd;
        private string nazwa_kraju;
        
        public Kontorla_jezyka()
		{
            rd = new Random();
            unit_1_Eng = new Unit_1_eng();
            unit_1_Eng_Pl = new Unit_1_eng_pl();
            unit_2_Eng = new Unit_2_eng();
            unit_2_Eng_Pl = new Unit_2_eng_pl();
        }



        public int random { get; set; }
		public int random_slowa { get; set; }
		public void Radmon_Zmana(string kraj, string jaki_unit, ref Label Domyszni_jezyk, ref Label Inny_jezyk, ref Label domysli_liczba_punktuw)
		{
            

            //ustawan unit
           teraz_jest_te_unit = jaki_unit;

            //wyberanie języki
            if (kraj == "eng")
            {
                //wyberanie unit
                if (jaki_unit == "Unit 1")
                {

                    //daje randomowie opcje słowa
                    random_slowa = rd.Next(0, dalej);

                    //opcje słowa
                    if (random_slowa == 0)
                    {
                        //random zdanie i sprawdza czy zdanie nie jest takie samie
                        do
                        {
                            random = rd.Next(0, unit_1_Eng.liczba_slow + 1);
                        } while (stara_random != random);

                        //ustawia słowo
                        stara_random = random;
                        Domyszni_jezyk.Text = unit_1_Eng_Pl.Slowa(random);
                    }
                    else if (random_slowa == 2)
                    {
                        //random zdanie i sprawdza czy zdanie nie jest takie samie
                        do
                        {
                            random = rd.Next(0, unit_1_Eng.liczba_zdan + 1);
                        } while (stara_random != random);

                        //ustawia słowo
                        stara_random = random;
                        Domyszni_jezyk.Text = unit_1_Eng_Pl.Zdania(random);
                    }
                    else if (random_slowa == 3)
                    {
                        //random zdanie i sprawdza czy zdanie nie jest takie samie
                        do
                        {
                            random = rd.Next(0, unit_1_Eng.liczba_dodakowych_slow + 1);
                        } while (stara_random != random);


                        //ustawia słowo
                        stara_random = random;
                        Domyszni_jezyk.Text = unit_1_Eng_Pl.Slowa_dodakowie(random);
                    }

                    //sprawc ile jest punktu
                    if (domysli_liczba_punktuw.Text == "20" && dalej == 1) dalej++;
                    else if (domysli_liczba_punktuw.Text == "40" && dalej == 2) dalej++;
                    else if (dalej != 1 && Convert.ToInt32(domysli_liczba_punktuw) > 20) dalej--;
                    else if (dalej != 2 && Convert.ToInt32(domysli_liczba_punktuw) > 40) dalej--;

                    //spawca czy nie jest błąd
                    if (random_slowa == 0)
                    {
                        if (unit_1_Eng.Slowa(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + random.ToString();
                        else if (unit_1_Eng_Pl.Slowa(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + random.ToString();
                    }
                    else if (random_slowa == 1)
                    {
                        if (unit_1_Eng.Zdania(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + random.ToString();
                        else if (unit_1_Eng_Pl.Zdania(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + random.ToString();
                    }
                    else if (random_slowa == 2)
                    {
                        if (unit_1_Eng.Slowa_dodakowie(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + random.ToString();
                        else if (unit_1_Eng_Pl.Slowa_dodakowie(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + random.ToString();
                    }

                    return;
                }
                if (jaki_unit == "Unit 1 kurs")
                {
                //opcje słowa

                od_nowa:

                    //random słowo
                    random = rd.Next(0, unit_1_Eng.liczba_slow + 1);

                    //czy słowo jest takie sam jak tamte
                    if (stara_random == random) goto od_nowa;

                    //ustawia słowo
                    stara_random = random;
                    Domyszni_jezyk.Text = unit_1_Eng.Slowa(random);
                    Inny_jezyk.Text = unit_1_Eng_Pl.Slowa(random);
                    czy_kurs = true;

                    //spawca czy nie jest błąd
                    if (unit_1_Eng.Slowa(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + random.ToString();
                    else if (unit_1_Eng_Pl.Slowa(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + random.ToString();


                    return;
                }
                else if (jaki_unit == "Unit 2")
                {
                    //daje randomowie opcje słowa
                    random_slowa = rd.Next(0, dalej);

                    //opcje słowa
                    if (random_slowa == 0)
                    {
                    od_nowa:

                        //random słowo
                        random = rd.Next(0, unit_2_Eng.liczba_slow + 1);

                        //czy słowo jest takie sam jak tamte
                        if (stara_random == random) goto od_nowa;

                        //ustawia słowo
                        stara_random = random;
                        Domyszni_jezyk.Text = unit_2_Eng_Pl.Slowa(random);
                    }
                    else if (random_slowa == 2)
                    {
                    od_nowa:

                        //random zdanie
                        random = rd.Next(0, unit_2_Eng.liczba_zdan + 1);

                        //czy zdanie jest takie sam jak tamte
                        if (stara_random == random) goto od_nowa;

                        //ustawia słowo
                        stara_random = random;
                        Domyszni_jezyk.Text = unit_2_Eng_Pl.Zdania(random);
                    }
                    else if (random_slowa == 3)
                    {
                    od_nowa:

                        //random słowo
                        random = rd.Next(0, unit_2_Eng.liczba_dodakowych_slow + 1);

                        //czy słowo jest takie sam jak tamte
                        if (stara_random == random) goto od_nowa;

                        //ustawia słowo
                        stara_random = random;
                        Domyszni_jezyk.Text = unit_2_Eng_Pl.Slowa_dodakowie(random);
                    }

                    //sprawc ile jest punktu
                    if (domysli_liczba_punktuw.Text == "20" && dalej == 1) dalej++;
                    else if (domysli_liczba_punktuw.Text == "40" && dalej == 2) dalej++;
                    else if (dalej != 2 && Convert.ToInt32(domysli_liczba_punktuw.Text) > 20) dalej--;
                    else if (dalej != 3 && Convert.ToInt32(domysli_liczba_punktuw.Text) > 40) dalej--;

                    //spawca czy nie jest błąd
                    if (random_slowa == 0)
                    {
                        if (unit_2_Eng.Slowa(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + random.ToString();
                        else if (unit_2_Eng_Pl.Slowa(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + random.ToString();
                    }
                    else if (random_slowa == 1)
                    {
                        if (unit_2_Eng.Zdania(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + random.ToString();
                        else if (unit_2_Eng_Pl.Zdania(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + random.ToString();
                    }
                    else if (random_slowa == 2)
                    {
                        if (unit_2_Eng.Slowa_dodakowie(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng numer błedu: 0001 numer:" + random.ToString();
                        else if (unit_2_Eng_Pl.Slowa_dodakowie(random) == " ") Domyszni_jezyk.Text = "error Unit_1_eng_pl numer błedu: 0001 numer:" + random.ToString();
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
