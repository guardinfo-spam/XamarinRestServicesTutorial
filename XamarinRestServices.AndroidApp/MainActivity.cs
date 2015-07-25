using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XamarinRestServices.RestServicePclLibrary;
using XamarinRestServices.Models;

namespace XamarinRestServices.AndroidApp
{
    [Activity(Label = "XamarinRestServices.AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource
            Button button = FindViewById<Button>(Resource.Id.MyButton);


            ServiceWrapper serviceWrapper = new ServiceWrapper();
            var model = new UserModel { Username = "demo", Password = "demo" }; 

            var result = await serviceWrapper.GetData("test");
            button.Text = "get call says: " + result;            

            result = await serviceWrapper.RegisterUserJsonRequest(model);
            button.Text = "json post call says: " + result;

            result = await serviceWrapper.RegisterUserFormRequest(model);
            button.Text = "form post request says: " + result;
        }
    }
}

