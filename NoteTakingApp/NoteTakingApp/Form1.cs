using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp {
    public partial class Form1 : Form {

        DataTable table;

        public Form1() {
            InitializeComponent();
        }

        // This code runs when app start, or form loads
        private void Form1_Load(object sender, EventArgs e) {
            table=new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            dataGridView1.DataSource=table;
            dataGridView1.Columns["Message"].Visible=false;
            dataGridView1.Columns["Title"].Width=287;
        }

        // CLear the field when the button 'New' is pressed
        private void BtnNew_Click(object sender, EventArgs e) {
            txtTitle.Clear();
            txtMessage.Clear();
        }
        // Add row to table and clear fields when 'Save' button is pressed
        private void BtnSave_Click(object sender, EventArgs e) {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }

        // Get the selected item and plece it in the input fields
        private void BtnRead_Click(object sender, EventArgs e) {
            int index =dataGridView1.CurrentCell.RowIndex;

            // If index greater or equal to 0 it means a row is selected
            if (index>-1) {
                // Get the selected row index and item 0 is title and item 1 is message
                txtTitle.Text=table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text=table.Rows[index].ItemArray[1].ToString();
            }

        }

        // Delete the selected row
        private void BtnDelete_Click(object sender, EventArgs e) {
            int index = -1;
            try {
                index = dataGridView1.CurrentCell.RowIndex;
            }
            catch {
            }

            // If index greater or equal to 0 it means a row is selected
            if (index>-1) {
                table.Rows[index].Delete();
            }
            else {
                Console.WriteLine("Select a Row");
            }
        }
    }
}
