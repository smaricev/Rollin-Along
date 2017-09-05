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
using RestSharp;
using Android.Graphics;
using Android.Provider;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.Database;
using Java.IO;

namespace RollingAlongMobile.Najam
{
    [Activity(Label = "Prijava Incidenta")]
    public class PrijavaIncidentaActivity : Activity
    {
        Button posaljiIncident;
        ImageButton odaberiSliku;
        Android.Net.Uri podaci;
        Bitmap slika;
        Rent najam;
        List<User> user;
        string path;
        Java.IO.File file;

        public override void OnBackPressed()
        {
            Finish();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            string input = Intent.GetStringExtra("rent");
            string userinput = Intent.GetStringExtra("user");
            najam = JsonConvert.DeserializeObject<Rent>(input);
            user = JsonConvert.DeserializeObject<List<User>>(userinput);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.PrijavaIncidenta);
            Button prijaviinc = FindViewById<Button>(Resource.Id.posaljiIncident);
            odaberiSliku = FindViewById<ImageButton>(Resource.Id.odaberiSliku);
            EditText opis = FindViewById<EditText>(Resource.Id.Incidenttekst);

            prijaviinc.Click += (e, s) =>
            {
                RemoveRent slanje = new RemoveRent();
                slanje.IssueDesc = opis.Text;
                slanje.RentID = najam.Rentid;
                var klijent = new RestClient("http://marichely.me");
                var zahtjev = new RestRequest("rolling/issues", Method.POST);
                zahtjev.RequestFormat = DataFormat.Json;
                zahtjev.AddParameter("text/json", JsonConvert.SerializeObject(slanje), ParameterType.RequestBody);
                zahtjev.AddHeader("userapikey",user[0].ApiKey);
                IRestResponse odgovor = klijent.Execute(zahtjev);
                zahtjev = new RestRequest("rolling/issues/pictures", Method.POST);
                if ((int)odgovor.StatusCode == 200  )
                {
                    Toast.MakeText(this, "Successfully created the incident",ToastLength.Short).Show();
                    string issueid = odgovor.Content;

                    if (path != null)
                    {
                        zahtjev = new RestRequest("rolling/issues/pictures", Method.POST);
                        zahtjev.RequestFormat = DataFormat.Json;
                        zahtjev.AddHeader("userapikey", user[0].ApiKey);
                        zahtjev.AddHeader("incident", issueid);
                        zahtjev.AddFile("picture", path);
                        IRestResponse odgovor2 = klijent.Execute(zahtjev);
                        if ((int)odgovor2.StatusCode == 200)
                        {
                            Toast.MakeText(this, "Successfully created the incident", ToastLength.Short).Show();
                        }
                    }
                }

                


            };
            odaberiSliku.Click += (s, e) =>
            {
                var imageIntent = new Intent();
                imageIntent.SetType("image/*");
                imageIntent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(
                Intent.CreateChooser(imageIntent, "Select photo"), 0);          
            };
            
        }

        string ExportBitmapAsPNG(Bitmap bitmap)
        {
            var sdCardPath = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            var filePath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData),"slika.png");
            var stream = new FileStream(filePath, FileMode.Create);
            bitmap.Compress(Bitmap.CompressFormat.Png, 100, stream);
            stream.Close();
            return filePath;
        }


        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok)
            {
                var imageView =
                    FindViewById<ImageView>(Resource.Id.slikainc);
                imageView.SetImageURI(data.Data);
                podaci = data.Data;
                slika = MediaStore.Images.Media.GetBitmap(this.ContentResolver, podaci);
                path = ExportBitmapAsPNG(slika);
 
            }
        }

        

    }

}