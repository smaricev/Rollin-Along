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
using RollingAlongMobile.Podatkovne_klase;
using System.Net;
using Android.Graphics;
using FFImageLoading;
using FFImageLoading.Views;
using Android.Icu.Text;
using Android.Content.Res;
using Com.Nostra13.Universalimageloader.Core;
using Android.Support.V4.Util;
using RollingAlongMobile.Profil;
using Newtonsoft.Json;
using RestSharp;

namespace RollingAlongMobile.Najam
{
    class NajmoviAdapter:BaseAdapter<Rent>
    {
        string userdata;
        public List<Rent> Najmovi;
        private Activity activity;
        public AssetManager Assets { get; private set; }
        public Context MojKontekst { get; private set; }
        private ImageLoader imageloader;
        MemoryLimitedLruCache _memoryCache;


        public NajmoviAdapter(Activity activity,List<Rent> najmovi,string data)
        {
            this.activity = activity;
            this.Najmovi = najmovi;
            MojKontekst = activity;
            userdata = data;    
            int DEFAULT_CACHE_SIZE_PROPORTION = 8;
            ActivityManager manager = (ActivityManager)MojKontekst.GetSystemService(Context.ActivityService);
            int memoryClass = manager.MemoryClass;
            int memoryClassInKilobytes = memoryClass * 1024;
            int cacheSize = memoryClassInKilobytes / DEFAULT_CACHE_SIZE_PROPORTION;

            _memoryCache = new MemoryLimitedLruCache(cacheSize);


        }

        public override Rent this[int position] => throw new NotImplementedException();

        public override int Count
        {
            get
            {
                return Najmovi.Count;
            }
        }


