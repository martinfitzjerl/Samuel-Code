using System;

namespace PizzaStore.Library.Models
{
    public class History
    {
        private int _historyID;
        private string _historyDescription;
        private string _userInfo;
        public int HistoryID
        { 
            get
            {
                return _historyID;
            } 
            private set
            {
                _historyID = value;
            } 
        }

        public string HistoryDescription
        { 
            get
            {
                return _historyDescription;
            } 
            private set
            {
                _historyDescription = value;
            } 
        }

        public string UserInfo
        {
            get
            {
                return _userInfo;
            }
            private set
            {
                _userInfo = value;
            }
        }


    }
}