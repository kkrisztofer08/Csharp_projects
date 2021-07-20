using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Színház_jegyfoglaló_app
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        SQLiteDataAdapter sda;
        SQLiteCommand cmd = new SQLiteCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette: Kőrösi Krisztofer Roland\nVerziószám: 1.0\nKiadás dátuma: 2020.11.17");
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regisztracio r = new Regisztracio();
            r.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "rendszergazda" && textBox2.Text == "rendszergazda1" && radioButton1.Checked)
            {
                this.Hide();
                Rendszergazda admin = new Rendszergazda();
                admin.Show();
            }
            else if (radioButton2.Checked)
            {
                DB db = new DB();
                cmd = new SQLiteCommand("select count(*) from belepes where felhnev='" + textBox1.Text + "' and jelszo='" + textBox2.Text + "'", db.getConnection());
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    User u = new User();
                    u.Show();
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév és/vagy jelszó!\nKérjük próbáld újra!");
                }
            }
        }
    }
}
