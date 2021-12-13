using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Data : Form
    {
        #region GlobalVariables
        private static List<GeneralTask> _generalTaskList = new List<GeneralTask>();
        private static List<Grocery> _groceryTaskList = new List<Grocery>();
        private static List<Christmas> _christmasTaskList = new List<Christmas>(2);
        private static string _date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        #endregion

        #region Properties
        public static List<GeneralTask> generalTaskList
        {
            get { return _generalTaskList; }
            set { _generalTaskList = value; }
        }
        public static List<Grocery> groceryTaskList
        {
            get { return _groceryTaskList; }
            set { _groceryTaskList = value; }
        }
        public static List<Christmas> christmasTaskList
        {
            get { return _christmasTaskList; }
            set { _christmasTaskList = value; }
        }
        public static string date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion
    }
}
