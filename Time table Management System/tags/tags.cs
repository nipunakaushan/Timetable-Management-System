﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Time_table_Management_System
{

    public partial class tags : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public tags()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dashboard panel main
        }


        private void label1_Click(object sender, EventArgs e)
        {
            //label home
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //form
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //picturebox panel
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel dashboard
        }










        //--------------Header icons------------------//
        private void btn_home_header(object sender, EventArgs e)
        {

        }

        private void btn_sessions_header(object sender, EventArgs e)
        {

        }

        private void btn_rooms_header(object sender, EventArgs e)
        {

        }

        private void btn_advanced_header(object sender, EventArgs e)
        {

        }

        private void btn_genarate_header(object sender, EventArgs e)
        {

        }









        //------------------Slide navbar icons....................//
        private void btn_days_nav(object sender, EventArgs e)
        {

        }

        private void btn_lectures_nav(object sender, EventArgs e)
        {

        }

        private void btn_subjects_nav(object sender, EventArgs e)
        {

        }

        private void btn_students_nav(object sender, EventArgs e)
        {

        }

        private void btn_tags_nav(object sender, EventArgs e)
        {

        }

        private void btn_locations_nav(object sender, EventArgs e)
        {

        }

        private void btn_statics_nav(object sender, EventArgs e)
        {

        }





        //------------closed,minimized,maximized,buttons---------------//

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        //--------  tag Dashboard-------//

        private void btn_addtagname(object sender, EventArgs e)
        {
            //add tag name btn
        }

        private void btn_clear(object sender, EventArgs e)
        {
            //clear btn
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data grid
        }

        private void btn_tag_editdetails(object sender, EventArgs e)
        {
            //edit details btn
        }

        private void btn_tag_delete(object sender, EventArgs e)
        {
            //delete btn
        }

        

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search by combo box
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //tagname
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //search
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void tags_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
