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
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            string connentor = "server=localhost;user=root;database=test;password=1234";
            conn = new MySqlConnection(connentor);
            LoadFullTable(1);
            LoadFullTable(2);
            LoadFullTable(3);
        }
        //Загрузка всей таблицы
        public void LoadFullTable(byte id)
        {
            conn.Open();
            string table;
            if (id == 1) table = $"SELECT * FROM table1";
            else if (id == 2) table = $"SELECT * FROM table2";
            else table = $"SELECT * FROM table3";
            MySqlCommand command = new MySqlCommand(table, conn);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                if (id == 1)
                {
                    string temp = reader[3].ToString();
                    temp = temp.Replace(" 0:00:00", "");
                    data[data.Count - 1][3] = temp;
                }
                else data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            conn.Close();
            switch (id)
            {
                case 1:
                    dataGridView1.Rows.Clear();
                    foreach (string[] elem in data)
                    {
                        dataGridView1.Rows.Add(elem);
                    }
                    break;
                case 2:
                    dataGridView2.Rows.Clear();
                    foreach (string[] elem in data)
                    {
                        dataGridView2.Rows.Add(elem);
                    }
                    break;
                case 3:
                    dataGridView3.Rows.Clear();
                    foreach (string[] elem in data)
                    {
                        dataGridView3.Rows.Add(elem);
                    }
                    break;
            }
        }
        //Обращение в БД
        private void ExequteRequest()
        {

        }
        //Дебаг поискового запроса по INT
        private int Deb (string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch
            {
                return 99999;
            }
        }

        // Вывод таблицы в DataGreed 
        private new void Load(string text, byte id)
        {
            if (text != "")
            {
                conn.Open();
                string table;
                if (id == 1) table = $"SELECT * FROM table1 WHERE id = {Deb(text)} OR Fname = '{text}' OR Sname = '{text}' OR BPL = '{text}'";
                else if (id == 2) table = $"SELECT * FROM table2 WHERE id = {Deb(text)} OR Fname = '{text}' OR Sname = '{text}' OR Auto = '{text}'";
                else table = $"SELECT * FROM table3 WHERE id = {Deb(text)} OR Fname = '{text}' OR Sname = '{text}' OR Coins = {Deb(text)} ";
                MySqlCommand command = new MySqlCommand(table, conn);
                MySqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    if (id == 1)
                    {
                        string temp = reader[3].ToString();
                        temp = temp.Replace(" 0:00:00", "");
                        data[data.Count - 1][3] = temp;
                    }
                    else data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                }
                reader.Close();
                conn.Close();
                switch (id)
                {
                    case 1:
                        dataGridView1.Rows.Clear();
                        foreach (string[] elem in data)
                        {
                            dataGridView1.Rows.Add(elem);
                        }
                        break;
                    case 2:
                        dataGridView2.Rows.Clear();
                        foreach (string[] elem in data)
                        {
                            dataGridView2.Rows.Add(elem);
                        }
                        break;
                    case 3:
                        dataGridView3.Rows.Clear();
                        foreach (string[] elem in data)
                        {
                            dataGridView3.Rows.Add(elem);
                        }
                        break;
                }
            }
        }
      

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Поиск
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (str != "")
            {
                Load(str, 1);
                Load(str, 2);
                Load(str, 3);
            }
            else
            {
                LoadFullTable(1);
                LoadFullTable(2);
                LoadFullTable(3);
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LoadFullTable(1);
            LoadFullTable(2);
            LoadFullTable(3);
        }
        // Удаление
        private void buttonDel_Click(object sender, EventArgs e)
        {
            int y = dataGridView1.CurrentCell.RowIndex;  // Номер ячейки
            string id = dataGridView1[0, y].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                conn.Open();
                string request = $"DELETE FROM table1 WHERE id={id}";
                MySqlCommand command = new MySqlCommand(request, conn);
                command.ExecuteNonQuery();
                conn.Close();
                LoadFullTable(1);
                LoadFullTable(2);
                LoadFullTable(3);
            }
        }
        // Изменение
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int y = dataGridView1.CurrentCell.RowIndex;  // Номер ячейки
            
            Form3 form3 = new Form3();
            form3.labelID.Text = dataGridView1[0, y].Value.ToString();
            form3.ShowDialog();

        }

    }
}
