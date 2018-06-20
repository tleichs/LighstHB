using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace LighstHB
{
	public partial class App : Application
	{
        public static PublicClientApplication PCA { get; set; }
        public static object AuthenticationClient { get; internal set; }

        // Step #1: Add Azure AD B2C tenant information.
        public static string Tenant = "tiagoleichs.onmicrosoft.com";
        public static string ClientId = "f01671dc-6b74-4f68-a836-3409c6f28ab6";
        public static string SignUpPolicy = "B2C_1_Login";

        public static string AuthorityBase = $"https://login.microsoftonline.com/tfp/{Tenant}/";
        public static string Authority = $"{AuthorityBase}{SignUpPolicy}";
        public static string[] Scopes = { "https://tiagoleichs.onmicrosoft.com/demoapi/demo.read" };

        public static UIParent UiParent = null;

       


        //public static UIParent UiParent = null;

        public App ()
		{
			InitializeComponent();


            PCA = new PublicClientApplication(ClientId, Authority);
            PCA.RedirectUri = $"msal{ClientId}://auth";

            MainPage = new NavigationPage(new MainPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
