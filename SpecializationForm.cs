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
    public partial class SpecializationForm : Form
    {
        SqlConnection SqlConnection;
        Form last_form;
        public SpecializationForm(Form form,SqlConnection connection,String specialization)
        {
            // set connection and lat form
            SqlConnection = connection;
            last_form = form;
            InitializeComponent();

            //procedure select_dr_spec_form return dr name, type, cost, npatient
            SqlCommand command = new SqlCommand("exec select_dr_spec_form '"+specialization+"'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            set_spec(reader, gb1, lbl_type1, lbl_cost_1, lbl_npatient_1);
            set_spec(reader, gb2, lbl_type_2, lbl_cost_2, lbl_npatient_2);
            set_spec(reader, gb3, lbl_type_3, lbl_cost_3, lbl_npatient_3);
            set_spec(reader, gb4, lbl_type_4, lbl_cost_4, lbl_npatient_4);
            set_spec(reader, gb5, lbl_type_5, lbl_cost_5, lbl_npatient_5);
            set_spec(reader, gb6, lbl_type_6, lbl_cost_6, lbl_npatient_6);
            connection.Close();
            lbl_specialization.Text = specialization;
        }
        // for retrieving data of specializations from database
        void set_spec(SqlDataReader reader,GroupBox groupBox,Label type,Label cost,Label npatient)
        {
            reader.Read();
            groupBox.Text="DR."+reader[0]+" "+ reader[1]+"\r\t"+reader[4];
            type.Text = reader[2]+"";
            cost.Text = reader[3]+"";
            npatient.Text = reader[5] + "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            last_form.Visible = true;
            this.Close();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you can reserve through the \"reserve\"\n\n" +
                "locked means doctor is not available yet\n\n" +
                "to show dr profile click\"more\"\n\n" +
                "to return to the home page click\"back\"\n\nthank you for reading.", "helper(*.*)"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button_more_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string spec = button.Parent.Text.Substring(button.Parent.Text.Length - 3, 3);
            profile profile = new profile(SqlConnection,spec);
            profile.Show();
        }

        private void button_reserve_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string spec = button.Parent.Text.Substring(button.Parent.Text.Length - 3, 3);
            reserve reserve = new reserve(this,SqlConnection,spec);
            reserve.Show();
            this.Visible = false;
        }
    }
}
