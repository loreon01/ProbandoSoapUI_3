using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbandoSoapUI_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoapUI.TipoCambio client = new SoapUI.TipoCambio();
            var respuesta = client.TipoCambioDia();
            label2.Text = respuesta.CambioDolar.First().fecha;
            label3.Text = respuesta.CambioDolar.First().referencia.ToString();

      
        }
    }
}
