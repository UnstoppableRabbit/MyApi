using Newtonsoft.Json;
using System.Net;
using System.Windows;
using System.Text;
using System;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для PostWindow.xaml
    /// </summary>
    public partial class PostWindow : Window
    {
        public PostWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Person ps = new Person();
            ps.Anek = anekTBox.Text;
            ps.Id = int.Parse(idTBox.Text);
            WebClient webClient = new WebClient();
            string kakoynibud = JsonConvert.SerializeObject(ps);
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            webClient.UploadString("http://localhost:63751/Anek/Abc", kakoynibud);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var ps = int.Parse(idTBox.Text);
            WebClient webClient = new WebClient();
            webClient.UploadString($"http://localhost:63751/Anek/Abc/{ps}", "Delete", "");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Person ps = new Person();
            ps.Anek = anekTBox.Text;
            WebClient webClient = new WebClient();
            string kakoynibud = JsonConvert.SerializeObject(ps);
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            webClient.UploadString($"http://localhost:63751/Anek/Abc/", "Put", kakoynibud);
        }
    }
}
