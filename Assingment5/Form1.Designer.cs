namespace Assingment5
{
    partial class studentForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.studentinformationbox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.maxnameLabel = new System.Windows.Forms.Label();
            this.minnameLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.averegeTextBox = new System.Windows.Forms.TextBox();
            this.mimNameTextBox = new System.Windows.Forms.TextBox();
            this.nameMaxTextBox = new System.Windows.Forms.TextBox();
            this.mimTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.mobileRadioButton = new System.Windows.Forms.RadioButton();
            this.studentinformationbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 52);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(6, 79);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(38, 13);
            this.mobileLabel.TabIndex = 2;
            this.mobileLabel.Text = "Mobile";
            this.mobileLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(6, 110);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age";
            this.ageLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(6, 139);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            this.addressLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(6, 175);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(56, 13);
            this.gpaLabel.TabIndex = 5;
            this.gpaLabel.Text = "GPA Point";
            this.gpaLabel.Click += new System.EventHandler(this.gpaLabel_Click);
            // 
            // studentinformationbox
            // 
            this.studentinformationbox.Controls.Add(this.gpaTextBox);
            this.studentinformationbox.Controls.Add(this.addressTextBox);
            this.studentinformationbox.Controls.Add(this.ageTextBox);
            this.studentinformationbox.Controls.Add(this.mobileTextBox);
            this.studentinformationbox.Controls.Add(this.nameTextBox);
            this.studentinformationbox.Controls.Add(this.idTextBox);
            this.studentinformationbox.Controls.Add(this.idLabel);
            this.studentinformationbox.Controls.Add(this.gpaLabel);
            this.studentinformationbox.Controls.Add(this.nameLabel);
            this.studentinformationbox.Controls.Add(this.addressLabel);
            this.studentinformationbox.Controls.Add(this.mobileLabel);
            this.studentinformationbox.Controls.Add(this.ageLabel);
            this.studentinformationbox.Location = new System.Drawing.Point(12, 12);
            this.studentinformationbox.Name = "studentinformationbox";
            this.studentinformationbox.Size = new System.Drawing.Size(426, 223);
            this.studentinformationbox.TabIndex = 6;
            this.studentinformationbox.TabStop = false;
            this.studentinformationbox.Text = "Student Information";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(54, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(54, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(191, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(54, 77);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(191, 20);
            this.mobileTextBox.TabIndex = 8;
            this.mobileTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(54, 103);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(57, 136);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(188, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(68, 172);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTextBox.TabIndex = 11;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(21, 253);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(741, 96);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(this.mimTextBox);
            this.groupBox1.Controls.Add(this.nameMaxTextBox);
            this.groupBox1.Controls.Add(this.mimNameTextBox);
            this.groupBox1.Controls.Add(this.averegeTextBox);
            this.groupBox1.Controls.Add(this.maxTextBox);
            this.groupBox1.Controls.Add(this.totalLabel);
            this.groupBox1.Controls.Add(this.minnameLabel);
            this.groupBox1.Controls.Add(this.maxnameLabel);
            this.groupBox1.Controls.Add(this.averageLabel);
            this.groupBox1.Controls.Add(this.minLabel);
            this.groupBox1.Controls.Add(this.maxLabel);
            this.groupBox1.Location = new System.Drawing.Point(21, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPA Point";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(18, 16);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 0;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(234, 16);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 1;
            this.minLabel.Text = "Min";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(560, 16);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(26, 13);
            this.averageLabel.TabIndex = 2;
            this.averageLabel.Text = "Avg";
            // 
            // maxnameLabel
            // 
            this.maxnameLabel.AutoSize = true;
            this.maxnameLabel.Location = new System.Drawing.Point(18, 52);
            this.maxnameLabel.Name = "maxnameLabel";
            this.maxnameLabel.Size = new System.Drawing.Size(35, 13);
            this.maxnameLabel.TabIndex = 3;
            this.maxnameLabel.Text = "Name";
            // 
            // minnameLabel
            // 
            this.minnameLabel.AutoSize = true;
            this.minnameLabel.Location = new System.Drawing.Point(234, 52);
            this.minnameLabel.Name = "minnameLabel";
            this.minnameLabel.Size = new System.Drawing.Size(35, 13);
            this.minnameLabel.TabIndex = 4;
            this.minnameLabel.Text = "Name";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(560, 52);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(59, 16);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 6;
            // 
            // averegeTextBox
            // 
            this.averegeTextBox.Location = new System.Drawing.Point(610, 16);
            this.averegeTextBox.Name = "averegeTextBox";
            this.averegeTextBox.Size = new System.Drawing.Size(100, 20);
            this.averegeTextBox.TabIndex = 7;
            // 
            // mimNameTextBox
            // 
            this.mimNameTextBox.Location = new System.Drawing.Point(298, 52);
            this.mimNameTextBox.Name = "mimNameTextBox";
            this.mimNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.mimNameTextBox.TabIndex = 8;
            // 
            // nameMaxTextBox
            // 
            this.nameMaxTextBox.Location = new System.Drawing.Point(59, 49);
            this.nameMaxTextBox.Name = "nameMaxTextBox";
            this.nameMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameMaxTextBox.TabIndex = 9;
            // 
            // mimTextBox
            // 
            this.mimTextBox.Location = new System.Drawing.Point(298, 16);
            this.mimTextBox.Name = "mimTextBox";
            this.mimTextBox.Size = new System.Drawing.Size(100, 20);
            this.mimTextBox.TabIndex = 10;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(610, 49);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(532, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.mobileRadioButton);
            this.searchGroupBox.Controls.Add(this.nameRadioButton);
            this.searchGroupBox.Controls.Add(this.idRadioButton);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Location = new System.Drawing.Point(491, 49);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(204, 131);
            this.searchGroupBox.TabIndex = 10;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search By";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(537, 198);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(78, 97);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // idRadioButton
            // 
            this.idRadioButton.AutoSize = true;
            this.idRadioButton.Location = new System.Drawing.Point(17, 24);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(36, 17);
            this.idRadioButton.TabIndex = 1;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "ID";
            this.idRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(19, 48);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 2;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // mobileRadioButton
            // 
            this.mobileRadioButton.AutoSize = true;
            this.mobileRadioButton.Location = new System.Drawing.Point(21, 77);
            this.mobileRadioButton.Name = "mobileRadioButton";
            this.mobileRadioButton.Size = new System.Drawing.Size(56, 17);
            this.mobileRadioButton.TabIndex = 3;
            this.mobileRadioButton.TabStop = true;
            this.mobileRadioButton.Text = "Mobile";
            this.mobileRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.studentinformationbox);
            this.Name = "studentForm";
            this.Text = "Student Form";
            this.studentinformationbox.ResumeLayout(false);
            this.studentinformationbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.GroupBox studentinformationbox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox mimTextBox;
        private System.Windows.Forms.TextBox nameMaxTextBox;
        private System.Windows.Forms.TextBox mimNameTextBox;
        private System.Windows.Forms.TextBox averegeTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label minnameLabel;
        private System.Windows.Forms.Label maxnameLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton mobileRadioButton;
    }
}

