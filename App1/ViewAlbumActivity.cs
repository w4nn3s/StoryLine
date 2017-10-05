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

namespace App1
{
    [Activity(Label = "ViewAlbumActivity")]
    public class ViewAlbumActivity : Activity
    {

        List<int> panels; // Panel List
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
                case "1":
                    panels = new List<int>
                    {
                        2130837504,2130837505,2130837506,2130837507
                    };
                    break;
                case "2":
                    panels = new List<int>
                    {
                        2130837522,2130837523,2130837525,2130837526,2130837527,2130837528
                    };
                    break;
                case "3":
                    panels = new List<int>
                    {
                        2130837509,2130837510,2130837511,2130837512,2130837513,2130837514,2130837515,2130837516,2130837517,2130837518,2130837519,2130837520
                    };
                    break;
                default:
                    ImageView.SetImageResource(Resource.Drawable.ln2);
                    break;

            }









            ImageView.SetImageResource(panels[cp]); //Set viewer to first panel
            ImageView.Click += (sender, e) =>   //onclick, go to next panel
            {
                if((cp+1)==panels.Count())
                    cp = 0;
                else
                    cp++;

                ImageView.SetImageResource(panels[cp]);
            };
        }
    }
}