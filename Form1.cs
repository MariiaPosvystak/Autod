using Autod.Data;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Autod
{
    public partial class Form1 : Form
    {
        /// 
        /// Form
        /// 
        private readonly AutoDbContext _db;
        public Form1()
        {
            _db = new AutoDbContext();
            InitializeComponent();
            LaeOmanik();
            LaeAutod();
            LaeOmanikId();
            using (var db = new AutoDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Kustuta_oma_btn.Enabled = false;
            toolTip.SetToolTip(Kustuta_oma_btn, "Tabelist andmete kustutamiseks valige kustutatavad isikud.");
            Kustuta_oma_btn.ForeColor = Color.Silver;

            Kust_auto_btm.Enabled = false;
            Kust_auto_btm.ForeColor = Color.Silver;
            toolTip.SetToolTip(Kust_auto_btm, "Tabelist andmete kustutamiseks valige kustutatavad isikud.");
        }
        private void tabC_Click(object sender, EventArgs e)
        {
            // Omanik
            Controls.Remove(dataGridView_omanik);
            Controls.Remove(puhasta_oma_btn);
            Controls.Remove(lisa_oma_btn);
            Controls.Remove(name_oma_lbl);
            Controls.Remove(oma_tel_txt);
            Controls.Remove(Telefon_oma_lbl);
            Controls.Remove(oma_nimi_txt);
            Controls.Remove(Omanikud);

            Kustuta_oma_btn.Enabled = false;
            Kustuta_oma_btn.ForeColor = Color.Silver;

            //Autod
            Controls.Remove(dataGridView_autod);
            Controls.Remove(brand_auto_txt);
            Controls.Remove(mudel_auto_txt);
            Controls.Remove(RN_auto_txt);
            Controls.Remove(OmaId_auto_cb);
            Controls.Remove(Brand_auto_lbl);
            Controls.Remove(OmaId_auto_lbl);
            Controls.Remove(RN_auto_lbl);
            Controls.Remove(Mudel_auto_lbl);
            Controls.Remove(Autod_lbl);
            Controls.Remove(lisa_auto_btn);
            Controls.Remove(puhasta_auto_btn);

            Kust_auto_btm.Enabled = false;
            Kust_auto_btm.ForeColor = Color.Silver;
        }
        ///
        /// Omanik
        ///
        private void LaeOmanik()
        {
            dataGridView_omanik.DataSource = _db.Omanik.ToList();
        }
        private void Lisa_Click(object sender, EventArgs e)
        {
            Controls.Add(puhasta_oma_btn);
            Controls.Add(lisa_oma_btn);
            Controls.Add(name_oma_lbl);
            Controls.Add(oma_tel_txt);
            Controls.Add(Telefon_oma_lbl);
            Controls.Add(oma_nimi_txt);
            Controls.Add(Omanikud);
        }
        private void Lisa_oma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(oma_nimi_txt.Text))
            {
                MessageBox.Show("Omanik nimetus on kohustuslik");
                return;
            }
            var uus = new Owner
            {
                FullName = oma_nimi_txt.Text,
                Phone = oma_tel_txt.Text
            };
            _db.Omanik.Add(uus);
            _db.SaveChanges();
            LaeOmanik();
            Controls.Add(dataGridView_omanik);
            Kustuta_oma_btn.Enabled = true;
            Kustuta_oma_btn.ForeColor = Color.White;
        }
        private void Vaata_Click(object sender, EventArgs e)
        {
            Kustuta_oma_btn.Enabled = true;
            Kustuta_oma_btn.ForeColor = Color.White;

            Controls.Add(dataGridView_omanik);
        }
        private void Kustuta_Click(object sender, EventArgs e)
        {
            if (dataGridView_omanik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kasutatav omanik.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string omanikNimetus = dataGridView_omanik.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "valitud omanik";
            DialogResult vastus = MessageBox.Show(
                $"Kas olete kindel, et soovite kustuta omanik: {omanikNimetus}?",
                "Kustutamise kinnitus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (vastus == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridView_omanik.SelectedRows[0].Cells["Id"].Value;
                    var omanik = _db.Omanik.Find(id);

                    if (omanik != null)
                    {
                        _db.Omanik.Remove(omanik);
                        _db.SaveChanges();
                        LaeOmanik();
                        //puhasta_oma_Click;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void puhasta_oma_Click(object sender, EventArgs e)
        {
            oma_nimi_txt.Clear();
            oma_tel_txt.Clear();
        }
        ///
        /// Auto
        ///
        private void LaeAutod()
        {
            dataGridView_autod.DataSource = _db.Auto.Include(a => a.Owner).Select(a => new
            {
                a.Id,
                a.Brand,
                a.Model,
                a.RegistrationNumber,
                Omanik = a.Owner.FullName
            }).ToList();

            if (dataGridView_autod.Columns["OwnerId"] != null)
                dataGridView_autod.Columns["OwnerId"].Visible = false;
        }
        private void LaeOmanikId()
        {
            var omanikId = _db.Omanik.ToList();
            OmaId_auto_cb.DataSource = omanikId;
            OmaId_auto_cb.DisplayMember = "FullName";
            OmaId_auto_cb.ValueMember = "Id";
        }
        private void Vaata_auto_btn_Click(object sender, EventArgs e)
        {
            Kust_auto_btm.Enabled = true;
            Kust_auto_btm.ForeColor = Color.White;

            Controls.Add(dataGridView_autod);
        }
        private void Lisavorm_auto_btn_Click(object sender, EventArgs e)
        {
            Controls.Add(brand_auto_txt);
            Controls.Add(mudel_auto_txt);
            Controls.Add(RN_auto_txt);
            Controls.Add(OmaId_auto_cb);
            Controls.Add(Brand_auto_lbl);
            Controls.Add(OmaId_auto_lbl);
            Controls.Add(RN_auto_lbl);
            Controls.Add(Mudel_auto_lbl);
            Controls.Add(Autod_lbl);
            Controls.Add(lisa_auto_btn);
            Controls.Add(puhasta_auto_btn);
        }
        private void Kust_auto_btm_Click(object sender, EventArgs e)
        {
            if (dataGridView_autod.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kasutatav auto.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string autodNimetus = dataGridView_autod.SelectedRows[0].Cells["Brand"].Value?.ToString() ?? "valitud omanik";
            DialogResult vastus = MessageBox.Show(
                $"Kas olete kindel, et soovite kustuta auto: {autodNimetus}?",
                "Kustutamise kinnitus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (vastus == DialogResult.Yes)
            {

                try
                {
                    int id = (int)dataGridView_autod.SelectedRows[0].Cells["Id"].Value;
                    var auto = _db.Auto.Find(id);

                    if (auto != null)
                    {
                        _db.Auto.Remove(auto);
                        _db.SaveChanges();
                        LaeAutod();
                        //puhasta_oma_Click;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void puhasta_auto_Click(object sender, EventArgs e)
        {
            brand_auto_txt.Clear();
            mudel_auto_txt.Clear();
            RN_auto_txt.Clear();
            OmaId_auto_cb = null;
        }

        private void Lisa_auto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(brand_auto_txt.Text))
            {
                MessageBox.Show("Auto nimetus on kohustuslik");
                return;
            }
            var uus = new Car
            {
                Brand = brand_auto_txt.Text,
                Model = mudel_auto_txt.Text,
                RegistrationNumber = RN_auto_txt.Text,
                OwnerId = (int)OmaId_auto_cb.SelectedValue
            };
            _db.Auto.Add(uus);
            _db.SaveChanges();
            LaeOmanik();
            Controls.Add(dataGridView_autod);
            Kustuta_oma_btn.Enabled = true;
            Kustuta_oma_btn.ForeColor = Color.White;
        }
        
        ///
        /// HjT
        ///
    }
}
