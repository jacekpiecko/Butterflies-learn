﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Butterflies_learn
{
	public partial class Butterflies_Learn : Form
	{
		private  XVC xVC;
		/// <summary>
		/// przed właczeniem aplikacji
		/// </summary>
		public Butterflies_Learn()
		{
			// ustawia setting
			 xVC = new XVC();

			InitializeComponent();
		}


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
		/// jak kliniesz cofny to cofa się do menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Cofny_Click(object sender, EventArgs e)
		{
			if(Grupa_Menu_Flag.Visible == true)
			{
				// pokazuje menu
				Grupa_Menu.Visible = true;
				// ukrywa flagi
				Grupa_Menu_Flag.Visible = false;
				Pokaz_ceny(false);

				//ukrywa cofny
				Cofny.Visible = false;
			}
		}
		/// <summary>
		/// jak kliniesz flagie angielską
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Start_ENG_Click(object sender, EventArgs e)
		{
			if(Cena_Za_Angielski.Text == "Start")
			{

			}
			else if (Cena_Za_Angielski.Text == "free")
			{
				xVC.Kuponie_angielski = true;
			}
		}
		/// <summary>
		// początkowie łatowanie
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Butterflies_Learn_Load(object sender, EventArgs e)
		{
			

			// Ustawnia cenie
			#region cena
			if (xVC.cena == 0)
			{
				Cena_Za_Angielski.Text = "free";
			}
			#endregion

			//ustawia kuponie flagi
			#region kuponie
			//ustawia cenie angielskiego
			if (xVC.Kuponie_angielski == true)
				Cena_Za_Angielski.Text = "Start";
			else if (xVC.Czy_był_kupony > 0)
				Cena_Za_Angielski.Text = (xVC.Czy_był_kupony * 500).ToString();
			else
				Cena_Za_Angielski.Text = "Free";

			#endregion
		}
	}
}
