using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _607A2
{
    [Activity(Label = "activity_4Profile")]
    public class activity_5OrderRe : Activity
    {

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_5OrderRe);
            ImageView home = FindViewById<ImageView>(Resource.Id.Sc5Back);
            home.Click += Home_Click;
            TextView edit = FindViewById<TextView>(Resource.Id.edit1);
            edit.Click += User1edit_Click;
            ImageView view = FindViewById<ImageView>(Resource.Id.BACK1);
            view.Click += User1view_Click;
        }

        void Home_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }
        void User1edit_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(Add_EditRece10));

        }
        void User1view_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(activity_6RecDetail));

        }

    }
}
