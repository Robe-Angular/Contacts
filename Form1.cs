using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i= i + 2)
            {
                MessageBox.Show("Contact List 1.0.\nWritten by: Your Name", "About");
            }
            
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'contactDBDataSet.People' Puede moverla o quitarla según sea necesario.
            this.peopleTableAdapter.Fill(this.contactDBDataSet.People);

        }
    }
}
