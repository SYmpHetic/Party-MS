﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class UserTranscript : Form
    {
        public UserTranscript()
        {
            InitializeComponent();
            
        }

        private void table()
        {
            Dao dao = new Dao();
            string sql = "select course_no, course_name, course_score from t_transcript where no=" + Data.UID;
            IDataReader dc = dao.read(sql);
            string course_no, course_name, course_score;
            while(dc.Read())
            {
                course_no = dc[0].ToString();
                course_name = dc[1].ToString();
                course_score = dc[2].ToString();

                string[] table = new string[] { course_no, course_name, course_score };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserIndex userIndex = new UserIndex();
            userIndex.Show();
        }
    }
}
