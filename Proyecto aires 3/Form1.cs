using System;
using System.Windows.Forms;

namespace Proyecto_aires_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string usuario = "admin";
        string contraseña = "acceso";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

            string user = txtusuario.Text;
            string password = txtcontraseña.Text;

            if (user.Equals(usuario))
            {
                if (password.Equals(contraseña))
                {
                    MessageBox.Show("Acceso exitoso");
                    Form2 administrador = new Form2();
                    administrador.Show();
                    this.Hide();


                }


                else
                    MessageBox.Show("La contraseña es incorrecta");

            }
            else
                MessageBox.Show("Usuario incorrecto");


        }

    }

}



