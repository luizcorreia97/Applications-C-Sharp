using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormCliente : Form
    {
        Minhas_Classes.Professor prof = new Minhas_Classes.Professor();

        public FormCliente()
        {
            InitializeComponent();
        }
        public FormCliente(string _nome)
        {
            InitializeComponent();
        }
        public FormCliente(string _nome, int _idade)
        {
            InitializeComponent();
        }

        private void btnCarregaDados_Click(object sender, EventArgs e)
        {
            gridProfessor.DataSource = prof.Buscar().Tables[0];
            gridFuncionario.DataSource = prof.Buscar().Tables[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();

        }
    }
}
