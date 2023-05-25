using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EBook
{
    public partial class Training : Form
    {

        public Training()
        {
            InitializeComponent();
            this.CenterToScreen();
           
        }

        private void Training_Load(object sender, EventArgs e)
        {
            
            MaximizeBox = false;
        }

        private void Training_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            MessageBox.Show("Программа созданна студентом группы И-42, Андреевым Андреем Игоревичем", "О программе");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"Help.docx");
        }
    }
}
