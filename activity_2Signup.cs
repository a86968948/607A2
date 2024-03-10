using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _607A2.Models;

namespace _607A2
{
    [Activity(Label = "activity2_Signup")]
    public class activity_2Signup : Activity
    {
        EditText? obj_UserName, obj_PassWord, obj_Name, obj_Mobile, obj_Email;
        private ImageView Signupbtn;
        DatabaseManager obj_databaseManager;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_2Signup);
            //get all the value for the sign up page
            obj_UserName = FindViewById<EditText>(Resource.Id.UserName_EditText);
            obj_PassWord = FindViewById<EditText>(Resource.Id.PassWord_EditText);
            obj_Name = FindViewById<EditText>(Resource.Id.Name_EditText);
            obj_Mobile = FindViewById<EditText>(Resource.Id.Mobile_EditText);
            obj_Email = FindViewById<EditText>(Resource.Id.Email_EditText);

            obj_databaseManager = new DatabaseManager();
            //click to register
            Signupbtn = FindViewById<ImageView>(Resource.Id.Signupbtn);
            Signupbtn.Click += onImageViewClick_Signupbtn;
            ImageView home = FindViewById<ImageView>(Resource.Id.homebtn1);
            home.Click += Home_Click;
        }

        private void onImageViewClick_Signupbtn(object? sender, EventArgs e)
        {
            //making sure the button is working
            Toast.MakeText(this, "you have clicked the button", ToastLength.Long).Show();
            Signup signUp = new Signup();
            {
                signUp.UserName = obj_UserName.Text;
                signUp.PassWord = obj_PassWord.Text;
                signUp.Name = obj_Name.Text;
                signUp.Mobile = obj_Mobile.Text;
                signUp.Email = obj_Email.Text;
            };

            obj_databaseManager.InsertUser(signUp);
            Toast.MakeText(this, "Person Data is inserted successfully", ToastLength.Long).Show();
        }

        void Home_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }
    }
}
