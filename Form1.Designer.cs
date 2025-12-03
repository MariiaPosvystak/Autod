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
            Kustuta_oma_btn = new Button();
            Lisavorm_oma_btn = new Button();
            Vaata_oma_btn = new Button();
            Autod = new TabPage();
            Kust_auto_btm = new Button();
            Lisavorm_auto_btn = new Button();
            Vaata_auto_btn = new Button();
            HjT = new TabPage();
            dataGridView_omanik = new DataGridView();
            Omanikud = new Label();
            oma_nimi_txt = new TextBox();
            name_oma_lbl = new Label();
            oma_tel_txt = new TextBox();
            Telefon_oma_lbl = new Label();
            lisa_oma_btn = new Button();
            puhasta_oma_btn = new Button();
            toolTip = new ToolTip(components);
            dataGridView_autod = new DataGridView();
            Autod_lbl = new Label();
            Mudel_auto_lbl = new Label();
            RN_auto_lbl = new Label();
            OmaId_auto_lbl = new Label();
            Brand_auto_lbl = new Label();
            OmaId_auto_cb = new ComboBox();
            RN_auto_txt = new TextBox();
            mudel_auto_txt = new TextBox();
            brand_auto_txt = new TextBox();
            lisa_auto_btn = new Button();
            puhasta_auto_btn = new Button();
            tabC.SuspendLayout();
            Omanik.SuspendLayout();
            Autod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_omanik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_autod).BeginInit();
            SuspendLayout();
            // 
            // tabC
            // 
            tabC.Controls.Add(Omanik);
            tabC.Controls.Add(Autod);
            tabC.Controls.Add(HjT);
            tabC.Location = new Point(456, 12);
            tabC.Name = "tabC";
            tabC.SelectedIndex = 0;
            tabC.Size = new Size(356, 233);
            tabC.TabIndex = 0;
            tabC.Click += tabC_Click;
            // 
            // Omanik
            // 
            Omanik.Controls.Add(Kustuta_oma_btn);
            Omanik.Controls.Add(Lisavorm_oma_btn);
            Omanik.Controls.Add(Vaata_oma_btn);
            Omanik.Location = new Point(4, 24);
            Omanik.Name = "Omanik";
            Omanik.Padding = new Padding(3);
            Omanik.Size = new Size(348, 205);
            Omanik.TabIndex = 0;
            Omanik.Text = "Omanikud";
            Omanik.UseVisualStyleBackColor = true;
            // 
            // Kustuta_oma_btn
            // 
            Kustuta_oma_btn.BackColor = Color.Gray;
            Kustuta_oma_btn.ForeColor = SystemColors.ControlLightLight;
            Kustuta_oma_btn.Location = new Point(54, 153);
            Kustuta_oma_btn.Name = "Kustuta_oma_btn";
            Kustuta_oma_btn.Size = new Size(255, 35);
            Kustuta_oma_btn.TabIndex = 2;
            Kustuta_oma_btn.Text = "Kustuta";
            Kustuta_oma_btn.UseVisualStyleBackColor = false;
            Kustuta_oma_btn.Click += Kustuta_Click;
            // 
            // Lisavorm_oma_btn
            // 
            Lisavorm_oma_btn.BackColor = Color.Gray;
            Lisavorm_oma_btn.ForeColor = SystemColors.ControlLight;
            Lisavorm_oma_btn.Location = new Point(54, 85);
            Lisavorm_oma_btn.Name = "Lisavorm_oma_btn";
            Lisavorm_oma_btn.Size = new Size(255, 35);
            Lisavorm_oma_btn.TabIndex = 1;
            Lisavorm_oma_btn.Text = "Lisavorm";
            Lisavorm_oma_btn.UseVisualStyleBackColor = false;
            Lisavorm_oma_btn.Click += Lisa_Click;
            // 
            // Vaata_oma_btn
            // 
            Vaata_oma_btn.BackColor = Color.Gray;
            Vaata_oma_btn.ForeColor = SystemColors.ControlLightLight;
            Vaata_oma_btn.Location = new Point(54, 18);
            Vaata_oma_btn.Name = "Vaata_oma_btn";
            Vaata_oma_btn.Size = new Size(255, 35);
            Vaata_oma_btn.TabIndex = 0;
            Vaata_oma_btn.Text = "Vaata";
            Vaata_oma_btn.UseVisualStyleBackColor = false;
            Vaata_oma_btn.Click += Vaata_Click;
            // 
            // Autod
            // 
            Autod.Controls.Add(Kust_auto_btm);
            Autod.Controls.Add(Lisavorm_auto_btn);
            Autod.Controls.Add(Vaata_auto_btn);
            Autod.Location = new Point(4, 24);
            Autod.Name = "Autod";
            Autod.Padding = new Padding(3);
            Autod.Size = new Size(348, 205);
            Autod.TabIndex = 1;
            Autod.Text = "Autod";
            Autod.UseVisualStyleBackColor = true;
            // 
            // Kust_auto_btm
            // 
            Kust_auto_btm.BackColor = Color.Gray;
            Kust_auto_btm.ForeColor = SystemColors.ControlLightLight;
            Kust_auto_btm.Location = new Point(51, 151);
            Kust_auto_btm.Name = "Kust_auto_btm";
            Kust_auto_btm.Size = new Size(255, 35);
            Kust_auto_btm.TabIndex = 3;
            Kust_auto_btm.Text = "Kustuta";
            Kust_auto_btm.UseVisualStyleBackColor = false;
            Kust_auto_btm.Click += Kust_auto_btm_Click;
            // 
            // Lisavorm_auto_btn
            // 
            Lisavorm_auto_btn.BackColor = Color.Gray;
            Lisavorm_auto_btn.ForeColor = SystemColors.ControlLight;
            Lisavorm_auto_btn.Location = new Point(51, 85);
            Lisavorm_auto_btn.Name = "Lisavorm_auto_btn";
            Lisavorm_auto_btn.Size = new Size(255, 35);
            Lisavorm_auto_btn.TabIndex = 2;
            Lisavorm_auto_btn.Text = "Lisavorm";
            Lisavorm_auto_btn.UseVisualStyleBackColor = false;
            Lisavorm_auto_btn.Click += Lisavorm_auto_btn_Click;
            // 
            // Vaata_auto_btn
            // 
            Vaata_auto_btn.BackColor = Color.Gray;
            Vaata_auto_btn.ForeColor = SystemColors.ControlLightLight;
            Vaata_auto_btn.Location = new Point(51, 17);
            Vaata_auto_btn.Name = "Vaata_auto_btn";
            Vaata_auto_btn.Size = new Size(255, 35);
            Vaata_auto_btn.TabIndex = 1;
            Vaata_auto_btn.Text = "Vaata";
            Vaata_auto_btn.UseVisualStyleBackColor = false;
            Vaata_auto_btn.Click += Vaata_auto_btn_Click;
            // 
            // HjT
            // 
            HjT.Location = new Point(4, 24);
            HjT.Name = "HjT";
            HjT.Size = new Size(348, 205);
            HjT.TabIndex = 2;
            HjT.Text = "Hooldus ja Teenused";
            HjT.UseVisualStyleBackColor = true;
            // 
            // dataGridView_omanik
            // 
            dataGridView_omanik.Location = new Point(20, 250);
            dataGridView_omanik.Name = "dataGridView_omanik";
            dataGridView_omanik.Size = new Size(790, 290);
            dataGridView_omanik.TabIndex = 0;
            // 
            // Omanikud
            // 
            Omanikud.AutoSize = true;
            Omanikud.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Omanikud.Location = new Point(31, 12);
            Omanikud.Name = "Omanikud";
            Omanikud.Size = new Size(166, 44);
            Omanikud.TabIndex = 1;
            Omanikud.Text = "Omanikud";
            // 
            // oma_nimi_txt
            // 
            oma_nimi_txt.Location = new Point(205, 110);
            oma_nimi_txt.Name = "oma_nimi_txt";
            oma_nimi_txt.Size = new Size(120, 23);
            oma_nimi_txt.TabIndex = 2;
            // 
            // name_oma_lbl
            // 
            name_oma_lbl.AutoSize = true;
            name_oma_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            name_oma_lbl.Location = new Point(12, 110);
            name_oma_lbl.Name = "name_oma_lbl";
            name_oma_lbl.Size = new Size(121, 21);
            name_oma_lbl.TabIndex = 3;
            name_oma_lbl.Text = "Ees- ja perenimi";
            // 
            // oma_tel_txt
            // 
            oma_tel_txt.Location = new Point(205, 169);
            oma_tel_txt.Name = "oma_tel_txt";
            oma_tel_txt.Size = new Size(120, 23);
            oma_tel_txt.TabIndex = 4;
            // 
            // Telefon_oma_lbl
            // 
            Telefon_oma_lbl.AutoSize = true;
            Telefon_oma_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Telefon_oma_lbl.Location = new Point(12, 171);
            Telefon_oma_lbl.Name = "Telefon_oma_lbl";
            Telefon_oma_lbl.Size = new Size(59, 21);
            Telefon_oma_lbl.TabIndex = 5;
            Telefon_oma_lbl.Text = "Telefon";
            // 
            // lisa_oma_btn
            // 
            lisa_oma_btn.Location = new Point(101, 221);
            lisa_oma_btn.Name = "lisa_oma_btn";
            lisa_oma_btn.Size = new Size(65, 24);
            lisa_oma_btn.TabIndex = 7;
            lisa_oma_btn.Text = "Lisa";
            lisa_oma_btn.UseVisualStyleBackColor = true;
            lisa_oma_btn.Click += Lisa_oma_Click;
            // 
            // puhasta_oma_btn
            // 
            puhasta_oma_btn.Location = new Point(178, 221);
            puhasta_oma_btn.Name = "puhasta_oma_btn";
            puhasta_oma_btn.Size = new Size(65, 24);
            puhasta_oma_btn.TabIndex = 8;
            puhasta_oma_btn.Text = "Puhasta";
            puhasta_oma_btn.UseVisualStyleBackColor = true;
            puhasta_oma_btn.Click += puhasta_oma_Click;
            // 
            // dataGridView_autod
            // 
            dataGridView_autod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_autod.Location = new Point(13, 265);
            dataGridView_autod.Name = "dataGridView_autod";
            dataGridView_autod.Size = new Size(802, 277);
            dataGridView_autod.TabIndex = 1;
            // 
            // Autod_lbl
            // 
            Autod_lbl.AutoSize = true;
            Autod_lbl.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Autod_lbl.Location = new Point(31, 12);
            Autod_lbl.Name = "Autod_lbl";
            Autod_lbl.Size = new Size(101, 44);
            Autod_lbl.TabIndex = 2;
            Autod_lbl.Text = "Autod";
            // 
            // Mudel_auto_lbl
            // 
            Mudel_auto_lbl.AutoSize = true;
            Mudel_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Mudel_auto_lbl.Location = new Point(31, 126);
            Mudel_auto_lbl.Name = "Mudel_auto_lbl";
            Mudel_auto_lbl.Size = new Size(54, 21);
            Mudel_auto_lbl.TabIndex = 3;
            Mudel_auto_lbl.Text = "Mudel";
            // 
            // RN_auto_lbl
            // 
            RN_auto_lbl.AutoSize = true;
            RN_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            RN_auto_lbl.Location = new Point(31, 176);
            RN_auto_lbl.Name = "RN_auto_lbl";
            RN_auto_lbl.Size = new Size(165, 21);
            RN_auto_lbl.TabIndex = 4;
            RN_auto_lbl.Text = "Registreerimisnumber";
            // 
            // OmaId_auto_lbl
            // 
            OmaId_auto_lbl.AutoSize = true;
            OmaId_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            OmaId_auto_lbl.Location = new Point(31, 220);
            OmaId_auto_lbl.Name = "OmaId_auto_lbl";
            OmaId_auto_lbl.Size = new Size(65, 21);
            OmaId_auto_lbl.TabIndex = 5;
            OmaId_auto_lbl.Text = "Omanik";
            // 
            // Brand_auto_lbl
            // 
            Brand_auto_lbl.AutoSize = true;
            Brand_auto_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            Brand_auto_lbl.Location = new Point(31, 82);
            Brand_auto_lbl.Name = "Brand_auto_lbl";
            Brand_auto_lbl.Size = new Size(51, 21);
            Brand_auto_lbl.TabIndex = 6;
            Brand_auto_lbl.Text = "Bränd";
            // 
            // OmaId_auto_cb
            // 
            OmaId_auto_cb.FormattingEnabled = true;
            OmaId_auto_cb.Location = new Point(219, 218);
            OmaId_auto_cb.Name = "OmaId_auto_cb";
            OmaId_auto_cb.Size = new Size(130, 23);
            OmaId_auto_cb.TabIndex = 7;
            // 
            // RN_auto_txt
            // 
            RN_auto_txt.Location = new Point(219, 174);
            RN_auto_txt.Name = "RN_auto_txt";
            RN_auto_txt.Size = new Size(130, 23);
            RN_auto_txt.TabIndex = 8;
            // 
            // mudel_auto_txt
            // 
            mudel_auto_txt.Location = new Point(219, 124);
            mudel_auto_txt.Name = "mudel_auto_txt";
            mudel_auto_txt.Size = new Size(130, 23);
            mudel_auto_txt.TabIndex = 9;
            // 
            // brand_auto_txt
            // 
            brand_auto_txt.Location = new Point(219, 80);
            brand_auto_txt.Name = "brand_auto_txt";
            brand_auto_txt.Size = new Size(130, 23);
            brand_auto_txt.TabIndex = 10;
            // 
            // lisa_auto_btn
            // 
            lisa_auto_btn.Location = new Point(101, 221);
            lisa_auto_btn.Name = "lisa_auto_btn";
            lisa_auto_btn.Size = new Size(65, 24);
            lisa_auto_btn.TabIndex = 7;
            lisa_auto_btn.Text = "Lisa";
            lisa_auto_btn.UseVisualStyleBackColor = true;
            lisa_auto_btn.Click += Lisa_oma_Click;
            // 
            // puhasta_auto_btn
            // 
            puhasta_auto_btn.Location = new Point(178, 221);
            puhasta_auto_btn.Name = "puhasta_auto_btn";
            puhasta_auto_btn.Size = new Size(65, 24);
            puhasta_auto_btn.TabIndex = 8;
            puhasta_auto_btn.Text = "Puhasta";
            puhasta_auto_btn.UseVisualStyleBackColor = true;
            puhasta_auto_btn.Click += puhasta_oma_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 554);
            Controls.Add(tabC);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabC.ResumeLayout(false);
            Omanik.ResumeLayout(false);
            Autod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_omanik).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_autod).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TabControl tabC;
        private TabPage Omanik;
        private TabPage Autod;
        private TabPage HjT;
        private Button Kustuta_oma_btn;
        private Button Lisavorm_oma_btn;
        private Button Vaata_oma_btn;
        private DataGridView dataGridView_omanik;
        private Label Omanikud;
        private TextBox oma_nimi_txt;
        private Label name_oma_lbl;
        private TextBox oma_tel_txt;
        private Label Telefon_oma_lbl;
        private Button lisa_oma_btn;
        private Button puhasta_oma_btn;
        private ToolTip toolTip;
        private Button Kust_auto_btm;
        private Button Lisavorm_auto_btn;
        private Button Vaata_auto_btn;
        private DataGridView dataGridView_autod;
        private Label Autod_lbl;
        private Label Mudel_auto_lbl;
        private Label RN_auto_lbl;
        private Label OmaId_auto_lbl;
        private Label Brand_auto_lbl;
        private ComboBox OmaId_auto_cb;
        private TextBox RN_auto_txt;
        private TextBox mudel_auto_txt;
        private TextBox brand_auto_txt;
        private Button lisa_auto_btn;
        private Button puhasta_auto_btn;
    }
}
