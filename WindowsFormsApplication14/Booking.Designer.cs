namespace create_member
{
    partial class Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bookbutton = new System.Windows.Forms.Button();
            this.BookingCancelbutton = new System.Windows.Forms.Button();
            this.BookingSlotcomboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1ICNumber = new System.Windows.Forms.ComboBox();
            this.memberDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsCenterDataSet_MemberIcNumber_And_MemberID = new WindowsFormsApplication14.SportsCenterDataSet_MemberIcNumber_And_MemberID();
            this.comboBox2Equipment = new System.Windows.Forms.ComboBox();
            this.memberDetailsTableAdapter = new WindowsFormsApplication14.SportsCenterDataSet_MemberIcNumber_And_MemberIDTableAdapters.MemberDetailsTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCenterDataSet_MemberIcNumber_And_MemberID)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IC Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipment :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Slot :";
            // 
            // Bookbutton
            // 
            this.Bookbutton.Location = new System.Drawing.Point(65, 190);
            this.Bookbutton.Name = "Bookbutton";
            this.Bookbutton.Size = new System.Drawing.Size(75, 23);
            this.Bookbutton.TabIndex = 6;
            this.Bookbutton.Text = "Book";
            this.Bookbutton.UseVisualStyleBackColor = true;
            this.Bookbutton.Click += new System.EventHandler(this.Bookbutton_Click);
            // 
            // BookingCancelbutton
            // 
            this.BookingCancelbutton.Location = new System.Drawing.Point(158, 190);
            this.BookingCancelbutton.Name = "BookingCancelbutton";
            this.BookingCancelbutton.Size = new System.Drawing.Size(75, 23);
            this.BookingCancelbutton.TabIndex = 7;
            this.BookingCancelbutton.Text = "Cancel";
            this.BookingCancelbutton.UseVisualStyleBackColor = true;
            // 
            // BookingSlotcomboBox
            // 
            this.BookingSlotcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookingSlotcomboBox.FormattingEnabled = true;
            this.BookingSlotcomboBox.Location = new System.Drawing.Point(114, 111);
            this.BookingSlotcomboBox.Name = "BookingSlotcomboBox";
            this.BookingSlotcomboBox.Size = new System.Drawing.Size(54, 21);
            this.BookingSlotcomboBox.TabIndex = 8;
            // 
            // comboBox1ICNumber
            // 
            this.comboBox1ICNumber.DataSource = this.memberDetailsBindingSource;
            this.comboBox1ICNumber.DisplayMember = "ICNumber";
            this.comboBox1ICNumber.FormattingEnabled = true;
            this.comboBox1ICNumber.Location = new System.Drawing.Point(112, 40);
            this.comboBox1ICNumber.Name = "comboBox1ICNumber";
            this.comboBox1ICNumber.Size = new System.Drawing.Size(121, 21);
            this.comboBox1ICNumber.TabIndex = 9;
            this.comboBox1ICNumber.ValueMember = "ICNumber";
            // 
            // memberDetailsBindingSource
            // 
            this.memberDetailsBindingSource.DataMember = "MemberDetails";
            this.memberDetailsBindingSource.DataSource = this.sportsCenterDataSet_MemberIcNumber_And_MemberID;
            // 
            // sportsCenterDataSet_MemberIcNumber_And_MemberID
            // 
            this.sportsCenterDataSet_MemberIcNumber_And_MemberID.DataSetName = "SportsCenterDataSet_MemberIcNumber_And_MemberID";
            this.sportsCenterDataSet_MemberIcNumber_And_MemberID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2Equipment
            // 
            this.comboBox2Equipment.FormattingEnabled = true;
            this.comboBox2Equipment.Location = new System.Drawing.Point(112, 78);
            this.comboBox2Equipment.Name = "comboBox2Equipment";
            this.comboBox2Equipment.Size = new System.Drawing.Size(121, 21);
            this.comboBox2Equipment.TabIndex = 10;
            // 
            // memberDetailsTableAdapter
            // 
            this.memberDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox2Equipment);
            this.Controls.Add(this.comboBox1ICNumber);
            this.Controls.Add(this.BookingSlotcomboBox);
            this.Controls.Add(this.BookingCancelbutton);
            this.Controls.Add(this.Bookbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCenterDataSet_MemberIcNumber_And_MemberID)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bookbutton;
        private System.Windows.Forms.Button BookingCancelbutton;
        private System.Windows.Forms.ComboBox BookingSlotcomboBox;
        private System.Windows.Forms.ComboBox comboBox1ICNumber;
        private System.Windows.Forms.ComboBox comboBox2Equipment;
        private WindowsFormsApplication14.SportsCenterDataSet_MemberIcNumber_And_MemberID sportsCenterDataSet_MemberIcNumber_And_MemberID;
        private System.Windows.Forms.BindingSource memberDetailsBindingSource;
        private WindowsFormsApplication14.SportsCenterDataSet_MemberIcNumber_And_MemberIDTableAdapters.MemberDetailsTableAdapter memberDetailsTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}