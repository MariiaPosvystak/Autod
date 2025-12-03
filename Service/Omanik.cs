using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autod
{
    public partial class Form1 : Form
    {
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
    }
    
}
