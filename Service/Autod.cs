using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autod
{
    public partial class Form1 : Form
    {
        private void LaeAutod()
        {
            dataGridView_autod.DataSource = _db.Auto.ToList();
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
            oma_nimi_txt.Clear();
            oma_tel_txt.Clear();
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
            };
            _db.Auto.Add(uus);
            _db.SaveChanges();
            LaeOmanik();
            Controls.Add(dataGridView_autod);
            Kustuta_oma_btn.Enabled = true;
            Kustuta_oma_btn.ForeColor = Color.White;
        }
    }
}
