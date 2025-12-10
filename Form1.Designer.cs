namespace Autod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabC = new TabControl();
            Omanik = new TabPage();
            otsi_oma_txt = new TextBox();
            name_oma_lbl = new Label();
            oma_tel_txt = new TextBox();
            Telefon_oma_lbl = new Label();
            oma_nimi_txt = new TextBox();
            Omanikud = new Label();
            dataGridView_omanik = new DataGridView();
            Autod = new TabPage();
            otsi_auto_txt = new TextBox();
            brand_auto_txt = new TextBox();
            mudel_auto_txt = new TextBox();
            RN_auto_txt = new TextBox();
            OmaId_auto_cb = new ComboBox();
            Brand_auto_lbl = new Label();
            OmaId_auto_lbl = new Label();
            RN_auto_lbl = new Label();
            Mudel_auto_lbl = new Label();
            Autod_lbl = new Label();
            dataGridView_autod = new DataGridView();
            HjT = new TabPage();
            otsi_hold_txt = new TextBox();
            mileage_lbl = new Label();
            hod_kuu_lbl = new Label();
            hold_ten_lbl = new Label();
            hold_auto_lbl = new Label();
            mileage_txt = new TextBox();
            tenus_vaata_btn = new Button();
            hold_auto_cb = new ComboBox();
            teenus_cb = new ComboBox();
            hodl_datetime = new DateTimePicker();
            dataGridView_hold = new DataGridView();
            Holdus_lbl = new Label();
            uue_btn = new Button();
            Otsi_btn = new Button();
            Kustuta_btn = new Button();
            Lisa_btn = new Button();
            toolTip = new ToolTip(components);
            Teenuste_lbl = new Label();
            ten_nimi_lbl = new Label();
            ten_hind_lbl = new Label();
            dataGridView_teen = new DataGridView();
            ten_cl_btn = new Button();
            keel_cb = new ComboBox();
            nim_teen_txt = new TextBox();
            hind_teen_txt = new NumericUpDown();
            change_btn = new Button();
            otsi_teen_txt = new TextBox();
            Kustuta_ch_btn = new Button();
            Lisa_ch_btn = new Button();
            uue_ch_btn = new Button();
            Otsi_ch_btn = new Button();
            change_ch_btn = new Button();
            tabC.SuspendLayout();
            Omanik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_omanik).BeginInit();
            Autod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_autod).BeginInit();
            HjT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_teen).BeginInit();
            SuspendLayout();
            // 
            // tabC
            // 
            tabC.Controls.Add(Omanik);
            tabC.Controls.Add(Autod);
            tabC.Controls.Add(HjT);
            tabC.Location = new Point(10, 10);
            tabC.Name = "tabC";
            tabC.SelectedIndex = 0;
            tabC.Size = new Size(646, 478);
            tabC.TabIndex = 0;
            tabC.Click += tabC_Click;
            // 
            // Omanik
            // 
            Omanik.Controls.Add(otsi_oma_txt);
            Omanik.Controls.Add(name_oma_lbl);
            Omanik.Controls.Add(oma_tel_txt);
            Omanik.Controls.Add(Telefon_oma_lbl);
            Omanik.Controls.Add(oma_nimi_txt);
            Omanik.Controls.Add(Omanikud);
            Omanik.Controls.Add(dataGridView_omanik);
            Omanik.Location = new Point(4, 24);
            Omanik.Name = "Omanik";
            Omanik.Padding = new Padding(3);
            Omanik.Size = new Size(638, 450);
            Omanik.TabIndex = 0;
            Omanik.Text = "Omanikud";
            Omanik.UseVisualStyleBackColor = true;
            // 
            // otsi_oma_txt
            // 
            otsi_oma_txt.Location = new Point(526, 157);
            otsi_oma_txt.Name = "otsi_oma_txt";
            otsi_oma_txt.Size = new Size(100, 23);
            otsi_oma_txt.TabIndex = 6;
            // 
            // name_oma_lbl
            // 
            name_oma_lbl.AutoSize = true;
            name_oma_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            name_oma_lbl.Location = new Point(13, 86);
            name_oma_lbl.Name = "name_oma_lbl";
            name_oma_lbl.Size = new Size(121, 21);
            name_oma_lbl.TabIndex = 3;
            name_oma_lbl.Text = "Ees- ja perenimi";
            // 
            // oma_tel_txt
            // 
            oma_tel_txt.Location = new Point(179, 127);
            oma_tel_txt.Margin = new Padding(3, 2, 3, 2);
            oma_tel_txt.Name = "oma_tel_txt";
            oma_tel_txt.Size = new Size(106, 23);
            oma_tel_txt.TabIndex = 4;
            // 
            // Telefon_oma_lbl
            // 
            Telefon_oma_lbl.AutoSize = true;
            Telefon_oma_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Telefon_oma_lbl.Location = new Point(13, 131);
            Telefon_oma_lbl.Name = "Telefon_oma_lbl";
            Telefon_oma_lbl.Size = new Size(59, 21);
            Telefon_oma_lbl.TabIndex = 5;
            Telefon_oma_lbl.Text = "Telefon";
            // 
            // oma_nimi_txt
            // 
            oma_nimi_txt.Location = new Point(179, 82);
            oma_nimi_txt.Margin = new Padding(3, 2, 3, 2);
            oma_nimi_txt.Name = "oma_nimi_txt";
            oma_nimi_txt.Size = new Size(106, 23);
            oma_nimi_txt.TabIndex = 2;
            // 
            // Omanikud
            // 
            Omanikud.AutoSize = true;
            Omanikud.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Omanikud.Location = new Point(30, 12);
            Omanikud.Name = "Omanikud";
            Omanikud.Size = new Size(166, 44);
            Omanikud.TabIndex = 1;
            Omanikud.Text = "Omanikud";
            // 
            // dataGridView_omanik
            // 
            dataGridView_omanik.ColumnHeadersHeight = 29;
            dataGridView_omanik.Location = new Point(13, 188);
            dataGridView_omanik.Margin = new Padding(3, 2, 3, 2);
            dataGridView_omanik.Name = "dataGridView_omanik";
            dataGridView_omanik.RowHeadersWidth = 51;
            dataGridView_omanik.Size = new Size(613, 260);
            dataGridView_omanik.TabIndex = 0;
            // 
            // Autod
            // 
            Autod.Controls.Add(otsi_auto_txt);
            Autod.Controls.Add(brand_auto_txt);
            Autod.Controls.Add(mudel_auto_txt);
            Autod.Controls.Add(RN_auto_txt);
            Autod.Controls.Add(OmaId_auto_cb);
            Autod.Controls.Add(Brand_auto_lbl);
            Autod.Controls.Add(OmaId_auto_lbl);
            Autod.Controls.Add(RN_auto_lbl);
            Autod.Controls.Add(Mudel_auto_lbl);
            Autod.Controls.Add(Autod_lbl);
            Autod.Controls.Add(dataGridView_autod);
            Autod.Location = new Point(4, 24);
            Autod.Name = "Autod";
            Autod.Padding = new Padding(3);
            Autod.Size = new Size(638, 450);
            Autod.TabIndex = 1;
            Autod.Text = "Autod";
            Autod.UseVisualStyleBackColor = true;
            // 
            // otsi_auto_txt
            // 
            otsi_auto_txt.Location = new Point(532, 171);
            otsi_auto_txt.Name = "otsi_auto_txt";
            otsi_auto_txt.Size = new Size(100, 23);
            otsi_auto_txt.TabIndex = 11;
            // 
            // brand_auto_txt
            // 
            brand_auto_txt.Location = new Point(192, 68);
            brand_auto_txt.Margin = new Padding(3, 2, 3, 2);
            brand_auto_txt.Name = "brand_auto_txt";
            brand_auto_txt.Size = new Size(178, 23);
            brand_auto_txt.TabIndex = 10;
            // 
            // mudel_auto_txt
            // 
            mudel_auto_txt.Location = new Point(192, 98);
            mudel_auto_txt.Margin = new Padding(3, 2, 3, 2);
            mudel_auto_txt.Name = "mudel_auto_txt";
            mudel_auto_txt.Size = new Size(178, 23);
            mudel_auto_txt.TabIndex = 9;
            // 
            // RN_auto_txt
            // 
            RN_auto_txt.Location = new Point(192, 130);
            RN_auto_txt.Margin = new Padding(3, 2, 3, 2);
            RN_auto_txt.Name = "RN_auto_txt";
            RN_auto_txt.Size = new Size(178, 23);
            RN_auto_txt.TabIndex = 8;
            // 
            // OmaId_auto_cb
            // 
            OmaId_auto_cb.FormattingEnabled = true;
            OmaId_auto_cb.Location = new Point(192, 162);
            OmaId_auto_cb.Margin = new Padding(3, 2, 3, 2);
            OmaId_auto_cb.Name = "OmaId_auto_cb";
            OmaId_auto_cb.Size = new Size(178, 23);
            OmaId_auto_cb.TabIndex = 7;
            // 
            // Brand_auto_lbl
            // 
            Brand_auto_lbl.AutoSize = true;
            Brand_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Brand_auto_lbl.Location = new Point(11, 67);
            Brand_auto_lbl.Name = "Brand_auto_lbl";
            Brand_auto_lbl.Size = new Size(51, 21);
            Brand_auto_lbl.TabIndex = 6;
            Brand_auto_lbl.Text = "Bränd";
            // 
            // OmaId_auto_lbl
            // 
            OmaId_auto_lbl.AutoSize = true;
            OmaId_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            OmaId_auto_lbl.Location = new Point(11, 162);
            OmaId_auto_lbl.Name = "OmaId_auto_lbl";
            OmaId_auto_lbl.Size = new Size(65, 21);
            OmaId_auto_lbl.TabIndex = 5;
            OmaId_auto_lbl.Text = "Omanik";
            // 
            // RN_auto_lbl
            // 
            RN_auto_lbl.AutoSize = true;
            RN_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            RN_auto_lbl.Location = new Point(11, 130);
            RN_auto_lbl.Name = "RN_auto_lbl";
            RN_auto_lbl.Size = new Size(165, 21);
            RN_auto_lbl.TabIndex = 4;
            RN_auto_lbl.Text = "Registreerimisnumber";
            // 
            // Mudel_auto_lbl
            // 
            Mudel_auto_lbl.AutoSize = true;
            Mudel_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Mudel_auto_lbl.Location = new Point(11, 98);
            Mudel_auto_lbl.Name = "Mudel_auto_lbl";
            Mudel_auto_lbl.Size = new Size(54, 21);
            Mudel_auto_lbl.TabIndex = 3;
            Mudel_auto_lbl.Text = "Mudel";
            // 
            // Autod_lbl
            // 
            Autod_lbl.AutoSize = true;
            Autod_lbl.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Autod_lbl.Location = new Point(30, 12);
            Autod_lbl.Name = "Autod_lbl";
            Autod_lbl.Size = new Size(101, 44);
            Autod_lbl.TabIndex = 2;
            Autod_lbl.Text = "Autod";
            // 
            // dataGridView_autod
            // 
            dataGridView_autod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_autod.Location = new Point(11, 199);
            dataGridView_autod.Margin = new Padding(3, 2, 3, 2);
            dataGridView_autod.Name = "dataGridView_autod";
            dataGridView_autod.RowHeadersWidth = 51;
            dataGridView_autod.Size = new Size(622, 249);
            dataGridView_autod.TabIndex = 1;
            // 
            // HjT
            // 
            HjT.Controls.Add(otsi_hold_txt);
            HjT.Controls.Add(mileage_lbl);
            HjT.Controls.Add(hod_kuu_lbl);
            HjT.Controls.Add(hold_ten_lbl);
            HjT.Controls.Add(hold_auto_lbl);
            HjT.Controls.Add(mileage_txt);
            HjT.Controls.Add(tenus_vaata_btn);
            HjT.Controls.Add(hold_auto_cb);
            HjT.Controls.Add(teenus_cb);
            HjT.Controls.Add(hodl_datetime);
            HjT.Controls.Add(dataGridView_hold);
            HjT.Controls.Add(Holdus_lbl);
            HjT.Location = new Point(4, 24);
            HjT.Name = "HjT";
            HjT.Size = new Size(638, 450);
            HjT.TabIndex = 2;
            HjT.Text = "Hooldus ja Teenused";
            HjT.UseVisualStyleBackColor = true;
            // 
            // otsi_hold_txt
            // 
            otsi_hold_txt.Location = new Point(525, 193);
            otsi_hold_txt.Name = "otsi_hold_txt";
            otsi_hold_txt.Size = new Size(100, 23);
            otsi_hold_txt.TabIndex = 12;
            // 
            // mileage_lbl
            // 
            mileage_lbl.AutoSize = true;
            mileage_lbl.Location = new Point(30, 193);
            mileage_lbl.Name = "mileage_lbl";
            mileage_lbl.Size = new Size(49, 15);
            mileage_lbl.TabIndex = 11;
            mileage_lbl.Text = "Mileage";
            // 
            // hod_kuu_lbl
            // 
            hod_kuu_lbl.AutoSize = true;
            hod_kuu_lbl.Location = new Point(30, 158);
            hod_kuu_lbl.Name = "hod_kuu_lbl";
            hod_kuu_lbl.Size = new Size(53, 15);
            hod_kuu_lbl.TabIndex = 10;
            hod_kuu_lbl.Text = "Kuupäev";
            // 
            // hold_ten_lbl
            // 
            hold_ten_lbl.AutoSize = true;
            hold_ten_lbl.Location = new Point(30, 119);
            hold_ten_lbl.Name = "hold_ten_lbl";
            hold_ten_lbl.Size = new Size(44, 15);
            hold_ten_lbl.TabIndex = 9;
            hold_ten_lbl.Text = "Teenus";
            // 
            // hold_auto_lbl
            // 
            hold_auto_lbl.AutoSize = true;
            hold_auto_lbl.Location = new Point(30, 81);
            hold_auto_lbl.Name = "hold_auto_lbl";
            hold_auto_lbl.Size = new Size(33, 15);
            hold_auto_lbl.TabIndex = 8;
            hold_auto_lbl.Text = "Auto";
            // 
            // mileage_txt
            // 
            mileage_txt.Location = new Point(171, 188);
            mileage_txt.Margin = new Padding(3, 2, 3, 2);
            mileage_txt.Name = "mileage_txt";
            mileage_txt.Size = new Size(167, 23);
            mileage_txt.TabIndex = 7;
            // 
            // tenus_vaata_btn
            // 
            tenus_vaata_btn.BackColor = Color.Gray;
            tenus_vaata_btn.ForeColor = SystemColors.ControlLightLight;
            tenus_vaata_btn.Location = new Point(490, 16);
            tenus_vaata_btn.Name = "tenus_vaata_btn";
            tenus_vaata_btn.Size = new Size(136, 51);
            tenus_vaata_btn.TabIndex = 0;
            tenus_vaata_btn.Text = "Teenuste vaata";
            tenus_vaata_btn.UseVisualStyleBackColor = false;
            tenus_vaata_btn.Click += tenus_vaata_btn_Click;
            // 
            // hold_auto_cb
            // 
            hold_auto_cb.FormattingEnabled = true;
            hold_auto_cb.Location = new Point(171, 81);
            hold_auto_cb.Margin = new Padding(3, 2, 3, 2);
            hold_auto_cb.Name = "hold_auto_cb";
            hold_auto_cb.Size = new Size(167, 23);
            hold_auto_cb.TabIndex = 6;
            // 
            // teenus_cb
            // 
            teenus_cb.FormattingEnabled = true;
            teenus_cb.Location = new Point(171, 119);
            teenus_cb.Margin = new Padding(3, 2, 3, 2);
            teenus_cb.Name = "teenus_cb";
            teenus_cb.Size = new Size(167, 23);
            teenus_cb.TabIndex = 5;
            // 
            // hodl_datetime
            // 
            hodl_datetime.Location = new Point(171, 158);
            hodl_datetime.Margin = new Padding(3, 2, 3, 2);
            hodl_datetime.Name = "hodl_datetime";
            hodl_datetime.Size = new Size(167, 23);
            hodl_datetime.TabIndex = 4;
            // 
            // dataGridView_hold
            // 
            dataGridView_hold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_hold.Location = new Point(13, 227);
            dataGridView_hold.Margin = new Padding(3, 2, 3, 2);
            dataGridView_hold.Name = "dataGridView_hold";
            dataGridView_hold.RowHeadersWidth = 51;
            dataGridView_hold.Size = new Size(612, 214);
            dataGridView_hold.TabIndex = 3;
            // 
            // Holdus_lbl
            // 
            Holdus_lbl.AutoSize = true;
            Holdus_lbl.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Holdus_lbl.Location = new Point(30, 12);
            Holdus_lbl.Name = "Holdus_lbl";
            Holdus_lbl.Size = new Size(114, 44);
            Holdus_lbl.TabIndex = 2;
            Holdus_lbl.Text = "Holdus";
            // 
            // uue_btn
            // 
            uue_btn.BackColor = Color.Gray;
            uue_btn.ForeColor = SystemColors.ControlLight;
            uue_btn.Location = new Point(156, 496);
            uue_btn.Name = "uue_btn";
            uue_btn.Size = new Size(140, 51);
            uue_btn.TabIndex = 4;
            uue_btn.Text = "Uuenda";
            uue_btn.UseVisualStyleBackColor = false;
            uue_btn.Click += uue_btn_Click;
            // 
            // Otsi_btn
            // 
            Otsi_btn.BackColor = Color.Gray;
            Otsi_btn.ForeColor = SystemColors.ControlLight;
            Otsi_btn.Location = new Point(448, 496);
            Otsi_btn.Name = "Otsi_btn";
            Otsi_btn.Size = new Size(140, 51);
            Otsi_btn.TabIndex = 3;
            Otsi_btn.Text = "Otsi";
            Otsi_btn.UseVisualStyleBackColor = false;
            // 
            // Kustuta_btn
            // 
            Kustuta_btn.BackColor = Color.Gray;
            Kustuta_btn.ForeColor = SystemColors.ControlLightLight;
            Kustuta_btn.Location = new Point(302, 496);
            Kustuta_btn.Name = "Kustuta_btn";
            Kustuta_btn.Size = new Size(140, 51);
            Kustuta_btn.TabIndex = 2;
            Kustuta_btn.Text = "Kustuta";
            Kustuta_btn.UseVisualStyleBackColor = false;
            Kustuta_btn.Click += Kustuta_Click;
            // 
            // Lisa_btn
            // 
            Lisa_btn.BackColor = Color.Gray;
            Lisa_btn.ForeColor = SystemColors.ControlLight;
            Lisa_btn.Location = new Point(10, 496);
            Lisa_btn.Name = "Lisa_btn";
            Lisa_btn.Size = new Size(140, 51);
            Lisa_btn.TabIndex = 1;
            Lisa_btn.Text = "Lisa";
            Lisa_btn.UseVisualStyleBackColor = false;
            Lisa_btn.Click += Lisa_btn_Click;
            // 
            // Teenuste_lbl
            // 
            Teenuste_lbl.AutoSize = true;
            Teenuste_lbl.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Teenuste_lbl.Location = new Point(788, 32);
            Teenuste_lbl.Name = "Teenuste_lbl";
            Teenuste_lbl.Size = new Size(145, 44);
            Teenuste_lbl.TabIndex = 5;
            Teenuste_lbl.Text = "Teenuste";
            // 
            // ten_nimi_lbl
            // 
            ten_nimi_lbl.AutoSize = true;
            ten_nimi_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ten_nimi_lbl.Location = new Point(662, 138);
            ten_nimi_lbl.Name = "ten_nimi_lbl";
            ten_nimi_lbl.Size = new Size(44, 21);
            ten_nimi_lbl.TabIndex = 6;
            ten_nimi_lbl.Text = "Nimi";
            // 
            // ten_hind_lbl
            // 
            ten_hind_lbl.AutoSize = true;
            ten_hind_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ten_hind_lbl.Location = new Point(663, 175);
            ten_hind_lbl.Name = "ten_hind_lbl";
            ten_hind_lbl.Size = new Size(43, 21);
            ten_hind_lbl.TabIndex = 7;
            ten_hind_lbl.Text = "Hind";
            // 
            // dataGridView_teen
            // 
            dataGridView_teen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_teen.Location = new Point(658, 261);
            dataGridView_teen.Margin = new Padding(3, 2, 3, 2);
            dataGridView_teen.Name = "dataGridView_teen";
            dataGridView_teen.RowHeadersWidth = 51;
            dataGridView_teen.Size = new Size(399, 212);
            dataGridView_teen.TabIndex = 8;
            // 
            // ten_cl_btn
            // 
            ten_cl_btn.BackColor = Color.Gray;
            ten_cl_btn.ForeColor = SystemColors.ControlLight;
            ten_cl_btn.Location = new Point(1004, 32);
            ten_cl_btn.Name = "ten_cl_btn";
            ten_cl_btn.Size = new Size(56, 40);
            ten_cl_btn.TabIndex = 9;
            ten_cl_btn.Text = "Kinni";
            ten_cl_btn.UseVisualStyleBackColor = false;
            ten_cl_btn.Click += tenus_kinni_btn_Click;
            // 
            // keel_cb
            // 
            keel_cb.FormattingEnabled = true;
            keel_cb.Location = new Point(594, 493);
            keel_cb.Margin = new Padding(3, 2, 3, 2);
            keel_cb.Name = "keel_cb";
            keel_cb.Size = new Size(63, 23);
            keel_cb.TabIndex = 10;
            keel_cb.Text = "Keel";
            // 
            // nim_teen_txt
            // 
            nim_teen_txt.Location = new Point(770, 136);
            nim_teen_txt.Margin = new Padding(3, 2, 3, 2);
            nim_teen_txt.Name = "nim_teen_txt";
            nim_teen_txt.Size = new Size(134, 23);
            nim_teen_txt.TabIndex = 11;
            // 
            // hind_teen_txt
            // 
            hind_teen_txt.Location = new Point(770, 173);
            hind_teen_txt.Margin = new Padding(3, 2, 3, 2);
            hind_teen_txt.Name = "hind_teen_txt";
            hind_teen_txt.Size = new Size(134, 23);
            hind_teen_txt.TabIndex = 12;
            // 
            // change_btn
            // 
            change_btn.BackColor = Color.Gray;
            change_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            change_btn.ForeColor = SystemColors.ControlLight;
            change_btn.Location = new Point(593, 521);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(63, 26);
            change_btn.TabIndex = 13;
            change_btn.Text = "⇄";
            change_btn.UseVisualStyleBackColor = false;
            // 
            // change_ch_btn
            // 
            change_ch_btn.BackColor = Color.Gray;
            change_ch_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            change_ch_btn.ForeColor = SystemColors.ControlLight;
            change_ch_btn.Location = new Point(593, 521);
            change_ch_btn.Name = "change_ch_btn";
            change_ch_btn.Size = new Size(63, 26);
            change_ch_btn.TabIndex = 13;
            change_ch_btn.Text = "⇄";
            change_ch_btn.UseVisualStyleBackColor = false;
            // 
            // otsi_teen_txt
            // 
            otsi_teen_txt.Location = new Point(957, 233);
            otsi_teen_txt.Name = "otsi_teen_txt";
            otsi_teen_txt.Size = new Size(100, 23);
            otsi_teen_txt.TabIndex = 14;
            //
            // Kustuta_ch_btn
            //
            Kustuta_ch_btn.BackColor = Color.Gray;
            Kustuta_ch_btn.ForeColor = SystemColors.ControlLightLight;
            Kustuta_ch_btn.Location = new Point(302, 496);
            Kustuta_ch_btn.Name = "Kustuta_ch_btn";
            Kustuta_ch_btn.Size = new Size(140, 51);
            Kustuta_ch_btn.TabIndex = 2;
            Kustuta_ch_btn.Text = "Kustuta";
            Kustuta_ch_btn.UseVisualStyleBackColor = false;
            Kustuta_ch_btn.Click += Kustuta_Click;
            //
            // Lisa_ch_btn
            //
            Lisa_ch_btn.BackColor = Color.Gray;
            Lisa_ch_btn.ForeColor = SystemColors.ControlLight;
            Lisa_ch_btn.Location = new Point(10, 496);
            Lisa_ch_btn.Name = "Lisa_ch_btn";
            Lisa_ch_btn.Size = new Size(140, 51);
            Lisa_ch_btn.TabIndex = 1;
            Lisa_ch_btn.Text = "Lisa";
            Lisa_ch_btn.UseVisualStyleBackColor = false;
            Lisa_ch_btn.Click += Lisa_btn_Click;
            //
            // uue_ch_btn
            //
            uue_ch_btn.BackColor = Color.Gray;
            uue_ch_btn.ForeColor = SystemColors.ControlLight;
            uue_ch_btn.Location = new Point(156, 496);
            uue_ch_btn.Name = "uue_ch_btn";
            uue_ch_btn.Size = new Size(140, 51);
            uue_ch_btn.TabIndex = 4;
            uue_ch_btn.Text = "Uuenda";
            uue_ch_btn.UseVisualStyleBackColor = false;
            uue_ch_btn.Click += uue_btn_Click;
            //
            // Otsi_ch_btn
            //
            Otsi_ch_btn.BackColor = Color.Gray;
            Otsi_ch_btn.ForeColor = SystemColors.ControlLight;
            Otsi_ch_btn.Location = new Point(448, 496);
            Otsi_ch_btn.Name = "Otsi_ch_btn";
            Otsi_ch_btn.Size = new Size(140, 51);
            Otsi_ch_btn.TabIndex = 3;
            Otsi_ch_btn.Text = "Otsi";
            Otsi_ch_btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 557);
            Controls.Add(tabC);
            Controls.Add(uue_btn);
            Controls.Add(Otsi_btn);
            Controls.Add(Kustuta_btn);
            Controls.Add(Lisa_btn);
            Controls.Add(keel_cb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabC.ResumeLayout(false);
            Omanik.ResumeLayout(false);
            Omanik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_omanik).EndInit();
            Autod.ResumeLayout(false);
            Autod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_autod).EndInit();
            HjT.ResumeLayout(false);
            HjT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hold).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_teen).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TabControl tabC;
        private TabPage Omanik;
        private TabPage Autod;
        private TabPage HjT;
        private Button Kustuta_btn;
        private Button Lisa_btn;
        private Button tenus_vaata_btn;
        private DataGridView dataGridView_omanik;
        private Label Omanikud;
        private TextBox oma_nimi_txt;
        private Label name_oma_lbl;
        private TextBox oma_tel_txt;
        private Label Telefon_oma_lbl;
        private ToolTip toolTip;
        private DataGridView dataGridView_autod;
        private Label Autod_lbl, Holdus_lbl;
        private Label Mudel_auto_lbl;
        private Label RN_auto_lbl;
        private Label OmaId_auto_lbl;
        private Label Brand_auto_lbl;
        private ComboBox OmaId_auto_cb;
        private TextBox RN_auto_txt;
        private TextBox mudel_auto_txt;
        private TextBox brand_auto_txt;
        private Button uue_btn;
        private Button Otsi_btn;
        private DateTimePicker hodl_datetime;
        private DataGridView dataGridView_hold;
        private ComboBox hold_auto_cb;
        private ComboBox teenus_cb;
        private Label mileage_lbl;
        private Label hod_kuu_lbl;
        private Label hold_ten_lbl;
        private Label hold_auto_lbl;
        private TextBox mileage_txt;
        private Label Teenuste_lbl;
        private Label ten_nimi_lbl;
        private Label ten_hind_lbl;
        private DataGridView dataGridView_teen;
        private Button ten_cl_btn;
        private ComboBox keel_cb;
        private TextBox nim_teen_txt;
        private NumericUpDown hind_teen_txt;
        private Button change_btn;
        private TextBox otsi_oma_txt;
        private TextBox otsi_auto_txt;
        private TextBox otsi_hold_txt;
        private TextBox otsi_teen_txt;
        private Button Kustuta_ch_btn, Lisa_ch_btn, uue_ch_btn, Otsi_ch_btn, change_ch_btn;
    }
}
