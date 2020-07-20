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
		public string Slowna()
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
		public string Slowna(byte liczba)
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
			return slowa switch
			{

				1 => "and",
				2 => "to",
				3 => "in",
				4 => "is",
				5 => "you",
				6 => "that",
				7 => "it",
				8 => "he",
				9 => "was",
				10 => "for",
				11 => "on",
				12 => "are",
				13 => "as",
				14 => "with",
				15 => "his",
				16 => "they",
				17 => "I",
				18 => "at",
				19 => "be",
				20 => "this",
				21 => "had",
				22 => "have",
				23 => "from",
				24 => "or",
				25 => "one",
				26 => "by",
				27 => "word",
				28 => "but",
				29 => "not",
				30 => "what",
				31 => "all",
				32 => "were",
				33 => "we",
				34 => "when",
				35 => "your",
				36 => "can",
				37 => "said",
				38 => "there",
				39 => "use",
				40 => "each",
				41 => "which",
				42 => "she",
				43 => "do",
				44 => "how",
				45 => "their",
				46 => "if",
				47 => "will",
				48 => "up",
				49 => "other",
				50 => "about",
				_ => "" // wysyła błąd
			};
		}

	}
}
