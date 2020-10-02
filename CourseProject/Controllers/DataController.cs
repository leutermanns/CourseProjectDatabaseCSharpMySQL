using CourseProject.Model;
using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class DataController
    {
        private static Courses courses;
        private static DiscreteUser discreteUser;
        private static Evidence evidence;
        private static Groups groups;
        private static Skills skills;
        private static UserTable userTable;
        private static SkillCategoriesSQL skillCategories;

        #region Generate DataSets
        public static void genData(int user_id)
        {
            generateCourses(user_id);
            generateEvidence(user_id);
            generateGroups(user_id);
            generateSkills(user_id);
            generateUserTable();
            generateSkillCagetories();
        }
        public static void generateUserTable()
        {
            userTable = new UserTable();
        }
        public static void generateCourses(int user_id)
        {
            courses = new Courses(user_id);
        }

        public static void generateDiscreteUser(string username, string password)
        {
            discreteUser = new DiscreteUser(username, password);
        }

        public static void generateEvidence(int user_id)
        {
            evidence = new Evidence(user_id);
        }

        public static void generateGroups(int user_id)
        {
            groups = new Groups(user_id);
        }

        public static void generateSkills(int user_id)
        {
            skills = new Skills(user_id);
        }

        public static void generateSkillCagetories()
        {
            skillCategories = new SkillCategoriesSQL();
        }

        #endregion

        #region Getters
        public static SkillCategoriesSQL GetSkillCategories()
        {
            return skillCategories;
        }

        public static Courses GetCourses()
        {
            return courses;
        }

        public static DiscreteUser GetDiscreteUser()
        {
            return discreteUser;
        }

        public static Evidence GetEvidence()
        {
            return evidence;
        }

        public static Groups GetGroups()
        {
            return groups;
        }

        public static Skills GetSkills()
        {
            return skills;
        }

        public static UserTable GetUserTable()
        {
            return userTable;
        }
        #endregion
    }
}
