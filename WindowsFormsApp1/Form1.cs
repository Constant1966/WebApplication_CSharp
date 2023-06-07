using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntSwap_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            string prenom = textBox2.Text;
            string nom = txtNom.Text;

            temp = nom;

            txtNom.Text = prenom;
            textBox2.Text = temp;


        }

        private void txtPrenom_Click(object sender, EventArgs e)
        {

        }

        private void bntFill_DropList_Click(object sender, EventArgs e)
        {
            string sexe;

            sexe = txtFillSexe.Text;
            cbxSexe.Items.Add(new ListItem(sexe));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntFillgrid_Click(object sender, EventArgs e)
        {
            string nom, prenom, adress, status, sexe;
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            sexe = bntFillgrid.Text;
            adress = txtAdress.Text;
            status = txtStatus.Text;
            int age = Convert.ToInt32(txtAge.Text);

            txtAge.Clear();
            txtNom.Clear();
            


            try
            {
                int ID = 0;

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);

                newRow.Cells[0].Value = ID + 1;
                newRow.Cells[1].Value = nom;
                newRow.Cells[2].Value = prenom;
                newRow.Cells[3].Value = adress;
                newRow.Cells[4].Value = status;
                newRow.Cells[5].Value = age;
                //newRow.Cells[6].Value = sexe;



                dataGridView1.Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                label2.Text = "Erreur: " + ex.Message;
            }
            
        
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            string v = $"{txtNom.Text} {txtPrenom.Text} {txtAge.Text}";
            item.Text = v;

            

            listView.Items.Add(item);




















        }
    }
}
