using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoWF
{
    public partial class Today : UserControl
    {
        MeteoDBEntities context = new MeteoDBEntities();
        public Today()
        {
            InitializeComponent();
            WyswietlWykres();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Today_Load(object sender, EventArgs e)
        {
            var lastid = context.Pomiaries.Select(x => x.PomiarID).Max();
            //var lastdate = context.Pomiaries.Where(x => x.PomiarID == lastid).Select(x => x.DataCzas);
            
            double sr1;
            double sr25;
            double sr10;

            try
            {
                var temp = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.Temperatura);
                double srtemp = Math.Round((double)temp, 1);
                TempWar.Text = string.Format(srtemp.ToString() + "°C");

                var humid = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.Wilgotnosc);
                double srhumid = Math.Round((double)humid, 1);
                HumidWar.Text = string.Format(srhumid.ToString() + "%");

                var srednia1 = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM1);
                sr1 = Math.Round((double)srednia1, 1);
                PM1text.Text = string.Format(sr1.ToString() + " µg/m3");

                var srednia25 = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM25);
                sr25 = Math.Round((double)srednia25, 1);
                PM25text.Text = string.Format(sr25.ToString() + " µg/m3");

                var srednia10 = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM10);
                sr10 = Math.Round((double)srednia10, 1);
                PM10text.Text = string.Format(sr10.ToString() + " µg/m3");
            }
            catch (Exception)
            {
                MessageBox.Show("There's no today's data in attached database. Previous data will be shown.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var temp = context.Pomiaries.Where(x => x.PomiarID == lastid).Average(x => x.Temperatura);
                double srtemp = Math.Round((double)temp, 1);
                TempWar.Text = string.Format(srtemp.ToString() + "°C");

                var humid = context.Pomiaries.Where(x => x.PomiarID == lastid).Average(x => x.Wilgotnosc);
                double srhumid = Math.Round((double)humid, 1);
                HumidWar.Text = string.Format(srhumid.ToString() + "%");

                var srednia1 = context.Pomiaries.Where(x => x.PomiarID == lastid).Average(x => x.PM1);
                sr1 = Math.Round((double)srednia1, 1);
                PM1text.Text = string.Format(sr1.ToString() + " µg/m3");
                
                var srednia25 = context.Pomiaries.Where(x => x.PomiarID == lastid).Average(x => x.PM25);
                sr25 = Math.Round((double)srednia25, 1);
                PM25text.Text = string.Format(sr25.ToString() + " µg/m3");

                var srednia10 = context.Pomiaries.Where(x => x.PomiarID == lastid).Average(x => x.PM10);
                sr10 = Math.Round((double)srednia10, 1);
                PM10text.Text = string.Format(sr10.ToString() + " µg/m3");

            }

            //ustawienie kolorow dla PM1
            if (sr1 <= 35)
            {
                PM1text.ForeColor = System.Drawing.Color.Green;
            }
            if ((sr1 > 35) && (sr1 <= 75))
            {
                PM1text.ForeColor = System.Drawing.Color.Orange;
            }
            if (sr1 > 75)
            {
                PM1text.ForeColor = System.Drawing.Color.Red;
            }

            //ustawienie kolorow dla PM2,5
            if (sr25 <= 35)
            {
                PM25text.ForeColor = System.Drawing.Color.Green;
            }
            if ((sr25 > 35) && (sr25 <= 75))
            {
                PM25text.ForeColor = System.Drawing.Color.Orange;
            }
            if (sr25 > 75)
            {
                PM25text.ForeColor = System.Drawing.Color.Red;
            }

            //ustawienie kolorow dla PM10
            if (sr10 <= 50)
            {
                PM10text.ForeColor = System.Drawing.Color.Green;
            }
            if ((sr10 > 50) && (sr10 <= 110))
            {
                PM10text.ForeColor = System.Drawing.Color.Orange;
            }
            if (sr10 > 110)
            {
                PM10text.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void TempWar_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        void WyswietlWykres()
        {
            var lastid = context.Pomiaries.Select(x => x.PomiarID).Max();
            try
            {
                var srednia1 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM1), 2);
                this.chart1.Series["Concentration"].Points.AddXY("PM1", srednia1);

                var srednia25 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM25), 2);
                this.chart1.Series["Concentration"].Points.AddXY("PM2,5", srednia25);

                var srednia10 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM10), 2);
                this.chart1.Series["Concentration"].Points.AddXY("PM10", srednia10);
            }
            catch (Exception)
            {
                var srednia1 = Math.Round((double)context.Pomiaries.Where(x => x.PomiarID == lastid).Average(x => x.PM1), 2);
                this.chart1.Series["Concentration"].Points.AddXY("PM1", srednia1);

                var srednia25 = Math.Round((double)context.Pomiaries.Where(x => x.PomiarID == lastid).Average(x => x.PM25), 2);
                this.chart1.Series["Concentration"].Points.AddXY("PM2,5", srednia25);

                var srednia10 = Math.Round((double)context.Pomiaries.Where(x => x.PomiarID == lastid).Average(x => x.PM10), 2);
                this.chart1.Series["Concentration"].Points.AddXY("PM10", srednia10);
            }
        }

    }
}
