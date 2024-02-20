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
    public partial class reserve : Form
    {
        SqlConnection SqlConnection;
        SqlCommand command;
        Form last_form;
        int cost;
        string spec;
        public reserve(Form form,SqlConnection sqlConnection,string spec)
        {
            SqlConnection = sqlConnection;
            command = new SqlCommand("select cost,fname from doctor where clin_loc='" + spec.Trim() + "'",sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            this.cost = int.Parse(reader[0].ToString());
            
            last_form = form;
            this.spec = spec.Trim();
            InitializeComponent();
            lbl_cost.Text = cost + "";
            lbl_clinicName.Text = ("reserve in dr "+reader[1]+" clinic");
            sqlConnection.Close();
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("exec reservation_insert '" + tb_patient_name.Text + "','" + mtb_age.Text +
                "','" + cob_type.Text + "','" + cob_gender.Text + "','" + spec+ "','"+lbl_cost.Text+"'", SqlConnection);

            SqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            MessageBox.Show(
                "your reserve number is " + reader[0] +"\n\nyou can sit in waiing chairs"+
                "\n\nlocation : " + spec + "\n\n" +
                "thank you", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlConnection.Close();
            btn_back_Click(sender, e);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            last_form.Visible = true;
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cob_type.SelectedItem.Equals("consultation"))
            { lbl_cost.Text = "0"; }
            else
            {
                lbl_cost.Text = cost + "";
            }
        }
    }
}
