using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontendDesktop
{
    public partial class MainPanel : Form
    {
        public static MainPanel Current = new MainPanel();

        Timer tm;
        Bitmap bmp;
        Graphics g;

        private MainPanel()
        {
            InitializeComponent();
            tm = new Timer();
            tm.Interval = 25;
            tm.Tick += Tm_Tick;
        }

        private void Tm_Tick(object? sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            g.Clear(Color.Magenta);
            g.FillPie(Brushes.White, x - 50, y - 50, 100, 100, 0, 8 * count);
            g.FillPie(Brushes.Magenta, x - 25, y - 25, 50, 50, 0, 8 * count);
            count++;
            pb.Refresh();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pb.Width, pb.Height);
            g = Graphics.FromImage(bmp);
            pb.Image = bmp;
        }

        int count = -1;
        public void StartLoading()
        {
            if (count == -1)
            {
                count = 0;
                tm.Start();
            }
        }

        public void StopLoading()
        {
            count = -1;
            tm.Stop();
            g.Clear(Color.Magenta);
            pb.Refresh();
        }

        public void DrawRectangle()
        {
            g.FillRectangle(Brushes.Blue, 50, 50, 300, 200);
            pb.Refresh();
        }
    }
}
