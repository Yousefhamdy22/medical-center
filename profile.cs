using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace medical_center
{
    public partial class profile : Form
    {
        
        public profile(SqlConnection conn,string spec_loc)
        {
            SqlCommand command = new SqlCommand("" +
                "select fname,mname,lname,age,phone,sch_day,stime,etime,p_work from doctor, schedule " +
                "where id = dr_id and clin_loc = '"+spec_loc.Trim()+"'", conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            InitializeComponent();
            tb_name.Text = string.Format("{0} {1} {2}",reader[0].ToString(),reader[1].ToString(),reader[2].ToString());
            tb_age.Text = reader[3] + "";
            tb_phone.Text = reader[4] + "";
            tb_workDays.Text = reader[5] + "";
            tb_workTime.Text="from "+reader[6]+" to " +reader[7];
            tb_workPlace.Text = reader[8] + "";
            conn.Close();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
