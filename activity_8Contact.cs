using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _607A2
{
    [Activity(Label = "activity_8Contact")]
    public class activity_8Contact : Activity
    {

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_8Contact);
            ImageView home = FindViewById<ImageView>(Resource.Id.Sc8Back);
            home.Click += Home_Click;
        }

        void Home_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }
    


    }
}