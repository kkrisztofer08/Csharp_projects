using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Startup : Form
    {
        Random random = new Random();

        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int randomIncrement = random.Next(1, 10);
            

            if (progressBar1.Value + randomIncrement >= progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
                timer1.Stop();

                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                progressBar1.Value += randomIncrement;
                label1.Text = "Loading... " + progressBar1.Value.ToString() + "%";
            }
        }
    }
}
