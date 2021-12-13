using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class GeneralTask
    {
        #region Fields
        private string _name;
        private string _description;
        private string _createdDate;

        private string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        #endregion

        #region Constructor
        public GeneralTask()
        {
            p_name = "Task Name";
            p_createdDate = date;
            p_description = "Enter Description";
        }
        public GeneralTask(string name, string description, string createdDate)
        {
            p_name = name;
            p_description = description;
            p_createdDate = createdDate;
        }
        #endregion

        #region Properties
        //set original stuff
        private string p_name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string p_createdDate
        {
            get { return _createdDate; }
            set { _createdDate = date; }
        }
        private string p_description
        {
            get { return _description; }
            set { _description = value; }
        }
        //retrieval stuff
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }
        #endregion
    }
}
