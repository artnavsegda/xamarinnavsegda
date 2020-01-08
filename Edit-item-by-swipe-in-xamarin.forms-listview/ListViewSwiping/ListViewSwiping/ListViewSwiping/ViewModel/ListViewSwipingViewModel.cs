using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swiping
{
    public class ListViewSwipingViewModel
    {
        #region Fields

        private ObservableCollection<ListViewInboxInfo> inboxInfo;

        private SfListView ListView;

        #endregion

        #region Constructor

        public ListViewSwipingViewModel()
        {
            GenerateSource();
        }

        #endregion

        #region Properties

      
        public ObservableCollection<ListViewInboxInfo> InboxInfo
        {
            get { return inboxInfo; }
            set { this.inboxInfo = value; }
        }

        #endregion

        #region Generate Source

        private void GenerateSource()
        {
            swipeStartedCommand = new Command<SwipeStartedEventArgs>(OnSwipeStarted);
            swipeEndedCommand = new Command<SwipeEndedEventArgs>(OnSwipeEnded);
            loadedCommand = new Command<SfListView>(OnListViewLoaded);

            ListViewInboxInfoRepository inboxinfo = new ListViewInboxInfoRepository();
            inboxInfo = inboxinfo.GetInboxInfo();
        }

       
        #endregion

        #region Command

        #region Fields

        int itemIndex = -1;
        Command<SfListView> loadedCommand;
        Command<SwipeStartedEventArgs> swipeStartedCommand; 
        Command<SwipeEndedEventArgs> swipeEndedCommand;

        #endregion

        #region Properties

        public Command<SwipeStartedEventArgs> SwipeStartedCommand
        {
            get { return swipeStartedCommand; }
            protected set { swipeStartedCommand = value; }
        }

        public Command<SwipeEndedEventArgs> SwipeEndedCommand
        {
            get { return swipeEndedCommand; }
            protected set { swipeEndedCommand = value; }
        }

        public Command<SfListView> LoadedCommand
        {
            get { return loadedCommand; }
            protected set { loadedCommand = value; }
        }


        #endregion

        #region Methods

        public void OnListViewLoaded(SfListView listView)
        {
            ListView = listView;
        }
        public void OnSwipeStarted(SwipeStartedEventArgs eventArgs)
        {
            itemIndex = -1;
        }

        public void OnSwipeEnded(SwipeEndedEventArgs eventArgs)
        {
            itemIndex = eventArgs.ItemIndex;
        }

        #endregion

        #endregion
    }
}
