using System.Windows.Forms;
namespace medical_center
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ortho = new System.Windows.Forms.Button();
            this.btn_stomach = new System.Windows.Forms.Button();
            this.btn_optha = new System.Windows.Forms.Button();
            this.btn_teeth = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn_panel2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_skin = new System.Windows.Forms.Button();
            this.btn_neuro = new System.Windows.Forms.Button();
            this.btn_nose = new System.Windows.Forms.Button();
            this.btn_obst = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.btn_panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 811);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ortho);
            this.panel2.Controls.Add(this.btn_stomach);
            this.panel2.Controls.Add(this.btn_optha);
            this.panel2.Controls.Add(this.btn_teeth);
            this.panel2.Location = new System.Drawing.Point(3, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 486);
            this.panel2.TabIndex = 19;
            // 
            // btn_ortho
            // 
            this.btn_ortho.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ortho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ortho.BackgroundImage")));
            this.btn_ortho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ortho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ortho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ortho.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ortho.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_ortho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ortho.Location = new System.Drawing.Point(-5, 4);
            this.btn_ortho.Name = "btn_ortho";
            this.btn_ortho.Size = new System.Drawing.Size(484, 227);
            this.btn_ortho.TabIndex = 17;
            this.btn_ortho.Text = "Orthopedic";
            this.btn_ortho.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ortho.UseVisualStyleBackColor = false;
            this.btn_ortho.Click += new System.EventHandler(this.btn_specialize_Click);
            // 
            // btn_stomach
            // 
            this.btn_stomach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stomach.BackgroundImage")));
            this.btn_stomach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stomach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stomach.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stomach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_stomach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stomach.Location = new System.Drawing.Point(482, 237);
            this.btn_stomach.Name = "btn_stomach";
            this.btn_stomach.Size = new System.Drawing.Size(469, 237);
            this.btn_stomach.TabIndex = 21;
            this.btn_stomach.Text = "stomach pain";
            this.btn_stomach.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_stomach.UseVisualStyleBackColor = true;
            this.btn_stomach.Click += new System.EventHandler(this.btn_specialize_Click);
            // 
            // btn_optha
            // 
            this.btn_optha.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_optha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_optha.BackgroundImage")));
            this.btn_optha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_optha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_optha.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_optha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_optha.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_optha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_optha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_optha.Location = new System.Drawing.Point(482, 4);
            this.btn_optha.Name = "btn_optha";
            this.btn_optha.Size = new System.Drawing.Size(469, 227);
            this.btn_optha.TabIndex = 19;
            this.btn_optha.Text = "ophthalmology";
            this.btn_optha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_optha.UseVisualStyleBackColor = false;
            this.btn_optha.Click += new System.EventHandler(this.btn_specialize_Click);
            // 
            // btn_teeth
            // 
            this.btn_teeth.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_teeth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_teeth.BackgroundImage")));
            this.btn_teeth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_teeth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_teeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teeth.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_teeth.Location = new System.Drawing.Point(0, 237);
            this.btn_teeth.Name = "btn_teeth";
            this.btn_teeth.Size = new System.Drawing.Size(479, 240);
            this.btn_teeth.TabIndex = 20;
            this.btn_teeth.Text = "dentist";
            this.btn_teeth.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_teeth.UseVisualStyleBackColor = false;
            this.btn_teeth.Click += new System.EventHandler(this.btn_specialize_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(973, 748);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(1045, 747);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 45);
            this.button6.TabIndex = 27;
            this.button6.Text = "give feedback";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(973, 600);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 135);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E-MAIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(11, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "yaakop_on@yahoo.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(11, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "yaakop123@gmail.com";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(973, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 236);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "phone numbers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "01112525717";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "090005647";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "01002457814";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "0154879734";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(967, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "for enquiry & complents: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(467, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(1164, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 69);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(546, 69);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(124, 112);
            this.button11.TabIndex = 12;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn_panel2
            // 
            this.btn_panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_panel2.Location = new System.Drawing.Point(3, 272);
            this.btn_panel2.Name = "btn_panel2";
            this.btn_panel2.Size = new System.Drawing.Size(951, 45);
            this.btn_panel2.TabIndex = 15;
            this.btn_panel2.Text = "click for more specializations";
            this.btn_panel2.UseVisualStyleBackColor = false;
            this.btn_panel2.Click += new System.EventHandler(this.btn_panel2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "We wish you a speedy recovery";
            // 
            // btn_help
            // 
            this.btn_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_help.BackgroundImage")));
            this.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_help.Location = new System.Drawing.Point(1070, 3);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(88, 69);
            this.btn_help.TabIndex = 9;
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Title.Location = new System.Drawing.Point(393, 184);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(426, 40);
            this.lbl_Title.TabIndex = 16;
            this.lbl_Title.Text = "yaakop medical center";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_skin);
            this.panel3.Controls.Add(this.btn_neuro);
            this.panel3.Controls.Add(this.btn_nose);
            this.panel3.Controls.Add(this.btn_obst);
            this.panel3.Location = new System.Drawing.Point(6, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 492);
            this.panel3.TabIndex = 23;
            // 
            // btn_skin
            // 
            this.btn_skin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_skin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_skin.BackgroundImage")));
            this.btn_skin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_skin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_skin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_skin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_skin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_skin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_skin.Location = new System.Drawing.Point(484, 243);
            this.btn_skin.Name = "btn_skin";
            this.btn_skin.Size = new System.Drawing.Size(461, 237);
            this.btn_skin.TabIndex = 22;
            this.btn_skin.Text = "skin disease";
            this.btn_skin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_skin.UseVisualStyleBackColor = false;
            this.btn_skin.Click += new System.EventHandler(this.btn_specialize_Click);
            // 
            // btn_neuro
            // 
            this.btn_neuro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_neuro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_neuro.BackgroundImage")));
            this.btn_neuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_neuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_neuro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_neuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_neuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_neuro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_neuro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_neuro.Location = new System.Drawing.Point(485, 13);
            this.btn_neuro.Name = "btn_neuro";
            this.btn_neuro.Size = new System.Drawing.Size(461, 224);
            this.btn_neuro.TabIndex = 19;
            this.btn_neuro.Text = "Neurologists";
            this.btn_neuro.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_neuro.UseVisualStyleBackColor = false;
            this.btn_neuro.Click += new System.EventHandler(this.btn_specialize_Click);
            // 
            // btn_nose
            // 
            this.btn_nose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_nose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nose.BackgroundImage")));
            this.btn_nose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_nose.Location = new System.Drawing.Point(0, 13);
            this.btn_nose.Name = "btn_nose";
            this.btn_nose.Size = new System.Drawing.Size(479, 224);
            this.btn_nose.TabIndex = 17;
            this.btn_nose.Text = "Ear, Nose and Throat";
            this.btn_nose.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_nose.UseVisualStyleBackColor = false;
            this.btn_nose.Click += new System.EventHandler(this.btn_specialize_Click);
            // 
            // btn_obst
            // 
            this.btn_obst.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_obst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_obst.BackgroundImage")));
            this.btn_obst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_obst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_obst.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obst.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_obst.Location = new System.Drawing.Point(0, 243);
            this.btn_obst.Name = "btn_obst";
            this.btn_obst.Size = new System.Drawing.Size(479, 237);
            this.btn_obst.TabIndex = 20;
            this.btn_obst.Text = "Obstetrics and Gynecology";
            this.btn_obst.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_obst.UseVisualStyleBackColor = false;
            this.btn_obst.Click += new System.EventHandler(this.btn_specialize_Click);
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(1278, 835);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home_page";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button11;
        private Button btn_panel2;
        private Label label1;
        private Button btn_help;
        private Label lbl_Title;
        private Button btn_exit;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_ortho;
        private Button btn_teeth;
        private PictureBox pictureBox2;
        private Button button6;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Panel panel3;
        private Button btn_stomach;
        private Button btn_skin;
        private Button btn_optha;
        private Button btn_neuro;
        private Button btn_nose;
        private Button btn_obst;
    }
}

