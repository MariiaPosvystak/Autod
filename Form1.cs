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
            LaeOmanik();
            LaeAutod();
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
            Controls.Remove(dataGridView_omanik);
            Controls.Remove(puhasta_oma_btn);
            Controls.Remove(lisa_oma_btn);
            Controls.Remove(name_oma_lbl);
            Controls.Remove(oma_tel_txt);
            Controls.Remove(Telefon_oma_lbl);
            Controls.Remove(oma_nimi_txt);
            Controls.Remove(Omanikud);

            Kust_auto_btm.Enabled = false;
            Kust_auto_btm.ForeColor = Color.Silver;
            Kustuta_oma_btn.Enabled = false;
            Kustuta_oma_btn.ForeColor = Color.Silver;
        }
    }
}
