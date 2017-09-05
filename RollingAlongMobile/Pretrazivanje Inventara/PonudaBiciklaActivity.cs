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

namespace RollingAlongMobile.Pretrazivanje_Inventara
{
    [Activity(Label = "PonudaActivity")]
    public class PonudaBiciklaActivity : Activity
    {
        public Profil.ProfilActivity ProfilActivity
        {
            get => default(Profil.ProfilActivity);
            set
            {
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}