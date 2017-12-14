using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects_END1_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new MANUFORM();//แสดงฟรอมเมนูและซ่อนฟรอม
            f1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {                          
              
            ADMIN am = new ADMIN();//แสดงหน้าแอดมิน
            am.Show();           
           // this.Hide();       
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();//ปิดโปรแกรม
        }
    }
}
