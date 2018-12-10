using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwyerCapstone
{
    //This is a pass-through class which is called by Form1 for display values
    class Class2
    {
        //Property for NUMBER OF COURSES
        public static string retNumCourses, outNumCourses;
        public static string GetNumber
        {
            get
            {
                return retNumCourses;
            }
            set
            {
                Class2.outNumCourses = value;               
            }        
        }

        //Property for NAME
        public static string retName, outName;
        public static string GetName
        {
            get
            {
                return retName;
            }
            set
            {
                Class2.outName = value;
            }
        }

        //Property for DATE
        public static string retDate, outDate;
        public static string GetDate
        {
            get
            {
                return retDate;
            }
            set
            {
                Class2.outDate = value;
            }
        }

        //Property for STYLE
        public static string retStyle, outStyle;
        public static string GetStyle
        {
            get
            {
                return retStyle;
            }
            set
            {
                Class2.outStyle = value;               
            }
        }
        //Property for CODE
        public static string retCode, outCode;
        public static string GetCode
        {
            get
            {
                return retCode;
            }
            set
            {
                Class2.outCode = value;
            }
        }
    }
}

