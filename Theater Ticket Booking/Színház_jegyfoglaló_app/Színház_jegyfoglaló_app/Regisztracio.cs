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
    public partial class Regisztracio : Form
    {
        public Regisztracio()
        {
            InitializeComponent();
        }

        private void Regisztracio_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "A megadott jelszó: " + textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            SQLiteCommand cmd = new SQLiteCommand("insert into belepes(felhnev, jelszo) values('" + textBox1.Text + "', '" + textBox2.Text + "')", db.getConnection());
            cmd.ExecuteNonQuery();
            db.closeConnection();
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("A regisztráció sikeres volt");
        }
    }
}
