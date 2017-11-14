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
using Android.Graphics;
using System.Net;

namespace App1
{
    [Activity(Label = "StoryLine")]
    public class ViewAlbumActivity : Activity
    {


        List<Bitmap> panels; //Panel list in bitmap format (preloaded)
        int cp = 0; // Current panel ID in List

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ViewAlbum);

            //Inladen Album
            string albumid = Intent.GetStringExtra("AlbumID") ?? "Album niet beschikbaar";


            


            var ImageView = FindViewById<ImageView>(Resource.Id.imageView1);


            //Load
            switch (albumid)
            {
                case "1": // LITTLE NEMO
                    panels = new List<Bitmap>
                    {
                        GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/little_nemo/1.png"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/little_nemo/2.png"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/little_nemo/3.png"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/little_nemo/4.png")
                    };
                    break;
                case "2": //TOM
                    panels = new List<Bitmap>
                    {
                        GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/tom/t1.jpg"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/tom/t2.jpg"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/tom/t3.jpg"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/tom/t4.jpg"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/tom/t5.jpg"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/tom/t6.jpg"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/tom/t7.jpg")
                    };
                    break;
                case "3": // MIRA NORTH
                    panels = new List<Bitmap>
                    {
                        GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn1.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn2.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn3.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn4.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn5.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn6.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn7.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn8.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn9.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn10.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn11.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/myra_north/mn12.PNG")
                    };
                    break;
                case "4": // CAPTAIN EASY
                    panels = new List<Bitmap>
                    {
                        GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/captain_easy/ce1.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/captain_easy/ce2.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/captain_easy/ce3.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/captain_easy/ce4.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/captain_easy/ce6.PNG"),GetImageBitmapFromUrl("http://www.wannescolman.be/storyline/captain_easy/ce6.PNG")
                    };
                    break;
                default:
                    ImageView.SetImageResource(Resource.Drawable.mncover);
                    break;


            }









            ImageView.SetImageBitmap(panels[cp]); //Set viewer to first panel
            ImageView.Click += (sender, e) =>   //onclick, go to next panel
            {
                if((cp+1)==panels.Count())
                    cp = 0;
                else
                    cp++;

                ImageView.SetImageBitmap(panels[cp]);
            };
        }


        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }

    }



}