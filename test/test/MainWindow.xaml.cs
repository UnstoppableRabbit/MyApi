using System.Windows;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void JustButton_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            //using (Stream stream = webClient.OpenRead("http://localhost:63751/anek/Abc/2"))
            //{
            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        using (FileStream fs = new FileStream("", FileMode.OpenOrCreate))
            //        {
            //            Person tom = new Person() { Id = 2, Anek = "qweqwe" };
            //            string json = JsonConvert.SerializeObject(tom, Formatting.Indented);
            //            File.WriteAllText("D:\\stud\\Desktop\\228\\user.json", json, System.Text.Encoding.GetEncoding(1251));

            //        }
            //    }
            //}
            webClient.Encoding = System.Text.Encoding.UTF8;
            string kakoynibud = webClient.DownloadString("http://localhost:63751/anek/Abc/2");
            string kakoynibud2 = webClient.DownloadString("http://localhost:63751/anek/Abc");

            var ps = new Person();
            ps = JsonConvert.DeserializeObject<Person>(kakoynibud);
            DataTBox.Text = ps.Anek;
            List<Person> mm = new List<Person>();
            mm = JsonConvert.DeserializeObject<List<Person>>(kakoynibud2);
            lolGrid.ItemsSource = mm;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PostWindow pw = new PostWindow();
            pw.Show();

        }
    }
}
