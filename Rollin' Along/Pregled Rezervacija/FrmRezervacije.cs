﻿using Newtonsoft.Json;
using RestSharp;
using Rollin__Along.Podatkovne_klase;
using Rollin__Along.pomocne;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollin__Along.Pregled_Rezervacija
{
    public partial class FrmRezervacije : Form
    {
        User korisnik;
        FrmGlavna menu1;
        public FrmRezervacije(User a,FrmGlavna b)
        {   

            InitializeComponent();
            menu1 = b;
            korisnik = a;
            userLabel.Text = "USER: " + korisnik.Username;

            var klijent = new RestClient("http://marichely.me");
            var zahtjev = new RestRequest("rolling/rent", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            zahtjev.AddHeader("userapikey",korisnik.ApiKey);
          
            IRestResponse odgovor = klijent.Execute(zahtjev);
            if ((int)odgovor.StatusCode == 200)
            {
                List<Rent> rent = JsonConvert.DeserializeObject<List<Rent>>(odgovor.Content);
                SortableBindingList<Rent> sortableBindingList = new SortableBindingList<Rent>(rent);
                dgNajmovi.DataSource = sortableBindingList;

                List<Status> lista= new List<Status>();
                Status unos = new Status();
                unos.ID = 1;
                unos.Ime = "Reserved";
                lista.Add(unos);
                Status unos1 = new Status();
                unos1.ID = 2;
                unos1.Ime = "Active";
                lista.Add(unos1);
                Status unos2 = new Status();
                unos2.ID = 3;
                unos2.Ime = "Expired";
                lista.Add(unos2);
                promjenaStatus.Items.Add(unos);
                promjenaStatus.Items.Add(unos2);
                promjenaStatus.Items.Add(unos1);


                var listBinding = new BindingList<Status>(lista);
                
            }

        }

        private void dgNajmovi_SelectionChanged(object sender, EventArgs e)
        {
            Rent a = (Rent)dgNajmovi.CurrentRow.DataBoundItem;
            Status stat = new Status();
            stat.ID = a.Status;
            switch (stat.ID)
            {
                case 1: stat.Ime = "Reserved";break;
                case 2: stat.Ime = "Active";break;
                case 3: stat.Ime = "Expired";break;
            }
            promjenaStatus.Text = stat.Ime;
            promjenaStatus.SelectedItem = stat;
    }

        private void changeStatusBtn_Click(object sender, EventArgs e)
        {
           Status a = (Status)promjenaStatus.SelectedItem;
           Rent b = (Rent)dgNajmovi.CurrentRow.DataBoundItem;
            b.Status = a.ID;
            var klijent = new RestClient("http://marichely.me");
            var zahtjev = new RestRequest("rolling/rent/status", Method.PUT)
            {
                RequestFormat = DataFormat.Json
            };

            zahtjev.AddHeader("userapikey", korisnik.ApiKey);
            zahtjev.AddHeader("status", a.ID.ToString());
            zahtjev.AddHeader("rentid", b.Rentid.ToString());
            IRestResponse odgovor = klijent.Execute(zahtjev);
            if ((int)odgovor.StatusCode == 200)
            {
                dgNajmovi.Update();
                dgNajmovi.Refresh();

            }


        }

        private void Menu_Click(object sender, EventArgs e)
        {
            menu1.Show();
            this.Dispose();
        }

 
    }
}
