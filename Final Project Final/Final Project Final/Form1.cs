using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Quit button that closes page
        {
            Application.Exit();
        }
        Form2 secondform = new Form2();
        private void Start_Click(object sender, EventArgs e) //Start button shows game form and hides menu form
        {
            secondform.Show();
            this.Hide();
        }
        Form4 fourthform = new Form4();
        private void Multiplayer_Click(object sender, EventArgs e) //Multiplayer button shows multiplayer game mode form and hides menu form
        {
            fourthform.Show();
            this.Hide();
        }
        Form3 thirdform = new Form3();
        private void OneHandedMode_Click(object sender, EventArgs e) //One-handed mode button shows one-handed game mode form and hides menu form
        {
            thirdform.Show();
            this.Hide();
        }
    }
}
