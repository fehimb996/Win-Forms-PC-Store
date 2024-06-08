namespace DrugiProjekat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTestiraj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKapacitetSkladista = new System.Windows.Forms.TextBox();
            this.txtTipSkladista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrstaKucista = new System.Windows.Forms.TextBox();
            this.txtGrafickaKarta = new System.Windows.Forms.TextBox();
            this.txtMaticnaPloca = new System.Windows.Forms.TextBox();
            this.txtVelicinaRAM = new System.Windows.Forms.TextBox();
            this.txtVrstaRAM = new System.Windows.Forms.TextBox();
            this.txtProcesor = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSacuvajUListBox = new System.Windows.Forms.Button();
            this.btnSacuvajKaoJSON = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnTestiraj2 = new System.Windows.Forms.Button();
            this.btnTestiraj3 = new System.Windows.Forms.Button();
            this.btnTestiraj4 = new System.Windows.Forms.Button();
            this.btnTestiraj5 = new System.Windows.Forms.Button();
            this.btnTestiraj6 = new System.Windows.Forms.Button();
            this.btnTestiraj7 = new System.Windows.Forms.Button();
            this.btnTestiraj8 = new System.Windows.Forms.Button();
            this.btnTestiraj9 = new System.Windows.Forms.Button();
            this.btnTestiraj10 = new System.Windows.Forms.Button();
            this.btnTestiraj11 = new System.Windows.Forms.Button();
            this.btnOtvoriJSON = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestiraj
            // 
            this.btnTestiraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj.Location = new System.Drawing.Point(8, 482);
            this.btnTestiraj.Name = "btnTestiraj";
            this.btnTestiraj.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj.TabIndex = 0;
            this.btnTestiraj.Text = "Test1";
            this.btnTestiraj.UseVisualStyleBackColor = true;
            this.btnTestiraj.Click += new System.EventHandler(this.btnTestiraj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtProizvodjac);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o uređaju";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proizvođač:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv uređaja:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(162, 104);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(204, 22);
            this.txtCena.TabIndex = 2;
            this.txtCena.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(162, 61);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(204, 22);
            this.txtProizvodjac.TabIndex = 1;
            this.txtProizvodjac.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(162, 21);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(204, 22);
            this.txtNaziv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKapacitetSkladista);
            this.groupBox2.Controls.Add(this.txtTipSkladista);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtVrstaKucista);
            this.groupBox2.Controls.Add(this.txtGrafickaKarta);
            this.groupBox2.Controls.Add(this.txtMaticnaPloca);
            this.groupBox2.Controls.Add(this.txtVelicinaRAM);
            this.groupBox2.Controls.Add(this.txtVrstaRAM);
            this.groupBox2.Controls.Add(this.txtProcesor);
            this.groupBox2.Location = new System.Drawing.Point(8, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 326);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Specifikacije";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Kapacitet skladišta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Vrsta kućišta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Grafička karta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tip skladišta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Matična ploča:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Veličina RAM memorije:";
            // 
            // txtKapacitetSkladista
            // 
            this.txtKapacitetSkladista.Location = new System.Drawing.Point(162, 292);
            this.txtKapacitetSkladista.Name = "txtKapacitetSkladista";
            this.txtKapacitetSkladista.Size = new System.Drawing.Size(204, 22);
            this.txtKapacitetSkladista.TabIndex = 13;
            // 
            // txtTipSkladista
            // 
            this.txtTipSkladista.Location = new System.Drawing.Point(162, 253);
            this.txtTipSkladista.Name = "txtTipSkladista";
            this.txtTipSkladista.Size = new System.Drawing.Size(204, 22);
            this.txtTipSkladista.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vrsta RAM memorije:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Procesor:";
            // 
            // txtVrstaKucista
            // 
            this.txtVrstaKucista.Location = new System.Drawing.Point(162, 218);
            this.txtVrstaKucista.Name = "txtVrstaKucista";
            this.txtVrstaKucista.Size = new System.Drawing.Size(204, 22);
            this.txtVrstaKucista.TabIndex = 5;
            // 
            // txtGrafickaKarta
            // 
            this.txtGrafickaKarta.Location = new System.Drawing.Point(162, 181);
            this.txtGrafickaKarta.Name = "txtGrafickaKarta";
            this.txtGrafickaKarta.Size = new System.Drawing.Size(204, 22);
            this.txtGrafickaKarta.TabIndex = 4;
            // 
            // txtMaticnaPloca
            // 
            this.txtMaticnaPloca.Location = new System.Drawing.Point(162, 144);
            this.txtMaticnaPloca.Name = "txtMaticnaPloca";
            this.txtMaticnaPloca.Size = new System.Drawing.Size(204, 22);
            this.txtMaticnaPloca.TabIndex = 3;
            // 
            // txtVelicinaRAM
            // 
            this.txtVelicinaRAM.Location = new System.Drawing.Point(162, 100);
            this.txtVelicinaRAM.Name = "txtVelicinaRAM";
            this.txtVelicinaRAM.Size = new System.Drawing.Size(204, 22);
            this.txtVelicinaRAM.TabIndex = 2;
            this.txtVelicinaRAM.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // txtVrstaRAM
            // 
            this.txtVrstaRAM.Location = new System.Drawing.Point(162, 61);
            this.txtVrstaRAM.Name = "txtVrstaRAM";
            this.txtVrstaRAM.Size = new System.Drawing.Size(204, 22);
            this.txtVrstaRAM.TabIndex = 1;
            // 
            // txtProcesor
            // 
            this.txtProcesor.Location = new System.Drawing.Point(162, 22);
            this.txtProcesor.Name = "txtProcesor";
            this.txtProcesor.Size = new System.Drawing.Size(204, 22);
            this.txtProcesor.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(425, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 324);
            this.listBox1.TabIndex = 3;
            // 
            // btnSacuvajUListBox
            // 
            this.btnSacuvajUListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSacuvajUListBox.Location = new System.Drawing.Point(443, 357);
            this.btnSacuvajUListBox.Name = "btnSacuvajUListBox";
            this.btnSacuvajUListBox.Size = new System.Drawing.Size(144, 41);
            this.btnSacuvajUListBox.TabIndex = 4;
            this.btnSacuvajUListBox.Text = "Dodaj u ListBox";
            this.btnSacuvajUListBox.UseVisualStyleBackColor = true;
            this.btnSacuvajUListBox.Click += new System.EventHandler(this.btnSacuvajUListBox_Click);
            // 
            // btnSacuvajKaoJSON
            // 
            this.btnSacuvajKaoJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSacuvajKaoJSON.Location = new System.Drawing.Point(606, 357);
            this.btnSacuvajKaoJSON.Name = "btnSacuvajKaoJSON";
            this.btnSacuvajKaoJSON.Size = new System.Drawing.Size(152, 44);
            this.btnSacuvajKaoJSON.TabIndex = 5;
            this.btnSacuvajKaoJSON.Text = "Sačuvaj kao JSON";
            this.btnSacuvajKaoJSON.UseVisualStyleBackColor = true;
            this.btnSacuvajKaoJSON.Click += new System.EventHandler(this.btnSacuvajKaoJSON_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.Location = new System.Drawing.Point(447, 405);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(140, 37);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOsvezi.Location = new System.Drawing.Point(606, 407);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(152, 37);
            this.btnOsvezi.TabIndex = 7;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnTestiraj2
            // 
            this.btnTestiraj2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj2.Location = new System.Drawing.Point(8, 513);
            this.btnTestiraj2.Name = "btnTestiraj2";
            this.btnTestiraj2.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj2.TabIndex = 8;
            this.btnTestiraj2.Text = "Test2";
            this.btnTestiraj2.UseVisualStyleBackColor = true;
            this.btnTestiraj2.Click += new System.EventHandler(this.btnTestiraj2_Click);
            // 
            // btnTestiraj3
            // 
            this.btnTestiraj3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj3.Location = new System.Drawing.Point(79, 482);
            this.btnTestiraj3.Name = "btnTestiraj3";
            this.btnTestiraj3.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj3.TabIndex = 9;
            this.btnTestiraj3.Text = "Test3";
            this.btnTestiraj3.UseVisualStyleBackColor = true;
            this.btnTestiraj3.Click += new System.EventHandler(this.btnTestiraj3_Click);
            // 
            // btnTestiraj4
            // 
            this.btnTestiraj4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj4.Location = new System.Drawing.Point(79, 514);
            this.btnTestiraj4.Name = "btnTestiraj4";
            this.btnTestiraj4.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj4.TabIndex = 10;
            this.btnTestiraj4.Text = "Test4";
            this.btnTestiraj4.UseVisualStyleBackColor = true;
            this.btnTestiraj4.Click += new System.EventHandler(this.btnTestiraj4_Click);
            // 
            // btnTestiraj5
            // 
            this.btnTestiraj5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj5.Location = new System.Drawing.Point(150, 482);
            this.btnTestiraj5.Name = "btnTestiraj5";
            this.btnTestiraj5.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj5.TabIndex = 11;
            this.btnTestiraj5.Text = "Test5";
            this.btnTestiraj5.UseVisualStyleBackColor = true;
            this.btnTestiraj5.Click += new System.EventHandler(this.btnTestiraj5_Click);
            // 
            // btnTestiraj6
            // 
            this.btnTestiraj6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj6.Location = new System.Drawing.Point(150, 514);
            this.btnTestiraj6.Name = "btnTestiraj6";
            this.btnTestiraj6.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj6.TabIndex = 12;
            this.btnTestiraj6.Text = "Test6";
            this.btnTestiraj6.UseVisualStyleBackColor = true;
            this.btnTestiraj6.Click += new System.EventHandler(this.btnTestiraj6_Click);
            // 
            // btnTestiraj7
            // 
            this.btnTestiraj7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj7.Location = new System.Drawing.Point(221, 482);
            this.btnTestiraj7.Name = "btnTestiraj7";
            this.btnTestiraj7.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj7.TabIndex = 13;
            this.btnTestiraj7.Text = "Test7";
            this.btnTestiraj7.UseVisualStyleBackColor = true;
            this.btnTestiraj7.Click += new System.EventHandler(this.btnTestiraj7_Click);
            // 
            // btnTestiraj8
            // 
            this.btnTestiraj8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj8.Location = new System.Drawing.Point(221, 514);
            this.btnTestiraj8.Name = "btnTestiraj8";
            this.btnTestiraj8.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj8.TabIndex = 14;
            this.btnTestiraj8.Text = "Test8";
            this.btnTestiraj8.UseVisualStyleBackColor = true;
            this.btnTestiraj8.Click += new System.EventHandler(this.btnTestiraj8_Click);
            // 
            // btnTestiraj9
            // 
            this.btnTestiraj9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj9.Location = new System.Drawing.Point(292, 482);
            this.btnTestiraj9.Name = "btnTestiraj9";
            this.btnTestiraj9.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj9.TabIndex = 15;
            this.btnTestiraj9.Text = "Test9";
            this.btnTestiraj9.UseVisualStyleBackColor = true;
            this.btnTestiraj9.Click += new System.EventHandler(this.btnTestiraj9_Click);
            // 
            // btnTestiraj10
            // 
            this.btnTestiraj10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj10.Location = new System.Drawing.Point(292, 514);
            this.btnTestiraj10.Name = "btnTestiraj10";
            this.btnTestiraj10.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj10.TabIndex = 16;
            this.btnTestiraj10.Text = "Test10";
            this.btnTestiraj10.UseVisualStyleBackColor = true;
            this.btnTestiraj10.Click += new System.EventHandler(this.btnTestiraj10_Click);
            // 
            // btnTestiraj11
            // 
            this.btnTestiraj11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestiraj11.Location = new System.Drawing.Point(363, 514);
            this.btnTestiraj11.Name = "btnTestiraj11";
            this.btnTestiraj11.Size = new System.Drawing.Size(65, 26);
            this.btnTestiraj11.TabIndex = 17;
            this.btnTestiraj11.Text = "Test11";
            this.btnTestiraj11.UseVisualStyleBackColor = true;
            this.btnTestiraj11.Click += new System.EventHandler(this.btnTestiraj11_Click);
            // 
            // btnOtvoriJSON
            // 
            this.btnOtvoriJSON.Location = new System.Drawing.Point(528, 450);
            this.btnOtvoriJSON.Name = "btnOtvoriJSON";
            this.btnOtvoriJSON.Size = new System.Drawing.Size(144, 40);
            this.btnOtvoriJSON.TabIndex = 18;
            this.btnOtvoriJSON.Text = "Otvori JSON";
            this.btnOtvoriJSON.UseVisualStyleBackColor = true;
            this.btnOtvoriJSON.Click += new System.EventHandler(this.btnOtvoriJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.btnOtvoriJSON);
            this.Controls.Add(this.btnTestiraj11);
            this.Controls.Add(this.btnTestiraj10);
            this.Controls.Add(this.btnTestiraj9);
            this.Controls.Add(this.btnTestiraj8);
            this.Controls.Add(this.btnTestiraj7);
            this.Controls.Add(this.btnTestiraj6);
            this.Controls.Add(this.btnTestiraj5);
            this.Controls.Add(this.btnTestiraj4);
            this.Controls.Add(this.btnTestiraj3);
            this.Controls.Add(this.btnTestiraj2);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvajKaoJSON);
            this.Controls.Add(this.btnSacuvajUListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTestiraj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 599);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Ring To Rule Them All";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestiraj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVrstaKucista;
        private System.Windows.Forms.TextBox txtGrafickaKarta;
        private System.Windows.Forms.TextBox txtMaticnaPloca;
        private System.Windows.Forms.TextBox txtVelicinaRAM;
        private System.Windows.Forms.TextBox txtVrstaRAM;
        private System.Windows.Forms.TextBox txtProcesor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSacuvajUListBox;
        private System.Windows.Forms.Button btnSacuvajKaoJSON;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKapacitetSkladista;
        private System.Windows.Forms.TextBox txtTipSkladista;
        private System.Windows.Forms.Button btnTestiraj2;
        private System.Windows.Forms.Button btnTestiraj3;
        private System.Windows.Forms.Button btnTestiraj4;
        private System.Windows.Forms.Button btnTestiraj5;
        private System.Windows.Forms.Button btnTestiraj6;
        private System.Windows.Forms.Button btnTestiraj7;
        private System.Windows.Forms.Button btnTestiraj8;
        private System.Windows.Forms.Button btnTestiraj9;
        private System.Windows.Forms.Button btnTestiraj10;
        private System.Windows.Forms.Button btnTestiraj11;
        private System.Windows.Forms.Button btnOtvoriJSON;
    }
}