        public override long GetItemId(int position)
        {
            return Najmovi[position].Rentid;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {


            Typeface fontNormal;
            Assets = MojKontekst.Assets;
            fontNormal = Typeface.CreateFromAsset(Assets, "robotol.ttf");
            Typeface fontBold;
            fontBold = Typeface.CreateFromAsset(Assets, "roboto.ttf"); 
                
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.NajamRow, parent, false);
            var naslov = view.FindViewById<TextView>(Resource.Id.Naslov);
            var datum = view.FindViewById<TextView>(Resource.Id.Datum);
            var bicikl = view.FindViewById<TextView>(Resource.Id.Bicikl);
            var slika = view.FindViewById<ImageView>(Resource.Id.Slika);
            var cancelGumb = view.FindViewById<Button>(Resource.Id.cancel);
            var locationGumb = view.FindViewById<Button>(Resource.Id.location);
            var prijaviincidentgumb = view.FindViewById<Button>(Resource.Id.Incident);
            var ostaviRecenzijuGumb = view.FindViewById<Button>(Resource.Id.feedback);

            var glavni = view.FindViewById<RelativeLayout>(Resource.Id.glavni);




            naslov.Typeface = fontBold;
            datum.Typeface = fontNormal;bicikl.Typeface = fontNormal;

            DateTime dt = Convert.ToDateTime(Najmovi[position].Date_from);
            DateTime dt2 = Convert.ToDateTime(Najmovi[position].Date_to);

            string status = "not set" ;

            switch (Najmovi[position].Status)
            {
                case 1: status = "Reserved";break;
                case 2: status = "Active";break;
                case 3: status = "Expired"; break;
            }
            if(Najmovi[position].Status == 1)
            {
                /*glavni.RemoveView(locationGumb);
                glavni.RemoveView(prijaviincidentgumb);
                glavni.RemoveView(ostaviRecenzijuGumb);*/
                locationGumb.Visibility = ViewStates.Gone;
                prijaviincidentgumb.Visibility = ViewStates.Visible;
                ostaviRecenzijuGumb.Visibility = ViewStates.Gone;
                cancelGumb.Visibility = ViewStates.Visible;
                var param1 = (RelativeLayout.LayoutParams)cancelGumb.LayoutParameters;
                param1.AddRule(LayoutRules.RightOf, Resource.Id.Incident);
            }
            if (Najmovi[position].Status == 2)
            {
                cancelGumb.Visibility = ViewStates.Gone;
                ostaviRecenzijuGumb.Visibility = ViewStates.Gone;
                locationGumb.Visibility = ViewStates.Visible;
                prijaviincidentgumb.Visibility = ViewStates.Visible;
               /* glavni.RemoveView(cancelGumb);
                glavni.RemoveView(ostaviRecenzijuGumb);*/
                var param1 = (RelativeLayout.LayoutParams)locationGumb.LayoutParameters;
                param1.AddRule(LayoutRules.RightOf, Resource.Id.Incident);
            }
            if (Najmovi[position].Status == 3)
            {
                /*glavni.RemoveView(locationGumb);
                glavni.RemoveView(prijaviincidentgumb);
                glavni.RemoveView(ostaviRecenzijuGumb);*/
                ostaviRecenzijuGumb.Visibility = ViewStates.Visible;
                cancelGumb.Visibility = ViewStates.Gone;
                locationGumb.Visibility = ViewStates.Gone;
                prijaviincidentgumb.Visibility = ViewStates.Gone;
            }

            naslov.Text = "Rent ID: " + Najmovi[position].Rentid.ToString();
            datum.Text ="From: " + dt.ToLocalTime().ToString() +"\n"+ "To: " + dt2.ToLocalTime().ToString()+"\n"+"Status: "+status;
            bicikl.Text = "Bicycle ID: " + Najmovi[position].Bicycle.Bicycleid + "\n" + "Category: " + Najmovi[position].Bicycle.Category.Name + "\n" + "Price per day: " + Najmovi[position].Bicycle.Price_per_day + " " + Najmovi[position].Bicycle.Currency
                            + "\n" + "Price per hour: " + Najmovi[position].Bicycle.Price_per_hour + " " + Najmovi[position].Bicycle.Currency + "\n";
            var id = Najmovi[position].Bicycle.Bicycleid;
            string url = "http://marichely.me/rolling/media/bike/"+id+"/"+id+".jpg";

            if (_memoryCache.Get(id) == null)
                _memoryCache.Put(id, GetImageBitmapFromUrl(url));
            slika.SetImageBitmap((Bitmap)_memoryCache.Get(id));

            prijaviincidentgumb.Click += (e, s) =>
            {
                Intent incident = new Intent(MojKontekst, typeof(PrijavaIncidentaActivity));

                string serializiraniNajmovi = JsonConvert.SerializeObject(Najmovi[position]);

                incident.PutExtra("user", userdata);
                incident.PutExtra("rent", serializiraniNajmovi);
                MojKontekst.StartActivity(incident);
            };
            ostaviRecenzijuGumb.Click += (e, s) =>
            {
                Intent incident = new Intent(MojKontekst, typeof(RecenzijaActivity));
                string serializiraniNajmovi = JsonConvert.SerializeObject(Najmovi[position]);
                incident.PutExtra("user", userdata);
                incident.PutExtra("rent", serializiraniNajmovi);
                MojKontekst.StartActivity(incident);
            };
            cancelGumb.Click += (e, s) =>
              {
                  List<User> user = JsonConvert.DeserializeObject<List<User>>(userdata);
                  var klijent = new RestClient("http://marichely.me");
                  var zahtjev = new RestRequest("rolling/rent", Method.DELETE);
                  zahtjev.RequestFormat = DataFormat.Json;
                  zahtjev.AddHeader("userapikey", user[0].ApiKey);
                  zahtjev.AddHeader("rentid", Najmovi[position].Rentid.ToString());
                  IRestResponse odgovor = klijent.Execute(zahtjev);
                  if ((int)odgovor.StatusCode == 200)
                  {
                      Toast.MakeText(MojKontekst, "Successfully removed the Rent", ToastLength.Short).Show();
                  }
                  Najmovi.Remove(Najmovi[position]);
                  this.NotifyDataSetChanged();
                    
              };



            return view;
        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);

                }
            }

            return imageBitmap;
        }

        public PrijavaIncidentaActivity PrijavaIncidentaActivity
        {
            get => default(PrijavaIncidentaActivity);
            set
            {
            }
        }

        public AktivniNajmoviActivity AktivniNajmoviActivity
        {
            get => default(AktivniNajmoviActivity);
            set
            {
            }
        }
    }

    public class MemoryLimitedLruCache : LruCache
    {
        public MemoryLimitedLruCache(int size) : base(size) { }

        protected override int SizeOf(Java.Lang.Object key, Java.Lang.Object value)
        {
            // android.graphics.Bitmap.getByteCount() method isn't currently implemented in Xamarin. Invoke Java method.
            IntPtr classRef = JNIEnv.FindClass("android/graphics/Bitmap");
            var getBytesMethodHandle = JNIEnv.GetMethodID(classRef, "getByteCount", "()I");
            var byteCount = JNIEnv.CallIntMethod(value.Handle, getBytesMethodHandle);

            return byteCount / 1024;
        }
    }
}