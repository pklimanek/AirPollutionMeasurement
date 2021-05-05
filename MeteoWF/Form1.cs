using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MeteoWF
{
    public partial class home : Form
    {
        MeteoDBEntities context = new MeteoDBEntities();
        public home()
        {
            InitializeComponent();
            dashboard1.BringToFront();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openNowlabel.Text = "Dashboard";
            dashboard1.BringToFront();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openNowlabel.Text = "Historic data - air quality";
            lastWeek1.BringToFront();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openNowlabel.Text = "Today's air quality";
            today1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closePic_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimisePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reportbutton_Click(object sender, EventArgs e)
        {
            openNowlabel.Text = "Generate report";
            generateReport1.BringToFront();
        }

        
    }
}
