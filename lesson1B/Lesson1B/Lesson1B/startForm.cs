using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1B
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

     

        private void ClickMeButton_MouseEnter(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hi!"; 
        }

        private void ClickMeButton_MouseLeave(object sender, EventArgs e)
        {
            MessageLabel.Text = "GoodBye!";
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hello World!";
        }

        private void ClickMeButton_MouseHover(object sender, EventArgs e)
        {
            MessageLabel.Text = "Yo!";
        }

        private void MessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
