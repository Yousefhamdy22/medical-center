
namespace medical_center
{
    partial class reserve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cob_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_age = new System.Windows.Forms.MaskedTextBox();
            this.cob_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_patient_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_clinicName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btn_reserve);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lbl_cost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cob_gender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mtb_age);
            this.panel1.Controls.Add(this.cob_type);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_patient_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_clinicName);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 309);
            this.panel1.TabIndex = 1;
            // 
            // btn_reserve
            // 
            this.btn_reserve.Location = new System.Drawing.Point(395, 245);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(108, 48);
            this.btn_reserve.TabIndex = 16;
            this.btn_reserve.Text = "reserve";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(5, 245);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(151, 48);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "<< back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(261, 179);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(39, 29);
            this.lbl_cost.TabIndex = 11;
            this.lbl_cost.Text = "45";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "cost : ";
            // 
            // cob_gender
            // 
            this.cob_gender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cob_gender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cob_gender.FormattingEnabled = true;
            this.cob_gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cob_gender.Location = new System.Drawing.Point(381, 98);
            this.cob_gender.Name = "cob_gender";
            this.cob_gender.Size = new System.Drawing.Size(121, 37);
            this.cob_gender.TabIndex = 9;
            this.cob_gender.Text = "male";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "gender : ";
            // 
            // mtb_age
            // 
            this.mtb_age.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mtb_age.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mtb_age.Location = new System.Drawing.Point(266, 98);
            this.mtb_age.Mask = "00";
            this.mtb_age.Name = "mtb_age";
            this.mtb_age.Size = new System.Drawing.Size(34, 34);
            this.mtb_age.TabIndex = 7;
            this.mtb_age.ValidatingType = typeof(int);
            // 
            // cob_type
            // 
            this.cob_type.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cob_type.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cob_type.FormattingEnabled = true;
            this.cob_type.Items.AddRange(new object[] {
            "normal",
            "consultation"});
            this.cob_type.Location = new System.Drawing.Point(5, 176);
            this.cob_type.Name = "cob_type";
            this.cob_type.Size = new System.Drawing.Size(185, 37);
            this.cob_type.TabIndex = 6;
            this.cob_type.Text = "normal";
            this.cob_type.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "reservation type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "age : ";
            // 
            // tb_patient_name
            // 
            this.tb_patient_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_patient_name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_patient_name.Location = new System.Drawing.Point(3, 98);
            this.tb_patient_name.Name = "tb_patient_name";
            this.tb_patient_name.Size = new System.Drawing.Size(187, 34);
            this.tb_patient_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "patient name : ";
            // 
            // lbl_clinicName
            // 
            this.lbl_clinicName.AutoSize = true;
            this.lbl_clinicName.Location = new System.Drawing.Point(3, 9);
            this.lbl_clinicName.Name = "lbl_clinicName";
            this.lbl_clinicName.Size = new System.Drawing.Size(79, 29);
            this.lbl_clinicName.TabIndex = 0;
            this.lbl_clinicName.Text = "label1";
            // 
            // reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(530, 335);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reserve";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cob_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_age;
        private System.Windows.Forms.ComboBox cob_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_patient_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_clinicName;
    }
}