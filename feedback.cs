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
    public partial class feedback : Form
    {
        SqlConnection SqlConnection;
        Form last_form;
        public feedback(Form form, SqlConnection connection)
        {
            SqlConnection = connection;
            last_form = form;
            InitializeComponent();
        }
        public feedback()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            last_form.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("u can type your feedback in the up field then click\"send\"" +
                "\n\nif you want to return back click \"back\"", "helper", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_send_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into feedback values ((select max(num) from feedback)+1,'"+textBox1.Text+"')", SqlConnection);
            SqlConnection.Open();
            command.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("sent successfulliy");
            btn_close_Click(sender, e);
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_centerDataSet.specialization' table. You can move, or remove it, as needed.
            this.specializationTableAdapter.Fill(this.medical_centerDataSet.specialization);

        }
    }
}
