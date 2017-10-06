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
    [Activity(Label = "StoryLine")]
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
                case "1": // LITTLE NEMO
                    panels = new List<int>
                    {
                        2130837511,2130837512,2130837513,2130837514
                    };
                    break;
                case "2": //TOM
                    panels = new List<int>
                    {
                        2130837529,2130837530,2130837531,2130837532,2130837533,2130837534,2130837535
                    };
                    break;
                case "3": // MIRA NORTH
                    panels = new List<int>
                    {
                        2130837516,2130837520,2130837521,2130837522,2130837523,2130837524,2130837525,2130837526,2130837527,2130837517,2130837518,2130837519
                    };
                    break;
                case "4": // CAPTAIN EASY
                    panels = new List<int>
                    {
                        2130837504,2130837505,2130837506,2130837507,2130837508,2130837509
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