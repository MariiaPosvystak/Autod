using Autod.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Autod
{
    public partial class Form1 : Form
    {
        // 
        // FORM
        // 
        //bool _keelLaetud;
        private readonly AutoDbContext _db;
        public Form1()
        {
            _db = new AutoDbContext();
            InitializeComponent();
            LaeOmanik();
            LaeAutod();
            LaeTeenus();
            LaeHooldus();
            LaeOmanikId();
            LaeAutodId();
            LaeTeenusId();
            using (var db = new AutoDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void tabC_Click(object sender, EventArgs e)
        {
            this.Size = new Size(678, 596);
            Controls.Remove(otsi_teen_txt);
            Controls.Remove(hind_teen_txt);
            Controls.Remove(nim_teen_txt);
            Controls.Remove(change_btn);
            Controls.Remove(ten_cl_btn);
            Controls.Remove(dataGridView_teen);
            Controls.Remove(ten_hind_lbl);
            Controls.Remove(ten_nimi_lbl);
            Controls.Remove(Teenuste_lbl);
            Controls.Remove(uue_ch_btn);
            Controls.Remove(Otsi_ch_btn);
            Controls.Remove(Kustuta_ch_btn);
            Controls.Remove(Lisa_ch_btn);
            Controls.Remove(change_ch_btn);
            Controls.Add(uue_btn);
            Controls.Add(Otsi_btn);
            Controls.Add(Kustuta_btn);
            Controls.Add(Lisa_btn);

            LaeOmanik();
            LaeAutod();
            LaeTeenus();
            LaeHooldus();
        }
        private void puhasta()
        {
            oma_nimi_txt.Clear();
            oma_tel_txt.Clear();

            brand_auto_txt.Clear();
            mudel_auto_txt.Clear();
            RN_auto_txt.Clear();
            OmaId_auto_cb = null;

            hold_auto_cb = null;
            teenus_cb = null;
            hodl_datetime = null;
            mileage_txt.Clear();

            nim_teen_txt.Clear();
            hind_teen_txt.Clear();
        }
        // 
        // LAE
        //
        private void LaeOmanik()
        {
            dataGridView_omanik.DataSource = _db.Omanik.ToList();
            if (dataGridView_omanik.Columns["Id"] != null)
                dataGridView_omanik.Columns["Id"].Visible = false;
        }
        private void LaeAutod()
        {
            dataGridView_autod.DataSource = _db.Auto.Include(o => o.Owner).Select(o => new
            {
                o.Id,
                o.Brand,
                o.Model,
                o.RegistrationNumber,
                Omanik = o.Owner.FullName
            }).ToList();

            if (dataGridView_autod.Columns["OwnerId"] != null)
                dataGridView_autod.Columns["OwnerId"].Visible = false;
            if (dataGridView_autod.Columns["Id"] != null)
                dataGridView_autod.Columns["Id"].Visible = false;
        }
        private void LaeOmanikId()
        {
            OmaId_auto_cb.DataSource = _db.Omanik.ToList();
            OmaId_auto_cb.DisplayMember = "FullName";
            OmaId_auto_cb.ValueMember = "Id";
            OmaId_auto_cb.SelectedIndex = -1;
        }
        private void LaeAutodId()
        {
            hold_auto_cb.DataSource = _db.Auto.ToList();
            hold_auto_cb.DisplayMember = "Brand";
            hold_auto_cb.ValueMember = "Id";
            hold_auto_cb.SelectedIndex = -1;
        }
        private void LaeTeenusId()
        {
            teenus_cb.DataSource = _db.Teenus.ToList();
            teenus_cb.DisplayMember = "Name";
            teenus_cb.ValueMember = "Id";
            teenus_cb.SelectedIndex = -1;
        }
        private void LaeHooldus()
        {
            dataGridView_hold.DataSource = _db.Hoolduse_Kirje.Include(cs => cs.Car).Include(cs => cs.Service).Select(cs => new
            {
                Autod = cs.Car.Brand,
                Teenus = cs.Service.Name,
                cs.DateOfService,
                cs.Mileage
            }).ToList();

            if (dataGridView_hold.Columns["CarId"] != null)
                dataGridView_hold.Columns["CarId"].Visible = false;
            if (dataGridView_hold.Columns["ServiceId"] != null)
                dataGridView_hold.Columns["ServiceId"].Visible = false;
        }
        private void LaeTeenus()
        {
            dataGridView_teen.DataSource = _db.Teenus.Select(o => new
            {
                o.Name,
                o.Price
            }).ToList();

        }
        //
        // IUDS
        //
        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            if (tabC.SelectedTab == Omanik)
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
                Kustuta_btn.ForeColor = Color.White;
                puhasta();
            }
            else if (tabC.SelectedTab == Autod)
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
                LaeAutod();
                puhasta();
            }
            else if (tabC.SelectedTab == HjT)
            {
                if (hold_auto_cb.SelectedValue == null)
                {
                    MessageBox.Show("Valige auto!");
                    return;
                }
                if (teenus_cb.SelectedValue == null)
                {
                    MessageBox.Show("Valige teenus!");
                    return;
                }
                if (!DateTime.TryParse(hodl_datetime.Text, out DateTime kuup) || !int.TryParse(mileage_txt.Text, out int aeg))
                {
                    MessageBox.Show("Kuupäev või läbisõit on valesformaadis!");
                    return;
                }
                var uus2 = new CarService
                {
                    CarId = (int)hold_auto_cb.SelectedValue,
                    ServiceId = (int)teenus_cb.SelectedValue,
                    DateOfService = kuup,
                    Mileage = aeg
                };
                _db.Hoolduse_Kirje.Add(uus2);
                _db.SaveChanges();
                LaeHooldus();
                puhasta();
            }

        }
        private void Kustuta_Click(object sender, EventArgs e)
        {
            if (tabC.SelectedTab == Omanik)
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
                            puhasta();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (tabC.SelectedTab == Autod)
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
                            puhasta();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (tabC.SelectedTab == HjT)
            {
                if (dataGridView_hold.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige kustutatav hooldus.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string hool = dataGridView_hold.SelectedRows[0].Cells["CarId"].Value?.ToString() ?? "valitud auto";
                DialogResult vastus = MessageBox.Show(
                    $"Kas olete kindel, et soovite kustutada: {hool}?",
                    "Kustutamise kinnitus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    try
                    {
                        int id = (int)dataGridView_hold.SelectedRows[0].Cells["Id"].Value;
                        var car1 = _db.Hoolduse_Kirje.Find(id);

                        if (car1 != null)
                        {
                            _db.Hoolduse_Kirje.Remove(car1);
                            _db.SaveChanges();
                            LaeHooldus();
                            puhasta();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void uue_btn_Click(object sender, EventArgs e)
        {
            if (tabC.SelectedTab == Omanik)
            {

                int id = (int)dataGridView_omanik.SelectedRows[0].Cells["Id"].Value;

                var omanik = _db.Omanik.Find(id);

                omanik.FullName = oma_nimi_txt.Text;
                omanik.Phone = oma_tel_txt.Text;
                if (string.IsNullOrWhiteSpace(oma_nimi_txt.Text))
                {
                    MessageBox.Show("Omanik nimetus on kohustuslik");
                    return;
                }
                _db.SaveChanges();
                LaeOmanik();
            }
            else if (tabC.SelectedTab == Autod)
            {
                int id = (int)dataGridView_autod.SelectedRows[0].Cells["Id"].Value;

                var auto = _db.Auto.Find(id);

                auto.Brand = brand_auto_txt.Text;
                auto.Model = mudel_auto_txt.Text;
                auto.RegistrationNumber = RN_auto_txt.Text;
                auto.OwnerId = (int)OmaId_auto_cb.SelectedValue;
                if (string.IsNullOrWhiteSpace(brand_auto_txt.Text))
                {
                    MessageBox.Show("Auto nimetus on kohustuslik");
                    return;
                }
                _db.SaveChanges();
                LaeAutod();
            }
            else if (tabC.SelectedTab == HjT)
            {
                if (dataGridView_hold.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige auto!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int oldCarId = (int)dataGridView_hold.SelectedRows[0].Cells["CarId"].Value;
                int oldServiceId = (int)dataGridView_hold.SelectedRows[0].Cells["ServiceId"].Value;
                DateTime oldDate = (DateTime)dataGridView_hold.SelectedRows[0].Cells["DateOfService"].Value;
                var oldEntry = _db.Hoolduse_Kirje.Find(oldCarId, oldServiceId, oldDate);
                if (oldEntry == null)
                {
                    MessageBox.Show("Kirjet ei leitud!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (hold_auto_cb.SelectedValue == null)
                {
                    MessageBox.Show("Valige auto!");
                    return;
                }
                if (teenus_cb.SelectedValue == null)
                {
                    MessageBox.Show("Valige teenus!");
                    return;
                }
                if (!DateTime.TryParse(hodl_datetime.Text, out DateTime newDate))
                {
                    MessageBox.Show("Kuupäev on vales formaadis!");
                    return;
                }
                if (!int.TryParse(mileage_txt.Text, out int newMileage))
                {
                    MessageBox.Show("Läbisõit peab olema arv!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _db.Hoolduse_Kirje.Remove(oldEntry);
                _db.SaveChanges();
                var newEntry = new CarService
                {
                    CarId = (int)hold_auto_cb.SelectedValue,
                    ServiceId = (int)teenus_cb.SelectedValue,
                    DateOfService = newDate,
                    Mileage = newMileage
                };
                _db.Hoolduse_Kirje.Add(newEntry);
                _db.SaveChanges();
                LaeHooldus();
                puhasta();
            }
        }
        private void otsi_btn_Click(object sender, EventArgs e)
        {
            if (tabC.SelectedTab == Omanik)
            {
                if (string.IsNullOrWhiteSpace(oma_nimi_txt.Text) && string.IsNullOrEmpty(oma_tel_txt.Text))
                {
                    MessageBox.Show("Sisesta omaniku nimi või telefoninumber!");
                }
                else
                {
                    var query = _db.Omanik.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(oma_nimi_txt.Text))
                    {
                        query = query.Where(o => o.FullName.Contains(oma_nimi_txt.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(oma_tel_txt.Text))
                    {
                        query = query.Where(o => o.Phone.Contains(oma_tel_txt.Text));
                    }
                    var tulemused = query
                        .Select(o => new
                        {
                            o.FullName,
                            o.Phone
                        })
                        .ToList();

                    dataGridView_omanik.DataSource = tulemused;
                }
            }
            else if (tabC.SelectedTab == Autod)
            {
                if (string.IsNullOrWhiteSpace(brand_auto_txt.Text) && string.IsNullOrEmpty(mudel_auto_txt.Text)
                    && string.IsNullOrWhiteSpace(RN_auto_txt.Text) && string.IsNullOrEmpty(OmaId_auto_cb.Text))
                {
                    MessageBox.Show("Sisesta omaniku nimi või telefoninumber!");
                }
                else
                {
                    var query = _db.Auto.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(brand_auto_txt.Text))
                    {
                        query = query.Where(a => a.Brand.Contains(brand_auto_txt.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(mudel_auto_txt.Text))
                    {
                        query = query.Where(a => a.Model.Contains(mudel_auto_txt.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(RN_auto_txt.Text))
                    {
                        query = query.Where(a => a.RegistrationNumber.Contains(RN_auto_txt.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(OmaId_auto_cb.Text))
                    {
                        string ownerName = OmaId_auto_cb.Text.Trim();

                        query = query.Where(c => c.Owner.FullName.Contains(ownerName));
                    }
                    var tulemused = query
                        .Select(a => new
                        {
                            a.Brand,
                            a.Model,
                            a.RegistrationNumber,
                            a.OwnerId
                        }).ToList();
                }
            }
            else if (tabC.SelectedTab == HjT)
            {
                if (string.IsNullOrWhiteSpace(hold_auto_cb.Text) && string.IsNullOrEmpty(teenus_cb.Text) &&
                    string.IsNullOrWhiteSpace(hodl_datetime.Text) && string.IsNullOrEmpty(mileage_txt.Text))
                {
                    MessageBox.Show("Sisesta omaniku nimi või telefoninumber!");
                }
                else
                {
                    var query = _db.Hoolduse_Kirje.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(hold_auto_cb.Text))
                    {
                        string autoName = hold_auto_cb.Text.Trim();

                        query = query.Where(c => c.Car.Brand.Contains(autoName));
                    }
                    if (!string.IsNullOrWhiteSpace(teenus_cb.Text))
                    {
                        string ownerName = teenus_cb.Text.Trim();

                        query = query.Where(c => c.Service.Name.Contains(ownerName));
                    }
                    if (!string.IsNullOrWhiteSpace(hodl_datetime.Text))
                    {
                        if (DateTime.TryParse(hodl_datetime.Text, out DateTime searchDate))
                        {
                            query = query.Where(cs => cs.DateOfService == searchDate);
                        }
                        else
                        {
                            MessageBox.Show("Kuupäev on vales formaadis!");
                            return;
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(mileage_txt.Text))
                    {
                        if (int.TryParse(mileage_txt.Text, out int mileage))
                        {
                            query = query.Where(cs => cs.Mileage == mileage);
                        }
                        else
                        {
                            MessageBox.Show("Läbisõit peab olema arv!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    var tulemused = query
                        .Select(h => new
                        {
                            h.CarId,
                            h.ServiceId,
                            h.DateOfService,
                            h.Mileage
                        }).ToList();
                }
            }
        }
        //
        // TEENUS
        //
        private void tenus_vaata_btn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1080, 596);
            Controls.Add(otsi_teen_txt);
            Controls.Add(hind_teen_txt);
            Controls.Add(nim_teen_txt);
            Controls.Add(change_btn);
            Controls.Add(ten_cl_btn);
            Controls.Add(dataGridView_teen);
            Controls.Add(ten_hind_lbl);
            Controls.Add(ten_nimi_lbl);
            Controls.Add(Teenuste_lbl);
        }
        private void tenus_kinni_btn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(678, 596);
            Controls.Remove(otsi_teen_txt);
            Controls.Remove(hind_teen_txt);
            Controls.Remove(nim_teen_txt);
            Controls.Remove(change_btn);
            Controls.Remove(ten_cl_btn);
            Controls.Remove(dataGridView_teen);
            Controls.Remove(ten_hind_lbl);
            Controls.Remove(ten_nimi_lbl);
            Controls.Remove(Teenuste_lbl);
            Controls.Remove(uue_ch_btn);
            Controls.Remove(Otsi_ch_btn);
            Controls.Remove(Kustuta_ch_btn);
            Controls.Remove(Lisa_ch_btn);
            Controls.Remove(change_ch_btn);
            Controls.Add(uue_btn);
            Controls.Add(Otsi_btn);
            Controls.Add(Kustuta_btn);
            Controls.Add(Lisa_btn);
        }
        private void Change_btn_Click(object sender, EventArgs e)
        {
            Controls.Remove(uue_btn);
            Controls.Remove(Otsi_btn);
            Controls.Remove(Kustuta_btn);
            Controls.Remove(Lisa_btn);
            Controls.Remove(change_btn);

            Controls.Add(uue_ch_btn);
            Controls.Add(Otsi_ch_btn);
            Controls.Add(Kustuta_ch_btn);
            Controls.Add(Lisa_ch_btn);
            Controls.Add(change_ch_btn);

            LaeOmanik();
            LaeAutod();
            LaeTeenus();
            LaeHooldus();
            LaeOmanikId();
            LaeAutodId();
            LaeTeenusId();
        }
        private void change_ch_btn_Click(object sender, EventArgs e)
        {
            Controls.Add(uue_btn);
            Controls.Add(Otsi_btn);
            Controls.Add(Kustuta_btn);
            Controls.Add(Lisa_btn);
            Controls.Add(change_btn);

            Controls.Remove(uue_ch_btn);
            Controls.Remove(Otsi_ch_btn);
            Controls.Remove(Kustuta_ch_btn);
            Controls.Remove(Lisa_ch_btn);
            Controls.Remove(change_ch_btn);

            LaeOmanik();
            LaeAutod();
            LaeTeenus();
            LaeHooldus();
            LaeOmanikId();
            LaeAutodId();
            LaeTeenusId();
        }
        //
        // TEENUS_IUDS
        //
        private void Lisa_ch_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nim_teen_txt.Text))
            {
                MessageBox.Show("Teenus nimetus on kohustuslik");
                return;
            }
            var uus = new Service
            {
                Name = nim_teen_txt.Text,
                Price = float.Parse(hind_teen_txt.Text)
            };
            _db.Teenus.Add(uus);
            _db.SaveChanges();
            LaeTeenus();
            Kustuta_btn.ForeColor = Color.White;
            puhasta();
        }
        private void Kustuta_ch_Click(object sender, EventArgs e)
        {
            if (dataGridView_teen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kasutatav teenus.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string teenNimetus = dataGridView_teen.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "valitud teenus";
            DialogResult vastus = MessageBox.Show(
                $"Kas olete kindel, et soovite kustuta teenus: {teenNimetus}?",
                "Kustutamise kinnitus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (vastus == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridView_teen.SelectedRows[0].Cells["Id"].Value;
                    var teenus = _db.Teenus.Find(id);

                    if (teenus != null)
                    {
                        _db.Teenus.Remove(teenus);
                        _db.SaveChanges();
                        LaeTeenus();
                        puhasta();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void uue_ch_btn_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView_teen.SelectedRows[0].Cells["Id"].Value;

            var teenus = _db.Teenus.Find(id);

            teenus.Name = nim_teen_txt.Text;
            teenus.Price = float.Parse(hind_teen_txt.Text);
            if (string.IsNullOrWhiteSpace(nim_teen_txt.Text))
            {
                MessageBox.Show("Teenus nimetus on kohustuslik");
                return;
            }
            _db.SaveChanges();
            LaeOmanik();
        }
        private void otsi_ch_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nim_teen_txt.Text) && string.IsNullOrEmpty(hind_teen_txt.Text))
            {
                MessageBox.Show("Sisesta omaniku nimi või telefoninumber!");
            }
            else
            {
                var query = _db.Teenus.AsQueryable();
                if (!string.IsNullOrWhiteSpace(nim_teen_txt.Text))
                {
                    query = query.Where(t => t.Name.Contains(nim_teen_txt.Text));
                }
                if (!string.IsNullOrWhiteSpace(hind_teen_txt.Text))
                {
                    if (float.TryParse(hind_teen_txt.Text, out float price))
                    {
                        query = query.Where(t => t.Price == price);
                    }
                }
                var tulemused = query
                    .Select(t => new
                    {
                        t.Name,
                        t.Price
                    })
                    .ToList();

                dataGridView_teen.DataSource = tulemused;
            }
        }

        //
        // LANG
        //

        //private void ChangeLanguage(string lang)
        //{
        //    Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
        //    var res = new ComponentResourceManager(typeof(Pood));
        //    ApplyResourcesToControl(this, res);
        //    res.ApplyResources(this, "$this");
        //    Properties.Settings.Default.UserLanguage = lang;
        //    Properties.Settings.Default.Save();

        //}
        //private void ApplyResourcesToControl(Control ctrl, ComponentResourceManager res)
        //{
        //    res.ApplyResources(ctrl, ctrl.Name);
        //    foreach (Control child in ctrl.Controls)
        //    {
        //        ApplyResourcesToControl(child, res);
        //    }
        //}
        //private void keel_cb_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!_keelLaetud)
        //        return;
        //    if (keel_cb.SelectedItem?.ToString() == "English")
        //        ChangeLanguage("en-GB");
        //    else
        //        ChangeLanguage("et-EE");
        //}
    }
}
