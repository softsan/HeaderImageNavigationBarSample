using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using CenterHeaderImageSample;
using CenterHeaderImageSample.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SamplePage), typeof(MyNavigationRenderer))]
namespace CenterHeaderImageSample.iOS
{
    public class MyNavigationRenderer : PageRenderer
    {
       
        //private UIImage logo;
        public MyNavigationRenderer()
        {
            //logo = UIImage.FromFile("Icon-Small.png");
            //        UIImageView imageView = new UIImageView(new System.Drawing.Rectangle(0, 0, 100, 44));
            //        imageView.Image = logo;

            //NavigationItem.TitleView = imageView;
             // NavigationItem.TitleView = new UIImageView(UIImage.FromFile("OIcon57.png"));
        }
        public override void ViewDidLoad()
        {
            try
            {
                base.ViewDidLoad();
                //this.NavigationBar.TintColor = UIColor.White;
                //this.NavigationBar.BarTintColor = MobileCRM.Shared.Helpers.Color.Blue.ToUIColor();
                //this.NavigationBar.BarStyle = UIBarStyle.Black;

                var image = UIImage.FromFile("Icon-Small.png");
                var small = image.Scale(new SizeF(25f, 25f));
                UIImageView imageView = new UIImageView(small);
                NavigationItem.TitleView = imageView;

                // UINavigationBar.Appearance.BarTintColor = UIColor.Blue;
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message + " " + ex.StackTrace);
                // throw;
            }
        }
    }
}