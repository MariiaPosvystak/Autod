using Autod.Data;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
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
        private void LaeOmanik()
        {
            dataGridView_omanik.DataSource = _db.Omanik.ToList();
        }
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
                oma_nimi_txt.Clear();
                oma_tel_txt.Clear();
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

                brand_auto_txt.Clear();
                mudel_auto_txt.Clear();
                RN_auto_txt.Clear();
                OmaId_auto_cb = null;
            }
            else if (tabC.SelectedTab == HjT)
            {
                if (auto_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige auto!");
                    return;
                }
                if (teenus_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige teenus!");
                    return;
                }
                if (!DateTime.TryParse(kuup_txt_box.Text, out DateTime kuup) || !int.TryParse(aeg_txt_box.Text, out int aeg))
                {
                    MessageBox.Show("Kuupäev või läbisõit on valesformaadis!");
                    return;
                }
                var uus2 = new CarService
                {
                    CarId = (int)auto_com_box.SelectedValue,
                    ServiceId = (int)teenus_com_box.SelectedValue,
                    DateOfService = kuup,
                    Mileage = aeg
                };
                _db.CarServices.Add(uus2);
                _db.SaveChanges();
                LoeCarServices();
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
                            //puhasta_oma_Click;
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
                if (hooldus_data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige kustutatav hooldus.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string hool = hooldus_data.SelectedRows[0].Cells["CarId"].Value?.ToString() ?? "valitud auto";
                DialogResult vastus = MessageBox.Show(
                    $"Kas olete kindel, et soovite kustutada: {hool}?",
                    "Kustutamise kinnitus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    try
                    {
                        int id = (int)hooldus_data.SelectedRows[0].Cells["Id"].Value;
                        var car1 = _db.CarServices.Find(id);

                        if (car1 != null)
                        {
                            _db.CarServices.Remove(car1);
                            _db.SaveChanges();
                            LoeCarServices();
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
                if (hooldus_data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige auto!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int oldCarId = (int)hooldus_data.SelectedRows[0].Cells["CarId"].Value;
                int oldServiceId = (int)hooldus_data.SelectedRows[0].Cells["ServiceId"].Value;
                DateTime oldDate = (DateTime)hooldus_data.SelectedRows[0].Cells["DateOfService"].Value;
                var oldEntry = _db.CarServices.Find(oldCarId, oldServiceId, oldDate);
                if (oldEntry == null)
                {
                    MessageBox.Show("Kirjet ei leitud!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (auto_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige auto!");
                    return;
                }
                if (teenus_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige teenus!");
                    return;
                }
                if (!DateTime.TryParse(kuup_txt_box.Text, out DateTime newDate))
                {
                    MessageBox.Show("Kuupäev on vales formaadis!");
                    return;
                }
                if (!int.TryParse(aeg_txt_box.Text, out int newMileage))
                {
                    MessageBox.Show("Läbisõit peab olema arv!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _db.CarServices.Remove(oldEntry);
                _db.SaveChanges();
                var newEntry = new CarService
                {
                    CarId = (int)auto_com_box.SelectedValue,
                    ServiceId = (int)teenus_com_box.SelectedValue,
                    DateOfService = newDate,
                    Mileage = newMileage
                };
                _db.CarServices.Add(newEntry);
                _db.SaveChanges();
                LoeCarServices();
                puhasta();
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tenus_vaata_btn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1224, 743);
            Kustuta_btn.Size = new Size(180, 68);
        }
    }
}
