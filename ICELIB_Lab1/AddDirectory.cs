using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ICELIB_Lab1;
using ININ;
using ININ.IceLib;
using ININ.IceLib.Directories;
namespace ICELIB_Lab1
{
    public partial class AddDirectory : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private ICELibWrapper connection;
        private TabControl TabController;
        private TabPage SampleTab;
        public ContactDirectory WatchedDirectory;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public AddDirectory(ref ICELibWrapper wrapper, ref TabControl Tabs)
        {
            InitializeComponent();
            connection = wrapper;
            TabController = Tabs;
        }
        
        private TabPage TabBuilder()
        {
            TabPage tempTab = new TabPage();
            DataGridView dg = new DataGridView();
            dg.Name = WatchedDirectory.Metadata.DisplayName;
            tempTab.Text = WatchedDirectory.Metadata.DisplayName;
            dg.DataSource = WatchedDirectory.GetList();
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            tempTab.Controls.Add(dg);
            return tempTab;
        }
        private void addTab()
        {
            TabController.TabPages.Add(TabBuilder());
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AddDirectory_Load(object sender, EventArgs e)
        {
            lstDirectoryType.DataSource = connection.GetDirectoryCategories();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstDirectoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDirectories.DisplayMember = "DisplayName";
            lstDirectories.DataSource = connection.GetDirectoriesFromCategory(connection.GetDirectoryCategories()[lstDirectoryType.SelectedIndex]);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            WatchedDirectory = connection.WatchDirecotry(connection.GetDirectoriesFromCategory(connection.GetDirectoryCategories()[lstDirectoryType.SelectedIndex])[lstDirectories.SelectedIndex]);
            addTab();
            this.Close();
        }
    }
}
