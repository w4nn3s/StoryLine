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

            ImageButton imgbtnLN = FindViewById<ImageButton>(Resource.Id.imgbtnLN);
            ImageButton imgbtnT = FindViewById<ImageButton>(Resource.Id.imgbtnT);
            ImageButton imgbtnMN = FindViewById<ImageButton>(Resource.Id.imgbtnMN);
            ImageButton imgbtnCE = FindViewById<ImageButton>(Resource.Id.imgbtnCE);

            imgbtnLN.Click += (sender, e) =>
            {
                var viewalbumact = new Intent(this, typeof(ViewAlbumActivity));
                viewalbumact.PutExtra("AlbumID", "1");
                StartActivity(viewalbumact);
            };

            imgbtnT.Click += (sender, e) =>
            {
                var viewalbumact = new Intent(this, typeof(ViewAlbumActivity));
                viewalbumact.PutExtra("AlbumID", "2");
                StartActivity(viewalbumact);
            };


            imgbtnMN.Click += (sender, e) =>
            {
                var viewalbumact = new Intent(this, typeof(ViewAlbumActivity));
                viewalbumact.PutExtra("AlbumID", "3");
                StartActivity(viewalbumact);
            };


            imgbtnCE.Click += (sender, e) =>
            {
                var viewalbumact = new Intent(this, typeof(ViewAlbumActivity));
                viewalbumact.PutExtra("AlbumID", "4");
                StartActivity(viewalbumact);
            };

        }
    }
}

