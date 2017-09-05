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

namespace RollingAlongMobile.Prijava_i_registracija
{
    [Activity(Label = "Registracija")]
    public class RegistracijaActivity : Activity
    {
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

            // Create your application here
        }
    }
}