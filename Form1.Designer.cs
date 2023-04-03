namespace CarDbDesign
{
    partial class CarDb
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDb));
            this.CarInformationLabel = new System.Windows.Forms.Label();
            this.CarBrandLabel = new System.Windows.Forms.Label();
            this.CarBrandTextBox = new System.Windows.Forms.TextBox();
            this.CarMarkLabel = new System.Windows.Forms.Label();
            this.CarMarkTextBox = new System.Windows.Forms.TextBox();
            this.CarYearLabel = new System.Windows.Forms.Label();
            this.ManufactureTextBox = new System.Windows.Forms.TextBox();
            this.VinCodeLabel = new System.Windows.Forms.Label();
            this.VinCodeTextBox = new System.Windows.Forms.TextBox();
            this.CarColorLabel = new System.Windows.Forms.Label();
            this.CarColorTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ImageUrlLabel = new System.Windows.Forms.Label();
            this.ImageUrlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarDetailsBox = new System.Windows.Forms.DataGridView();
            this.DeleteDBButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dropdown = new System.Windows.Forms.ComboBox();
            this.MechanichButton = new System.Windows.Forms.RadioButton();
            this.AutomaticButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DrivenDistanceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarDetailsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarInformationLabel
            // 
            this.CarInformationLabel.AutoSize = true;
            this.CarInformationLabel.Font = new System.Drawing.Font("Montserrat Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarInformationLabel.Location = new System.Drawing.Point(30, 24);
            this.CarInformationLabel.Name = "CarInformationLabel";
            this.CarInformationLabel.Size = new System.Drawing.Size(235, 29);
            this.CarInformationLabel.TabIndex = 0;
            this.CarInformationLabel.Text = "Upload Information";
            // 
            // CarBrandLabel
            // 
            this.CarBrandLabel.AutoSize = true;
            this.CarBrandLabel.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarBrandLabel.Location = new System.Drawing.Point(30, 59);
            this.CarBrandLabel.Name = "CarBrandLabel";
            this.CarBrandLabel.Size = new System.Drawing.Size(76, 16);
            this.CarBrandLabel.TabIndex = 1;
            this.CarBrandLabel.Text = "Car Brand";
            this.CarBrandLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarBrandTextBox
            // 
            this.CarBrandTextBox.Location = new System.Drawing.Point(30, 78);
            this.CarBrandTextBox.Name = "CarBrandTextBox";
            this.CarBrandTextBox.Size = new System.Drawing.Size(156, 23);
            this.CarBrandTextBox.TabIndex = 1;
            this.CarBrandTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CarMarkLabel
            // 
            this.CarMarkLabel.AutoSize = true;
            this.CarMarkLabel.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarMarkLabel.Location = new System.Drawing.Point(30, 104);
            this.CarMarkLabel.Name = "CarMarkLabel";
            this.CarMarkLabel.Size = new System.Drawing.Size(69, 16);
            this.CarMarkLabel.TabIndex = 1;
            this.CarMarkLabel.Text = "Car Mark";
            this.CarMarkLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarMarkTextBox
            // 
            this.CarMarkTextBox.Location = new System.Drawing.Point(30, 123);
            this.CarMarkTextBox.Name = "CarMarkTextBox";
            this.CarMarkTextBox.Size = new System.Drawing.Size(156, 23);
            this.CarMarkTextBox.TabIndex = 2;
            this.CarMarkTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CarYearLabel
            // 
            this.CarYearLabel.AutoSize = true;
            this.CarYearLabel.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarYearLabel.Location = new System.Drawing.Point(30, 194);
            this.CarYearLabel.Name = "CarYearLabel";
            this.CarYearLabel.Size = new System.Drawing.Size(132, 16);
            this.CarYearLabel.TabIndex = 1;
            this.CarYearLabel.Text = "Manufacture Date";
            this.CarYearLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManufactureTextBox
            // 
            this.ManufactureTextBox.Location = new System.Drawing.Point(30, 213);
            this.ManufactureTextBox.Name = "ManufactureTextBox";
            this.ManufactureTextBox.Size = new System.Drawing.Size(156, 23);
            this.ManufactureTextBox.TabIndex = 4;
            this.ManufactureTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VinCodeLabel
            // 
            this.VinCodeLabel.AutoSize = true;
            this.VinCodeLabel.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VinCodeLabel.Location = new System.Drawing.Point(30, 239);
            this.VinCodeLabel.Name = "VinCodeLabel";
            this.VinCodeLabel.Size = new System.Drawing.Size(94, 16);
            this.VinCodeLabel.TabIndex = 1;
            this.VinCodeLabel.Text = "VIN Number";
            this.VinCodeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // VinCodeTextBox
            // 
            this.VinCodeTextBox.Location = new System.Drawing.Point(30, 258);
            this.VinCodeTextBox.Name = "VinCodeTextBox";
            this.VinCodeTextBox.Size = new System.Drawing.Size(156, 23);
            this.VinCodeTextBox.TabIndex = 5;
            this.VinCodeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CarColorLabel
            // 
            this.CarColorLabel.AutoSize = true;
            this.CarColorLabel.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarColorLabel.Location = new System.Drawing.Point(30, 149);
            this.CarColorLabel.Name = "CarColorLabel";
            this.CarColorLabel.Size = new System.Drawing.Size(45, 16);
            this.CarColorLabel.TabIndex = 1;
            this.CarColorLabel.Text = "Color";
            this.CarColorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarColorTextBox
            // 
            this.CarColorTextBox.Location = new System.Drawing.Point(30, 168);
            this.CarColorTextBox.Name = "CarColorTextBox";
            this.CarColorTextBox.Size = new System.Drawing.Size(156, 23);
            this.CarColorTextBox.TabIndex = 3;
            this.CarColorTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(30, 387);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(125, 34);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Upload";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ImageUrlLabel
            // 
            this.ImageUrlLabel.AutoSize = true;
            this.ImageUrlLabel.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImageUrlLabel.Location = new System.Drawing.Point(30, 338);
            this.ImageUrlLabel.Name = "ImageUrlLabel";
            this.ImageUrlLabel.Size = new System.Drawing.Size(83, 16);
            this.ImageUrlLabel.TabIndex = 1;
            this.ImageUrlLabel.Text = "Image URL";
            this.ImageUrlLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImageUrlTextBox
            // 
            this.ImageUrlTextBox.Location = new System.Drawing.Point(30, 357);
            this.ImageUrlTextBox.Name = "ImageUrlTextBox";
            this.ImageUrlTextBox.Size = new System.Drawing.Size(156, 23);
            this.ImageUrlTextBox.TabIndex = 6;
            this.ImageUrlTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(326, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Information";
            // 
            // CarDetailsBox
            // 
            this.CarDetailsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDetailsBox.Location = new System.Drawing.Point(337, 111);
            this.CarDetailsBox.Name = "CarDetailsBox";
            this.CarDetailsBox.RowTemplate.Height = 25;
            this.CarDetailsBox.Size = new System.Drawing.Size(777, 244);
            this.CarDetailsBox.TabIndex = 8;
            this.CarDetailsBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarDetailsBox_CellContentClick);
            // 
            // DeleteDBButton
            // 
            this.DeleteDBButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteDBButton.Location = new System.Drawing.Point(999, 376);
            this.DeleteDBButton.Name = "DeleteDBButton";
            this.DeleteDBButton.Size = new System.Drawing.Size(115, 34);
            this.DeleteDBButton.TabIndex = 9;
            this.DeleteDBButton.Text = "Clear DB";
            this.DeleteDBButton.UseVisualStyleBackColor = false;
            this.DeleteDBButton.Click += new System.EventHandler(this.DeleteDBButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(809, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Dropdown
            // 
            this.Dropdown.FormattingEnabled = true;
            this.Dropdown.Items.AddRange(new object[] {
            "Used",
            "New"});
            this.Dropdown.Location = new System.Drawing.Point(192, 78);
            this.Dropdown.Name = "Dropdown";
            this.Dropdown.Size = new System.Drawing.Size(121, 23);
            this.Dropdown.TabIndex = 11;
            this.Dropdown.SelectedIndexChanged += new System.EventHandler(this.Dropdown_SelectedIndexChanged);
            // 
            // MechanichButton
            // 
            this.MechanichButton.AutoSize = true;
            this.MechanichButton.Location = new System.Drawing.Point(248, 387);
            this.MechanichButton.Name = "MechanichButton";
            this.MechanichButton.Size = new System.Drawing.Size(77, 19);
            this.MechanichButton.TabIndex = 12;
            this.MechanichButton.TabStop = true;
            this.MechanichButton.Text = "Mechanic";
            this.MechanichButton.UseVisualStyleBackColor = true;
            this.MechanichButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AutomaticButton
            // 
            this.AutomaticButton.AutoSize = true;
            this.AutomaticButton.Location = new System.Drawing.Point(161, 387);
            this.AutomaticButton.Name = "AutomaticButton";
            this.AutomaticButton.Size = new System.Drawing.Size(81, 19);
            this.AutomaticButton.TabIndex = 12;
            this.AutomaticButton.TabStop = true;
            this.AutomaticButton.Text = "Automatic";
            this.AutomaticButton.UseVisualStyleBackColor = true;
            this.AutomaticButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driven Distance";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // DrivenDistanceTextBox
            // 
            this.DrivenDistanceTextBox.Location = new System.Drawing.Point(30, 312);
            this.DrivenDistanceTextBox.Name = "DrivenDistanceTextBox";
            this.DrivenDistanceTextBox.Size = new System.Drawing.Size(156, 23);
            this.DrivenDistanceTextBox.TabIndex = 6;
            this.DrivenDistanceTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CarDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.AutomaticButton);
            this.Controls.Add(this.MechanichButton);
            this.Controls.Add(this.Dropdown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteDBButton);
            this.Controls.Add(this.CarDetailsBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DrivenDistanceTextBox);
            this.Controls.Add(this.ImageUrlTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImageUrlLabel);
            this.Controls.Add(this.VinCodeTextBox);
            this.Controls.Add(this.VinCodeLabel);
            this.Controls.Add(this.ManufactureTextBox);
            this.Controls.Add(this.CarYearLabel);
            this.Controls.Add(this.CarColorTextBox);
            this.Controls.Add(this.CarColorLabel);
            this.Controls.Add(this.CarMarkTextBox);
            this.Controls.Add(this.CarMarkLabel);
            this.Controls.Add(this.CarBrandTextBox);
            this.Controls.Add(this.CarBrandLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarInformationLabel);
            this.Name = "CarDb";
            this.Text = "Card DB";
            ((System.ComponentModel.ISupportInitialize)(this.CarDetailsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CarInformationLabel;
        private Label CarBrandLabel;
        private TextBox CarBrandTextBox;
        private Label CarMarkLabel;
        private TextBox CarMarkTextBox;
        private Label CarYearLabel;
        private TextBox ManufactureTextBox;
        private Label VinCodeLabel;
        private TextBox VinCodeTextBox;
        private Label CarColorLabel;
        private TextBox CarColorTextBox;
        private Button SubmitButton;
        private Label ImageUrlLabel;
        private TextBox ImageUrlTextBox;
        private Label label1;
        private DataGridView CarDetailsBox;
        private Button DeleteDBButton;
        private PictureBox pictureBox1;
        private ComboBox Dropdown;
        private RadioButton MechanichButton;
        private RadioButton AutomaticButton;
        private Label label2;
        private TextBox DrivenDistanceTextBox;
    }
}