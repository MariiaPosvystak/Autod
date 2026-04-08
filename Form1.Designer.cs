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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            Teenuste_lbl = new Label();
            ten_nimi_lbl = new Label();
            ten_hind_lbl = new Label();
            dataGridView_teen = new DataGridView();
            ten_cl_btn = new Button();
            keel_cb = new ComboBox();
            nim_teen_txt = new TextBox();
            hind_teen_txt = new TextBox();
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
            resources.ApplyResources(tabC, "tabC");
            tabC.Name = "tabC";
            tabC.SelectedIndex = 0;
            tabC.Click += tabC_Click;
            // 
            // Omanik
            // 
            Omanik.BackColor = Color.FromArgb(110, 0, 0);
            Omanik.Controls.Add(otsi_oma_txt);
            Omanik.Controls.Add(name_oma_lbl);
            Omanik.Controls.Add(oma_tel_txt);
            Omanik.Controls.Add(Telefon_oma_lbl);
            Omanik.Controls.Add(oma_nimi_txt);
            Omanik.Controls.Add(Omanikud);
            Omanik.Controls.Add(dataGridView_omanik);
            Omanik.ForeColor = Color.Wheat;
            resources.ApplyResources(Omanik, "Omanik");
            Omanik.Name = "Omanik";
            // 
            // otsi_oma_txt
            // 
            otsi_oma_txt.BackColor = Color.FloralWhite;
            otsi_oma_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(otsi_oma_txt, "otsi_oma_txt");
            otsi_oma_txt.Name = "otsi_oma_txt";
            // 
            // name_oma_lbl
            // 
            resources.ApplyResources(name_oma_lbl, "name_oma_lbl");
            name_oma_lbl.ForeColor = Color.FloralWhite;
            name_oma_lbl.Name = "name_oma_lbl";
            // 
            // oma_tel_txt
            // 
            oma_tel_txt.BackColor = Color.FloralWhite;
            oma_tel_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(oma_tel_txt, "oma_tel_txt");
            oma_tel_txt.Name = "oma_tel_txt";
            // 
            // Telefon_oma_lbl
            // 
            resources.ApplyResources(Telefon_oma_lbl, "Telefon_oma_lbl");
            Telefon_oma_lbl.ForeColor = Color.FloralWhite;
            Telefon_oma_lbl.Name = "Telefon_oma_lbl";
            // 
            // oma_nimi_txt
            // 
            oma_nimi_txt.BackColor = Color.FloralWhite;
            oma_nimi_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(oma_nimi_txt, "oma_nimi_txt");
            oma_nimi_txt.Name = "oma_nimi_txt";
            // 
            // Omanikud
            // 
            resources.ApplyResources(Omanikud, "Omanikud");
            Omanikud.BackColor = Color.FromArgb(110, 0, 0);
            Omanikud.ForeColor = Color.FloralWhite;
            Omanikud.Name = "Omanikud";
            // 
            // dataGridView_omanik
            // 
            dataGridView_omanik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_omanik.BackgroundColor = Color.FloralWhite;
            dataGridView_omanik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView_omanik, "dataGridView_omanik");
            dataGridView_omanik.Name = "dataGridView_omanik";
            // 
            // Autod
            // 
            Autod.BackColor = Color.FromArgb(110, 0, 0);
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
            resources.ApplyResources(Autod, "Autod");
            Autod.Name = "Autod";
            // 
            // otsi_auto_txt
            // 
            otsi_auto_txt.BackColor = Color.FloralWhite;
            otsi_auto_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(otsi_auto_txt, "otsi_auto_txt");
            otsi_auto_txt.Name = "otsi_auto_txt";
            // 
            // brand_auto_txt
            // 
            brand_auto_txt.BackColor = Color.FloralWhite;
            brand_auto_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(brand_auto_txt, "brand_auto_txt");
            brand_auto_txt.Name = "brand_auto_txt";
            // 
            // mudel_auto_txt
            // 
            mudel_auto_txt.BackColor = Color.FloralWhite;
            mudel_auto_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(mudel_auto_txt, "mudel_auto_txt");
            mudel_auto_txt.Name = "mudel_auto_txt";
            // 
            // RN_auto_txt
            // 
            RN_auto_txt.BackColor = Color.FloralWhite;
            RN_auto_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(RN_auto_txt, "RN_auto_txt");
            RN_auto_txt.Name = "RN_auto_txt";
            // 
            // OmaId_auto_cb
            // 
            OmaId_auto_cb.BackColor = Color.FloralWhite;
            OmaId_auto_cb.ForeColor = Color.FromArgb(110, 0, 0);
            OmaId_auto_cb.FormattingEnabled = true;
            resources.ApplyResources(OmaId_auto_cb, "OmaId_auto_cb");
            OmaId_auto_cb.Name = "OmaId_auto_cb";
            // 
            // Brand_auto_lbl
            // 
            resources.ApplyResources(Brand_auto_lbl, "Brand_auto_lbl");
            Brand_auto_lbl.Name = "Brand_auto_lbl";
            // 
            // OmaId_auto_lbl
            // 
            resources.ApplyResources(OmaId_auto_lbl, "OmaId_auto_lbl");
            OmaId_auto_lbl.Name = "OmaId_auto_lbl";
            // 
            // RN_auto_lbl
            // 
            resources.ApplyResources(RN_auto_lbl, "RN_auto_lbl");
            RN_auto_lbl.Name = "RN_auto_lbl";
            // 
            // Mudel_auto_lbl
            // 
            resources.ApplyResources(Mudel_auto_lbl, "Mudel_auto_lbl");
            Mudel_auto_lbl.Name = "Mudel_auto_lbl";
            // 
            // Autod_lbl
            // 
            resources.ApplyResources(Autod_lbl, "Autod_lbl");
            Autod_lbl.Name = "Autod_lbl";
            // 
            // dataGridView_autod
            // 
            dataGridView_autod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_autod.BackgroundColor = Color.FromArgb(240, 235, 225);
            dataGridView_autod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView_autod, "dataGridView_autod");
            dataGridView_autod.Name = "dataGridView_autod";
            // 
            // HjT
            // 
            HjT.BackColor = Color.FromArgb(110, 0, 0);
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
            resources.ApplyResources(HjT, "HjT");
            HjT.Name = "HjT";
            // 
            // otsi_hold_txt
            // 
            otsi_hold_txt.BackColor = Color.FloralWhite;
            otsi_hold_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(otsi_hold_txt, "otsi_hold_txt");
            otsi_hold_txt.Name = "otsi_hold_txt";
            // 
            // mileage_lbl
            // 
            resources.ApplyResources(mileage_lbl, "mileage_lbl");
            mileage_lbl.Name = "mileage_lbl";
            // 
            // hod_kuu_lbl
            // 
            resources.ApplyResources(hod_kuu_lbl, "hod_kuu_lbl");
            hod_kuu_lbl.Name = "hod_kuu_lbl";
            // 
            // hold_ten_lbl
            // 
            resources.ApplyResources(hold_ten_lbl, "hold_ten_lbl");
            hold_ten_lbl.Name = "hold_ten_lbl";
            // 
            // hold_auto_lbl
            // 
            resources.ApplyResources(hold_auto_lbl, "hold_auto_lbl");
            hold_auto_lbl.Name = "hold_auto_lbl";
            // 
            // mileage_txt
            // 
            mileage_txt.BackColor = Color.FloralWhite;
            mileage_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(mileage_txt, "mileage_txt");
            mileage_txt.Name = "mileage_txt";
            // 
            // tenus_vaata_btn
            // 
            tenus_vaata_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(tenus_vaata_btn, "tenus_vaata_btn");
            tenus_vaata_btn.ForeColor = Color.FromArgb(110, 0, 0);
            tenus_vaata_btn.Name = "tenus_vaata_btn";
            tenus_vaata_btn.UseVisualStyleBackColor = false;
            tenus_vaata_btn.Click += tenus_vaata_btn_Click;
            // 
            // hold_auto_cb
            // 
            hold_auto_cb.BackColor = Color.FloralWhite;
            hold_auto_cb.ForeColor = Color.FromArgb(110, 0, 0);
            hold_auto_cb.FormattingEnabled = true;
            resources.ApplyResources(hold_auto_cb, "hold_auto_cb");
            hold_auto_cb.Name = "hold_auto_cb";
            // 
            // teenus_cb
            // 
            teenus_cb.BackColor = Color.FloralWhite;
            teenus_cb.ForeColor = Color.FromArgb(110, 0, 0);
            teenus_cb.FormattingEnabled = true;
            resources.ApplyResources(teenus_cb, "teenus_cb");
            teenus_cb.Name = "teenus_cb";
            // 
            // hodl_datetime
            // 
            hodl_datetime.CalendarForeColor = Color.FromArgb(110, 0, 0);
            hodl_datetime.CalendarMonthBackground = Color.FloralWhite;
            hodl_datetime.CalendarTitleBackColor = Color.FloralWhite;
            hodl_datetime.CalendarTitleForeColor = Color.FromArgb(110, 0, 0);
            hodl_datetime.CalendarTrailingForeColor = Color.FromArgb(200, 0, 0);
            resources.ApplyResources(hodl_datetime, "hodl_datetime");
            hodl_datetime.MinDate = new DateTime(2025, 12, 16, 0, 0, 0, 0);
            hodl_datetime.Name = "hodl_datetime";
            hodl_datetime.Value = new DateTime(2025, 12, 16, 12, 28, 59, 0);
            // 
            // dataGridView_hold
            // 
            dataGridView_hold.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_hold.BackgroundColor = Color.FromArgb(240, 235, 225);
            dataGridView_hold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView_hold, "dataGridView_hold");
            dataGridView_hold.Name = "dataGridView_hold";
            // 
            // Holdus_lbl
            // 
            resources.ApplyResources(Holdus_lbl, "Holdus_lbl");
            Holdus_lbl.Name = "Holdus_lbl";
            // 
            // uue_btn
            // 
            uue_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(uue_btn, "uue_btn");
            uue_btn.ForeColor = Color.FromArgb(110, 0, 0);
            uue_btn.Name = "uue_btn";
            uue_btn.UseVisualStyleBackColor = false;
            uue_btn.Click += uue_btn_Click;
            // 
            // Otsi_btn
            // 
            Otsi_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(Otsi_btn, "Otsi_btn");
            Otsi_btn.ForeColor = Color.FromArgb(110, 0, 0);
            Otsi_btn.Name = "Otsi_btn";
            Otsi_btn.UseVisualStyleBackColor = false;
            Otsi_btn.Click += otsi_btn_Click;
            // 
            // Kustuta_btn
            // 
            Kustuta_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(Kustuta_btn, "Kustuta_btn");
            Kustuta_btn.ForeColor = Color.FromArgb(110, 0, 0);
            Kustuta_btn.Name = "Kustuta_btn";
            Kustuta_btn.UseVisualStyleBackColor = false;
            Kustuta_btn.Click += Kustuta_Click;
            // 
            // Lisa_btn
            // 
            Lisa_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(Lisa_btn, "Lisa_btn");
            Lisa_btn.ForeColor = Color.FromArgb(110, 0, 0);
            Lisa_btn.Name = "Lisa_btn";
            Lisa_btn.UseVisualStyleBackColor = false;
            Lisa_btn.Click += Lisa_btn_Click;
            // 
            // Teenuste_lbl
            // 
            resources.ApplyResources(Teenuste_lbl, "Teenuste_lbl");
            Teenuste_lbl.ForeColor = Color.FloralWhite;
            Teenuste_lbl.Name = "Teenuste_lbl";
            // 
            // ten_nimi_lbl
            // 
            resources.ApplyResources(ten_nimi_lbl, "ten_nimi_lbl");
            ten_nimi_lbl.ForeColor = Color.FloralWhite;
            ten_nimi_lbl.Name = "ten_nimi_lbl";
            // 
            // ten_hind_lbl
            // 
            resources.ApplyResources(ten_hind_lbl, "ten_hind_lbl");
            ten_hind_lbl.ForeColor = Color.FloralWhite;
            ten_hind_lbl.Name = "ten_hind_lbl";
            // 
            // dataGridView_teen
            // 
            dataGridView_teen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_teen.BackgroundColor = Color.FromArgb(240, 235, 225);
            dataGridView_teen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView_teen, "dataGridView_teen");
            dataGridView_teen.Name = "dataGridView_teen";
            // 
            // ten_cl_btn
            // 
            ten_cl_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(ten_cl_btn, "ten_cl_btn");
            ten_cl_btn.ForeColor = Color.FromArgb(110, 0, 0);
            ten_cl_btn.Name = "ten_cl_btn";
            ten_cl_btn.UseVisualStyleBackColor = false;
            ten_cl_btn.Click += tenus_kinni_btn_Click;
            // 
            // keel_cb
            // 
            keel_cb.BackColor = Color.FloralWhite;
            resources.ApplyResources(keel_cb, "keel_cb");
            keel_cb.ForeColor = Color.FromArgb(110, 0, 0);
            keel_cb.FormattingEnabled = true;
            keel_cb.Name = "keel_cb";
            keel_cb.SelectedIndexChanged += keel_cb_SelectedIndexChanged;
            // 
            // nim_teen_txt
            // 
            nim_teen_txt.BackColor = Color.FloralWhite;
            nim_teen_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(nim_teen_txt, "nim_teen_txt");
            nim_teen_txt.Name = "nim_teen_txt";
            // 
            // hind_teen_txt
            // 
            hind_teen_txt.BackColor = Color.FloralWhite;
            hind_teen_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(hind_teen_txt, "hind_teen_txt");
            hind_teen_txt.Name = "hind_teen_txt";
            // 
            // change_btn
            // 
            change_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(change_btn, "change_btn");
            change_btn.ForeColor = Color.FromArgb(110, 0, 0);
            change_btn.Name = "change_btn";
            change_btn.UseVisualStyleBackColor = false;
            change_btn.Click += Change_btn_Click;
            // 
            // otsi_teen_txt
            // 
            otsi_teen_txt.BackColor = Color.FloralWhite;
            otsi_teen_txt.ForeColor = Color.FromArgb(110, 0, 0);
            resources.ApplyResources(otsi_teen_txt, "otsi_teen_txt");
            otsi_teen_txt.Name = "otsi_teen_txt";
            // 
            // Kustuta_ch_btn
            // 
            Kustuta_ch_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(Kustuta_ch_btn, "Kustuta_ch_btn");
            Kustuta_ch_btn.ForeColor = Color.FromArgb(110, 0, 0);
            Kustuta_ch_btn.Name = "Kustuta_ch_btn";
            Kustuta_ch_btn.UseVisualStyleBackColor = false;
            Kustuta_ch_btn.Click += Kustuta_ch_Click;
            // 
            // Lisa_ch_btn
            // 
            Lisa_ch_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(Lisa_ch_btn, "Lisa_ch_btn");
            Lisa_ch_btn.ForeColor = Color.FromArgb(110, 0, 0);
            Lisa_ch_btn.Name = "Lisa_ch_btn";
            Lisa_ch_btn.UseVisualStyleBackColor = false;
            Lisa_ch_btn.Click += Lisa_ch_btn_Click;
            // 
            // uue_ch_btn
            // 
            uue_ch_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(uue_ch_btn, "uue_ch_btn");
            uue_ch_btn.ForeColor = Color.FromArgb(110, 0, 0);
            uue_ch_btn.Name = "uue_ch_btn";
            uue_ch_btn.UseVisualStyleBackColor = false;
            uue_ch_btn.Click += uue_ch_btn_Click;
            // 
            // Otsi_ch_btn
            // 
            Otsi_ch_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(Otsi_ch_btn, "Otsi_ch_btn");
            Otsi_ch_btn.ForeColor = Color.FromArgb(110, 0, 0);
            Otsi_ch_btn.Name = "Otsi_ch_btn";
            Otsi_ch_btn.UseVisualStyleBackColor = false;
            Otsi_ch_btn.Click += otsi_ch_btn_Click;
            // 
            // change_ch_btn
            // 
            change_ch_btn.BackColor = Color.FloralWhite;
            resources.ApplyResources(change_ch_btn, "change_ch_btn");
            change_ch_btn.ForeColor = Color.FromArgb(110, 0, 0);
            change_ch_btn.Name = "change_ch_btn";
            change_ch_btn.UseVisualStyleBackColor = false;
            change_ch_btn.Click += change_ch_btn_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 0, 0);
            Controls.Add(tabC);
            Controls.Add(uue_btn);
            Controls.Add(Otsi_btn);
            Controls.Add(Kustuta_btn);
            Controls.Add(Lisa_btn);
            Controls.Add(keel_cb);
            ForeColor = Color.FloralWhite;
            Name = "Form1";
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
        private TextBox hind_teen_txt;
        private Button change_btn;
        private TextBox otsi_oma_txt;
        private TextBox otsi_auto_txt;
        private TextBox otsi_hold_txt;
        private TextBox otsi_teen_txt;
        private Button Kustuta_ch_btn, Lisa_ch_btn, uue_ch_btn, Otsi_ch_btn, change_ch_btn;
    }
}
