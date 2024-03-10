using Android.Text;
using Android.Views;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


namespace _607A2
{
    [Activity(Label = "SurfsApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ImageView Signupbtn;
        private bool loginornot = false;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            Signupbtn = FindViewById<ImageView>(Resource.Id.imageView5);
            Signupbtn.Click += onImageViewClick_SC4Back;

            ImageView menubtn = FindViewById<ImageView>(Resource.Id.menubtn1);
            TextView home = FindViewById<TextView>(Resource.Id.Homebtn);
            TextView profile = FindViewById<TextView>(Resource.Id.Profilebtn);
            TextView ordersum = FindViewById<TextView>(Resource.Id.OrderSummarybtn);
            TextView receiver = FindViewById<TextView>(Resource.Id.ReceListbtn);
            TextView contact = FindViewById<TextView>(Resource.Id.Contactbtn);
            TextView histroy = FindViewById<TextView>(Resource.Id.Histroybtn);
            TextView sign = FindViewById<TextView>(Resource.Id.Signbtn);
            menubtn.Click += Menubtn_Click;
            home.Click += Home_Click;
            profile.Click += Profile_Click;
            ordersum.Click += Ordersum_Click;
            receiver.Click += Receiver_Click;
            contact.Click += Contact_Click;
            histroy.Click += Histroy_Click;
            sign.Click += Sign_Click;
        }
        private void Menubtn_Click(object? sender, EventArgs e)
        {
            ImageView icon = FindViewById<ImageView>(Resource.Id.menuicon1);
            TextView icon1 = FindViewById<TextView>(Resource.Id.Homebtn);
            TextView icon2 = FindViewById<TextView>(Resource.Id.Profilebtn);
            TextView icon3 = FindViewById<TextView>(Resource.Id.OrderSummarybtn);
            TextView icon4 = FindViewById<TextView>(Resource.Id.ReceListbtn);
            TextView icon5 = FindViewById<TextView>(Resource.Id.Contactbtn);
            TextView icon6 = FindViewById<TextView>(Resource.Id.Histroybtn);
            TextView icon7 = FindViewById<TextView>(Resource.Id.Signbtn);
            if (icon.Visibility == ViewStates.Visible)
            {
                icon.Visibility = ViewStates.Gone; // Òþ²Ø Toolbar
                icon1.Visibility = ViewStates.Gone;
                icon2.Visibility = ViewStates.Gone;
                icon3.Visibility = ViewStates.Gone;
                icon4.Visibility = ViewStates.Gone;
                icon5.Visibility = ViewStates.Gone;
                icon6.Visibility = ViewStates.Gone;
                icon7.Visibility = ViewStates.Gone;
            }
            else
            {
                icon.Visibility = ViewStates.Visible;
                icon1.Visibility = ViewStates.Visible;
                icon2.Visibility = ViewStates.Visible;
                icon3.Visibility = ViewStates.Visible;
                icon4.Visibility = ViewStates.Visible;
                icon5.Visibility = ViewStates.Visible;
                icon6.Visibility = ViewStates.Visible;
                icon7.Visibility = ViewStates.Visible;// ÏÔÊ¾ Toolbar
            }
        }

        void onImageViewClick_SC4Back(Object sender, EventArgs e)
        {

            StartActivity(typeof(activity_2Signup));
        }
        void Home_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }
        void Profile_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(activity_4Profile));

        }
        void Ordersum_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(activity_9OrderSum));

        }
        void Receiver_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(activity_5OrderRe));

        }
        void Contact_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(activity_8Contact));

        }
        void Histroy_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(activity_7HistroyTrans));

        }
        void Sign_Click(object? sender, EventArgs e)
        {
            if (loginornot == false)
            {
                StartActivity(typeof(activity_2Signup));

            }
            else if(loginornot == true)
            {
                StartActivity(typeof(activity_3Signin));
            }
        }
    }
}