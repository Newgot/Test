using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        Form1 form1 = new Form1();
        public Form2()
        { 
            InitializeComponent();
            string connentor = "server=localhost;user=root;database=test;password=1234";
            conn = new MySqlConnection(connentor);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string data = $"{comboBox4.Text}-{comboBox3.Text}-{comboBox2.Text}";
            conn.Open();
            // Вставляем данные в table1
            string request = $"INSERT INTO table1 (Fname, Sname, DOB, BPL) VALUES ('{tbFname.Text}', '{tbSname.Text}', '{data}', '{tbPBL.Text}' );";
            MySqlCommand command = new MySqlCommand(request, conn);
            command.ExecuteNonQuery();
            // Ищем нужный нам ID
            request = "SELECT ID FROM table1 ORDER BY id DESC LIMIT 1";
            MySqlCommand command1 = new MySqlCommand(request, conn);
            command1.ExecuteNonQuery();
            // Вставляем Авто в table2
            string id = command1.ExecuteScalar().ToString();
            request = $"UPDATE table2 SET id={id}, Auto='{comboBox1.Text}' WHERE id = {id} "; // Id, меняющийся сам на себя, используется в триггере MySQL
            MySqlCommand command2 = new MySqlCommand(request, conn);
            command1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sussesfull!");
            this.Close();
        }
    }
}
