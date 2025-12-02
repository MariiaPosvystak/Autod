using Autod.Data;
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
            LaeAutod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kustuta_oma_btn.Enabled = false;
            Kustuta_oma_btn.ForeColor = Color.Silver;
            toolTip_oma.SetToolTip(Kustuta_oma_btn, "Tabelist andmete kustutamiseks valige kustutatavad isikud.");
        }
        private void LaeAutod()
        {
            dataGridView_omanik.DataSource = _db.Omanik.ToList();

        }
        private void HjT_Click(object sender, EventArgs e)
        {

        }
        private void Omanik_Click(object sender, EventArgs e)
        {

        }
        private void Autod_Click(object sender, EventArgs e)
        {

        }

        private void Kustuta_Click(object sender, EventArgs e)
        {
            if (dataGridViewTooded.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kasutatav toode.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tooteNimetus = dataGridViewTooded.SelectedRows[0].Cells["Toodenimetus"].Value?.ToString() ?? "valitud toode";
            DialogResult vastus = MessageBox.Show(
                $"Kas olete kindel, et soovite kustuta toote: {tooteNimetus}?",
                "Kustutamise kinnitus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (vastus == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridViewTooded.SelectedRows[0].Cells["Id"].Value;
                    var toode = _db.Tootetabel.Find(id);

                    if (toode != null)
                    {
                        _db.Tootetabel.Remove(toode);
                        _db.SaveChanges();
                        LaeTooted();
                        PuhastaVorm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Lisa_Click(object sender, EventArgs e)
        {
            Controls.Add(puhasta_oma_btn);
            Controls.Add(lisa_oma_btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(oma_tel_txt);
            Controls.Add(label2);
            Controls.Add(oma_nimi_txt);
            Controls.Add(Omanikud);
        }

        private void Lisa_oma_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(oma_nimi_txt.Text))
            {
                MessageBox.Show("Toode nimetus on kohustuslik");
                return;
            }
            var uus = new Owner
            {
                FullName = oma_nimi_txt.Text,
                Phone = oma_tel_txt.Text
            };
            _db.Omanik.Add(uus);
            _db.SaveChanges();
            LaeAutod();
            Controls.Add(dataGridView_omanik);
            Kustuta_oma_btn.Enabled = true;
            Kustuta_oma_btn.ForeColor = Color.White;
        }
        private void puhasta_oma_Click(object sender, EventArgs e)
        {
            oma_nimi_txt.Text = "";
            oma_tel_txt.Text = "";
        }
        private void Vaata_Click(object sender, EventArgs e)
        {
            Kustuta_oma_btn.Enabled = true;
            Kustuta_oma_btn.ForeColor = Color.White;

            Controls.Add(dataGridView_omanik);
        }
    }
}
