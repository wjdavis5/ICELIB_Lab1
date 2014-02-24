using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Runtime.InteropServices;
using ININ.IceLib;
namespace ICELIB_Lab1
{
    public partial class LogIn : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static bool _validServer = false;
        private const int SLIDEDISTANCE = 327;
        private bool needMove = true;
        public ICELibWrapper connection;
        private bool isStatusChange;
        private ImageList statusImageList;
        private TabPage CompanyDirectory;
        public LogIn()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPWD.Enabled = !checkBox1.Checked;
            txtUName.Enabled = !checkBox1.Checked;
            if (checkBox1.Checked)
                txtUName.Text = Environment.UserName;

        }

        private void txtServer_Leave(object sender, EventArgs e)
        {
            TextBox tempTxt = sender as TextBox;
            var t = Task.Factory.StartNew(() =>
            {
                if (ping(tempTxt.Text))
                    _validServer = true;
                else
                    _validServer = false;
            }).ContinueWith((t2) =>
                {
                    if (!_validServer)
                    {
                        ExecuteSecure(() => txtServer.ForeColor = Color.Red);
                        ExecuteSecure(() => lblServer.ForeColor = Color.Red);
                        ExecuteSecure(() => stsLabel.Text = "Ping Failed!");
                        ExecuteSecure(() => btnLogin.Enabled = false);
                    }
                    else
                    {
                        ExecuteSecure(() => txtServer.ForeColor = Color.Green);
                        ExecuteSecure(() => lblServer.ForeColor = Color.Green);
                        ExecuteSecure(() => stsLabel.Text = "Ping Success!");
                        ExecuteSecure(() => btnLogin.Enabled = true);
                    }
                });
        }
        private void ExecuteSecure(Action a)
        {
            if (InvokeRequired)
                BeginInvoke(a);
            else a();
        }
        private void EnableQueue()
        {
            var t = Task.Factory.StartNew(() =>
            ExecuteSecure(() =>
                {
                    grdQueue.DataSource = connection.Interactions;
                    grdQueue.Enabled = true;
                })).ContinueWith((t2) => 
                    ExecuteSecure(() => grdQueue.Update()));
        }
        private static bool ping(string server)
        {
                    using (Ping p = new Ping())
                    {
                        PingReply r;
                        try
                        {
                            r = p.Send(server);
                            if (r.Status == IPStatus.Success)
                                return true;
                            else return false;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                            
                    }

        }
        private void SaveSettings()
        {
            Properties.Settings.Default.Password = txtPWD.Text;
            Properties.Settings.Default.Username = txtUName.Text;
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Station = txtStation.Text;
            Properties.Settings.Default.WindowsAuth = checkBox1.Checked;
            Properties.Settings.Default.StationLess = checkBox2.Checked;
            Properties.Settings.Default.Save();

        }
        private void LoadSettings()
        {

            txtPWD.Text = Properties.Settings.Default.Password;
            txtUName.Text = Properties.Settings.Default.Username;
            txtServer.Text = Properties.Settings.Default.Server;
            txtStation.Text = Properties.Settings.Default.Station;
            checkBox1.Checked = Properties.Settings.Default.WindowsAuth;
            checkBox2.Checked = Properties.Settings.Default.StationLess;

        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            LoadSettings();
            this.Width = 311 + 12 + 11;
            btnLogin.Enabled = false;
            txtServer.Select();
            ToolTip answerCallTip = new ToolTip();
            answerCallTip.SetToolTip(answerCall, "Click to Answer");
            answerCallTip.ToolTipTitle = "Answer";
            ToolTip disCallTIp = new ToolTip();
            disCallTIp.SetToolTip(disconnectCall, "Disconnect Call");
            disCallTIp.ToolTipTitle = "Disconnect";
            ToolTip muteTip = new ToolTip();
            muteTip.SetToolTip(muteCall, "Mute Call");
            muteTip.ToolTipTitle = "Mute";
            ToolTip holdTip = new ToolTip();
            holdTip.SetToolTip(holdCall, "Hold Call");
            holdTip.ToolTipTitle = "Hold";
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtStation.Enabled = !checkBox2.Checked;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SaveSettings();
            grdQueue.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            grdQueue.DefaultCellStyle = new DataGridViewCellStyle();
            
            needMove = true;
            isStatusChange = false;
            comboBox1.Items.Clear();
            ExecuteSecure(() => btnError.Visible = false);
            stsLabel.Text = "Trying to Connect";
            connection = new ICELibWrapper(txtUName.Text, txtPWD.Text, txtServer.Text, checkBox1.Checked, checkBox2.Checked, txtStation.Text,ConnectionCallback);
            connection.ConnectionExceptionss.Clear();
            connection.StatusChangedCallback = ConnectionCallback;
            connection.WatchingQueueCompleted = EnableQueue;
            connection.DirectoryConfigurationCallbackAction = DirectoryConfigurationCallback;
            connection.UpdateQueueList = UpdateQueueListCallback;
        }
        private void UpdateQueueListCallback()
        {
            var t = Task.Factory.StartNew(() =>
                {
                    ExecuteSecure(() =>
                        {
                            grdQueue.Update();
                        });
                }).ContinueWith((t2) =>
                    {
                        ExecuteSecure(() =>
                            {
                            });
                    });
        }
        private void DirectoryConfigurationCallback()
        {
            var t = Task.Factory.StartNew(() =>
                {
                    ExecuteSecure(() => connection.WatchDirectory(ININ.IceLib.Directories.DirectoryMetadataCategory.Company));
                }).ContinueWith((t2) =>
                    {
                        ExecuteSecure(() => grdDirectory.DataSource = connection.DirectoryContacts);
                        if (connection.DirectoryContacts != null)
                        {
                            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                            var t3 = Task.Factory.StartNew(() =>
                                {
                                    foreach (ININ.IceLib.Directories.ContactEntry c in connection.DirectoryContacts)
                                    {
                                        autoCompleteCollection.Add(c.Extension);
                                    }
                                }).ContinueWith((t4) => ExecuteSecure(() => txtRemoteAddress.AutoCompleteCustomSource = new AutoCompleteStringCollection()));
                        }
                    });
        }
        private void BackupCompanyDirectoryPriorToRemoval()
        {
            try
            {
                TabPage tempTab = tabControl1.SelectedTab;
                Control[] tempControls = new Control[tabControl1.SelectedTab.Controls.Count];
                tabControl1.SelectedTab.Controls.CopyTo(tempControls, 0);
                tempTab.Controls.AddRange(tempControls);
                CompanyDirectory = tempTab;
            }
            catch (NullReferenceException) { }
        }
        private void doSlide(GroupBox MoveThis)
        {
            //location 12,27
            var t = Task.Factory.StartNew(() =>
                {
                    ExecuteSecure(() =>
                        {
                            //foreach (GroupBox box in this.Controls)
                            foreach (GroupBox box in this.Controls.OfType<GroupBox>())
                            {
                                if (box != MoveThis)
                                {
                                    box.Left = (-1) * box.Width;
                                }
                                else
                                {
                                    do
                                    {
                                        if (box.Left > 12)
                                            box.Left--;
                                        else
                                            box.Left++;
                                    }
                                    while (box.Left != 12);
                                }
                            }

                        });
                });
                
        }
        private void doSlide(ININ.IceLib.Connection.ConnectionState ConnState)
        {
            //location 12,27
            if (ConnState == ININ.IceLib.Connection.ConnectionState.Attempting) return;
            if (ConnState == ININ.IceLib.Connection.ConnectionState.Up && needMove)
            {
                needMove = false;
                ExecuteSecure(() =>
                {
                    for (int x = 0; x < SLIDEDISTANCE; x++)
                    {
                        grpLogin.Left--;
                        grpStatus.Left--;

                    }
                    
                });
            }
            else if (needMove &&  grpLogin.Left <0) 
            {
                needMove = false;
                ExecuteSecure(() =>
                {
                    for (int x = 0; x < SLIDEDISTANCE; x++)
                    {
                        grpLogin.Left++;
                        grpStatus.Left++;
                       
                    }
                    
                });
            }
        }
        private void ConnectionCallback()
        {
            if (connection.Session.ConnectionState == ININ.IceLib.Connection.ConnectionState.Up)
            {
                ExecuteSecure(() => stsLabel.Text = "Session Connected : " + connection.Session.SessionId.ToString());
                ExecuteSecure(() => btnLogin.Enabled = false);
                ExecuteSecure(() => btnError.Visible = false);
                doSlide(grpStatus);
               // doSlide(ININ.IceLib.Connection.ConnectionState.Up);
                connection.SetPeopleManager();
                Task t = null;
                if (!isStatusChange)
                {
                    isStatusChange = true;
                     t = Task.Factory.StartNew(() =>
                        {
                            foreach (string d in connection.PopulateStatusList())
                            {
                               // ExecuteSecure(() => listView1.Items.Add(d));
                                ExecuteSecure(() => comboBox1.Items.Add(d));
                            }
                            
                            ExecuteSecure(() => statusImageList = connection.StatusImageList);
                        }).ContinueWith((t2) =>
                            {
                                ExecuteSecure(() => comboBox1.SelectedItem = connection.CurrentStatus.MessageText);
                            });
                }
                if(t == null)
                    ExecuteSecure(() => comboBox1.SelectedItem = connection.CurrentStatus.MessageText);
                
            }
            else if (connection.Session.ConnectionState == ININ.IceLib.Connection.ConnectionState.Down)
            {
                ExecuteSecure(() => stsLabel.Text = "Disconnected! ");
                ExecuteSecure(() => btnLogin.Enabled = true);
                needMove = true;
                //doSlide(ININ.IceLib.Connection.ConnectionState.None);
                doSlide(grpLogin);
                if (connection.ConnectionExceptionss.Count > 0)
                {
                    ExecuteSecure(() =>
                    {
                        ToolTip tempTT = new ToolTip();
                        tempTT.SetToolTip(btnError, connection.ConnectionExceptionss[0].Message);
                        tempTT.Show(connection.ConnectionExceptionss[0].Message, this, 4000);
                    });
                    ExecuteSecure(() => stsLabel.Text = "Connection Failed! ");
                    ExecuteSecure(() => btnError.Visible = true);
                    ExecuteSecure(() => btnLogin.Enabled = true);
                }
                
            }
            else if (connection.Session.ConnectionState != ININ.IceLib.Connection.ConnectionState.Attempting) 
            {
                ExecuteSecure(() =>
                    {
                        ToolTip tempTT = new ToolTip();
                        tempTT.SetToolTip(btnError, connection.ConnectionExceptionss[0].Message);
                        tempTT.Show(connection.ConnectionExceptionss[0].Message, this,4000);
                    });
                ExecuteSecure(() => stsLabel.Text = "Connection Failed! ");
                ExecuteSecure(() => btnError.Visible = true);
                ExecuteSecure(() => btnLogin.Enabled = true);
                
            }
        }
        private void btnError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connection.ConnectionExceptionss[0].Message);
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            doLogout();
        }
        private bool doLogout()
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Logout?", MessageBoxButtons.YesNo);
            if( answer == DialogResult.Yes)
            {
                try
                {
                    SaveSettings();
                    comboBox1.Items.Clear();
                    isStatusChange = false;
                    needMove = true;
                    stsLabel.Text = "Disconnecting";
                    connection.disconnectionAsync();
                    return true;
                }
                catch (NullReferenceException) { return true; }
            }
            return false;
        }
        private string GetSelectedStatus()
        {
            if (comboBox1.SelectedIndex >= 0)
                return comboBox1.SelectedItem.ToString();
            else
                return string.Empty;
        }
        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            isStatusChange = true;
            connection.ChangeUserStatus(GetSelectedStatus());
        }
        private void logOut()
        {
            comboBox1.Items.Clear();
            isStatusChange = false;
            needMove = true;
            stsLabel.Text = "Disconnecting";
            connection.disconnectionAsync();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            pictureBox1.Image = statusImageList.Images[comboBox1.SelectedIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtRemoteAddress.TextLength > 0)
                connection.MakeCall(txtRemoteAddress.Text);
            else
                MessageBox.Show("Please enter a phone number");
            txtRemoteAddress.Text = string.Empty;
            
        }

        private void btnDirectories_Click(object sender, EventArgs e)
        {
            doSlide(grpDirectory);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            doSlide(grpStatus);
        }

        private void grdDirectory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdDirectory.Rows[e.RowIndex].Cells["Extension"].Value.ToString().Length > 0)
            {
                var t = Task.Factory.StartNew(() =>
                    {
                        ExecuteSecure(() => connection.MakeCall(grdDirectory.Rows[e.RowIndex].Cells["Extension"].Value.ToString()));
                        ExecuteSecure(() => doSlide(grpStatus));
                    });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doLogout();
        }

        private void answerCall_Click(object sender, EventArgs e)
        {
            connection.AnswerInteraction(grdQueue.SelectedRows[0].Cells["CallID"].Value.ToString());
        }

        private void disconnectCall_Click(object sender, EventArgs e)
        {
            connection.DisconnectInteraction(grdQueue.SelectedRows[0].Cells["CallID"].Value.ToString());
        }

        private void grdDirectory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdQueue_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
            var t = Task.Factory.StartNew(() =>
                {
                    if (e.Value.ToString().Contains("Connected"))
                    {
                        ExecuteSecure(() =>
                            {
                                
                                e.CellStyle.ForeColor = Color.Black;
                                e.CellStyle.BackColor = Color.White;
                                e.CellStyle.SelectionBackColor = Color.AntiqueWhite;
                                e.CellStyle.SelectionForeColor = Color.Black;
                            });
                    }
                    else if (e.Value.ToString().Contains("Hold"))
                    {
                        ExecuteSecure(() =>
                            {
                                e.CellStyle.ForeColor = Color.Red;
                                e.CellStyle.BackColor = Color.White;
                                e.CellStyle.SelectionBackColor = Color.AntiqueWhite;
                                e.CellStyle.SelectionForeColor = Color.Red;
                            });
                    }
                    else if (e.Value.ToString().Contains("Alert"))
                    {
                        ExecuteSecure(() =>
                            {
                                e.CellStyle.ForeColor = Color.Yellow;
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.SelectionBackColor = Color.Red;
                                e.CellStyle.SelectionForeColor = Color.White;
                            });

                    }
                    else
                    {
                        ExecuteSecure(() =>
                            {
                                e.CellStyle.ForeColor = Color.LightGray;
                                e.CellStyle.BackColor = Color.DarkGray;
                                e.CellStyle.SelectionBackColor = Color.LightGray;
                                e.CellStyle.SelectionForeColor = Color.DarkGray;
                            });
                    }
                });
            */

        }

        private void muteCall_Click(object sender, EventArgs e)
        {
            connection.MuteInteraction(grdQueue.SelectedRows[0].Cells["CallID"].Value.ToString());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            connection.HoldInteraction(grdQueue.SelectedRows[0].Cells["CallID"].Value.ToString());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(doLogout())
                Application.Exit();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtRemoteAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button3_Click(sender, e);
            }
        }

        private void txtRemoteAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackupCompanyDirectoryPriorToRemoval();
            AddDirectory add = new AddDirectory(ref connection, ref tabControl1);
            add.ShowDialog(this);
            /*
            TabPage tempTabPage = new TabPage("New");
            DataGridView dgw = new DataGridView();
            dgw.Dock = DockStyle.Fill;
            dgw.Name = "Directory" + (tabControl1.TabPages.Count+1).ToString();
            tempTabPage.Controls.Add(dgw);
            tabControl1.TabPages.Add(CompanyDirectory);
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?\r\nClosing: " + tabControl1.SelectedTab.Text, "Close Tab", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                var t = Task.Factory.StartNew(() =>
                    {
                        ExecuteSecure(() =>
                            {
                                if (tabControl1.SelectedTab.Text == "Company Directory")
                                {
                                    BackupCompanyDirectoryPriorToRemoval();
                                }
                                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                            });
                    }).ContinueWith((t2) =>
                        {
                            ExecuteSecure(() =>
                                {
                                    if (tabControl1.TabPages.Count < 1)
                                        btnRemoveTab.Enabled = false;
                                });
                        });
            }
        }

        private void tabControl1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (tabControl1.TabPages.Count < 1)
                btnRemoveTab.Enabled = false;   
        }

        private void tabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            btnRemoveTab.Enabled = true;
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        

       
    }
}
