﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBCourseWork
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
            sqlConnection.Open();
            /*if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Right");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
