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
using LighstHB;
using LighstHB.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]
namespace LighstHB.Droid
{
    [Activity(Label = "MainPageRenderer")]
    class MainPageRenderer : PageRenderer
    {
        MainPage page;

        public MainPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            page = e.NewElement as MainPage;
            var activity = this.Context as Activity;
        }
    }
}