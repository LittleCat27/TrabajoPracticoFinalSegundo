using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class PantallaWeb : UserControl
    {
        public PantallaWeb()
        {
            InitializeComponent();
        }

        public void WebLoad() 
        {
            pictureBox1.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\LogoEjemplo.png");
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
