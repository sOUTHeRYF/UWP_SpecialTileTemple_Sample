using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Notifications;
using Windows.Storage;
//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍
using NotificationsExtensions.Tiles;
using Windows.Data.Xml.Dom;
namespace UpdateTile
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<string> charactorPics = new List<string>();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async  void UpdatePeopleTileBtn_Click(object sender, RoutedEventArgs e)
        {
            StorageFile xmlDataFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("UpdateTiles_People.xml");
            XmlDocument doc = await XmlDocument.LoadFromFileAsync(xmlDataFile);
            //     doc.Load(xmlFilePath);

            //   var notification = new TileNotification(content.GetXml());
            var notification = new TileNotification(doc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);
        }

        private async void UpdateContactTileBtn_Click(object sender, RoutedEventArgs e)
        {
            /*
            TileContent content = new TileContent()
            {
                Visual = new TileVisual()
                {
                    TileMedium = new TileBinding()
                    {

                    }
                }
            };
            TileBindingContentContact a = new TileBindingContentContact();
            a.Image = new TileImageSource("ms-appx:///TilesIcon/player_amazon.png");
            a.Text = new TileBasicText(); 
            a.Text.Text = "拥有10000金币";
            content.Visual.TileMedium.Content = a;
            string temp = content.GetContent();
            //   TileBindingContentPhotos b;
            //     doc.Load(xmlFilePath);

            var notification = new TileNotification(content.GetXml());
            // var notification = new TileNotification(doc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);
            */
            StorageFile xmlDataFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("UpdateTiles_Contact.xml");
            XmlDocument doc = await XmlDocument.LoadFromFileAsync(xmlDataFile);
            //     doc.Load(xmlFilePath);

            //   var notification = new TileNotification(content.GetXml());
            var notification = new TileNotification(doc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);
        }

        private async void UpdatePhotosTileBtn_Click(object sender, RoutedEventArgs e)
        {
            StorageFile xmlDataFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("UpdateTiles_Photo.xml");
            XmlDocument doc = await XmlDocument.LoadFromFileAsync(xmlDataFile);

            var notification = new TileNotification(doc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);
        }
    }
}
