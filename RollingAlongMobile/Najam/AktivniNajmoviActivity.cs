using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using RestSharp;
using RollingAlongMobile.Podatkovne_klase;
using Android.Support.Design.Widget;
using RollingAlongMobile.Profil;
using Android.Support.V7.App;
using Android.Graphics;

namespace RollingAlongMobile.Najam
{


    [Activity(Label = "Aktivni najmovi", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class AktivniNajmoviActivity : AppCompatActivity
    {

        private ListView najmovilista;
        Button otvoriLokaciju, otvoriRecenziju, otvoriPrijavuIncidenta;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AktivniNajmovi);
            string text = Intent.GetStringExtra("user") ?? "Data not available";
            var user = JsonConvert.DeserializeObject<List<User>>(text);
            var klijent = new RestClient("http://marichely.me");
            var zahtjev = new RestRequest("rolling/rent/user", Method.GET);
            zahtjev.AddHeader("UserApiKey", user[0].ApiKey);
            var odgovor = klijent.Execute(zahtjev);
            if ((int)odgovor.StatusCode == 200)
            {
                var najmovi = JsonConvert.DeserializeObject<List<Rent>>(odgovor.Content);
                najmovilista = FindViewById<ListView>(Resource.Id.najmovi11);
                var adapter = new NajmoviAdapter(this, najmovi,text);
                najmovilista.Adapter = adapter; 
            }


            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNavigation.NavigationItemSelected += (s, e) =>
            {
                if (e.Item.ItemId == Resource.Id.action_profil)
                {
                    var profil = new Intent(this, typeof(ProfilActivity));
                    profil.PutExtra("user", text);
                    StartActivity(profil);
                }
              
            };
            




        }
        
    }
}