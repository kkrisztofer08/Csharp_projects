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
    public partial class Rendszergazda : Form
    {
        private int osszegShakespeare = 0;
        private int osszegMoliere = 0;
        private int osszegMadach = 0;

        public Rendszergazda()
        {
            InitializeComponent();
        }

        private void Rendszergazda_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette: Kőrösi Krisztofer Roland\nProgramverzió: v1.0\nKiadás dátuma: 2020.11.20", "Információk");
        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Rendszergazda_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panel2.Hide();
            this.panel3.Hide();

           
            User u1 = new User();
            u1.panel1.Show();

            this.updateSQLShakespeare();
            this.updateSQLMoliere();
            this.updateSQLMadach();

            label9.Text = (osszegShakespeare + osszegMoliere + osszegMadach).ToString() + " Ft";
        }

 

        private void updateSQLShakespeare()
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            db.openConnection();
            string selectDB = "SELECT * FROM foglalasShakespeare";
            SQLiteCommand cmdSelect = new SQLiteCommand(selectDB, db.getConnection());
            SQLiteDataAdapter sdaSelect = new SQLiteDataAdapter(cmdSelect);
            sdaSelect.Fill(dt);
            db.closeConnection();

            List<int> bevetelShakespeare = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                bevetelShakespeare.Add(Convert.ToInt32(row[2].ToString()));
            }


            foreach (var c in bevetelShakespeare)
            {
                osszegShakespeare += c;
            }

            this.label5.Text = osszegShakespeare.ToString() + "Ft";
        }

        private void updateSQLMoliere()
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            db.openConnection();
            string selectDB = "SELECT * FROM foglalasMoliere";
            SQLiteCommand cmdSelect = new SQLiteCommand(selectDB, db.getConnection());
            SQLiteDataAdapter sdaSelect = new SQLiteDataAdapter(cmdSelect);
            sdaSelect.Fill(dt);
            db.closeConnection();

            List<int> bevetelMoliere = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                bevetelMoliere.Add(Convert.ToInt32(row[2].ToString()));
            }


            foreach (var c in bevetelMoliere)
            {
                osszegMoliere += c;
            }

            this.label6.Text = osszegMoliere.ToString() + "Ft";
        }

        private void updateSQLMadach()
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            db.openConnection();
            string selectDB = "SELECT * FROM foglalasMadach";
            SQLiteCommand cmdSelect = new SQLiteCommand(selectDB, db.getConnection());
            SQLiteDataAdapter sdaSelect = new SQLiteDataAdapter(cmdSelect);
            sdaSelect.Fill(dt);
            db.closeConnection();

            List<int> bevetelMadach = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                bevetelMadach.Add(Convert.ToInt32(row[2].ToString()));
            }


            foreach (var c in bevetelMadach)
            {
                osszegMadach += c;
            }

            this.label7.Text = osszegMadach.ToString() + "Ft";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();

            DB db = new DB();
            DataTable dt = new DataTable();
            db.openConnection();
            SQLiteCommand sqlSelect = new SQLiteCommand("SELECT *  FROM foglalasShakespeare", db.getConnection());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlSelect);
            sda.Fill(dt);
            db.closeConnection();

            foreach (DataRow row in dt.Rows)
            {
                if (((PictureBox)panel1.Controls["pictureBox" + row[3].ToString()]).Name.ToString().Substring(10) == row[3].ToString())
                {
                    ((PictureBox)panel1.Controls["pictureBox" + row[3].ToString()]).BackColor = Color.Red;
                    toolTip1.SetToolTip(((PictureBox)panel1.Controls["pictureBox" + row[3].ToString()]),
                        "Név: " + row[0].ToString() + " " + row[1].ToString() + "\nÖsszeg: " + row[2].ToString() + " Ft\nÜlőhelyszám: " + row[3].ToString());

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel1.Hide();
            panel2.Show();

            DB db = new DB();
            DataTable dt = new DataTable();
            db.openConnection();
            SQLiteCommand sqlSelect = new SQLiteCommand("SELECT *  FROM foglalasMoliere", db.getConnection());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlSelect);
            sda.Fill(dt);
            db.closeConnection();

            foreach (DataRow row in dt.Rows)
            {
                if (((PictureBox)panel2.Controls["pictureBox" + row[3].ToString()]).Name.ToString().Substring(10) == row[3].ToString())
                {
                    ((PictureBox)panel2.Controls["pictureBox" + row[3].ToString()]).BackColor = Color.Red;
                    toolTip1.SetToolTip(((PictureBox)panel2.Controls["pictureBox" + row[3].ToString()]),
                        "Név: " + row[0].ToString() + " " + row[1].ToString() + "\nÖsszeg: " + row[2].ToString() + " Ft\nÜlőhelyszám: " + row[3].ToString());

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Hide();
            panel3.Show();

            DB db = new DB();
            DataTable dt = new DataTable();
            db.openConnection();
            SQLiteCommand sqlSelect = new SQLiteCommand("SELECT *  FROM foglalasMadach", db.getConnection());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlSelect);
            sda.Fill(dt);
            db.closeConnection();

            foreach (DataRow row in dt.Rows)
            {
                if (((PictureBox)panel3.Controls["pictureBox" + row[3].ToString()]).Name.ToString().Substring(10) == row[3].ToString())
                {
                    ((PictureBox)panel3.Controls["pictureBox" + row[3].ToString()]).BackColor = Color.Red;
                    toolTip1.SetToolTip(((PictureBox)panel3.Controls["pictureBox" + row[3].ToString()]),
                        "Név: " + row[0].ToString() + " " + row[1].ToString() + "\nÖsszeg: " + row[2].ToString() + " Ft\nÜlőhelyszám: " + row[3].ToString());

                }
            }
        }

        
    }
}
