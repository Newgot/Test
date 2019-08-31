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
    public partial class Form3 : Form
    {
        MySqlConnection conn;
        public Form3()
        {
            InitializeComponent();
            string connentor = "server=localhost;user=root;database=test;password=1234";
            conn = new MySqlConnection(connentor);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string dob = $"{comboBox4.Text}-{comboBox3.Text}-{comboBox2.Text}";
            string request = $"UPDATE table1 SET Fname='{tbFname.Text}', Sname='{tbSname.Text}', DOB='{dob}', BPL='{tbBPL.Text}' WHERE id = {labelID.Text}";
            conn.Open();
            MySqlCommand command = new MySqlCommand(request, conn);
            command.ExecuteNonQuery();
            request = $"UPDATE table2 SET id={labelID.Text}, Auto='{comboBox1.Text}' WHERE id = {labelID.Text}"; // Id, меняющийся сам на себя, используется в триггере MySQL
            command = new MySqlCommand(request, conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Complete!");
        }
        // Инициализация
        private void Form3_Activated(object sender, EventArgs e)
        {
            string id = labelID.Text;
            string request = $"SELECT * FROM table1 WHERE id = {id}";
            conn.Open();
            MySqlCommand command = new MySqlCommand(request, conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            tbFname.Text = reader[1].ToString(); // Имя
            tbSname.Text = reader[2].ToString(); // Фамилия
            string dobStr = reader[3].ToString();
            dobStr = dobStr.Replace(" 0:00:00", ""); // Удаление часов
            string[] dob = dobStr.Split('.');  // Разбиение на массив
            comboBox4.Text = dob[2]; // Год
            comboBox3.Text = dob[1]; // Месяц
            comboBox2.Text = dob[0]; // День
            tbBPL.Text = reader[4].ToString();   // Место рождения
            reader.Close();
            request = $"SELECT Auto FROM table2 WHERE id = {id}"; //Вытягивание автомобиля из table2
            command = new MySqlCommand(request, conn);
            reader = command.ExecuteReader();
            reader.Read();
            comboBox1.Text = reader[0].ToString();
            reader.Close();
            conn.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
