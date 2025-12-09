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
            name_oma_lbl = new Label();
            oma_tel_txt = new TextBox();
            Telefon_oma_lbl = new Label();
            oma_nimi_txt = new TextBox();
            Omanikud = new Label();
            dataGridView_omanik = new DataGridView();
            Autod = new TabPage();
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
            mileage_lbl = new Label();
            hod_kuu_lbl = new Label();
            hold_ten_lbl = new Label();
            hold_auto_lbl = new Label();
            mileage_txt = new TextBox();
            tenus_vaata_btn = new Button();
            hold_auto_cb = new ComboBox();
            teenus_cb = new ComboBox();
            hodl_datetime = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Holdus_lbl = new Label();
            uue_btn = new Button();
            Otsi_btn = new Button();
            Kustuta_btn = new Button();
            Lisa_btn = new Button();
            toolTip = new ToolTip(components);
            Teenuste_lbl = new Label();
            ten_nimi_lbl = new Label();
            ten_hind_lbl = new Label();
            dataGridView2 = new DataGridView();
            ten_cl_btn = new Button();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tabC.SuspendLayout();
            Omanik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_omanik).BeginInit();
            Autod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_autod).BeginInit();
            HjT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabC
            // 
            tabC.Controls.Add(Omanik);
            tabC.Controls.Add(Autod);
            tabC.Controls.Add(HjT);
            tabC.Location = new Point(12, 13);
            tabC.Margin = new Padding(3, 4, 3, 4);
            tabC.Name = "tabC";
            tabC.SelectedIndex = 0;
            tabC.Size = new Size(738, 637);
            tabC.TabIndex = 0;
            // 
            // Omanik
            // 
            Omanik.Controls.Add(name_oma_lbl);
            Omanik.Controls.Add(oma_tel_txt);
            Omanik.Controls.Add(Telefon_oma_lbl);
            Omanik.Controls.Add(oma_nimi_txt);
            Omanik.Controls.Add(Omanikud);
            Omanik.Controls.Add(dataGridView_omanik);
            Omanik.Location = new Point(4, 29);
            Omanik.Margin = new Padding(3, 4, 3, 4);
            Omanik.Name = "Omanik";
            Omanik.Padding = new Padding(3, 4, 3, 4);
            Omanik.Size = new Size(730, 604);
            Omanik.TabIndex = 0;
            Omanik.Text = "Omanikud";
            Omanik.UseVisualStyleBackColor = true;
            // 
            // name_oma_lbl
            // 
            name_oma_lbl.AutoSize = true;
            name_oma_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            name_oma_lbl.Location = new Point(15, 114);
            name_oma_lbl.Name = "name_oma_lbl";
            name_oma_lbl.Size = new Size(150, 28);
            name_oma_lbl.TabIndex = 3;
            name_oma_lbl.Text = "Ees- ja perenimi";
            // 
            // oma_tel_txt
            // 
            oma_tel_txt.Location = new Point(205, 169);
            oma_tel_txt.Name = "oma_tel_txt";
            oma_tel_txt.Size = new Size(120, 27);
            oma_tel_txt.TabIndex = 4;
            // 
            // Telefon_oma_lbl
            // 
            Telefon_oma_lbl.AutoSize = true;
            Telefon_oma_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Telefon_oma_lbl.Location = new Point(15, 175);
            Telefon_oma_lbl.Name = "Telefon_oma_lbl";
            Telefon_oma_lbl.Size = new Size(74, 28);
            Telefon_oma_lbl.TabIndex = 5;
            Telefon_oma_lbl.Text = "Telefon";
            // 
            // oma_nimi_txt
            // 
            oma_nimi_txt.Location = new Point(205, 110);
            oma_nimi_txt.Name = "oma_nimi_txt";
            oma_nimi_txt.Size = new Size(120, 27);
            oma_nimi_txt.TabIndex = 2;
            // 
            // Omanikud
            // 
            Omanikud.AutoSize = true;
            Omanikud.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Omanikud.Location = new Point(34, 16);
            Omanikud.Name = "Omanikud";
            Omanikud.Size = new Size(211, 55);
            Omanikud.TabIndex = 1;
            Omanikud.Text = "Omanikud";
            // 
            // dataGridView_omanik
            // 
            dataGridView_omanik.ColumnHeadersHeight = 29;
            dataGridView_omanik.Location = new Point(15, 250);
            dataGridView_omanik.Name = "dataGridView_omanik";
            dataGridView_omanik.RowHeadersWidth = 51;
            dataGridView_omanik.Size = new Size(701, 347);
            dataGridView_omanik.TabIndex = 0;
            // 
            // Autod
            // 
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
            Autod.Location = new Point(4, 29);
            Autod.Margin = new Padding(3, 4, 3, 4);
            Autod.Name = "Autod";
            Autod.Padding = new Padding(3, 4, 3, 4);
            Autod.Size = new Size(730, 604);
            Autod.TabIndex = 1;
            Autod.Text = "Autod";
            Autod.UseVisualStyleBackColor = true;
            // 
            // brand_auto_txt
            // 
            brand_auto_txt.Location = new Point(219, 90);
            brand_auto_txt.Name = "brand_auto_txt";
            brand_auto_txt.Size = new Size(203, 27);
            brand_auto_txt.TabIndex = 10;
            // 
            // mudel_auto_txt
            // 
            mudel_auto_txt.Location = new Point(219, 131);
            mudel_auto_txt.Name = "mudel_auto_txt";
            mudel_auto_txt.Size = new Size(203, 27);
            mudel_auto_txt.TabIndex = 9;
            // 
            // RN_auto_txt
            // 
            RN_auto_txt.Location = new Point(219, 174);
            RN_auto_txt.Name = "RN_auto_txt";
            RN_auto_txt.Size = new Size(203, 27);
            RN_auto_txt.TabIndex = 8;
            // 
            // OmaId_auto_cb
            // 
            OmaId_auto_cb.FormattingEnabled = true;
            OmaId_auto_cb.Location = new Point(219, 216);
            OmaId_auto_cb.Name = "OmaId_auto_cb";
            OmaId_auto_cb.Size = new Size(203, 28);
            OmaId_auto_cb.TabIndex = 7;
            // 
            // Brand_auto_lbl
            // 
            Brand_auto_lbl.AutoSize = true;
            Brand_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Brand_auto_lbl.Location = new Point(13, 89);
            Brand_auto_lbl.Name = "Brand_auto_lbl";
            Brand_auto_lbl.Size = new Size(63, 28);
            Brand_auto_lbl.TabIndex = 6;
            Brand_auto_lbl.Text = "Bränd";
            // 
            // OmaId_auto_lbl
            // 
            OmaId_auto_lbl.AutoSize = true;
            OmaId_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            OmaId_auto_lbl.Location = new Point(13, 216);
            OmaId_auto_lbl.Name = "OmaId_auto_lbl";
            OmaId_auto_lbl.Size = new Size(80, 28);
            OmaId_auto_lbl.TabIndex = 5;
            OmaId_auto_lbl.Text = "Omanik";
            // 
            // RN_auto_lbl
            // 
            RN_auto_lbl.AutoSize = true;
            RN_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            RN_auto_lbl.Location = new Point(13, 173);
            RN_auto_lbl.Name = "RN_auto_lbl";
            RN_auto_lbl.Size = new Size(202, 28);
            RN_auto_lbl.TabIndex = 4;
            RN_auto_lbl.Text = "Registreerimisnumber";
            // 
            // Mudel_auto_lbl
            // 
            Mudel_auto_lbl.AutoSize = true;
            Mudel_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Mudel_auto_lbl.Location = new Point(13, 130);
            Mudel_auto_lbl.Name = "Mudel_auto_lbl";
            Mudel_auto_lbl.Size = new Size(68, 28);
            Mudel_auto_lbl.TabIndex = 3;
            Mudel_auto_lbl.Text = "Mudel";
            // 
            // Autod_lbl
            // 
            Autod_lbl.AutoSize = true;
            Autod_lbl.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Autod_lbl.Location = new Point(34, 16);
            Autod_lbl.Name = "Autod_lbl";
            Autod_lbl.Size = new Size(129, 55);
            Autod_lbl.TabIndex = 2;
            Autod_lbl.Text = "Autod";
            // 
            // dataGridView_autod
            // 
            dataGridView_autod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_autod.Location = new Point(13, 265);
            dataGridView_autod.Name = "dataGridView_autod";
            dataGridView_autod.RowHeadersWidth = 51;
            dataGridView_autod.Size = new Size(711, 332);
            dataGridView_autod.TabIndex = 1;
            // 
            // HjT
            // 
            HjT.Controls.Add(mileage_lbl);
            HjT.Controls.Add(hod_kuu_lbl);
            HjT.Controls.Add(hold_ten_lbl);
            HjT.Controls.Add(hold_auto_lbl);
            HjT.Controls.Add(mileage_txt);
            HjT.Controls.Add(tenus_vaata_btn);
            HjT.Controls.Add(hold_auto_cb);
            HjT.Controls.Add(teenus_cb);
            HjT.Controls.Add(hodl_datetime);
            HjT.Controls.Add(dataGridView1);
            HjT.Controls.Add(Holdus_lbl);
            HjT.Location = new Point(4, 29);
            HjT.Margin = new Padding(3, 4, 3, 4);
            HjT.Name = "HjT";
            HjT.Size = new Size(730, 604);
            HjT.TabIndex = 2;
            HjT.Text = "Hooldus ja Teenused";
            HjT.UseVisualStyleBackColor = true;
            // 
            // mileage_lbl
            // 
            mileage_lbl.AutoSize = true;
            mileage_lbl.Location = new Point(34, 257);
            mileage_lbl.Name = "mileage_lbl";
            mileage_lbl.Size = new Size(63, 20);
            mileage_lbl.TabIndex = 11;
            mileage_lbl.Text = "Mileage";
            // 
            // hod_kuu_lbl
            // 
            hod_kuu_lbl.AutoSize = true;
            hod_kuu_lbl.Location = new Point(34, 210);
            hod_kuu_lbl.Name = "hod_kuu_lbl";
            hod_kuu_lbl.Size = new Size(66, 20);
            hod_kuu_lbl.TabIndex = 10;
            hod_kuu_lbl.Text = "Kuupäev";
            // 
            // hold_ten_lbl
            // 
            hold_ten_lbl.AutoSize = true;
            hold_ten_lbl.Location = new Point(34, 159);
            hold_ten_lbl.Name = "hold_ten_lbl";
            hold_ten_lbl.Size = new Size(54, 20);
            hold_ten_lbl.TabIndex = 9;
            hold_ten_lbl.Text = "Teenus";
            // 
            // hold_auto_lbl
            // 
            hold_auto_lbl.AutoSize = true;
            hold_auto_lbl.Location = new Point(34, 108);
            hold_auto_lbl.Name = "hold_auto_lbl";
            hold_auto_lbl.Size = new Size(41, 20);
            hold_auto_lbl.TabIndex = 8;
            hold_auto_lbl.Text = "Auto";
            // 
            // mileage_txt
            // 
            mileage_txt.Location = new Point(195, 250);
            mileage_txt.Name = "mileage_txt";
            mileage_txt.Size = new Size(190, 27);
            mileage_txt.TabIndex = 7;
            // 
            // tenus_vaata_btn
            // 
            tenus_vaata_btn.BackColor = Color.Gray;
            tenus_vaata_btn.ForeColor = SystemColors.ControlLightLight;
            tenus_vaata_btn.Location = new Point(532, 21);
            tenus_vaata_btn.Margin = new Padding(3, 4, 3, 4);
            tenus_vaata_btn.Name = "tenus_vaata_btn";
            tenus_vaata_btn.Size = new Size(183, 68);
            tenus_vaata_btn.TabIndex = 0;
            tenus_vaata_btn.Text = "Teenuste vaata";
            tenus_vaata_btn.UseVisualStyleBackColor = false;
            tenus_vaata_btn.Click += tenus_vaata_btn_Click;
            // 
            // hold_auto_cb
            // 
            hold_auto_cb.FormattingEnabled = true;
            hold_auto_cb.Location = new Point(195, 108);
            hold_auto_cb.Name = "hold_auto_cb";
            hold_auto_cb.Size = new Size(190, 28);
            hold_auto_cb.TabIndex = 6;
            // 
            // teenus_cb
            // 
            teenus_cb.FormattingEnabled = true;
            teenus_cb.Location = new Point(195, 159);
            teenus_cb.Name = "teenus_cb";
            teenus_cb.Size = new Size(190, 28);
            teenus_cb.TabIndex = 5;
            // 
            // hodl_datetime
            // 
            hodl_datetime.Location = new Point(195, 210);
            hodl_datetime.Name = "hodl_datetime";
            hodl_datetime.Size = new Size(190, 27);
            hodl_datetime.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(700, 286);
            dataGridView1.TabIndex = 3;
            // 
            // Holdus_lbl
            // 
            Holdus_lbl.AutoSize = true;
            Holdus_lbl.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Holdus_lbl.Location = new Point(34, 16);
            Holdus_lbl.Name = "Holdus_lbl";
            Holdus_lbl.Size = new Size(147, 55);
            Holdus_lbl.TabIndex = 2;
            Holdus_lbl.Text = "Holdus";
            // 
            // uue_btn
            // 
            uue_btn.BackColor = Color.Gray;
            uue_btn.ForeColor = SystemColors.ControlLight;
            uue_btn.Location = new Point(319, 662);
            uue_btn.Margin = new Padding(3, 4, 3, 4);
            uue_btn.Name = "uue_btn";
            uue_btn.Size = new Size(290, 68);
            uue_btn.TabIndex = 4;
            uue_btn.Text = "Uuenda";
            uue_btn.UseVisualStyleBackColor = false;
            uue_btn.Click += uue_btn_Click;
            // 
            // Otsi_btn
            // 
            Otsi_btn.BackColor = Color.Gray;
            Otsi_btn.ForeColor = SystemColors.ControlLight;
            Otsi_btn.Location = new Point(932, 662);
            Otsi_btn.Margin = new Padding(3, 4, 3, 4);
            Otsi_btn.Name = "Otsi_btn";
            Otsi_btn.Size = new Size(290, 68);
            Otsi_btn.TabIndex = 3;
            Otsi_btn.Text = "Otsi";
            Otsi_btn.UseVisualStyleBackColor = false;
            // 
            // Kustuta_btn
            // 
            Kustuta_btn.BackColor = Color.Gray;
            Kustuta_btn.ForeColor = SystemColors.ControlLightLight;
            Kustuta_btn.Location = new Point(626, 662);
            Kustuta_btn.Margin = new Padding(3, 4, 3, 4);
            Kustuta_btn.Name = "Kustuta_btn";
            Kustuta_btn.Size = new Size(290, 68);
            Kustuta_btn.TabIndex = 2;
            Kustuta_btn.Text = "Kustuta";
            Kustuta_btn.UseVisualStyleBackColor = false;
            Kustuta_btn.Click += Kustuta_Click;
            // 
            // Lisa_btn
            // 
            Lisa_btn.BackColor = Color.Gray;
            Lisa_btn.ForeColor = SystemColors.ControlLight;
            Lisa_btn.Location = new Point(12, 662);
            Lisa_btn.Margin = new Padding(3, 4, 3, 4);
            Lisa_btn.Name = "Lisa_btn";
            Lisa_btn.Size = new Size(290, 68);
            Lisa_btn.TabIndex = 1;
            Lisa_btn.Text = "Lisa";
            Lisa_btn.UseVisualStyleBackColor = false;
            Lisa_btn.Click += Lisa_btn_Click;
            // 
            // Teenuste_lbl
            // 
            Teenuste_lbl.AutoSize = true;
            Teenuste_lbl.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Teenuste_lbl.Location = new Point(900, 42);
            Teenuste_lbl.Name = "Teenuste_lbl";
            Teenuste_lbl.Size = new Size(184, 55);
            Teenuste_lbl.TabIndex = 5;
            Teenuste_lbl.Text = "Teenuste";
            // 
            // ten_nimi_lbl
            // 
            ten_nimi_lbl.AutoSize = true;
            ten_nimi_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ten_nimi_lbl.Location = new Point(768, 181);
            ten_nimi_lbl.Name = "ten_nimi_lbl";
            ten_nimi_lbl.Size = new Size(54, 28);
            ten_nimi_lbl.TabIndex = 6;
            ten_nimi_lbl.Text = "Nimi";
            // 
            // ten_hind_lbl
            // 
            ten_hind_lbl.AutoSize = true;
            ten_hind_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ten_hind_lbl.Location = new Point(768, 252);
            ten_hind_lbl.Name = "ten_hind_lbl";
            ten_hind_lbl.Size = new Size(54, 28);
            ten_hind_lbl.TabIndex = 7;
            ten_hind_lbl.Text = "Hind";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(752, 345);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(456, 286);
            dataGridView2.TabIndex = 8;
            // 
            // ten_cl_btn
            // 
            ten_cl_btn.BackColor = Color.Gray;
            ten_cl_btn.ForeColor = SystemColors.ControlLight;
            ten_cl_btn.Location = new Point(1148, 42);
            ten_cl_btn.Margin = new Padding(3, 4, 3, 4);
            ten_cl_btn.Name = "ten_cl_btn";
            ten_cl_btn.Size = new Size(64, 54);
            ten_cl_btn.TabIndex = 9;
            ten_cl_btn.Text = "Kinni";
            ten_cl_btn.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(743, 13);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(932, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(932, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 27);
            textBox2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 743);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(ten_cl_btn);
            Controls.Add(dataGridView2);
            Controls.Add(ten_hind_lbl);
            Controls.Add(ten_nimi_lbl);
            Controls.Add(Teenuste_lbl);
            Controls.Add(tabC);
            Controls.Add(uue_btn);
            Controls.Add(Otsi_btn);
            Controls.Add(Kustuta_btn);
            Controls.Add(Lisa_btn);
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private DataGridView dataGridView1;
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
        private DataGridView dataGridView2;
        private Button ten_cl_btn;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
