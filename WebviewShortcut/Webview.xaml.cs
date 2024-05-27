﻿using CefSharp;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using WpfAnimatedGif;

namespace WebviewShortcut
{
    /// <summary>
    /// Interaction logic for Webview.xaml
    /// </summary>
    public partial class Webview : Window
    {
        public Webview(string url, string tag)
        {
            InitializeComponent();

            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/Resources/loading.gif");
            image.EndInit();
            ImageBehavior.SetAnimatedSource(loadingImage, image);

            Browser.Address = url;

            Dispatcher.InvokeAsync(async () =>
            {
                await Task.Delay(3000); // Delay to ensure all elements are loaded
                // JavaScript to fill the form and click the login button
                string script = "";
                if (tag == "b1")
                {
                    string username = "Yang8034";
                    string password = "Yhs1137@";
                    script = $@"
                        document.querySelector('input[data-testid=""id""]').value = '{username}';
                        document.querySelector('input[data-testid=""password""]').value = '{password}';
                        document.querySelector('button.Button__StyledButton-sc-1cxc4dz-0.hlLPsc').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://self.baemin.com/shops/basic";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "b2")
                {
                    string username = "Yang8034";
                    string password = "Yhs1137@";
                    script = $@"
                        document.querySelector('input[data-testid=""id""]').value = '{username}';
                        document.querySelector('input[data-testid=""password""]').value = '{password}';
                        document.querySelector('button.Button__StyledButton-sc-1cxc4dz-0.hlLPsc').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://self.baemin.com/shops/suspend";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "b3")
                {
                    string username = "Yang8034";
                    string password = "Yhs1137@";
                    script = $@"
                        document.querySelector('input[data-testid=""id""]').value = '{username}';
                        document.querySelector('input[data-testid=""password""]').value = '{password}';
                        document.querySelector('button.Button__StyledButton-sc-1cxc4dz-0.hlLPsc').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://self.baemin.com/promotion/promotions";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "b4")
                {
                    string username = "Yang8034";
                    string password = "Yhs1137@";
                    script = $@"
                        document.querySelector('input[data-testid=""id""]').value = '{username}';
                        document.querySelector('input[data-testid=""password""]').value = '{password}';
                        document.querySelector('button.Button__StyledButton-sc-1cxc4dz-0.hlLPsc').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://self.baemin.com/shops/promotion/reviews";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "b5")
                {
                    string username = "Yang8034";
                    string password = "Yhs1137@";
                    script = $@"
                        document.querySelector('input[data-testid=""id""]').value = '{username}';
                        document.querySelector('input[data-testid=""password""]').value = '{password}';
                        document.querySelector('button.Button__StyledButton-sc-1cxc4dz-0.hlLPsc').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://self.baemin.com/shops/promotion/reviews/ceo/notice";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "b6")
                {
                    string username = "Yang8034";
                    string password = "Yhs1137@";
                    script = $@"
                        document.querySelector('input[data-testid=""id""]').value = '{username}';
                        document.querySelector('input[data-testid=""password""]').value = '{password}';
                        document.querySelector('button.Button__StyledButton-sc-1cxc4dz-0.hlLPsc').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://self.baemin.com/orders/history";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }

                if (tag == "y1")
                {
                    string username = "wardin86";
                    string password = "rjtjd8440!!";
                    script = $@"
                        document.querySelector('input[name=""username""]').value = '{username}';
                        document.querySelector('input[name=""password""]').value = '{password}';
                        document.querySelector('button.sc-bczRLJ.claiZC.sc-eCYdqJ.hsiXYt').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://ceo.yogiyo.co.kr/order-history/list";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "y2")
                {
                    string username = "wardin86";
                    string password = "rjtjd8440!!";
                    script = $@"
                        document.querySelector('input[name=""username""]').value = '{username}';
                        document.querySelector('input[name=""password""]').value = '{password}';
                        document.querySelector('button.sc-bczRLJ.claiZC.sc-eCYdqJ.hsiXYt').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://ceo.yogiyo.co.kr/opening-time";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "y3")
                {
                    string username = "wardin86";
                    string password = "rjtjd8440!!";
                    script = $@"
                        document.querySelector('input[name=""username""]').value = '{username}';
                        document.querySelector('input[name=""password""]').value = '{password}';
                        document.querySelector('button.sc-bczRLJ.claiZC.sc-eCYdqJ.hsiXYt').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://ceo.yogiyo.co.kr/menu/set";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "y4")
                {
                    string username = "wardin86";
                    string password = "rjtjd8440!!";
                    script = $@"
                        document.querySelector('input[name=""username""]').value = '{username}';
                        document.querySelector('input[name=""password""]').value = '{password}';
                        document.querySelector('button.sc-bczRLJ.claiZC.sc-eCYdqJ.hsiXYt').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://ceo.yogiyo.co.kr/soldout/menu";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "y5")
                {
                    string username = "wardin86";
                    string password = "rjtjd8440!!";
                    script = $@"
                        document.querySelector('input[name=""username""]').value = '{username}';
                        document.querySelector('input[name=""password""]').value = '{password}';
                        document.querySelector('button.sc-bczRLJ.claiZC.sc-eCYdqJ.hsiXYt').click();
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://ceo.yogiyo.co.kr/delivery/fee/list";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }

                if (tag == "c1")
                {
                    string username = "01087450981";
                    string password = "qhal1364@";
                    script = $@"
                        console.clear();
                        var userbox = document.querySelector('input[data-at=""loginId""]');
                        userbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{username}');
                        var passbox = document.querySelector('input[data-at=""password""]');
                        passbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{password}');
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    script = @"document.querySelector('button.btn.merchant-submit-btn').click();";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://store.coupangeats.com/merchant/management/orders";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "c2")
                {
                    string username = "01087450981";
                    string password = "qhal1364@";
                    script = $@"
                        console.clear();
                        var userbox = document.querySelector('input[data-at=""loginId""]');
                        userbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{username}');
                        var passbox = document.querySelector('input[data-at=""password""]');
                        passbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{password}');
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    script = @"document.querySelector('button.btn.merchant-submit-btn').click();";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://store.coupangeats.com/merchant/management/settlement";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "c3")
                {
                    string username = "01087450981";
                    string password = "qhal1364@";
                    script = $@"
                        console.clear();
                        var userbox = document.querySelector('input[data-at=""loginId""]');
                        userbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{username}');
                        var passbox = document.querySelector('input[data-at=""password""]');
                        passbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{password}');
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    script = @"document.querySelector('button.btn.merchant-submit-btn').click();";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://advertising.coupangeats.com/";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "c4")
                {
                    string username = "01087450981";
                    string password = "qhal1364@";
                    script = $@"
                        console.clear();
                        var userbox = document.querySelector('input[data-at=""loginId""]');
                        userbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{username}');
                        var passbox = document.querySelector('input[data-at=""password""]');
                        passbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{password}');
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    script = @"document.querySelector('button.btn.merchant-submit-btn').click();";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://store.coupangeats.com/merchant/management/coupons/recommendation";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "c5")
                {
                    string username = "01087450981";
                    string password = "qhal1364@";
                    script = $@"
                        console.clear();
                        var userbox = document.querySelector('input[data-at=""loginId""]');
                        userbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{username}');
                        var passbox = document.querySelector('input[data-at=""password""]');
                        passbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{password}');
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    script = @"document.querySelector('button.btn.merchant-submit-btn').click();";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://store.coupangeats.com/merchant/management/operation-hours/information";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "c6")
                {
                    string username = "01087450981";
                    string password = "qhal1364@";
                    script = $@"
                        console.clear();
                        var userbox = document.querySelector('input[data-at=""loginId""]');
                        userbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{username}');
                        var passbox = document.querySelector('input[data-at=""password""]');
                        passbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{password}');
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    script = @"document.querySelector('button.btn.merchant-submit-btn').click();";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://store.coupangeats.com/merchant/management/stores/";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "c7")
                {
                    string username = "01087450981";
                    string password = "qhal1364@";
                    script = $@"
                        console.clear();
                        var userbox = document.querySelector('input[data-at=""loginId""]');
                        userbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{username}');
                        var passbox = document.querySelector('input[data-at=""password""]');
                        passbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{password}');
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    script = @"document.querySelector('button.btn.merchant-submit-btn').click();";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://store.coupangeats.com/merchant/management/menu/";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
                if (tag == "c8")
                {
                    string username = "01087450981";
                    string password = "qhal1364@";
                    script = $@"
                        console.clear();
                        var userbox = document.querySelector('input[data-at=""loginId""]');
                        userbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{username}');
                        var passbox = document.querySelector('input[data-at=""password""]');
                        passbox.select();
                        document.execCommand('delete');
                        document.execCommand('insertText', false, '{password}');
                    ";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    script = @"document.querySelector('button.btn.merchant-submit-btn').click();";
                    Browser.ExecuteScriptAsyncWhenPageLoaded(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://store.coupangeats.com/merchant/management/reviews";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
            });
        }



        protected override void OnClosed(EventArgs e)
        {
            Browser.Dispose();
            Cef.GetGlobalCookieManager().DeleteCookies("", "");
            base.OnClosed(e);
        }
    }
}
