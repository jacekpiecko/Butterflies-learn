using System;
using System.Windows.Forms;

using Eng;

using PLN
	;
namespace Kontorla
{
	public class Kontorla_jezyka
	{
		public bool Sprawcz_EngDoPOl(Unit_1_eng unit_1_Eng)
		{
			Unit_1_eng_pl unit_1_Eng_Pl = new Unit_1_eng_pl();
			if (unit_1_Eng.Slowna(unit_1_Eng.A) == unit_1_Eng_Pl.Slowa_sprawcz(unit_1_Eng.A))
			{
				return true;
			}

			return false;
		}
	}
}
