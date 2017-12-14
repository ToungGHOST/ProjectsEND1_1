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
    public partial class MANUFORM : Form
    {
        

        public MANUFORM()
        {
            InitializeComponent();
            comboBox1.Items.Add("08");//{ ข้อมูลตัวเลขใน combobox
            comboBox1.Items.Add("09");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox1.Items.Add("13");
            comboBox1.Items.Add("14");
            comboBox1.Items.Add("15");
            comboBox1.Items.Add("16");
            comboBox1.Items.Add("17");
            comboBox1.Items.Add("18");
            comboBox1.Items.Add("19");
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("21");
            comboBox1.Items.Add("22");
            comboBox1.Items.Add("23");
            comboBox2.Items.Add("00");
            comboBox2.Items.Add("30");
            comboBox3.Items.Add("01");
            comboBox3.Items.Add("02");
            comboBox3.Items.Add("03");
            comboBox3.Items.Add("04");
            comboBox3.Items.Add("05");
            comboBox3.Items.Add("06");
            comboBox3.Items.Add("07");
            comboBox3.Items.Add("08");
            comboBox3.Items.Add("09");
            comboBox3.Items.Add("10");//}
            GG();
        }              
        public Form2 f2 = new Form2();
        public void N()//สร้างตัวเก็บและอ่านไพล์
        {
            
            string name = textBox1.Text.ToUpper();//ใช้ในการเก็บชื่อ
            string Ber = textBox2.Text.ToUpper();//เก็บเบอร์
            string fb = textBox3.Text.ToUpper();//เก็บFB
            string jumnun = comboBox3.Text.ToUpper();//เก็บจำนวน
            string timeH = comboBox1.Text.ToUpper();//เก็บเวลา ชม.
            string timeM = comboBox2.Text.ToUpper();//เก็บเวลา นาที
            string date = dateTimePicker1.Text.ToUpper();// เก็บวันที่          
            string name_data = File.ReadAllText("data/NAME_1.txt");//เก็บตัวอ่านไพล์

            string name_save =name + "|"+name_data;//เก็บชื่อ
            string SAVE ="ชื่อ:"  + name +"|เบอร์:"+" |FB:"  +fb+"|จำนวน: "+jumnun+" |เวลา:"+timeH+":"+timeM+"|วัน:"  +date+"|||||||||";//ใช้เก็บข้อมูล
            File.WriteAllText("data/NAME_1.txt", name_save);//เก็บข้อมูลชื่อ
            File.WriteAllText("data/save_data.txt",SAVE);//เก็บรวบรวมข้อมูล
        }
        public void F(string Menu, string Bath)//สร้างตัวเก็บ รายการอาหาร
        {
            string[] F = { Menu, Bath };//เก็บรายการอาหาร
            var L = new ListViewItem(F);//
            listView1.Items.Add(L);//เอารายการมาแสดง
            var G = new ListViewItem(F);
            f2.listView2.Items.Add(G);

        }
        private void button40_Click(object sender, EventArgs e)
        {
            F("พิชซ่า", "150");//{ รายการอาหาร
        }

        private void button38_Click(object sender, EventArgs e)
        {
            F("สตูว์หมู", "150");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            F("ต้มยำกุ้ง", "200");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F("ต้มยำขาไก่", "150");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            F("ข้าวผัด", "100");
        }
    

        private void button32_Click(object sender, EventArgs e)
        {
            F("ผัดไท", "90");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            F("ข้าวเหนียวมะม่วง", "90");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            F("เสต็กเนื้อ", "150");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            F("เสต็กหมู", "120");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            F("เสต็กไก่", "100");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            F("เสต็กปลา", "80");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            F("น้ำเปล่า(300 มล.)", "50");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            F("โค้ก", "50");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            F("แป๊ปซี่", "50");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            F("สไปรท์", "50");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            F("น้ำแดง", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            F("น้ำส้ม", "50");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            F("เบียร์ช้าง", "160");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            F("เบียร์สิงห์", "180");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           F ("เบียร์ไฮเนเก้น", "200");//}
        }
        double P;
        public string[] K()//คำนวณรายการอาหาร
        {
            P = 0;
            string[] G = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                P += double.Parse(listView1.Items[i].SubItems[1].Text);
                G[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            lb_1.Text = P.ToString();
            return G;

        }
        public string[] M()//คำนวณรายการอาหาร
        {
            string[] G = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                G[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return G;
        }

       
        public void HA()//ตัวแสดงผล
        {
            string[] J = K();
            string[] b = M();
           
            
            f2.label18.Text = "วันที่:"+ dateTimePicker1.Text;//label จากฟรอม2 แสดง ค่าของdateTimePicker
            f2.label19.Text = "ชื่อ:" + textBox1.Text;//label จากฟรอม2 แสดงตัวอักษรของtextbox
            f2.label20.Text = "จำนวน:" + comboBox3.Text;//label จากฟรอม2 แสดงตัวcombobox
            f2.label21.Text="เวลา:" + comboBox1.Text + "นาฬิกา" + comboBox2.Text + "นาที ";//
            f2.label22.Text = "รวมราคา :" + lb_1.Text;//label จากฟรอม2 แสดงค่า ในlabelของฟรอม1
        }
        
        
        private void button8_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)//ถ้า ไอเทมเป็น0ให้แสดง กรุณาสั่งอาหาร
            {
                MessageBox.Show("กรุณาสั่งอาหาร", "Error");
            }
            else
            {
                if (listView1.Items.Count > 0)//ถ้าไอเทมมากกว่า0ให้คำนวณราคาและเปิดหน้าฟรอมใหม่
                HA();
                this.Hide();
                f2.Show();
                
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //เคลียร์ไอเทมและราคา                     
            lb_1.Text = "";
            f2.listView2.Items.Clear();
        }
        public void GG ()
        {
            string[] room_m = File.ReadAllLines("data/room_S.txt");//ใช้roomในการอ่านไพล์ txt
            Button[] R = new Button[24]//เก็บ button ด้วยอาเลย์R
               { r1, r2, r3, r4, r5, r6,
              r7, r8, r9, r10, r11,r12,
              r13, r14, r15, r16, r17, r18,
              v1,v2,v3,v4,v5,v6

               };
            for (int i = 0; i < R.Length; i++)
            {
               
                if (room_m[i] == "1")
                {
                    R[i].BackColor = Color.Red;
                   
                    R[i].Enabled = false;
                }//ถ้าเป็นสีแดงให้ room เปลี่ยนเป็นสีแดงและล็อคปุ่ม
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GG();
            tabcontrol1.Controls.Remove(Room);//ซ่อนแทบ
            tabcontrol1.Controls.Remove(MENUFOOD);
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox3.Text == ""|| comboBox3.Text == "00")//ถ้าช่องที่กำหนดเป็นช่องว่างให้แสดง กรุณากรอกข้อมูลให้ครบถ้วน
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Error");
            }
          
            else 
            {//การเช็คชื่อซ้ำ

                string NamE_S = textBox1.Text.ToUpper();
                    int NaMe = 0;
                string[] name_data1 = File.ReadAllText("data/NAME_1.txt").Split('|');//เช็คโดยการอ่านไฟล์
                for (int i = 0; i < name_data1.Length; i++) 
                {
                   
                    if (NamE_S == name_data1[i])
                    {
                        NaMe = 1;
                        break;
                    }//ถ้าชื่อมีมากกว่า1ให้หยุด
                    else
                    {
                        NaMe = 0;
                        tabcontrol1.Controls.Remove(Room);
                        tabcontrol1.TabPages.Insert(1, Room);
                        tabcontrol1.SelectedTab = Room;
                        N();
                    }//ถ้าชื่อมีชื่อเดียวให้เปิดแทบต่อไป
                }
                if (NaMe == 1) //ถ้าชื่อมีมากกว่า1ให้แสดง
                {
                    MessageBox.Show("ชื่อนี้ใช้ลงทะเบียนแล้ว!", "Error!");
                }
            }
        }

        private void lb_1_Click(object sender, EventArgs e)
        {                       
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] a = new string[24];
            Button[] R = new Button[24]//การเลือกห้อง
            { r1, r2, r3, r4, r5, r6,
              r7, r8, r9, r10, r11,r12,
              r13, r14, r15, r16, r17, r18,
              v1,v2,v3,v4,v5,v6 }; 
            
            for(int i = 0; i <= R.Length - 1; i++)
            {
                 
                if (R[i].BackColor==Color.Red)//ถ้าปุ่ม เป็นสีแดงให้เขียนเลข1ลงในไฟล์txt และเปิดแทบต่อไป
                {
                    a[i]="1" ;
                  
                tabcontrol1.Controls.Remove(MENUFOOD);
                tabcontrol1.TabPages.Insert(2, MENUFOOD);
                tabcontrol1.SelectedTab = MENUFOOD;
                }
                if (R[i].BackColor == Color.Gainsboro)//ถ้าปุ่มเป็นสีเทาจะไม่ทำการใดๆ
                {
                    a[i] = "0";                   
                }
                                                              
            }
           
            File.WriteAllLines("data/room_S.txt",a);//เขียนลงในไฟล์

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabcontrol1.Controls.Remove(MAINMENU);//เปิดแทบต่อไป
            tabcontrol1.TabPages.Insert(0,MAINMENU);          
            tabcontrol1.SelectedTab = MAINMENU;
            
        }

        private void v1_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้อง VIP1";//{ //เป็นlabel ที่จะแสดงชื่อห้องเมือกด
            f2.label1.Text = "คุณได้จอง:ห้อง VIP1";//เป็นlabel ที่จะแสดงชื่อห้องเมือกดและไปแสดงในฟรอมถัดไป
            this.v1.BackColor = this.v1.BackColor == Color.Red ? Color.Gainsboro : Color.Red;//เปลี่ยนสีButton
        }

        private void v2_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้อง VIP2";
            f2.label1.Text = "คุณได้จอง:ห้อง VIP2";
            this.v2.BackColor = this.v2.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void v3_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้อง VIP3";
            f2.label1.Text = "คุณได้จอง:ห้อง VIP3";
            this.v3.BackColor = this.v3.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void v4_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้อง VIP4";
            f2.label1.Text = "คุณได้จอง:ห้อง VIP4";
            this.v4.BackColor = this.v4.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void v5_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้อง VIP5";
            f2.label1.Text = "คุณได้จอง:ห้อง VIP5";
            this.v5.BackColor = this.v5.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void v6_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้อง VIP6";
            f2.label1.Text = "คุณได้จอง:ห้อง VIP6";
            this.v6.BackColor = this.v6.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r1_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 1";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 1";
            this.r1.BackColor = this.r1.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r2_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 2";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 2";

            this.r2.BackColor = this.r2.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r3_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 3";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 3";
            this.r3.BackColor = this.r3.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r4_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 4";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 4";
            this.r4.BackColor = this.r4.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r5_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 5";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 5";
            this.r5.BackColor = this.r5.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r6_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 6";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 6";

            this.r6.BackColor = this.r6.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r7_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 7";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 7";
            this.r7.BackColor = this.r7.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r8_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 8";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 8";

            this.r8.BackColor = this.r8.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r9_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 9";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 9";
            this.r9.BackColor = this.r9.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r10_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 10";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 10";
            this.r10.BackColor = this.r10.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r11_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 11";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 11";
            this.r11.BackColor = this.r11.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r12_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 12";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 12";
            this.r12.BackColor = this.r12.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r13_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 13";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 13";

            this.r13.BackColor = this.r13.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r14_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 14";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 14";
            this.r14.BackColor = this.r14.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r15_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 15";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 15";

            this.r15.BackColor = this.r15.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r16_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 16";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 16";
            this.r16.BackColor = this.r16.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r17_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 17";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 17";
            this.r17.BackColor = this.r17.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void r18_Click(object sender, EventArgs e)
        {
            label17.Text = "ห้องอาหารที่ 18";
            f2.label1.Text = "คุณได้จอง:ห้องอาหารที่ 18";//}
            this.r18.BackColor = this.r18.BackColor == Color.Red ? Color.Gainsboro : Color.Red;
        }

        private void MAINMENU_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();//ปิดโปรแกรม
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            ADMIN am = new ADMIN();//เปิดฟรอมต่อไป
            am.Show();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabcontrol1.Controls.Remove(MAINMENU);//เปิดแทบแรก
            tabcontrol1.TabPages.Insert(0, MAINMENU);
            tabcontrol1.SelectedTab = MAINMENU;
        }
    }
}
