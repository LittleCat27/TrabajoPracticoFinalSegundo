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
    public partial class RecursosDisplay : UserControl
    {
        public RecursosDisplay()
        {
            InitializeComponent();
        }

        public void LoadRecursos(int tamaTotal, int alturaTotal) 
        {
            this.Width = tamaTotal;
            this.Height = alturaTotal;
            
            this.flowLayoutPanel1.Height = alturaTotal;
            this.flowLayoutPanel1.Width = (tamaTotal / 3);

            this.flowLayoutPanel1.Location = new Point(tamaTotal/2,0);


            this.flowLayoutPanel2.Parent = this.flowLayoutPanel1;
            this.lbl_Tesoro.Parent = this.flowLayoutPanel2;
            this.lbl_Maderas.Parent = this.flowLayoutPanel2;
            this.lbl_Planos.Parent = this.flowLayoutPanel2;

            this.p_Madera.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Madera.png");
            this.p_Tesoro.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Oro.jpg");
            this.p_Planos.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Plano.png");

        }



    }
}
