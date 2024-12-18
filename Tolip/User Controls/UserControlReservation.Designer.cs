namespace Tolip.User_Controls
{
    partial class UserControlReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNo = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageSearchReservation = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndCancelReservation = new System.Windows.Forms.TabPage();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNo1 = new System.Windows.Forms.ComboBox();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClientID1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tabPageUpdateAndCancelReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchReservation);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateAndCancelReservation);
            this.tabControlReservation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlReservation.Location = new System.Drawing.Point(28, 56);
            this.tabControlReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1297, 604);
            this.tabControlReservation.TabIndex = 0;
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.Controls.Add(this.label13);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddReservation.Controls.Add(this.comboBoxNo);
            this.tabPageAddReservation.Controls.Add(this.comboBoxType);
            this.tabPageAddReservation.Controls.Add(this.btnAddReservation);
            this.tabPageAddReservation.Controls.Add(this.textBoxClientID);
            this.tabPageAddReservation.Controls.Add(this.label3);
            this.tabPageAddReservation.Controls.Add(this.textBox4);
            this.tabPageAddReservation.Controls.Add(this.label4);
            this.tabPageAddReservation.Controls.Add(this.textBox5);
            this.tabPageAddReservation.Controls.Add(this.label5);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1289, 570);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add Reservation";
            this.tabPageAddReservation.UseVisualStyleBackColor = true;
            this.tabPageAddReservation.Leave += new System.EventHandler(this.tabPageAddReservation_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Sienna;
            this.label13.Location = new System.Drawing.Point(8, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 23);
            this.label13.TabIndex = 59;
            this.label13.Text = "Add Reservation:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 366);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Out:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut.Location = new System.Drawing.Point(760, 389);
            this.dateTimePickerOut.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(469, 27);
            this.dateTimePickerOut.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "In:";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn.Location = new System.Drawing.Point(60, 389);
            this.dateTimePickerIn.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(469, 27);
            this.dateTimePickerIn.TabIndex = 55;
            // 
            // comboBoxNo
            // 
            this.comboBoxNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo.FormattingEnabled = true;
            this.comboBoxNo.Items.AddRange(new object[] {
            "Please Select ..."});
            this.comboBoxNo.Location = new System.Drawing.Point(760, 206);
            this.comboBoxNo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNo.Name = "comboBoxNo";
            this.comboBoxNo.Size = new System.Drawing.Size(469, 29);
            this.comboBoxNo.TabIndex = 54;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Please Select ....",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType.Location = new System.Drawing.Point(60, 206);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(469, 29);
            this.comboBoxType.TabIndex = 53;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddReservation.BackColor = System.Drawing.Color.Sienna;
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.FlatAppearance.BorderSize = 0;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReservation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(60, 425);
            this.btnAddReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(123, 38);
            this.btnAddReservation.TabIndex = 52;
            this.btnAddReservation.Text = "Add";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID.Location = new System.Drawing.Point(60, 296);
            this.textBoxClientID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(469, 27);
            this.textBoxClientID.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Client ID:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(760, 206);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(469, 27);
            this.textBox4.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(756, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Room No.:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(60, 206);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 27);
            this.textBox5.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Room Type:";
            // 
            // tabPageSearchReservation
            // 
            this.tabPageSearchReservation.Controls.Add(this.label14);
            this.tabPageSearchReservation.Controls.Add(this.dataGridViewReservation);
            this.tabPageSearchReservation.Controls.Add(this.textBoxSearchClientID);
            this.tabPageSearchReservation.Controls.Add(this.label6);
            this.tabPageSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSearchReservation.Name = "tabPageSearchReservation";
            this.tabPageSearchReservation.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSearchReservation.Size = new System.Drawing.Size(1289, 570);
            this.tabPageSearchReservation.TabIndex = 1;
            this.tabPageSearchReservation.Text = "Search Reservation";
            this.tabPageSearchReservation.UseVisualStyleBackColor = true;
            this.tabPageSearchReservation.Enter += new System.EventHandler(this.tabPageSearchReservation_Enter);
            this.tabPageSearchReservation.Leave += new System.EventHandler(this.tabPageSearchReservation_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Sienna;
            this.label14.Location = new System.Drawing.Point(4, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "Search Reservation:";
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewReservation.Location = new System.Drawing.Point(0, 241);
            this.dataGridViewReservation.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersWidth = 51;
            this.dataGridViewReservation.Size = new System.Drawing.Size(1289, 329);
            this.dataGridViewReservation.TabIndex = 11;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Reservation_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Reservation_Room_Type";
            this.Column2.HeaderText = "Room Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Reservation_Room_Number";
            this.Column3.HeaderText = "Room No.";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Reservation_Client_ID";
            this.Column4.HeaderText = "Client ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Reservation_In";
            this.Column5.HeaderText = "In";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Reservation_Out";
            this.Column6.HeaderText = "Out";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // textBoxSearchClientID
            // 
            this.textBoxSearchClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchClientID.Location = new System.Drawing.Point(178, 182);
            this.textBoxSearchClientID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchClientID.Name = "textBoxSearchClientID";
            this.textBoxSearchClientID.Size = new System.Drawing.Size(469, 27);
            this.textBoxSearchClientID.TabIndex = 10;
            this.textBoxSearchClientID.TextChanged += new System.EventHandler(this.textBoxSearchClientID_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Client ID:";
            // 
            // tabPageUpdateAndCancelReservation
            // 
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.buttonCancel);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label7);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.dateTimePickerOut1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label8);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.dateTimePickerIn1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.comboBoxNo1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label9);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.textBoxClientID1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label10);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.textBox2);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label11);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.textBox3);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label12);
            this.tabPageUpdateAndCancelReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndCancelReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageUpdateAndCancelReservation.Name = "tabPageUpdateAndCancelReservation";
            this.tabPageUpdateAndCancelReservation.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageUpdateAndCancelReservation.Size = new System.Drawing.Size(1289, 570);
            this.tabPageUpdateAndCancelReservation.TabIndex = 2;
            this.tabPageUpdateAndCancelReservation.Text = "Update and Cancel Reservation";
            this.tabPageUpdateAndCancelReservation.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndCancelReservation.Leave += new System.EventHandler(this.tabPageUpdateAndCancelReservation_Leave);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(187, 419);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(123, 38);
            this.buttonCancel.TabIndex = 45;
            this.buttonCancel.Text = "Delete";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Out:";
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut1.Location = new System.Drawing.Point(756, 383);
            this.dateTimePickerOut1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(469, 27);
            this.dateTimePickerOut1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 360);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "In:";
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn1.Location = new System.Drawing.Point(56, 383);
            this.dateTimePickerIn1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(469, 27);
            this.dateTimePickerIn1.TabIndex = 41;
            // 
            // comboBoxNo1
            // 
            this.comboBoxNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxNo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo1.FormattingEnabled = true;
            this.comboBoxNo1.Items.AddRange(new object[] {
            "Please Select ..."});
            this.comboBoxNo1.Location = new System.Drawing.Point(756, 200);
            this.comboBoxNo1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNo1.Name = "comboBoxNo1";
            this.comboBoxNo1.Size = new System.Drawing.Size(469, 29);
            this.comboBoxNo1.TabIndex = 40;
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Please Select ....",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType1.Location = new System.Drawing.Point(56, 200);
            this.comboBoxType1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(469, 29);
            this.comboBoxType1.TabIndex = 39;
            this.comboBoxType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxType1_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.Sienna;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(56, 419);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(123, 38);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Update and Cancel Reservation:";
            // 
            // textBoxClientID1
            // 
            this.textBoxClientID1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID1.Location = new System.Drawing.Point(56, 290);
            this.textBoxClientID1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClientID1.Name = "textBoxClientID1";
            this.textBoxClientID1.Size = new System.Drawing.Size(469, 27);
            this.textBoxClientID1.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Client ID:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(756, 200);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(469, 27);
            this.textBox2.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(752, 163);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 33;
            this.label11.Text = "Room No.:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(56, 200);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 27);
            this.textBox3.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(52, 163);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "Room Type:";
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReservation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1363, 712);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchReservation.ResumeLayout(false);
            this.tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tabPageUpdateAndCancelReservation.ResumeLayout(false);
            this.tabPageUpdateAndCancelReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.TabPage tabPageSearchReservation;
        private System.Windows.Forms.TabPage tabPageUpdateAndCancelReservation;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox textBoxSearchClientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.ComboBox comboBoxNo1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxClientID1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox comboBoxNo;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
    }
}
