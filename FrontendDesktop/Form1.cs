using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrontendDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MainPanel.Current.Show();
        }

        // picture box solo
        private void pb_solo_MouseClick(object sender, MouseEventArgs e)
        {
            pb_solo.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\solopress2.jpg");

            MainPanel.Current.StopLoading();
        }
        private void pb_solo_MouseEnter(object sender, EventArgs e)
        {
            pb_solo.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\soloup2.jpg");

            MainPanel.Current.StartLoading();
        }

        private void pb_solo_MouseLeave(object sender, EventArgs e)
        {
            pb_solo.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\solofix2.jpg");

            MainPanel.Current.StopLoading();
        }

        private void tm_solo_Tick(object sender, EventArgs e)
        {

        }

        // picture box duo
        private void pb_duo_MouseClick(object sender, MouseEventArgs e)
        {
            pb_duo.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\duopress.jpg");

            MainPanel.Current.StopLoading();
        }

        private void pb_duo_MouseEnter(object sender, EventArgs e)
        {
            pb_duo.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\duoup.jpg");

            MainPanel.Current.StartLoading();
        }

        private void pb_duo_MouseLeave(object sender, EventArgs e)
        {
            pb_duo.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\duofix.jpg");

            MainPanel.Current.StopLoading();
        }

        // picture box placar
        private void pb_placar_MouseClick(object sender, MouseEventArgs e)
        {
            pb_placar.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\placarpress.jpg");

            MainPanel.Current.StopLoading();

        }

        private void pb_placar_MouseEnter(object sender, EventArgs e)
        {
            pb_placar.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\placarup.jpg");

            MainPanel.Current.StartLoading();
        }

        private void pb_placar_MouseLeave(object sender, EventArgs e)
        {
            pb_placar.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\placarfix.jpg");

            MainPanel.Current.StopLoading();
        }

        //picture box cores
        private void pb_cores_MouseClick(object sender, MouseEventArgs e)
        {
            pb_cores.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\corespress.jpg");

            MainPanel.Current.StopLoading();

        }

        private void pb_cores_MouseEnter(object sender, EventArgs e)
        {
            pb_cores.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\coresup.jpg");

            MainPanel.Current.StartLoading();
        }

        private void pb_cores_MouseLeave(object sender, EventArgs e)
        {
            pb_cores.Image = Image.FromFile(@"D:\Documentos\SENAI\Desenvolvimento de Sistemas\ProjetoPong-Backup\FrontendDesktop\img\coresfix.jpg");

            MainPanel.Current.StopLoading();
        }

        private void pb_solo_Click(object sender, EventArgs e)
        {

        }
    }
}