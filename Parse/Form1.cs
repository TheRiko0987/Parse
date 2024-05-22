using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Parse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;

            if (keyword == "")
            {
                MessageBox.Show("Введите адрес");
                return;
            }
            try
            {
                string result4;
                using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
                {
                    client.BaseAddress = new Uri("https://ipinfo.io/");
                    HttpResponseMessage response = client.GetAsync($"{keyword}/geo").Result;
                    response.EnsureSuccessStatusCode();
                    result4 = response.Content.ReadAsStringAsync().Result;

                }
                // Преобразование в класс
                IpAdress ip = JsonConvert.DeserializeObject<IpAdress>(result4);

                DialogResult dialogResult = MessageBox.Show(ip.ToFormatedString(), "Добавить в базу данных?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            //db.Database.EnsureDeleted();
                            db.Database.EnsureCreated();

                            IpAdress ips = db.IpAdresses.FirstOrDefault(p => p.ip == keyword);
                            if (ips == null)
                            {
                                db.IpAdresses.Add(ip);
                                db.SaveChanges();
                                MessageBox.Show("Адрес успешно добавлен", "Уведомление", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Такой адрес уже добавлен", "Предупреждение!!!", MessageBoxButtons.OK);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            catch
            {
                MessageBox.Show("ip адрес введен неверно.");
            }
        }

        private void Navig_Butt_Click(object sender, EventArgs e)
        {
            DataGrid next = new DataGrid();
            next.Show();
        }
    }
}

