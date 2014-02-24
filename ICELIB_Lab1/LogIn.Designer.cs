namespace ICELIB_Lab1
{
    partial class LogIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnError = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdQueue = new System.Windows.Forms.DataGridView();
            this.txtRemoteAddress = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDirectories = new System.Windows.Forms.Button();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.holdCall = new System.Windows.Forms.PictureBox();
            this.muteCall = new System.Windows.Forms.PictureBox();
            this.disconnectCall = new System.Windows.Forms.PictureBox();
            this.answerCall = new System.Windows.Forms.PictureBox();
            this.grpDirectory = new System.Windows.Forms.GroupBox();
            this.btnRemoveTab = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdDirectory = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueue)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holdCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerCall)).BeginInit();
            this.grpDirectory.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDirectory)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLabel,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsLabel
            // 
            this.stsLabel.Name = "stsLabel";
            this.stsLabel.Size = new System.Drawing.Size(70, 17);
            this.stsLabel.Text = "Logged Out";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkBox1);
            this.flowLayoutPanel3.Controls.Add(this.btnLogin);
            this.flowLayoutPanel3.Controls.Add(this.checkBox2);
            this.flowLayoutPanel3.Controls.Add(this.btnError);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(9, 253);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(296, 88);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Windows Auth";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(95, 35);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(95, 9, 3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 32);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(176, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 20);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Stationless";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnError
            // 
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.Image = global::ICELIB_Lab1.Properties.Resources.alert;
            this.btnError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnError.Location = new System.Drawing.Point(176, 35);
            this.btnError.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(42, 32);
            this.btnError.TabIndex = 3;
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Visible = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 222);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.lblServer);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(113, 209);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 17, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Station";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(3, 153);
            this.lblServer.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(54, 16);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Server";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtUName);
            this.flowLayoutPanel1.Controls.Add(this.txtPWD);
            this.flowLayoutPanel1.Controls.Add(this.txtStation);
            this.flowLayoutPanel1.Controls.Add(this.txtServer);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(122, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 209);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(3, 30);
            this.txtUName.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(161, 22);
            this.txtUName.TabIndex = 0;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(3, 70);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '#';
            this.txtPWD.Size = new System.Drawing.Size(161, 22);
            this.txtPWD.TabIndex = 1;
            this.txtPWD.Text = "1234";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(3, 110);
            this.txtStation.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(161, 22);
            this.txtStation.TabIndex = 2;
            this.txtStation.Text = "Test1_1";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(3, 150);
            this.txtServer.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(161, 22);
            this.txtServer.TabIndex = 3;
            this.txtServer.Text = "davis02";
            this.txtServer.Leave += new System.EventHandler(this.txtServer_Leave);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.panel1);
            this.grpLogin.Controls.Add(this.flowLayoutPanel3);
            this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.grpLogin.Location = new System.Drawing.Point(12, 27);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(311, 350);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 197);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(239, 306);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 35);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.grdQueue);
            this.panel2.Controls.Add(this.txtRemoteAddress);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 240);
            this.panel2.TabIndex = 3;
            // 
            // grdQueue
            // 
            this.grdQueue.AllowUserToAddRows = false;
            this.grdQueue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Moire", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.grdQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdQueue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQueue.Enabled = false;
            this.grdQueue.Location = new System.Drawing.Point(-1, 28);
            this.grdQueue.Name = "grdQueue";
            this.grdQueue.ReadOnly = true;
            this.grdQueue.RowHeadersVisible = false;
            this.grdQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdQueue.Size = new System.Drawing.Size(299, 128);
            this.grdQueue.TabIndex = 10;
            this.grdQueue.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdQueue_CellFormatting);
            // 
            // txtRemoteAddress
            // 
            this.txtRemoteAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRemoteAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRemoteAddress.Location = new System.Drawing.Point(-1, 3);
            this.txtRemoteAddress.Name = "txtRemoteAddress";
            this.txtRemoteAddress.Size = new System.Drawing.Size(205, 22);
            this.txtRemoteAddress.TabIndex = 7;
            this.txtRemoteAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemoteAddress_KeyPress);
            this.txtRemoteAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRemoteAddress_KeyUp);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(206, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Make Call";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDirectories
            // 
            this.btnDirectories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectories.ForeColor = System.Drawing.Color.White;
            this.btnDirectories.Location = new System.Drawing.Point(206, 3);
            this.btnDirectories.Name = "btnDirectories";
            this.btnDirectories.Size = new System.Drawing.Size(88, 28);
            this.btnDirectories.TabIndex = 8;
            this.btnDirectories.Text = "Directory";
            this.btnDirectories.UseVisualStyleBackColor = true;
            this.btnDirectories.Click += new System.EventHandler(this.btnDirectories_Click);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.panel4);
            this.grpStatus.Controls.Add(this.btnLogOut);
            this.grpStatus.Controls.Add(this.panel2);
            this.grpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatus.ForeColor = System.Drawing.Color.Black;
            this.grpStatus.Location = new System.Drawing.Point(340, 27);
            this.grpStatus.Margin = new System.Windows.Forms.Padding(0);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(311, 350);
            this.grpStatus.TabIndex = 4;
            this.grpStatus.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.holdCall);
            this.panel4.Controls.Add(this.muteCall);
            this.panel4.Controls.Add(this.btnDirectories);
            this.panel4.Controls.Add(this.disconnectCall);
            this.panel4.Controls.Add(this.answerCall);
            this.panel4.Location = new System.Drawing.Point(3, 173);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 32);
            this.panel4.TabIndex = 8;
            // 
            // holdCall
            // 
            this.holdCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.holdCall.Image = global::ICELIB_Lab1.Properties.Resources.sync;
            this.holdCall.Location = new System.Drawing.Point(117, 0);
            this.holdCall.Name = "holdCall";
            this.holdCall.Size = new System.Drawing.Size(32, 32);
            this.holdCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.holdCall.TabIndex = 9;
            this.holdCall.TabStop = false;
            this.holdCall.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // muteCall
            // 
            this.muteCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteCall.Image = global::ICELIB_Lab1.Properties.Resources.chat;
            this.muteCall.Location = new System.Drawing.Point(79, 0);
            this.muteCall.Name = "muteCall";
            this.muteCall.Size = new System.Drawing.Size(32, 32);
            this.muteCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.muteCall.TabIndex = 8;
            this.muteCall.TabStop = false;
            this.muteCall.Click += new System.EventHandler(this.muteCall_Click);
            // 
            // disconnectCall
            // 
            this.disconnectCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnectCall.Image = global::ICELIB_Lab1.Properties.Resources.cancel;
            this.disconnectCall.Location = new System.Drawing.Point(41, 0);
            this.disconnectCall.Name = "disconnectCall";
            this.disconnectCall.Size = new System.Drawing.Size(32, 32);
            this.disconnectCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disconnectCall.TabIndex = 7;
            this.disconnectCall.TabStop = false;
            this.disconnectCall.Click += new System.EventHandler(this.disconnectCall_Click);
            // 
            // answerCall
            // 
            this.answerCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerCall.Image = global::ICELIB_Lab1.Properties.Resources.accept;
            this.answerCall.InitialImage = global::ICELIB_Lab1.Properties.Resources.accept;
            this.answerCall.Location = new System.Drawing.Point(3, 0);
            this.answerCall.Name = "answerCall";
            this.answerCall.Size = new System.Drawing.Size(32, 32);
            this.answerCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerCall.TabIndex = 6;
            this.answerCall.TabStop = false;
            this.answerCall.Click += new System.EventHandler(this.answerCall_Click);
            // 
            // grpDirectory
            // 
            this.grpDirectory.Controls.Add(this.btnRemoveTab);
            this.grpDirectory.Controls.Add(this.button4);
            this.grpDirectory.Controls.Add(this.button2);
            this.grpDirectory.Controls.Add(this.button1);
            this.grpDirectory.Controls.Add(this.panel3);
            this.grpDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDirectory.ForeColor = System.Drawing.Color.Black;
            this.grpDirectory.Location = new System.Drawing.Point(672, 27);
            this.grpDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.grpDirectory.Name = "grpDirectory";
            this.grpDirectory.Size = new System.Drawing.Size(311, 350);
            this.grpDirectory.TabIndex = 5;
            this.grpDirectory.TabStop = false;
            // 
            // btnRemoveTab
            // 
            this.btnRemoveTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTab.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTab.Image = global::ICELIB_Lab1.Properties.Resources.remove;
            this.btnRemoveTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveTab.Location = new System.Drawing.Point(143, 316);
            this.btnRemoveTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveTab.Name = "btnRemoveTab";
            this.btnRemoveTab.Size = new System.Drawing.Size(103, 34);
            this.btnRemoveTab.TabIndex = 5;
            this.btnRemoveTab.Text = "     Remove";
            this.btnRemoveTab.UseVisualStyleBackColor = true;
            this.btnRemoveTab.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::ICELIB_Lab1.Properties.Resources.add;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(57, 316);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "     Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 316);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(246, 316);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(6, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 295);
            this.panel3.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(297, 293);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl1_ControlAdded);
            this.tabControl1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl1_ControlRemoved);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdDirectory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(289, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Company Directory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdDirectory
            // 
            this.grdDirectory.AllowUserToAddRows = false;
            this.grdDirectory.AllowUserToDeleteRows = false;
            this.grdDirectory.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Moire", 7F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.grdDirectory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Moire", 7F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDirectory.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDirectory.Location = new System.Drawing.Point(3, 3);
            this.grdDirectory.MultiSelect = false;
            this.grdDirectory.Name = "grdDirectory";
            this.grdDirectory.ReadOnly = true;
            this.grdDirectory.RowHeadersVisible = false;
            this.grdDirectory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDirectory.Size = new System.Drawing.Size(283, 261);
            this.grdDirectory.TabIndex = 0;
            this.grdDirectory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDirectory_CellContentClick);
            this.grdDirectory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdDirectory_CellMouseDoubleClick);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 24);
            this.panel5.TabIndex = 6;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::ICELIB_Lab1.Properties.Resources.power;
            this.pictureBox3.Location = new System.Drawing.Point(294, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1008, 419);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.grpDirectory);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICELIB Lab 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueue)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.holdCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerCall)).EndInit();
            this.grpDirectory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDirectory)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtRemoteAddress;
        private System.Windows.Forms.GroupBox grpDirectory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grdDirectory;
        private System.Windows.Forms.Button btnDirectories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdQueue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox holdCall;
        private System.Windows.Forms.PictureBox muteCall;
        private System.Windows.Forms.PictureBox disconnectCall;
        private System.Windows.Forms.PictureBox answerCall;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRemoveTab;
    }
}

