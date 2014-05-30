using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSI
{
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }

        private void Persona_Load(object sender, EventArgs e)
        {

            pbLogo.Top = this.Size.Height - 110;
            pbLogo.Left = this.Size.Width - 90;

            lbLogo.Top = this.Size.Height - 60;
            lbLogo.Left = this.Size.Width - 210;
        }

     
    }
}
