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
    public partial class home_page : Form
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-GPAUT2J\\AMMAR;Initial Catalog=medical_center;Integrated Security=True");
        public home_page()
        {
            InitializeComponent();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "this is your APP for reserving in clinic \n\n please,choose specialization you want", "helper", MessageBoxButtons.OK);
        }

        private void btn_specialize_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SpecializationForm s = new SpecializationForm(this,SqlConnection, button.Text);
            s.Show();
            this.Visible = false;
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("are you sure you want to leave", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) { Application.Exit();}
            
        }
        bool check = true;
        private void btn_panel2_Click(object sender, EventArgs e)
        {
            if (check) 
            {
                panel2.BringToFront();
                panel3.SendToBack();
                check = false;
            }
            else
            {
                panel3.BringToFront();
                panel2.SendToBack();
                check = true;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wellcome to yaakop medical center,\n\nthat made by dr.Ahmed yaakop in 12/2000\n\n" +
                "our center have best_medical_center in egypt for 2020, it has doctors with many specializations with, different" +
                "degrees and costs\n\nwe do our best to be better and better\n\n" +
                "thanks for reading", "wellcome by dr.Ahmed yaakop", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            feedback feedback = new feedback(this,SqlConnection);
            feedback.Show();
            this.Visible = false;
        }
    }
}
