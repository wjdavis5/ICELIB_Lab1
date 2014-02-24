using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using ININ;
using ININ.IceLib;
using ININ.IceLib.People;
using ININ.IceLib.Connection;
using ININ.IceLib.Interactions;
using ININ.IceLib.Directories;
namespace ICELIB_Lab1
{
    public class ICELibWrapper
    {
        #region Props
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public string Station { get; set; }
        public bool StationLess { get; set; }
        public bool WindowsAuth { get; set; }
        public AuthSettings AuthSettings { get;  set; }
        public StationSettings StationSettings { get;  set; }
        public SessionSettings SessionSettings { get;  set; }
        public Session Session { get;  set; }
        public PeopleManager PeopleManager { get;  set; }
        public HostSettings HostSettings { get;  set; }
        public Action ConnectionCompleted { get; set; }
        public UserStatusList UserStatusList { get; set; }
        public System.Windows.Forms.ImageList StatusImageList { get; private set; }
        public Action ConnectionStateChangedHandler { get; set; }
        public StatusMessageDetails CurrentStatus { get
            {
                if (UserStatus == null)
                {
                    if (UserStatusList == null)
                    {
                        UserStatusList = new UserStatusList(PeopleManager);
                    }
                    UserStatus = UserStatusList.GetUserStatus(PeopleManager.Session.UserId);
                }
            
            return UserStatus.StatusMessageDetails; } private set { CurrentStatus = value; } }
        public List<Exception> ConnectionExceptionss { get;  private set; }
        public UserStatus UserStatus { get; private set; }
        public Action StatusChangedCallback { get; set; }
        private bool isStatusCallbackSet = false;
        public InteractionQueue InteractionQueue { get; private set; }
        public Action WatchingQueueCompleted { get; set; }
        public DirectoriesManager DirectoriesManager {get; private set;}
        public DirectoryConfiguration DirectoryConfiguration { get; private set; }
        public ContactDirectory WatchedDirectory { get; private set; }
        public List<ContactEntry> DirectoryContacts
            {
                 get
                 {
                     if (WatchedDirectory != null)
                         return WatchedDirectory.GetList().ToList<ContactEntry>();
                     else
                         return null;
                 }
           }
        public Action DirectoryConfigurationCallbackAction { get; set; }
        //public List<Interaction> Interactions { get { return InteractionQueue.GetContents().ToList<Interaction>(); } }
        public List<InternalInteractions.InternalInteraction> Interactions 
        {
            get
            {
                try
                {
                    InternalInteractions tempI = new InternalInteractions(InteractionQueue.GetContents().ToList<Interaction>());
                    return tempI.InternalInteractionss;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public Action UpdateQueueList { get; set; }
        #endregion
        #region Constructors
        ICELibWrapper()
        { }
        /// <summary>
        /// Does all the work and then Calls the callback
        /// </summary>
        public ICELibWrapper(string User, string Pass, string server,
            bool UseWindowsAuth,bool UseStationLess, string station,Action Callback)
        {
            UserName = User;
            Password = Pass;
            Server = server;
            Station = station;
            WindowsAuth = UseWindowsAuth;
            StationLess = UseStationLess;
            SetSessionSettings();
            SetAuthSettings();
            SetHostSettings();
            SetStationSettings();
            ConnectionCompleted = Callback;
            SetConnectionStateChangedHandler(Callback);
            ConnectionExceptionss = new List<Exception>();
            ConnectAsync();
            
        }
        #endregion
        #region Members
        public void SetSessionSettings()
        {
            SessionSettings = new SessionSettings();
            SessionSettings.ClassOfService = ClassOfService.General;
            SessionSettings.ApplicationName = "ICELIB Lab 1";
            SessionSettings.IsoLanguage = "en-US";
            
        }
        public void SetAuthSettings()
        {
            if (WindowsAuth)
                AuthSettings = new WindowsAuthSettings();
            else
                AuthSettings = new ICAuthSettings(UserName,Password);
        }
        public void SetHostSettings()
        {
            HostSettings = new HostSettings();
            HostSettings.HostEndpoint = new HostEndpoint(Server, HostEndpoint.DefaultPort);
        }
        public void SetStationSettings()
        {
            if (!StationLess)
                StationSettings = new WorkstationSettings(Station, SupportedMedia.None);
            else
                StationSettings = new StationlessSettings();
        }
        public void ConnectAsync()
        {
            Session = new ININ.IceLib.Connection.Session();
            Session.ConnectionStateChanged += delegate { ConnectionStateChangedHandler(); };
            Session.ConnectAsync(SessionSettings, HostSettings, AuthSettings,
                StationSettings, ConnectCompleted, null);
        }
        public void EmptyCallBack(object sender, AsyncCompletedEventArgs e)
        {
        }
        public void ConnectCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ConnectionExceptionss.Add(e.Error);
                ConnectionCompleted();
            }
            else
            {
                ConnectionCompleted();
                SetInteractionQueue();
                SetDirectoriesManager();
                SetDirectoryConfiguration();
            }
        }
        public void disconnectionAsync()
        {
            Session.DisconnectAsync(ConnectCompleted, null);
        }
        public delegate void ConnectionStateChangedEventHandler(ConnectionStateChangedEventArgs e);
        public void SetConnectionStateChangedHandler(Action a)
        {
            ConnectionStateChangedHandler = a;
        }
        public void SetPeopleManager()
        {
            if(PeopleManager == null)
            PeopleManager = PeopleManager.GetInstance(Session);
            
            
        }
        public void MuteInteraction(string InteractionID)
        {
            foreach (Interaction i in InteractionQueue.GetContents())
            {
                if (i.InteractionId.ToString() == InteractionID.Substring(0, 10))
                    if (i.IsConnected) { }
                        i.Mute(!i.IsMuted);
            }
        }
        public void AnswerInteraction(string InteractionID)
        {
            foreach (Interaction i in InteractionQueue.GetContents())
            {
                if (i.InteractionId.ToString() == InteractionID.Substring(0, 10))
                    if (!i.IsConnected)
                        i.Pickup();
            }
        }
        public void HoldInteraction(string InteractionID)
        {
            foreach (Interaction i in InteractionQueue.GetContents())
            {
                if (i.InteractionId.ToString() == InteractionID.Substring(0, 10))
                    if (i.IsConnected || i.IsHeld)
                        i.Hold(!i.IsHeld);
            }
        }
        public void DisconnectInteraction(string InteractionID)
        {
            foreach (Interaction i in InteractionQueue.GetContents())
            {
                if (i.InteractionId.ToString() == InteractionID.Substring(0,10))
                    i.Disconnect();
            }
        }
        private void UpdateCurrentUserStatus()
        {
            if (UserStatusList == null)
            {
                UserStatusList = new UserStatusList(PeopleManager);
            }
            UserStatus = UserStatusList.GetUserStatus(PeopleManager.Session.UserId);
            //CurrentStatus = UserStatus.StatusMessageDetails;
            if (!isStatusCallbackSet)
            {
                isStatusCallbackSet = true;
                UserStatusList.WatchedObjectsChanged += UpdateUsersStatus;
                string[] usertowatch = new string[1];
                usertowatch[0] = PeopleManager.Session.UserId;
                UserStatusList.StartWatchingAsync(usertowatch, EmptyCallBack, null);
            }
        }
        public List<string> PopulateStatusList()
        {
            UserStatusList = new UserStatusList(PeopleManager);
            UpdateCurrentUserStatus();
            StatusMessageList msgList = new StatusMessageList(PeopleManager);
            msgList.StartWatching();
            StatusImageList = new System.Windows.Forms.ImageList();
            List<string> items = new List<string>();//new object[msgList.GetList().Count];
            string lvi;
            foreach (StatusMessageDetails d in msgList.GetList())
            {
                StatusImageList.Images.Add(d.Icon);
                lvi = d.MessageText;
                items.Add(lvi);
            }
            return items;
        }
        public void ChangeUserStatus(string NewStatus)
        {
            
            UserStatusUpdate statusUpdate = new UserStatusUpdate(PeopleManager);
            StatusMessageList msgList = new StatusMessageList(PeopleManager);
            msgList.StartWatching();
            foreach (StatusMessageDetails d in msgList.GetList())
            {
                if (NewStatus == d.MessageText)
                    statusUpdate.StatusMessageDetails = d;
            }
            if (statusUpdate.StatusMessageDetails != null)
                //statusUpdate.UpdateRequest();
                statusUpdate.UpdateRequestAsync(ConnectCompleted, null);
            else
                return;
            UpdateCurrentUserStatus();
        }
        private delegate void UpdateUsersStatusDel(WatchedObjectsEventArgs<UserStatusProperty> objectChanged);
        private void UpdateUsersStatus(Object sender, WatchedObjectsEventArgs<UserStatusProperty> e)
        {
            if (StatusChangedCallback != null)
            {
                UpdateCurrentUserStatus();
                StatusChangedCallback();
            }
            else
                return;
        }
        private void SetInteractionQueue()
        {
            if(InteractionQueue == null)
                 InteractionQueue = new InteractionQueue(InteractionsManager.GetInstance(Session), 
                     new QueueId(QueueType.MyInteractions, Session.UserId));
            
            InteractionQueue.InteractionAdded += InteractionQueueInteractionAdded;
            InteractionQueue.InteractionChanged += InteractionQueueInteractionChanged;
            InteractionQueue.InteractionRemoved += InteractionQueueInteractionRemoved;
            InteractionQueue.ConferenceInteractionAdded += InteractionQueueConferenceInteractionAdded;
            InteractionQueue.ConferenceInteractionChanged += InteractionQueueConferenceInteractionChanged;
            InteractionQueue.ConferenceInteractionRemoved += InteractionQueueConferenceInteractionRemoved;
            
            List<string> RequiredAttributes = new List<string>();
            RequiredAttributes.Add(InteractionAttributeName.CallIdKey.ToString());
            RequiredAttributes.Add(InteractionAttributeName.RemoteName.ToString());
            RequiredAttributes.Add(InteractionAttributeName.RemoteAddress.ToString());
            RequiredAttributes.Add(InteractionAttributeName.State.ToString());
            //RequiredAttributes.Add(InteractionAttributeName.SupervisorRecorders.ToString());
            //RequiredAttributes.Add(InteractionAttributeName.Recorders.ToString());
            RequiredAttributes.Add(InteractionAttributeName.Muted.ToString());
            InteractionQueue.StartWatchingAsync(RequiredAttributes.ToArray(), UpdateInteractionList, null);

        }
        private void InteractionQueueInteractionChanged(object sender, InteractionAttributesEventArgs e)
        {
            WatchingQueueCompleted();
            UpdateQueueList();
        }
        private void InteractionQueueConferenceInteractionChanged(object sender, ConferenceInteractionAttributesEventArgs e)
        {
            WatchingQueueCompleted();
            UpdateQueueList();
        }
        private void InteractionQueueConferenceInteractionAdded(object sender, InteractionAttributesEventArgs e)
        {
            WatchingQueueCompleted();
            UpdateQueueList();
        }
        private void InteractionQueueConferenceInteractionRemoved(object sender, ConferenceInteractionEventArgs e)
        {
            WatchingQueueCompleted();
            UpdateQueueList();
        }
        private void InteractionQueueConferenceInteractionAdded(object sender, ConferenceInteractionAttributesEventArgs e)
        {
            WatchingQueueCompleted();
            UpdateQueueList();
        }
        private void InteractionQueueInteractionRemoved(object sender, InteractionEventArgs e)
        {
            WatchingQueueCompleted();
            UpdateQueueList();
        }
        private void InteractionQueueInteractionAdded(object sender, InteractionAttributesEventArgs e)
        {
            WatchingQueueCompleted();
            UpdateQueueList();
        }
        private void UpdateInteractionList(object sender, AsyncCompletedEventArgs e)
        {
            WatchingQueueCompleted();
            
        }
        public void MakeCall(string RemoteAddress)
        {
            InteractionsManager.GetInstance(Session).MakeCallAsync(
                new CallInteractionParameters(RemoteAddress, CallMadeStage.Allocated), MakeCallCompleted, null);
        }
        public void MakeCallCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
        public void SetDirectoriesManager()
        {
            if(DirectoriesManager == null)
                DirectoriesManager = DirectoriesManager.GetInstance(Session);
        }
        public void SetDirectoryConfiguration()
        {
            if (DirectoryConfiguration == null)
            {
                DirectoryConfiguration = new DirectoryConfiguration(DirectoriesManager);
                DirectoryConfiguration.StartWatchingAsync(DirectoryConfigurationCallback, null);
            }
        }
        private void DirectoryConfigurationCallback(object sender, AsyncCompletedEventArgs e)
        {
            DirectoryConfigurationCallbackAction();
        }
        public void WatchDirectory(DirectoryMetadataCategory directoryMetaDataCategory)
        {
            foreach (DirectoryMetadata d in DirectoryConfiguration.GetList())
            {
                if (d.Category == directoryMetaDataCategory)
                {
                    WatchedDirectory = new ContactDirectory(DirectoriesManager, d);
                    WatchedDirectory.StartWatching();
                    
                }
            }
        }
        public List<DirectoryMetadataCategory> GetDirectoryCategories()
        {
            List<DirectoryMetadataCategory> tempList = new List<DirectoryMetadataCategory>();
            foreach (DirectoryMetadata d in DirectoryConfiguration.GetList())
            {
                tempList.Add(d.Category);
            }
            List<DirectoryMetadataCategory> distinctOnly = new List<DirectoryMetadataCategory>(new HashSet<DirectoryMetadataCategory>(tempList));
            return distinctOnly;
        }
        public List<DirectoryMetadata> GetDirectoriesFromCategory(DirectoryMetadataCategory Category)
        {
            List<DirectoryMetadata> tempList = new List<DirectoryMetadata>();
            foreach (DirectoryMetadata d in DirectoryConfiguration.GetList())
            {
                if (d.Category == Category)
                    tempList.Add(d);
            }
            return tempList;
        }
        public ContactDirectory WatchDirecotry(DirectoryMetadata Directory)
        {
            ContactDirectory tempDirectory = new ContactDirectory(DirectoriesManager, Directory);
            tempDirectory.StartWatching();
            return tempDirectory;
        }
        #endregion

        #region AdditionalClasses
        public class InternalInteractions
        {
            //Call ID, Remote Name, Remote Number, State

            private List<Interaction> Interactions;
            public List<InternalInteraction> InternalInteractionss;

            public InternalInteractions(List<Interaction> InteractionList)
            {
                Interactions = InteractionList;
                InternalInteractionss = new List<InternalInteraction>();
                foreach (Interaction i in InteractionList)
                {
                    InternalInteractionss.Add(new InternalInteraction(i));
                }
            }

           public class InternalInteraction
            {
                public string State { get; set; }
                public string CallID { get;  set; }
                public string Name { get;  set; }
                public string Number { get;  set; }
                
                public InternalInteraction(Interaction NewInteraction)
                {
                    CallID = NewInteraction.CallIdKey;
                    Name = NewInteraction.RemoteName;
                    Number = NewInteraction.RemoteAddress;
                    State = NewInteraction.State.ToString();
                }
            }
        }
        
        #endregion
    }
}

