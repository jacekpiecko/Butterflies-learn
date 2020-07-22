using System;
using System.Linq;

namespace Eng
{
	public class Unit_1_eng
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

			 switch(slowa)
			{
				case 1:
					return "and";
				case 2:
					return "to";
				case 3:
					return "in";
				case 4:
					return "is";
				case 5:
					return "you";
				case 6:
					return "that";
				case 7:
					return "it";
				case 8:
					return "he";
				case 9:
					return "was";
				case 10:
					return   "for";
				case 11:
					return   "on";
				case 12:
					return   "are";
				case 13:
					return   "as";
				case 14:
					return "with";
				case 15:
					return "his";
				case 16:
					return "they";
				case 17:
					return "I";
				case 18:
					return "at";
				case 19:
					return "be";
				case 20:
					return "this";
				case 21:
					return "had";
				case 22:
					return "have";
				case 23:
					return "from";
				case 24:
					return "or";
				case 25:
					return "one";
				case 26:
					return "by";
				case 27:
					return "word";
				case 28:
					return "but";
				case 29:
					return "not";
				case 30:
					return "what";
				case 31:
					return "all";
				case 32:
					return "were";
				case 33:
					return "we";
				case 34:
					return "when";
				case 35:
					return "your";
				case 36:
					return "can";
				case 37:
					return "said";
				case 38:
					return "there";
				case 39:
					return "use";
				case 40:
					return "each";
				case 41:
					return "which";
				case 42:
					return "she";
				case 43:
					return "do";
				case 44:
					return "how";
				case 45:
					return "their";
				case 46:
					return "if";
				case 47:
					return "will";
				case 48:
					return "up";
				case 49:
					return "other";
				case 50:
					return "about";
				default:
					return ""; // wysyła błąd
			}
		}

	}
}
