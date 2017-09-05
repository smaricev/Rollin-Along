using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using RestSharp;
using RollingAlongMobile.Podatkovne_klase;
using RollingAlongMobile.Profil;
using Android.Views;
using Android.Graphics;
using Newtonsoft.Json;
using Android.Support.V7.App;
using Android.Content.Res;

namespace RollingAlongMobile
{
    [Activity(Label = "Rolling Along", MainLauncher = true)]
    public class PrijavaActivity : Activity
    {

        RelativeLayout sakri;

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.DecorView.SetBackgroundColor(Color.Rgb(117,117,117));
            
            SetContentView(Resource.Layout.thePrijava);

            sakri =  FindViewById<RelativeLayout>(Resource.Id.loadingPanel);
            sakri.Visibility = ViewStates.Invisible;
            Typeface fontNormal;
            AssetManager Assets = this.Assets;
            fontNormal = Typeface.CreateFromAsset(Assets, "robotol.ttf");
            Typeface fontBold;
            fontBold = Typeface.CreateFromAsset(Assets, "roboto.ttf");

            ImageView slika = FindViewById<ImageView>(Resource.Id.slikapozadine1);
            Button prijava = FindViewById<Button>(Resource.Id.prijavaGumb1);
            EditText lozinka = FindViewById<EditText>(Resource.Id.passwordprijava);
            EditText korisnickoIme = FindViewById<EditText>(Resource.Id.usernameprijava);
            slika.SetImageResource(Resource.Drawable.logof);
            prijava.Click += (b, e) => {
                sakri.Visibility = ViewStates.Visible;
                var klijent = new RestClient("http://marichely.me");
                var zahtjev = new RestRequest("rolling/user/login", Method.POST)
                {
                    RequestFormat = DataFormat.Json
                };
                Login a = new Login();
                a.Username = korisnickoIme.Text;
                a.Password = lozinka.Text;
                string test = JsonConvert.SerializeObject(a);
                zahtjev.AddParameter("text/json", test, ParameterType.RequestBody);

                IRestResponse odgovor = klijent.Execute(zahtjev);

                if ((int)odgovor.StatusCode == 200)
                {
                    var profil = new Intent(this, typeof(ProfilActivity));
                    profil.PutExtra("user", odgovor.Content);
                    StartActivity(profil);
                }
                else
                {
                    
                    Toast.MakeText(this, "Krivo korisnicko ime ili lozinka", ToastLength.Short).Show();
                }
            };
            

        }



    }
}


