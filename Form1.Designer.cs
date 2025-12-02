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
            HjT = new TabPage();
            dataGridView_omanik = new DataGridView();
            Omanikud = new Label();
            oma_nimi_txt = new TextBox();
            label2 = new Label();
            oma_tel_txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lisa_oma_btn = new Button();
            puhasta_oma_btn = new Button();
            toolTip_oma = new ToolTip(components);
            tabC.SuspendLayout();
            Omanik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_omanik).BeginInit();
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
            Omanik.Click += Omanik_Click;
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
            Autod.Location = new Point(4, 24);
            Autod.Name = "Autod";
            Autod.Padding = new Padding(3);
            Autod.Size = new Size(348, 205);
            Autod.TabIndex = 1;
            Autod.Text = "Autod";
            Autod.UseVisualStyleBackColor = true;
            Autod.Click += Autod_Click;
            // 
            // HjT
            // 
            HjT.Location = new Point(4, 24);
            HjT.Name = "HjT";
            HjT.Size = new Size(348, 205);
            HjT.TabIndex = 2;
            HjT.Text = "Hooldus ja Teenused";
            HjT.UseVisualStyleBackColor = true;
            HjT.Click += HjT_Click;
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
            // oma_nimi_box
            // 
            oma_nimi_txt.Location = new Point(205, 110);
            oma_nimi_txt.Name = "oma_nimi_box";
            oma_nimi_txt.Size = new Size(120, 23);
            oma_nimi_txt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 3;
            label2.Text = "Ees- ja perenimi";
            // 
            // oma_tel_box
            // 
            oma_tel_txt.Location = new Point(205, 169);
            oma_tel_txt.Name = "oma_tel_box";
            oma_tel_txt.Size = new Size(120, 23);
            oma_tel_txt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 5;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 246);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView_omanik).EndInit();
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
        private Label label2;
        private TextBox oma_tel_txt;
        private Label label3;
        private Label label4;
        private Button lisa_oma_btn;
        private Button puhasta_oma_btn;
        private ToolTip toolTip_oma;
    }
}
