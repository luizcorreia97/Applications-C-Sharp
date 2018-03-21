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
    public partial class Componentes : Form
    {
        public Componentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("C#");
            cmbMateria.Items.Add("JAVA");
            cmbMateria.Items.Add("PHP");
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            Professor prof = new Professor();
            cmbProfessor.DataSource = prof.Buscar().Tables[0];
            cmbProfessor.ValueMember = "idprofessor";
            cmbProfessor.DisplayMember = "nome";

        }

        private void btnSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cód: " + cmbProfessor.SelectedValue.ToString() + " Nome: " + cmbProfessor.Text);
            //cmbBuscado.SelectedValue.ToString();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbMateria.Items.Count; i++)
            {
                cmbMateria.Items.RemoveAt(i);
            }

            for (int i = 0; i < cmbProfessor.Items.Count; i++)
            {
                cmbProfessor.Items.RemoveAt(i);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chkJava.Checked == true) {
                MessageBox.Show("Java Selecionado");
            }
            if (chkSharp.Checked == true)
            {
                MessageBox.Show("Sharp Selecionado");
            }
            if (chkPHP.Checked == true)
            {
                MessageBox.Show("PHP Selecionado");
            }
            else {
                MessageBox.Show("Nenhum Selecionado");
            }
        }

        private void btnMarcaTodos_Click(object sender, EventArgs e)
        {
            chkJava.Checked = false;
            chkSharp.Checked = true;
            chkPHP.Checked = false;
        }
    }
}
