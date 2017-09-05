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
using RollingAlongMobile.Podatkovne_klase;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using RollingAlongMobile.Najam;
using RestSharp;

namespace RollingAlongMobile.Profil
{
    [Activity(Label = "Profil",Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class ProfilActivity : AppCompatActivity
    {
        Button izmjeniProfil;
        EditText ime, prezime, oib, email;
        List<User> user;

        public PrijavaActivity PrijavaActivity
        {
            get => default(PrijavaActivity);
            set
            {
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Profil);
            izmjeniProfil = FindViewById<Button>(Resource.Id.IzmjeniProfil);
            ime = FindViewById<EditText>(Resource.Id.ImeText);
            prezime = FindViewById<EditText>(Resource.Id.PrezimeText);
            email = FindViewById<EditText>(Resource.Id.EmailText);
            string text = Intent.GetStringExtra("user") ?? "Data not available";
            user = JsonConvert.DeserializeObject<List<User>>(text);
            ime.Text = user[0].Name;
            prezime.Text = user[0].Surname;
            email.Text = user[0].Email;
            
            //Navigacija
            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNavigation.NavigationItemSelected += (s, e) =>
            {
              
                if(e.Item.ItemId == Resource.Id.action_najmovi)
                {
                    var najmovi = new Intent(this, typeof(AktivniNajmoviActivity));
                    najmovi.PutExtra("user",text);
                    StartActivity(najmovi);
                }
            };

            izmjeniProfil.Click += (b, e) => {
                User changedProfile = user[0];
                changedProfile.Name = ime.Text;
                changedProfile.Surname = prezime.Text;
                changedProfile.Email = email.Text;
                var klijent = new RestClient("http://marichely.me");
                var zahtjev = new RestRequest("rolling/users/updates", Method.POST);
                zahtjev.RequestFormat = DataFormat.Json;
                zahtjev.AddParameter("text/json", JsonConvert.SerializeObject(changedProfile), ParameterType.RequestBody);
                zahtjev.AddHeader("userapikey", user[0].ApiKey);
                IRestResponse odgovor = klijent.Execute(zahtjev);
                if((int)odgovor.StatusCode == 200)
                {
                    Toast.MakeText(this, "Successfully updated your profile", ToastLength.Short).Show();
                }

            };
        
        }

        private void izmjeniProfil_onclick(object sender, EventArgs e)
        {
            
        }


    }
}