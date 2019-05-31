using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursed
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();

            Form2 PF = new Form2();
            if (PF.ShowDialog() == DialogResult.Cancel)
                Application.Exit();
        }

        public string dio;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Cursed\Cursed\Database1.mdf;Integrated Security=True";

        public void jojo(string dio)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            string stand = dio;

            SqlCommand command = new SqlCommand(stand, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[10]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
            }
            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string dio = "SELECT * FROM Abiturient ORDER BY Id";
            jojo(dio);


        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Abiturient] (Id, Фамилия,Имя,Отчество,Год_рождения,первый,второй,третий,Аттестат)" +
                "VALUES (@Id, @Фамилия,@Имя,@Отчество,@Год_рождения,@первый,@второй,@третий,@Аттестат)", sqlConnection);

                command.Parameters.AddWithValue("Id", textBox1.Text);
                command.Parameters.AddWithValue("Фамилия", textBox2.Text);
                command.Parameters.AddWithValue("Имя", textBox3.Text);
                command.Parameters.AddWithValue("Отчество", textBox4.Text);
                command.Parameters.AddWithValue("Год_рождения", textBox5.Text);
                command.Parameters.AddWithValue("первый", textBox6.Text);
                command.Parameters.AddWithValue("второй", textBox7.Text);
                command.Parameters.AddWithValue("третий", textBox8.Text);
                command.Parameters.AddWithValue("Аттестат", textBox9.Text);

                await sqlConnection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Заполните ВСЕ поля");
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            SqlDataReader sqlReader = null;

            dio = "SELECT Id, Фамилия,Имя,Отчество,Год_рождения,первый,второй,третий,Аттестат FROM[Abiturient]";

            SqlCommand command = new SqlCommand(dio, sqlConnection);
            try
            {
                jojo(dio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);

                    if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                    !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                    !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                    !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                    !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                    !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                    !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                    !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                    !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text))
                    {
                        
                        SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Фамилия]=@Фамилия" +
                        ",[Имя]= @Имя,[Отчество]=@Отчество,[Год_рождения]=@Год_рождения,[первый]=@первый,[второй]=@второй," +
                        "[третий]=@третий,[Аттестат]=@Аттестат WHERE [Id]= @Id", sqlConnection);

                    command.Parameters.AddWithValue("Id", textBox1.Text);
                    command.Parameters.AddWithValue("Фамилия", textBox2.Text);
                    command.Parameters.AddWithValue("Имя", textBox3.Text);
                    command.Parameters.AddWithValue("Отчество", textBox4.Text);
                    command.Parameters.AddWithValue("Год_рождения", textBox5.Text);
                    command.Parameters.AddWithValue("первый", textBox6.Text);
                    command.Parameters.AddWithValue("второй", textBox7.Text);
                    command.Parameters.AddWithValue("третий", textBox8.Text);
                    command.Parameters.AddWithValue("Аттестат", textBox9.Text);

                    await sqlConnection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
                else
                {
                    MessageBox.Show("Заполните ВСЕ поля");
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Abiturient] WHERE [Фамилия]=@Фамилия", sqlConnection);

                command.Parameters.AddWithValue("Фамилия", textBox10.Text);
                await sqlConnection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Заполните поле");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox11.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Abiturient] WHERE [Аттестат]<@Аттестат", sqlConnection);
                
                command.Parameters.AddWithValue("Аттестат", textBox11.Text);
                await sqlConnection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Заполните поле");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
