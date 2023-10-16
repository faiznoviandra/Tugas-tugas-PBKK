using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animasi_jam_digital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();                                 //nama variabel 
            timer.Interval = 1000;                                     //set interval, 1000 = 1detik
            timer.Tick += new EventHandler(label1_Click);              //objek menjalankan
            timer.Start();                                             //set agar program berjalan
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int jam = DateTime.Now.Hour;                              //variabel int jam dari sistem
            int menit = DateTime.Now.Minute;                          // -----"----- menit dari sistem
            int detik = DateTime.Now.Second;                          // -----"----- detik dari sistem
            label1.Text = jam + ":" + menit + ":" + detik;            //agar label menjadi jam : menit : detik
        }
    }
}
