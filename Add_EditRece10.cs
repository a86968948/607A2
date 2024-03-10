using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _607A2
{
    [Activity(Label = "Add_EditRece10")]
    public class Add_EditRece10 : Activity
    {

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Add_EditRece10);
            ImageView home = FindViewById<ImageView>(Resource.Id.Sc10Back);
            home.Click += Home_Click;
        }

        void Home_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }
    


    }
}