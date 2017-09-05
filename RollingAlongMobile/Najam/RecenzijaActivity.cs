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
using Android.Graphics;
using RollingAlongMobile.Podatkovne_klase;
using Newtonsoft.Json;
using RestSharp;

namespace RollingAlongMobile.Najam
{
    [Activity(Label = "RecenzijaActivity")]
    public class RecenzijaActivity : Activity
    {
        Rent najam;
        List<User> korisnik;
        RatingBar zvijezdice;
        Button posaljiReviewButton;
        EditText recenzijaText;

        internal NajmoviAdapter NajmoviAdapter
        {
            get => default(NajmoviAdapter);
            set
            {
            }
        }

        public override void OnBackPressed()
        {
            Finish();
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Recenzija);
            zvijezdice = FindViewById<RatingBar>(Resource.Id.ratingBar1);
            posaljiReviewButton = FindViewById<Button>(Resource.Id.button2);
            recenzijaText = FindViewById<EditText>(Resource.Id.OpisRezenzije1);
            string input = Intent.GetStringExtra("rent");
            string userinput = Intent.GetStringExtra("user");
            najam = JsonConvert.DeserializeObject<Rent>(input);
            korisnik = JsonConvert.DeserializeObject<List<User>>(userinput);



        posaljiReviewButton.Click += (b, e) =>
            {
                 if (recenzijaText.Text!=null)
                 {
                     korisnik = JsonConvert.DeserializeObject<List<User>>(userinput);
                     var klijent = new RestClient("http://marichely.me");
                     var zahtjev = new RestRequest("rolling/reviews", Method.POST);
                     zahtjev.RequestFormat = DataFormat.Json;
                     zahtjev.AddHeader("rentid", najam.Rentid.ToString());
                     zahtjev.AddHeader("userapikey", korisnik[0].ApiKey);
                     CreateReview posalji = new CreateReview();
                     posalji.Description = recenzijaText.Text;
                     posalji.Stars = zvijezdice.NumStars;
                     string test = JsonConvert.SerializeObject(posalji);
                     zahtjev.AddParameter("text/json", test, ParameterType.RequestBody);
                     IRestResponse odgovor = klijent.Execute(zahtjev);
                    if ((int)odgovor.StatusCode == 200)
                    {
                        Toast.MakeText(this, "Review Sent", ToastLength.Short).Show();
                    }
            }
            

            };
        }
    }
}