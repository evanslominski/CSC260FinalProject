using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Grocery : GeneralTask
    {
        #region Fields
        private string _store;
        private string _category; //either food, cleaning, other
        #endregion

        #region Constructor
        public Grocery()
        {
            p_store = "Task Name";
            p_category = "Enter food or cleaning";
        }
        public Grocery(string name, string createdDate, string description, string store, string category) : base(name, createdDate, description)
        {
            p_store = store;
            p_category = category;
        }
        #endregion

        #region Properties
        //set original stuff
        private string p_store
        {
            get { return _store; }
            set { _store = value; }
        }
        private string p_category
        {
            get { return _category; }
            set { _category = value; }
        }
        //retrieval stuff
        public string Store
        {
            get { return _store; }
            set { p_store = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        #endregion
    }
}
