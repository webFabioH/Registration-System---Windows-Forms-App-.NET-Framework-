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
    }
}
