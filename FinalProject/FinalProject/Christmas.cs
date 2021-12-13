using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Christmas : GeneralTask
    {
        #region Fields
        private string _personRecieving;
        private bool _naughtyOrNice; //true = nice nad false = naughty
        #endregion

        #region Contructors
        public Christmas()
        {
            p_personRecieving = "Gift Recipients Name";
            p_naughtyOrNice = true;
        }
        public Christmas(string name, string dateCreated, string description, string personRecieving, bool naughtyOrNice) : base(name, dateCreated, description)
        {
            p_personRecieving = personRecieving;
            p_naughtyOrNice = naughtyOrNice;
        }
        #endregion

        #region Properties
        //set original stuff
        private string p_personRecieving
        {
            get { return _personRecieving; }
            set { _personRecieving = value; }
        }
        private bool p_naughtyOrNice
        {
            get { return _naughtyOrNice; }
            set { _naughtyOrNice = value; }
        }
        //retrieval stuff
        public string PersonRecieving
        {
            get { return _personRecieving;}
            set { _personRecieving = value; }
        }
        public bool NaughtyOrNice
        {
            get { return _naughtyOrNice;  }
            set { _naughtyOrNice = value; }
        }
        #endregion
    }
}
