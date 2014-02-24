namespace ININ.IceLib.Samples.InteractionsTest
{
    public partial class InteractionQueueListView
    {
        private System.Windows.Forms.ListView _ListView;
        private System.Timers.Timer _Timer;
        private System.Windows.Forms.ContextMenu _ContextMenu;
        private System.Windows.Forms.ImageList _ImageList;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteractionQueueListView));
            this._ListView = new System.Windows.Forms.ListView();
            this._ContextMenu = new System.Windows.Forms.ContextMenu();
            this._ImageList = new System.Windows.Forms.ImageList(this.components);
            this._Timer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this._Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // _ListView
            // 
            this._ListView.ContextMenu = this._ContextMenu;
            this._ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ListView.Enabled = false;
            this._ListView.FullRowSelect = true;
            this._ListView.HideSelection = false;
            this._ListView.Location = new System.Drawing.Point(0, 0);
            this._ListView.MultiSelect = false;
            this._ListView.Name = "_ListView";
            this._ListView.Size = new System.Drawing.Size(150, 150);
            this._ListView.SmallImageList = this._ImageList;
            this._ListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._ListView.TabIndex = 20;
            this._ListView.UseCompatibleStateImageBehavior = false;
            this._ListView.View = System.Windows.Forms.View.Details;
            this._ListView.ItemActivate += new System.EventHandler(this.ListView_ItemActivate);
            this._ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            // 
            // _ContextMenu
            // 
            this._ContextMenu.Popup += new System.EventHandler(this.ContextMenu1_Popup);
            // 
            // _ImageList
            // 
            this._ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ImageList.ImageStream")));
            this._ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this._ImageList.Images.SetKeyName(0, "Callback Normal 16 n t.bmp");
            this._ImageList.Images.SetKeyName(1, "Telephone 16 n i8.ico");
            this._ImageList.Images.SetKeyName(2, "Initiate Chat 16 h i8.ico");
            this._ImageList.Images.SetKeyName(3, "Email Business 16 n i8.ico");
            this._ImageList.Images.SetKeyName(4, "Generic Normal 16 n t.bmp");
            // 
            // _Timer
            // 
            this._Timer.Interval = 1000;
            this._Timer.SynchronizingObject = this;
            this._Timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer1_Elapsed);
            // 
            // InteractionQueueListView
            // 
            this.Controls.Add(this._ListView);
            this.Name = "InteractionQueueListView";
            ((System.ComponentModel.ISupportInitialize)(this._Timer)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}