using Rollin__Along.Podatkovne_klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollin__Along
{
    public partial class FrmGlavna : Form
    {
        User korisnik;

        public FrmGlavna(User a)
        {
            InitializeComponent();
            korisnik = a;
        }

        public Prijava Prijava
        {
            get => default(Prijava);
            set
            {
            }
        }

        private void opremaPregled_Click(object sender, EventArgs e)
        {
            Unos_i_upravljanje_inventara.FrmOprema formaOprema = new Unos_i_upravljanje_inventara.FrmOprema();
            formaOprema.Show();
            this.Hide();
        }

        private void biciklPregled_Click(object sender, EventArgs e)
        {
            Unos_i_upravljanje_inventara.FrmBicikli formaBicikl = new Unos_i_upravljanje_inventara.FrmBicikli();
            formaBicikl.Show();
            this.Hide();
        }

        private void incidenti_Click(object sender, EventArgs e)
        {
            Upravljanje_Incidentima.FrmIncidenti formaIncident = new Upravljanje_Incidentima.FrmIncidenti(this, korisnik);

            formaIncident.Show();
            this.Hide();

        }

        private void rezervacije_Click(object sender, EventArgs e)
        {
            Pregled_Rezervacija.FrmRezervacije formaRezervacije = new Pregled_Rezervacija.FrmRezervacije(korisnik, this);
            formaRezervacije.Show();
            this.Hide();

        }
    }
}
