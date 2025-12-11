using Autod.Data;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Autod
{
    public partial class Form1 : Form
    {
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
        private void LaeOmanik()
        {
            dataGridView_omanik.DataSource = _db.Omanik.ToList();
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
        }
        private void LaeOmanikId()
        {
            var omanikId = _db.Omanik.ToList();
            OmaId_auto_cb.DataSource = omanikId;
            OmaId_auto_cb.DisplayMember = "FullName";
            OmaId_auto_cb.ValueMember = "Id";
        }
        private void LaeAutodId()
        {
            var autoId = _db.Auto.ToList();
            hold_auto_cb.DataSource = autoId;
            hold_auto_cb.DisplayMember = "Brand";
            hold_auto_cb.ValueMember = "Id";
        }
        private void LaeTeenusId()
        {
            var teenId = _db.Teenus.ToList();
            teenus_cb.DataSource = teenId;
            teenus_cb.DisplayMember = "Name";
            teenus_cb.ValueMember = "Id";
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
            dataGridView_teen.DataSource = _db.Teenus.ToList();
        }
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
                            //puhasta_oma_Click;
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
                //if (hooldus_data.SelectedRows.Count == 0)
                //{
                //    MessageBox.Show("Palun valige kustutatav hooldus.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                //string hool = hooldus_data.SelectedRows[0].Cells["CarId"].Value?.ToString() ?? "valitud auto";
                //DialogResult vastus = MessageBox.Show(
                //    $"Kas olete kindel, et soovite kustutada: {hool}?",
                //    "Kustutamise kinnitus",
                //    MessageBoxButtons.YesNo,
                //    MessageBoxIcon.Question);
                //if (vastus == DialogResult.Yes)
                //{
                //    try
                //    {
                //        int id = (int)hooldus_data.SelectedRows[0].Cells["Id"].Value;
                //        var car1 = _db.CarServices.Find(id);

                //        if (car1 != null)
                //        {
                //            _db.CarServices.Remove(car1);
                //            _db.SaveChanges();
                //            LoeCarServices();
                //            puhasta();

                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
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
                //if (hooldus_data.SelectedRows.Count == 0)
                //{
                //    MessageBox.Show("Palun valige auto!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                //int oldCarId = (int)hooldus_data.SelectedRows[0].Cells["CarId"].Value;
                //int oldServiceId = (int)hooldus_data.SelectedRows[0].Cells["ServiceId"].Value;
                //DateTime oldDate = (DateTime)hooldus_data.SelectedRows[0].Cells["DateOfService"].Value;
                //var oldEntry = _db.CarServices.Find(oldCarId, oldServiceId, oldDate);
                //if (oldEntry == null)
                //{
                //    MessageBox.Show("Kirjet ei leitud!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //if (auto_com_box.SelectedValue == null)
                //{
                //    MessageBox.Show("Valige auto!");
                //    return;
                //}
                //if (teenus_com_box.SelectedValue == null)
                //{
                //    MessageBox.Show("Valige teenus!");
                //    return;
                //}
                //if (!DateTime.TryParse(kuup_txt_box.Text, out DateTime newDate))
                //{
                //    MessageBox.Show("Kuupäev on vales formaadis!");
                //    return;
                //}
                //if (!int.TryParse(aeg_txt_box.Text, out int newMileage))
                //{
                //    MessageBox.Show("Läbisõit peab olema arv!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //_db.CarServices.Remove(oldEntry);
                //_db.SaveChanges();
                //var newEntry = new CarService
                //{
                //    CarId = (int)auto_com_box.SelectedValue,
                //    ServiceId = (int)teenus_com_box.SelectedValue,
                //    DateOfService = newDate,
                //    Mileage = newMileage
                //};
                //_db.CarServices.Add(newEntry);
                //_db.SaveChanges();
                //LoeCarServices();
                //puhasta();
            }


        }
        private void otsi_btn_Click(object sender, EventArgs e)
        {

        }
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
        private void uue_ch_btn_Click(object sender, EventArgs e)
        {
            
        }
        private void otsi_ch_btn_Click(object sender, EventArgs e)
        {

        }
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

            LaeOmanik();
            LaeAutod();
            LaeTeenus();
            LaeHooldus();
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
            hodl_datetime =null;
            mileage_txt.Clear();

            nim_teen_txt.Clear();
            hind_teen_txt.Clear();
        }
    }
}
