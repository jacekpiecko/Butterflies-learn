namespace Butterflies_learn
{
	partial class Butterflies_Learn
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Start = new System.Windows.Forms.Button();
			this.Start_POL = new System.Windows.Forms.PictureBox();
			this.Start_ENG = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.hajs = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.hajs_dodakowa = new System.Windows.Forms.Label();
			this.Exit = new System.Windows.Forms.Button();
			this.Grupa_Menu = new System.Windows.Forms.FlowLayoutPanel();
			this.Grupa_Menu_Flag = new System.Windows.Forms.FlowLayoutPanel();
			this.Cofny = new System.Windows.Forms.Button();
			this.Gruba_Startowa = new System.Windows.Forms.TableLayoutPanel();
			this.Sprawc = new System.Windows.Forms.Button();
			this.TlumaczeniePrzezUrzytkowinka = new System.Windows.Forms.TextBox();
			this.Inny_jezyk = new System.Windows.Forms.Label();
			this.dodawanie_hajsu = new System.Windows.Forms.Label();
			this.Grupa_serca = new System.Windows.Forms.FlowLayoutPanel();
			this.Serce_1 = new System.Windows.Forms.PictureBox();
			this.Serce_2 = new System.Windows.Forms.PictureBox();
			this.Serce_3 = new System.Windows.Forms.PictureBox();
			this.Liczba_Punktu = new System.Windows.Forms.Label();
			this.Slownik = new System.Windows.Forms.Label();
			this.Czas = new System.Windows.Forms.Label();
			this.CzasKoncza = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Cena_Za_Angielski = new System.Windows.Forms.Label();
			this.Cena_ZA_Polski = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Start_POL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Start_ENG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.Grupa_Menu.SuspendLayout();
			this.Grupa_Menu_Flag.SuspendLayout();
			this.Gruba_Startowa.SuspendLayout();
			this.Grupa_serca.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Serce_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Serce_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Serce_3)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Start
			// 
			this.Start.Location = new System.Drawing.Point(3, 3);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(75, 23);
			this.Start.TabIndex = 0;
			this.Start.Text = "Start";
			this.Start.UseVisualStyleBackColor = true;
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// Start_POL
			// 
			this.Start_POL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Start_POL.Image = global::Butterflies_learn.Properties.Resources.flaga_pl;
			this.Start_POL.Location = new System.Drawing.Point(3, 3);
			this.Start_POL.Name = "Start_POL";
			this.Start_POL.Size = new System.Drawing.Size(120, 70);
			this.Start_POL.TabIndex = 1;
			this.Start_POL.TabStop = false;
			// 
			// Start_ENG
			// 
			this.Start_ENG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Start_ENG.Image = global::Butterflies_learn.Properties.Resources.flaga_eng;
			this.Start_ENG.Location = new System.Drawing.Point(129, 3);
			this.Start_ENG.Name = "Start_ENG";
			this.Start_ENG.Size = new System.Drawing.Size(120, 70);
			this.Start_ENG.TabIndex = 2;
			this.Start_ENG.TabStop = false;
			this.Start_ENG.Click += new System.EventHandler(this.Start_ENG_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(3, 3);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(25, 25);
			this.pictureBox4.TabIndex = 14;
			this.pictureBox4.TabStop = false;
			// 
			// hajs
			// 
			this.hajs.AutoSize = true;
			this.hajs.Location = new System.Drawing.Point(50, 10);
			this.hajs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.hajs.Name = "hajs";
			this.hajs.Size = new System.Drawing.Size(13, 13);
			this.hajs.TabIndex = 13;
			this.hajs.Text = "0";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(188, 3);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(25, 25);
			this.pictureBox5.TabIndex = 15;
			this.pictureBox5.TabStop = false;
			// 
			// hajs_dodakowa
			// 
			this.hajs_dodakowa.AutoSize = true;
			this.hajs_dodakowa.Location = new System.Drawing.Point(224, 10);
			this.hajs_dodakowa.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.hajs_dodakowa.Name = "hajs_dodakowa";
			this.hajs_dodakowa.Size = new System.Drawing.Size(13, 13);
			this.hajs_dodakowa.TabIndex = 16;
			this.hajs_dodakowa.Text = "0";
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(3, 32);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 18;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// Grupa_Menu
			// 
			this.Grupa_Menu.Controls.Add(this.Start);
			this.Grupa_Menu.Controls.Add(this.Exit);
			this.Grupa_Menu.Location = new System.Drawing.Point(362, 12);
			this.Grupa_Menu.Name = "Grupa_Menu";
			this.Grupa_Menu.Size = new System.Drawing.Size(88, 100);
			this.Grupa_Menu.TabIndex = 19;
			// 
			// Grupa_Menu_Flag
			// 
			this.Grupa_Menu_Flag.Controls.Add(this.Start_POL);
			this.Grupa_Menu_Flag.Controls.Add(this.Start_ENG);
			this.Grupa_Menu_Flag.Location = new System.Drawing.Point(8, 45);
			this.Grupa_Menu_Flag.Name = "Grupa_Menu_Flag";
			this.Grupa_Menu_Flag.Size = new System.Drawing.Size(780, 100);
			this.Grupa_Menu_Flag.TabIndex = 20;
			this.Grupa_Menu_Flag.Visible = false;
			// 
			// Cofny
			// 
			this.Cofny.Location = new System.Drawing.Point(8, 227);
			this.Cofny.Name = "Cofny";
			this.Cofny.Size = new System.Drawing.Size(75, 23);
			this.Cofny.TabIndex = 21;
			this.Cofny.Text = "Cofny";
			this.Cofny.UseVisualStyleBackColor = true;
			this.Cofny.Visible = false;
			this.Cofny.Click += new System.EventHandler(this.Cofny_Click);
			// 
			// Gruba_Startowa
			// 
			this.Gruba_Startowa.ColumnCount = 4;
			this.Gruba_Startowa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.02156F));
			this.Gruba_Startowa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.97844F));
			this.Gruba_Startowa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
			this.Gruba_Startowa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
			this.Gruba_Startowa.Controls.Add(this.Sprawc, 1, 2);
			this.Gruba_Startowa.Controls.Add(this.TlumaczeniePrzezUrzytkowinka, 1, 1);
			this.Gruba_Startowa.Controls.Add(this.Inny_jezyk, 0, 1);
			this.Gruba_Startowa.Controls.Add(this.dodawanie_hajsu, 2, 2);
			this.Gruba_Startowa.Controls.Add(this.Grupa_serca, 2, 1);
			this.Gruba_Startowa.Controls.Add(this.Liczba_Punktu, 3, 1);
			this.Gruba_Startowa.Controls.Add(this.Slownik, 2, 0);
			this.Gruba_Startowa.Controls.Add(this.Czas, 3, 2);
			this.Gruba_Startowa.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Gruba_Startowa.Location = new System.Drawing.Point(0, 151);
			this.Gruba_Startowa.Name = "Gruba_Startowa";
			this.Gruba_Startowa.RowCount = 3;
			this.Gruba_Startowa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.47059F));
			this.Gruba_Startowa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.52941F));
			this.Gruba_Startowa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.Gruba_Startowa.Size = new System.Drawing.Size(800, 111);
			this.Gruba_Startowa.TabIndex = 23;
			this.Gruba_Startowa.Visible = false;
			// 
			// Sprawc
			// 
			this.Sprawc.Location = new System.Drawing.Point(304, 81);
			this.Sprawc.Name = "Sprawc";
			this.Sprawc.Size = new System.Drawing.Size(78, 27);
			this.Sprawc.TabIndex = 3;
			this.Sprawc.Text = "dalej";
			this.Sprawc.UseVisualStyleBackColor = true;
			this.Sprawc.Visible = false;
			// 
			// TlumaczeniePrzezUrzytkowinka
			// 
			this.TlumaczeniePrzezUrzytkowinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TlumaczeniePrzezUrzytkowinka.Location = new System.Drawing.Point(304, 31);
			this.TlumaczeniePrzezUrzytkowinka.Multiline = true;
			this.TlumaczeniePrzezUrzytkowinka.Name = "TlumaczeniePrzezUrzytkowinka";
			this.TlumaczeniePrzezUrzytkowinka.Size = new System.Drawing.Size(177, 32);
			this.TlumaczeniePrzezUrzytkowinka.TabIndex = 0;
			this.TlumaczeniePrzezUrzytkowinka.TabStop = false;
			this.TlumaczeniePrzezUrzytkowinka.Visible = false;
			// 
			// Inny_jezyk
			// 
			this.Inny_jezyk.AutoSize = true;
			this.Inny_jezyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Inny_jezyk.Location = new System.Drawing.Point(3, 28);
			this.Inny_jezyk.Name = "Inny_jezyk";
			this.Inny_jezyk.Size = new System.Drawing.Size(0, 25);
			this.Inny_jezyk.TabIndex = 1;
			this.Inny_jezyk.Visible = false;
			// 
			// dodawanie_hajsu
			// 
			this.dodawanie_hajsu.AutoSize = true;
			this.dodawanie_hajsu.Location = new System.Drawing.Point(581, 88);
			this.dodawanie_hajsu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.dodawanie_hajsu.Name = "dodawanie_hajsu";
			this.dodawanie_hajsu.Size = new System.Drawing.Size(13, 13);
			this.dodawanie_hajsu.TabIndex = 13;
			this.dodawanie_hajsu.Text = "0";
			// 
			// Grupa_serca
			// 
			this.Grupa_serca.Controls.Add(this.Serce_1);
			this.Grupa_serca.Controls.Add(this.Serce_2);
			this.Grupa_serca.Controls.Add(this.Serce_3);
			this.Grupa_serca.Location = new System.Drawing.Point(581, 31);
			this.Grupa_serca.Name = "Grupa_serca";
			this.Grupa_serca.Size = new System.Drawing.Size(138, 44);
			this.Grupa_serca.TabIndex = 7;
			// 
			// Serce_1
			// 
			this.Serce_1.Image = global::Butterflies_learn.Properties.Resources.serce;
			this.Serce_1.Location = new System.Drawing.Point(3, 3);
			this.Serce_1.Name = "Serce_1";
			this.Serce_1.Size = new System.Drawing.Size(40, 40);
			this.Serce_1.TabIndex = 7;
			this.Serce_1.TabStop = false;
			// 
			// Serce_2
			// 
			this.Serce_2.Image = global::Butterflies_learn.Properties.Resources.serce;
			this.Serce_2.Location = new System.Drawing.Point(49, 3);
			this.Serce_2.Name = "Serce_2";
			this.Serce_2.Size = new System.Drawing.Size(40, 40);
			this.Serce_2.TabIndex = 6;
			this.Serce_2.TabStop = false;
			// 
			// Serce_3
			// 
			this.Serce_3.Image = global::Butterflies_learn.Properties.Resources.serce;
			this.Serce_3.Location = new System.Drawing.Point(95, 3);
			this.Serce_3.Name = "Serce_3";
			this.Serce_3.Size = new System.Drawing.Size(40, 40);
			this.Serce_3.TabIndex = 8;
			this.Serce_3.TabStop = false;
			// 
			// Liczba_Punktu
			// 
			this.Liczba_Punktu.AutoSize = true;
			this.Liczba_Punktu.Location = new System.Drawing.Point(725, 28);
			this.Liczba_Punktu.Name = "Liczba_Punktu";
			this.Liczba_Punktu.Size = new System.Drawing.Size(13, 13);
			this.Liczba_Punktu.TabIndex = 4;
			this.Liczba_Punktu.Text = "0";
			// 
			// Slownik
			// 
			this.Slownik.AutoSize = true;
			this.Slownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Slownik.Location = new System.Drawing.Point(581, 0);
			this.Slownik.Name = "Slownik";
			this.Slownik.Size = new System.Drawing.Size(71, 18);
			this.Slownik.TabIndex = 14;
			this.Slownik.Text = "słownik - ";
			// 
			// Czas
			// 
			this.Czas.AutoSize = true;
			this.Czas.Location = new System.Drawing.Point(725, 78);
			this.Czas.Name = "Czas";
			this.Czas.Size = new System.Drawing.Size(22, 13);
			this.Czas.TabIndex = 5;
			this.Czas.Text = "0.0";
			// 
			// CzasKoncza
			// 
			this.CzasKoncza.Enabled = true;
			this.CzasKoncza.Interval = 1000;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.40541F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.5946F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.hajs, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.hajs_dodakowa, 3, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(504, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 34);
			this.tableLayoutPanel1.TabIndex = 24;
			// 
			// Cena_Za_Angielski
			// 
			this.Cena_Za_Angielski.AutoSize = true;
			this.Cena_Za_Angielski.BackColor = System.Drawing.SystemColors.Control;
			this.Cena_Za_Angielski.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Cena_Za_Angielski.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Cena_Za_Angielski.Location = new System.Drawing.Point(145, 100);
			this.Cena_Za_Angielski.Name = "Cena_Za_Angielski";
			this.Cena_Za_Angielski.Size = new System.Drawing.Size(21, 15);
			this.Cena_Za_Angielski.TabIndex = 25;
			this.Cena_Za_Angielski.Text = "00";
			this.Cena_Za_Angielski.Visible = false;
			this.Cena_Za_Angielski.Click += new System.EventHandler(this.Start_ENG_Click);
			// 
			// Cena_ZA_Polski
			// 
			this.Cena_ZA_Polski.AutoSize = true;
			this.Cena_ZA_Polski.BackColor = System.Drawing.SystemColors.Control;
			this.Cena_ZA_Polski.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Cena_ZA_Polski.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Cena_ZA_Polski.Location = new System.Drawing.Point(20, 100);
			this.Cena_ZA_Polski.Name = "Cena_ZA_Polski";
			this.Cena_ZA_Polski.Size = new System.Drawing.Size(71, 15);
			this.Cena_ZA_Polski.TabIndex = 26;
			this.Cena_ZA_Polski.Text = "zablokowany";
			this.Cena_ZA_Polski.Visible = false;
			// 
			// Butterflies_Learn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 262);
			this.Controls.Add(this.Cena_ZA_Polski);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.Cena_Za_Angielski);
			this.Controls.Add(this.Cofny);
			this.Controls.Add(this.Gruba_Startowa);
			this.Controls.Add(this.Grupa_Menu);
			this.Controls.Add(this.Grupa_Menu_Flag);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Butterflies_Learn";
			this.Text = "Butterflies learn";
			this.Load += new System.EventHandler(this.Butterflies_Learn_Load);
			((System.ComponentModel.ISupportInitialize)(this.Start_POL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Start_ENG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.Grupa_Menu.ResumeLayout(false);
			this.Grupa_Menu_Flag.ResumeLayout(false);
			this.Gruba_Startowa.ResumeLayout(false);
			this.Gruba_Startowa.PerformLayout();
			this.Grupa_serca.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Serce_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Serce_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Serce_3)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.PictureBox Start_POL;
		private System.Windows.Forms.PictureBox Start_ENG;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label hajs;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label hajs_dodakowa;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.FlowLayoutPanel Grupa_Menu;
		private System.Windows.Forms.FlowLayoutPanel Grupa_Menu_Flag;
		private System.Windows.Forms.Button Cofny;
		private System.Windows.Forms.TableLayoutPanel Gruba_Startowa;
		private System.Windows.Forms.Button Sprawc;
		private System.Windows.Forms.TextBox TlumaczeniePrzezUrzytkowinka;
		private System.Windows.Forms.Label Inny_jezyk;
		private System.Windows.Forms.Label dodawanie_hajsu;
		private System.Windows.Forms.FlowLayoutPanel Grupa_serca;
		private System.Windows.Forms.PictureBox Serce_1;
		private System.Windows.Forms.PictureBox Serce_2;
		private System.Windows.Forms.PictureBox Serce_3;
		private System.Windows.Forms.Label Liczba_Punktu;
		private System.Windows.Forms.Label Slownik;
		private System.Windows.Forms.Label Czas;
		private System.Windows.Forms.Timer CzasKoncza;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Cena_Za_Angielski;
		private System.Windows.Forms.Label Cena_ZA_Polski;
	}
}

