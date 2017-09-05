﻿using Newtonsoft.Json;
using RestSharp;
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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();

        }

        private void PrijavaButton_Click(object sender, EventArgs e)
        {

            var klijent = new RestClient("http://marichely.me");
            var zahtjev = new RestRequest("rolling/user/login", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };
            Login login = new Login();
            login.Username = korisnickoImeTextBox.Text;
            login.Password = passwordTextBoX.Text;
            string podaci = JsonConvert.SerializeObject(login);
            zahtjev.AddParameter("text/json", podaci, ParameterType.RequestBody);
            IRestResponse odgovor = klijent.Execute(zahtjev);

            if ((int)odgovor.StatusCode == 200)
            {
                List<User> user = JsonConvert.DeserializeObject<List<User>>(odgovor.Content);
                if (user[0].Type.UserTypeId <= 2)
                {
                    FrmGlavna a = new FrmGlavna(user[0]);
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You don't have enough permission to use this app");
                }
            }
            else
            {
                MessageBox.Show("Username and or Password is wrong");
            }
        }

        private void RegistracijaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
