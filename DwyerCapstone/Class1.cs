using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwyerCapstone
{

    //This class sets the class2 "ret" values equal to the "pass" value
    class Class1
    {
        //Property for NUMBER OF COURSES
        public static string passNumCourses;
        public static string Number
        {
            get
            {
                return passNumCourses;
            }
            set
            {
                Class2.retNumCourses = value;
            }
        }

        //Property for NAME
        public static string passName;
        public static string Name
        {         
            get
            {
                return passName;
            }
            set
            {
                Class2.retName = value;
            }
        }
      
        //Property for DATE
        public static string passDate;
        public static string Date
        {
            get
            {
                return passDate;
            }
            set
            {
                Class2.retDate = value;
            }
        }

        //Property for CODE
        public static string passCode;
        public static string Code
        {
            get
            {
                return passCode;
            }
            set
            {
                Class2.retCode = value;
            }
        }

        //Property for STYLE
        public static string passStyle;
        public static string Style
        {
            get
            {
                return passStyle;
            }
            set
            {
                Class2.retStyle = value;
            }
        }
    
    }
}
