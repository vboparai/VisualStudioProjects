using System;
using Xamarin.Auth;
using System.Json;
using Foundation;
using UIKit;

namespace FacebookLogin
{
    public partial class ViewController : UIViewController
    {

        private async void Auth_Completed(object sender, AuthenticatorCompletedEventArgs e)
        {

            if(e.IsAuthenticated)
            {
                var request = new OAuth2Request(
                    "GET",
                    new Uri("https://graph.facebook.com/me?fields=name,picture,cover,birthday"),
                    null,
                    e.Account
                );

                var fbResponse = await request.GetResponseAsync();

                var fbUser = JsonValue.Parse(fbResponse.GetResponseText());

                nameLabel.Text = fbUser["name"];
                idLabel.Text = fbUser["id"];
            }

            DismissViewController(true, null);



        }

        partial void FbButton_TouchUpInside(UIButton sender)
        {
            var auth = new OAuth2Authenticator(
                clientId: "185428948936483",
                scope: "",
                authorizeUrl: new Uri("http://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("https://www.facebook.com/connect/login_success.html")
            );

            auth.Completed += Auth_Completed;
            var ui = auth.GetUI();
            PresentViewController(ui, true, null);

        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
