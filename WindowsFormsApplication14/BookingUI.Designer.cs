namespace WindowsFormsApplication14
{
    partial class BookingUI
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
            this.comboBox2Equipment = new System.Windows.Forms.ComboBox();
            this.sportsFacilityDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsCenterDataSet = new WindowsFormsApplication14.SportsCenterDataSet();
            this.comboBox1ICNumber = new System.Windows.Forms.ComboBox();
            this.memberDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsCenterDataSet_MemberIcNumber_And_MemberID = new WindowsFormsApplication14.SportsCenterDataSet_MemberIcNumber_And_MemberID();
            this.BookingSlotcomboBox = new System.Windows.Forms.ComboBox();
            this.BookingCancelbutton = new System.Windows.Forms.Button();
            this.Bookbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sportsCenterDataSetMemberIcNumberAndMemberIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDetailsTableAdapter = new WindowsFormsApplication14.SportsCenterDataSet_MemberIcNumber_And_MemberIDTableAdapters.MemberDetailsTableAdapter();
            this.sportsFacilityDetailsTableAdapter = new WindowsFormsApplication14.SportsCenterDataSetTableAdapters.SportsFacilityDetailsTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.memberDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sportsFacilityDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCenterDataSet_MemberIcNumber_And_MemberID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCenterDataSetMemberIcNumberAndMemberIDBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2Equipment
            // 
            this.comboBox2Equipment.DataSource = this.sportsFacilityDetailsBindingSource;
            this.comboBox2Equipment.DisplayMember = "EqipmentName";
            this.comboBox2Equipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2Equipment.FormattingEnabled = true;
            this.comboBox2Equipment.Location = new System.Drawing.Point(304, 145);
            this.comboBox2Equipment.Name = "comboBox2Equipment";
            this.comboBox2Equipment.Size = new System.Drawing.Size(121, 21);
            this.comboBox2Equipment.TabIndex = 18;
            this.comboBox2Equipment.ValueMember = "EquipmentID";
            // 
            // sportsFacilityDetailsBindingSource
            // 
            this.sportsFacilityDetailsBindingSource.DataMember = "SportsFacilityDetails";
            this.sportsFacilityDetailsBindingSource.DataSource = this.sportsCenterDataSet;
            // 
            // sportsCenterDataSet
            // 
            this.sportsCenterDataSet.DataSetName = "SportsCenterDataSet";
            this.sportsCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1ICNumber
            // 
            this.comboBox1ICNumber.DataSource = this.memberDetailsBindingSource;
            this.comboBox1ICNumber.DisplayMember = "ICNumber";
            this.comboBox1ICNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1ICNumber.FormattingEnabled = true;
            this.comboBox1ICNumber.Location = new System.Drawing.Point(304, 102);
            this.comboBox1ICNumber.Name = "comboBox1ICNumber";
            this.comboBox1ICNumber.Size = new System.Drawing.Size(121, 21);
            this.comboBox1ICNumber.TabIndex = 17;
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
            // BookingSlotcomboBox
            // 
            this.BookingSlotcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookingSlotcomboBox.FormattingEnabled = true;
            this.BookingSlotcomboBox.Items.AddRange(new object[] {
            "09-10",
            "10-11",
            "11-12",
            "12-01",
            "01-02",
            "02-03",
            "03-04",
            "04-05",
            "05-06",
            "06-07",
            "07-08",
            "08-09"});
            this.BookingSlotcomboBox.Location = new System.Drawing.Point(304, 188);
            this.BookingSlotcomboBox.Name = "BookingSlotcomboBox";
            this.BookingSlotcomboBox.Size = new System.Drawing.Size(54, 21);
            this.BookingSlotcomboBox.TabIndex = 16;
            // 
            // BookingCancelbutton
            // 
            this.BookingCancelbutton.Location = new System.Drawing.Point(351, 260);
            this.BookingCancelbutton.Name = "BookingCancelbutton";
            this.BookingCancelbutton.Size = new System.Drawing.Size(75, 23);
            this.BookingCancelbutton.TabIndex = 15;
            this.BookingCancelbutton.Text = "Cancel";
            this.BookingCancelbutton.UseVisualStyleBackColor = true;
            this.BookingCancelbutton.Click += new System.EventHandler(this.BookingCancelbutton_Click);
            // 
            // Bookbutton
            // 
            this.Bookbutton.Location = new System.Drawing.Point(270, 260);
            this.Bookbutton.Name = "Bookbutton";
            this.Bookbutton.Size = new System.Drawing.Size(75, 23);
            this.Bookbutton.TabIndex = 14;
            this.Bookbutton.Text = "Book";
            this.Bookbutton.UseVisualStyleBackColor = true;
            this.Bookbutton.Click += new System.EventHandler(this.Bookbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Slot :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Equipment :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IC Number :";
            // 
            // sportsCenterDataSetMemberIcNumberAndMemberIDBindingSource
            // 
            this.sportsCenterDataSetMemberIcNumberAndMemberIDBindingSource.DataSource = this.sportsCenterDataSet_MemberIcNumber_And_MemberID;
            this.sportsCenterDataSetMemberIcNumberAndMemberIDBindingSource.Position = 0;
            // 
            // memberDetailsTableAdapter
            // 
            this.memberDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // sportsFacilityDetailsTableAdapter
            // 
            this.sportsFacilityDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // memberDetailsBindingSource1
            // 
            this.memberDetailsBindingSource1.DataMember = "MemberDetails";
            this.memberDetailsBindingSource1.DataSource = this.sportsCenterDataSetMemberIcNumberAndMemberIDBindingSource;
            // 
            // BookingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox2Equipment);
            this.Controls.Add(this.comboBox1ICNumber);
            this.Controls.Add(this.BookingSlotcomboBox);
            this.Controls.Add(this.BookingCancelbutton);
            this.Controls.Add(this.Bookbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingUI";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.BookingUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportsFacilityDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCenterDataSet_MemberIcNumber_And_MemberID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCenterDataSetMemberIcNumberAndMemberIDBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2Equipment;
        private System.Windows.Forms.ComboBox comboBox1ICNumber;
        private System.Windows.Forms.ComboBox BookingSlotcomboBox;
        private System.Windows.Forms.Button BookingCancelbutton;
        private System.Windows.Forms.Button Bookbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sportsCenterDataSetMemberIcNumberAndMemberIDBindingSource;
        private SportsCenterDataSet_MemberIcNumber_And_MemberID sportsCenterDataSet_MemberIcNumber_And_MemberID;
        private System.Windows.Forms.BindingSource memberDetailsBindingSource;
        private SportsCenterDataSet_MemberIcNumber_And_MemberIDTableAdapters.MemberDetailsTableAdapter memberDetailsTableAdapter;
        private SportsCenterDataSet sportsCenterDataSet;
        private System.Windows.Forms.BindingSource sportsFacilityDetailsBindingSource;
        private SportsCenterDataSetTableAdapters.SportsFacilityDetailsTableAdapter sportsFacilityDetailsTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource memberDetailsBindingSource1;
    }
}