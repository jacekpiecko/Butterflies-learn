namespace language_fast
{
    partial class Form1
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.Exit1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.Pelny = new System.Windows.Forms.PictureBox();
			this.Start = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.hajs = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.hajs_dodakowa = new System.Windows.Forms.Label();
			this.Start1 = new System.Windows.Forms.Button();
			this.Unity_1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Sprawc = new System.Windows.Forms.Button();
			this.Domyszni_jezyk = new System.Windows.Forms.Label();
			this.Zmania_jezyka = new System.Windows.Forms.TextBox();
			this.Inny_jezyk = new System.Windows.Forms.Label();
			this.dodawanie_hajsu = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.Czas = new System.Windows.Forms.Label();
			this.Liczba_Punktu = new System.Windows.Forms.Label();
			this.Slownik = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Eng = new System.Windows.Forms.PictureBox();
			this.Pl = new System.Windows.Forms.PictureBox();
			this.cena_kraju_pl = new System.Windows.Forms.Label();
			this.cena_kraju_eng = new System.Windows.Forms.Label();
			this.Unit_2 = new System.Windows.Forms.Label();
			this.Unit_1_kurs = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Pelny)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Eng)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Pl)).BeginInit();
			this.SuspendLayout();
			// 
			// Exit1
			// 
			this.Exit1.Location = new System.Drawing.Point(3, 3);
			this.Exit1.Name = "Exit1";
			this.Exit1.Size = new System.Drawing.Size(75, 23);
			this.Exit1.TabIndex = 1;
			this.Exit1.Text = "Exit";
			this.Exit1.UseVisualStyleBackColor = true;
			this.Exit1.Click += new System.EventHandler(this.Exit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Controls.Add(this.Exit1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 506);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(820, 30);
			this.panel1.TabIndex = 6;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.Pelny);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(788, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(32, 30);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// Pelny
			// 
			this.Pelny.BackColor = System.Drawing.Color.Red;
			this.Pelny.Image = global::language_fast.Properties.Resources.pelny;
			this.Pelny.Location = new System.Drawing.Point(3, 3);
			this.Pelny.Name = "Pelny";
			this.Pelny.Size = new System.Drawing.Size(24, 21);
			this.Pelny.TabIndex = 0;
			this.Pelny.TabStop = false;
			this.Pelny.Click += new System.EventHandler(this.Rozmiar_ekranu);
			// 
			// Start
			// 
			this.Start.AutoSize = true;
			this.Start.Location = new System.Drawing.Point(201, 3);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(59, 27);
			this.Start.TabIndex = 4;
			this.Start.Text = "start";
			this.Start.UseVisualStyleBackColor = true;
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.62555F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.37445F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.Start, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Start1, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 42);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.pictureBox4);
			this.flowLayoutPanel3.Controls.Add(this.hajs);
			this.flowLayoutPanel3.Controls.Add(this.pictureBox5);
			this.flowLayoutPanel3.Controls.Add(this.hajs_dodakowa);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(621, 3);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(196, 36);
			this.flowLayoutPanel3.TabIndex = 12;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(3, 3);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(25, 25);
			this.pictureBox4.TabIndex = 1;
			this.pictureBox4.TabStop = false;
			// 
			// hajs
			// 
			this.hajs.AutoSize = true;
			this.hajs.Location = new System.Drawing.Point(34, 10);
			this.hajs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.hajs.Name = "hajs";
			this.hajs.Size = new System.Drawing.Size(13, 13);
			this.hajs.TabIndex = 0;
			this.hajs.Text = "0";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(53, 3);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(25, 25);
			this.pictureBox5.TabIndex = 2;
			this.pictureBox5.TabStop = false;
			// 
			// hajs_dodakowa
			// 
			this.hajs_dodakowa.AutoSize = true;
			this.hajs_dodakowa.Location = new System.Drawing.Point(84, 10);
			this.hajs_dodakowa.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.hajs_dodakowa.Name = "hajs_dodakowa";
			this.hajs_dodakowa.Size = new System.Drawing.Size(13, 13);
			this.hajs_dodakowa.TabIndex = 12;
			this.hajs_dodakowa.Text = "0";
			// 
			// Start1
			// 
			this.Start1.AutoSize = true;
			this.Start1.Location = new System.Drawing.Point(402, 3);
			this.Start1.Name = "Start1";
			this.Start1.Size = new System.Drawing.Size(67, 27);
			this.Start1.TabIndex = 5;
			this.Start1.Text = "start";
			this.Start1.UseVisualStyleBackColor = true;
			this.Start1.Visible = false;
			this.Start1.Click += new System.EventHandler(this.Start_Click);
			// 
			// Unity_1
			// 
			this.Unity_1.AutoSize = true;
			this.Unity_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Unity_1.Location = new System.Drawing.Point(12, 69);
			this.Unity_1.Name = "Unity_1";
			this.Unity_1.Size = new System.Drawing.Size(31, 18);
			this.Unity_1.TabIndex = 10;
			this.Unity_1.Text = "text";
			this.Unity_1.Visible = false;
			this.Unity_1.Click += new System.EventHandler(this.Unity_1_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.02156F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.97844F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel2.Controls.Add(this.Sprawc, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.Domyszni_jezyk, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.Zmania_jezyka, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.Inny_jezyk, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.dodawanie_hajsu, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.Czas, 3, 2);
			this.tableLayoutPanel2.Controls.Add(this.Liczba_Punktu, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.Slownik, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 395);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.47059F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.52941F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 111);
			this.tableLayoutPanel2.TabIndex = 11;
			// 
			// Sprawc
			// 
			this.Sprawc.Location = new System.Drawing.Point(315, 81);
			this.Sprawc.Name = "Sprawc";
			this.Sprawc.Size = new System.Drawing.Size(78, 27);
			this.Sprawc.TabIndex = 3;
			this.Sprawc.Text = "dalej";
			this.Sprawc.UseVisualStyleBackColor = true;
			this.Sprawc.Visible = false;
			this.Sprawc.Click += new System.EventHandler(this.Sprawc_Click);
			// 
			// Domyszni_jezyk
			// 
			this.Domyszni_jezyk.AutoSize = true;
			this.Domyszni_jezyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Domyszni_jezyk.Location = new System.Drawing.Point(3, 78);
			this.Domyszni_jezyk.Name = "Domyszni_jezyk";
			this.Domyszni_jezyk.Size = new System.Drawing.Size(70, 25);
			this.Domyszni_jezyk.TabIndex = 2;
			this.Domyszni_jezyk.Text = "label2";
			this.Domyszni_jezyk.Visible = false;
			// 
			// Zmania_jezyka
			// 
			this.Zmania_jezyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Zmania_jezyka.Location = new System.Drawing.Point(315, 31);
			this.Zmania_jezyka.Multiline = true;
			this.Zmania_jezyka.Name = "Zmania_jezyka";
			this.Zmania_jezyka.Size = new System.Drawing.Size(177, 32);
			this.Zmania_jezyka.TabIndex = 0;
			this.Zmania_jezyka.TabStop = false;
			this.Zmania_jezyka.Visible = false;
			this.Zmania_jezyka.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Zmania_jezyka_KeyUp);
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
			this.dodawanie_hajsu.Location = new System.Drawing.Point(603, 88);
			this.dodawanie_hajsu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.dodawanie_hajsu.Name = "dodawanie_hajsu";
			this.dodawanie_hajsu.Size = new System.Drawing.Size(13, 13);
			this.dodawanie_hajsu.TabIndex = 13;
			this.dodawanie_hajsu.Text = "0";
			this.dodawanie_hajsu.Visible = false;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
			this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel2.Controls.Add(this.pictureBox3);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(603, 31);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(138, 44);
			this.flowLayoutPanel2.TabIndex = 7;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::language_fast.Properties.Resources.serce;
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 40);
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::language_fast.Properties.Resources.serce;
			this.pictureBox1.Location = new System.Drawing.Point(49, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 40);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::language_fast.Properties.Resources.serce;
			this.pictureBox3.Location = new System.Drawing.Point(95, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(40, 40);
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			// 
			// Czas
			// 
			this.Czas.AutoSize = true;
			this.Czas.Location = new System.Drawing.Point(747, 78);
			this.Czas.Name = "Czas";
			this.Czas.Size = new System.Drawing.Size(22, 13);
			this.Czas.TabIndex = 5;
			this.Czas.Text = "0.0";
			this.Czas.Visible = false;
			// 
			// Liczba_Punktu
			// 
			this.Liczba_Punktu.AutoSize = true;
			this.Liczba_Punktu.Location = new System.Drawing.Point(747, 28);
			this.Liczba_Punktu.Name = "Liczba_Punktu";
			this.Liczba_Punktu.Size = new System.Drawing.Size(13, 13);
			this.Liczba_Punktu.TabIndex = 4;
			this.Liczba_Punktu.Text = "0";
			this.Liczba_Punktu.Visible = false;
			// 
			// Slownik
			// 
			this.Slownik.AutoSize = true;
			this.Slownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Slownik.Location = new System.Drawing.Point(603, 0);
			this.Slownik.Name = "Slownik";
			this.Slownik.Size = new System.Drawing.Size(71, 18);
			this.Slownik.TabIndex = 14;
			this.Slownik.Text = "słownik - ";
			this.Slownik.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// Eng
			// 
			this.Eng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.Eng.Image = global::language_fast.Properties.Resources.flaga_eng;
			this.Eng.InitialImage = null;
			this.Eng.Location = new System.Drawing.Point(138, 58);
			this.Eng.Name = "Eng";
			this.Eng.Size = new System.Drawing.Size(120, 70);
			this.Eng.TabIndex = 9;
			this.Eng.TabStop = false;
			this.Eng.Visible = false;
			this.Eng.Click += new System.EventHandler(this.Eng_Click);
			// 
			// Pl
			// 
			this.Pl.BackColor = System.Drawing.Color.Red;
			this.Pl.Cursor = System.Windows.Forms.Cursors.No;
			this.Pl.Image = global::language_fast.Properties.Resources.flaga_pl;
			this.Pl.Location = new System.Drawing.Point(15, 58);
			this.Pl.Name = "Pl";
			this.Pl.Size = new System.Drawing.Size(120, 70);
			this.Pl.TabIndex = 8;
			this.Pl.TabStop = false;
			this.Pl.Visible = false;
			// 
			// cena_kraju_pl
			// 
			this.cena_kraju_pl.AutoSize = true;
			this.cena_kraju_pl.Location = new System.Drawing.Point(43, 131);
			this.cena_kraju_pl.Name = "cena_kraju_pl";
			this.cena_kraju_pl.Size = new System.Drawing.Size(75, 13);
			this.cena_kraju_pl.TabIndex = 9;
			this.cena_kraju_pl.Text = "zablokowanie ";
			this.cena_kraju_pl.Visible = false;
			// 
			// cena_kraju_eng
			// 
			this.cena_kraju_eng.AutoSize = true;
			this.cena_kraju_eng.Location = new System.Drawing.Point(185, 131);
			this.cena_kraju_eng.Name = "cena_kraju_eng";
			this.cena_kraju_eng.Size = new System.Drawing.Size(25, 13);
			this.cena_kraju_eng.TabIndex = 12;
			this.cena_kraju_eng.Text = "free";
			this.cena_kraju_eng.Visible = false;
			// 
			// Unit_2
			// 
			this.Unit_2.AutoSize = true;
			this.Unit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Unit_2.Location = new System.Drawing.Point(12, 93);
			this.Unit_2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
			this.Unit_2.Name = "Unit_2";
			this.Unit_2.Size = new System.Drawing.Size(31, 18);
			this.Unit_2.TabIndex = 13;
			this.Unit_2.Text = "text";
			this.Unit_2.Visible = false;
			this.Unit_2.Click += new System.EventHandler(this.Unit_2_Click);
			// 
			// Unit_1_kurs
			// 
			this.Unit_1_kurs.AutoSize = true;
			this.Unit_1_kurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Unit_1_kurs.Location = new System.Drawing.Point(135, 69);
			this.Unit_1_kurs.Name = "Unit_1_kurs";
			this.Unit_1_kurs.Size = new System.Drawing.Size(31, 18);
			this.Unit_1_kurs.TabIndex = 14;
			this.Unit_1_kurs.Text = "text";
			this.Unit_1_kurs.Visible = false;
			this.Unit_1_kurs.Click += new System.EventHandler(this.Unit_1_kurs_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(820, 536);
			this.ControlBox = false;
			this.Controls.Add(this.Unit_1_kurs);
			this.Controls.Add(this.Unit_2);
			this.Controls.Add(this.Unity_1);
			this.Controls.Add(this.cena_kraju_eng);
			this.Controls.Add(this.cena_kraju_pl);
			this.Controls.Add(this.Pl);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.Eng);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Pelny)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Eng)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Pl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pelny;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.PictureBox Pl;
        private System.Windows.Forms.PictureBox Eng;
        private System.Windows.Forms.Label Unity_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Zmania_jezyka;
        private System.Windows.Forms.Label Inny_jezyk;
        private System.Windows.Forms.Label Domyszni_jezyk;
        private System.Windows.Forms.Button Sprawc;
        private System.Windows.Forms.Label Liczba_Punktu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Czas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label hajs;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label hajs_dodakowa;
        private System.Windows.Forms.Label dodawanie_hajsu;
        private System.Windows.Forms.Label cena_kraju_pl;
        private System.Windows.Forms.Label cena_kraju_eng;
        private System.Windows.Forms.Label Unit_2;
        private System.Windows.Forms.Label Slownik;
        private System.Windows.Forms.Label Unit_1_kurs;
    }
}

