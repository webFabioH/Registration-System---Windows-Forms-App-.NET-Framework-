using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrationSystem.Entities;

namespace RegistrationSystem
{
    public partial class Form1 : Form
    {
        List<People> peoples;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            peoples = new List<People>();

            comboMS.Items.Add("Casado");
            comboMS.Items.Add("Solteiro");
            comboMS.Items.Add("Viúvo");
            comboMS.Items.Add("Separado");

            comboMS.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (People p in peoples)
            {
                if (p.Name == txtName.Text)
                {
                    index = peoples.IndexOf(p);
                }
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.");
                txtName.Focus();
                return;
            }

            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Preencha o campo Telefone.");
                txtPhoneNumber.Focus();
                return;
            }

            char gender;

            if (radioM.Checked)
            {
                gender = 'M';
            }
            else if (radioF.Checked)
            {
                gender = 'F';
            }
            else
            {
                gender = 'O';
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void List()
        {
            list.Items.Clear();

            foreach (People p in peoples)
            {
                list.Items.Add(p.Name);
            }
        }
    }
}
