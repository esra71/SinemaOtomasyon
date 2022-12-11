using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void xtrFollow_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7jCW87C2KMo&t=42s");  //xtrapage5 in adını xtrFollow diye değiştirdim. Click olayını kullanarak xtrFollow bastığımda webbrowser1 bağlandı. 
        }

        private void xtrOrman_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.youtube.com/watch?v=Dak0gk-rRso&t=5s"); //xtrapage6 nın adını xtrOrman diye değiştirdim. Click olayını kullanarak xtrOrman bastığımda webbrowser2 bağlandı. 
        }

        private void xtrFreaky_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate("https://www.youtube.com/watch?v=m4TgEjO4sYk&t=3s"); //xtrapage7 nın adını xtrFreaky diye değiştirdim. Click olayını kullanarak xtrFreaky bastığımda webbrowser3 bağlandı. 
        }

        private void xtrBarbar_Click(object sender, EventArgs e)
        {
            webBrowser4.Navigate("https://www.youtube.com/watch?v=2rGGGZaqGAg&t=6s"); //xtrapage8 nın adını xtrBarbar diye değiştirdim. Click olayını kullanarak xtrBarbar bastığımda webbrowser4 bağlandı.
        }

        private void xtrKabus_Click(object sender, EventArgs e)
        {
            webBrowser5.Navigate("https://www.youtube.com/watch?v=-KKOn7XkL4o&t=3s"); //xtrapage9 nın adını xtrKabus diye değiştirdim. Click olayını kullanarak xtrKabus bastığımda webbrowser5 bağlandı.
        }

        private void xtrTroll_Click(object sender, EventArgs e)
        {
            webBrowser6.Navigate("https://www.youtube.com/watch?v=rn4vcFXhGX0");//xtrapage10 nın adını xtrTroll diye değiştirdim. Click olayını kullanarak xtrTroll bastığımda webbrowser6 bağlandı.
        }

        private void xtrSessiz_Click(object sender, EventArgs e)
        {
            webBrowser7.Navigate("https://www.youtube.com/watch?v=eEFd94F7pcE"); //xtrapage11 nın adını xtrSessiz diye değiştirdim. Click olayını kullanarak xtrSessiz bastığımda webbrowser7 bağlandı.
        }

        private void xtrWonder_Click(object sender, EventArgs e)
        {
            webBrowser8.Navigate("https://www.youtube.com/watch?v=vNUcjqP11OY"); //xtrapage12 nın adını xtrWonder diye değiştirdim. Click olayını kullanarak xtrWonder bastığımda webbrowser8 bağlandı.
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            webBrowser9.Navigate("http://www.beyazperde.com/haberler/filmler/");
        }
    }
}
