using Android.App;
using Android.Widget;
using Android.OS;
using Android.Net;
using Android.Content;

namespace App1
{
    [Activity(Label = "StoryLine", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ImageButton imageButton1 = FindViewById<ImageButton>(Resource.Id.imageButton1);

          /*  imageButton1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ViewAlbumActivity));
                intent.put

            };*/
        }
    }
}

