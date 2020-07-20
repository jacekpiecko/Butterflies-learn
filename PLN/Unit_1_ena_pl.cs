using System;

namespace PLN
{
	public class Unit_1_eng_pl
	{

		byte _a;
		readonly Random random = new Random();
		public byte A { get { return _a; } private set { _a = value; } }
		/// <summary>
		/// ustawia radomowie słowo
		/// </summary>
		/// <returns></returns>
		public string Slowa()
		{
			//radomowa liczba do 50
			A = (byte)random.Next(50);
			//radowa liczba
			return Slowa_(A);
		}

		/// <summary>
		/// głownia metoda slowna
		/// </summary>
		/// <param name="liczba"></param>
		/// <returns></returns>
		public string Slowa(byte liczba)
		{
			// ustawia liczbe do pamiecy
			A = liczba;

			//sprawdza czy liczba jest do 50 
			return Slowa_(A);

		}
		/// <summary>
		/// wysyła Slowo do metody sprawdz. Nie używacz tego
		/// </summary>
		/// <param name="liczba"></param>
		/// <returns></returns>
		public string Slowa_sprawcz(byte liczba)
		{
			//sprawdza czy liczba jest do 50 
			return Slowa_(liczba);
		}

		/// <summary>
		/// ustawa liczby
		/// </summary>
		/// <param name="slowa"></param>
		/// <returns></returns>
		private string Slowa_(byte slowa)
		{
			switch (slowa)
			{
				case 1:
					return "i, a";
				case 2:
					return "do";
				case 3:
					return "w";
				case 4:
					return "jest";
				case 5:
					return "ty";
				case 6:
					return "te, że, który";
				case 7:
					return "to, ono";
				case 8:
					return "on";
				case 9:
					return "był/była, byłem/byłam";
				case 10:
					return "dla, za";
				case 11:
					return "na, przy, u";
				case 12:
					return "są";
				case 13:
					return "jako, jak";
				case 14:
					return "z";
				case 15:
					return "jego";
				case 16:
					return "oni, ci";
				case 17:
					return "ja";
				case 18:
					return "na, w";
				case 19:
					return "być, bądź";
				case 20:
					return "ten, to";
				case 21:
					return "miałem, miałam";
				case 22:
					return "mieć";
				case 23:
					return "od, z";
				case 24:
					return "albo, lub";
				case 25:
					return "jeden";
				case 26:
					return "przez, przy";
				case 27:
					return "słowo";
				case 28:
					return "ale, oprócz";
				case 29:
					return "nie";
				case 30:
					return "co, jaki";
				case 31:
					return "wszystko, wszyscy";
				case 32:
					return "byli/były, byliśmy/byłyśmy";
				case 33:
					return "my";
				case 34:
					return "kiedy";
				case 35:
					return "twój, wasz";
				case 36:
					return "móc";
				case 37:
					return "powiedziałem";
				case 38:
					return "tam";
				case 39:
					return "użyć";
				case 40:
					return "każdy";
				case 41:
					return "który/która";
				case 42:
					return "ona";
				case 43:
					return "robić, zrobić";
				case 44:
					return "jak";
				case 45:
					return "ich";
				case 46:
					return "jeśli, gdyby";
				case 47:
					return "byłem";
				case 48:
					return "w górę";
				case 49:
					return "inny, inaczej";
				case 50:
					return "o";
				default:
					return ""; // wysyła błąd
			}
		}
	}
}