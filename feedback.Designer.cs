
namespace medical_center
{
    partial class feedback
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.specializationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalcenterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_centerDataSet = new medical_center.medical_centerDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializationTableAdapter = new medical_center.medical_centerDataSetTableAdapters.specializationTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalcenterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 366);
            this.panel1.TabIndex = 9;
            // 
            // specializationBindingSource1
            // 
            this.specializationBindingSource1.DataMember = "specialization";
            this.specializationBindingSource1.DataSource = this.medicalcenterDataSetBindingSource;
            // 
            // medicalcenterDataSetBindingSource
            // 
            this.medicalcenterDataSetBindingSource.DataSource = this.medical_centerDataSet;
            this.medicalcenterDataSetBindingSource.Position = 0;
            // 
            // medical_centerDataSet
            // 
            this.medical_centerDataSet.DataSetName = "medical_centerDataSet";
            this.medical_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(3, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(669, 249);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "type your feedback here";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_send.Location = new System.Drawing.Point(277, 310);
            this.btn_send.Margin = new System.Windows.Forms.Padding(6);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(131, 50);
            this.btn_send.TabIndex = 11;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(551, 310);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 50);
            this.button4.TabIndex = 10;
            this.button4.Text = "help??";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_close.Location = new System.Drawing.Point(3, 310);
            this.btn_close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(129, 50);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "<< back";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // specializationBindingSource
            // 
            this.specializationBindingSource.DataMember = "specialization";
            this.specializationBindingSource.DataSource = this.medicalcenterDataSetBindingSource;
            // 
            // specializationTableAdapter
            // 
            this.specializationTableAdapter.ClearBeforeFill = true;
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(702, 390);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "feedback";
            this.Load += new System.EventHandler(this.feedback_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalcenterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.BindingSource medicalcenterDataSetBindingSource;
        private medical_centerDataSet medical_centerDataSet;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private medical_centerDataSetTableAdapters.specializationTableAdapter specializationTableAdapter;
        private System.Windows.Forms.BindingSource specializationBindingSource1;
    }
}