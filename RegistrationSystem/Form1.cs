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

            foreach (People people in peoples)
            {
                if (people.Name == txtName.Text)
                {
                    index = peoples.IndexOf(people);
                }
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.");
                txtName.Focus();
                return;
            }

            if (txtPhoneNumber.Text == "(  )      -")
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

            People p = new People();
            p.Name = txtName.Text;
            p.BirthDate = txtDate.Text;
            p.MaritalStatus = comboMS.SelectedItem.ToString();
            p.PhoneNumber = txtPhoneNumber.Text;
            p.OwnHouse = checkHome.Checked;
            p.Vehicle = checkVehicle.Checked;
            p.Gender = gender;

            if (index < 0)
            {
                peoples.Add(p);
            }
            else
            {
                peoples[index] = p;
            }
            
            btnClear_Click(btnClear, EventArgs.Empty);

            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = list.SelectedIndex;
            peoples.RemoveAt(i);

            List();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDate.Text = "";
            comboMS.SelectedIndex = 0;
            txtPhoneNumber.Text = "";
            checkHome.Checked = false;
            checkVehicle.Checked = false;
            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;

            txtName.Focus();
        }

        private void List()
        {
            list.Items.Clear();

            foreach (People p in peoples)
            {
                list.Items.Add(p.Name);
            }
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            People p = peoples[list.SelectedIndex];

            txtName.Text = p.Name;
            txtDate.Text = p.BirthDate;
            comboMS.SelectedItem = p.MaritalStatus;
            txtPhoneNumber.Text = p.PhoneNumber;
            checkHome.Checked = p.OwnHouse;
            checkVehicle.Checked = p.Vehicle;

            switch (p.Gender)
            {
                case 'M':
                    radioM.Checked = true;
                    break;

                case 'F':
                    radioF.Checked = true; 
                    break;

                default:
                    radioO.Checked = true;
                    break;
            }
        }
    }
}
