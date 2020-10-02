using System;

namespace CourseProject.Models
{
    internal class CurrentUser
    {
        /*
         * The purpose of this class is to serve as a global user_id for the forms
         * 
         */
        public static int UserId { get; set; }
        public static string FullName { get; set; }
    }
}
