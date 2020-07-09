using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butterflies_learn
{
	public partial class Butterflies_Learn : Form
	{
		public Butterflies_Learn()
		{
			InitializeComponent();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Start_Click(object sender, EventArgs e)
		{
			Grupa_Menu_Flag.Visible = true;
			Grupa_Menu.Visible = false;
			Cofny.Visible = true;
		}

		private void Cofny_Click(object sender, EventArgs e)
		{
			if(Grupa_Menu_Flag.Visible == true)
			{
				Grupa_Menu.Visible = true;
				Grupa_Menu_Flag.Visible = false;
				Cofny.Visible = false;
			}
		}
	}
}
