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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.ToUpper() == "ADMIN")//ถ้ากรอกคำว่าADMINจะล้างข้อมูลห้องและชื่อออก
            {
                string roomData = File.ReadAllText("data/room_reset.txt");//อ่านไฟล์ชื่อจาก roomdata 
                string nameData = File.ReadAllText("data/NAME_2.txt");//อ่านไฟล์ชื่อจาก namedata
                File.WriteAllText("data/room_S.txt", roomData);//เขียนแก้ในไฟล์ใหม่ ให้เหมือนroomdata 
                File.WriteAllText("data/NAME_1.txt", nameData);// เขียนแก้ในไฟล์ใหม่ ให้เหมือนnamedata

                MessageBox.Show("ล้างข้อมูลสำเร็จ", "Success");//แล้วแสดงคำว่า"ล้างข้อมูลสำเร็จ"
                this.Hide();
            }
            else
            {
                MessageBox.Show("Can't reset!", "Error");//ถ้าไม่ตรงคำให้แสดงCan't reset!
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();//ปิดโปรแกรม
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
