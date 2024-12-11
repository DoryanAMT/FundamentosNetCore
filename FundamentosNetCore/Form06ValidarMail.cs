using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;

            if (email.Contains("@"))
            {
                //lblResultado.Text = "Esta bien";
                if (email.IndexOf("@") != 0 && email.LastIndexOf("@") != email.Length)
                {
                    if (true)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    lblResultado.Text = "El correo no debe tener un @ ni al inicio ni al final";
                }

            }
            else
            {
                lblResultado.Text = "El correo debe contener un @";
            }
        }
    }
}
