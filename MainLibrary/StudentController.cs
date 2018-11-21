using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;
using MySql.Data.MySqlClient;

namespace MainLibrary
{
    public class StudentController
    {
        GroupController groupController = new GroupController();

        public IEnumerable<Student> GetAllStudents()
        {
            try
            {
                string sql = string.Format("SELECT * FROM students");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public IEnumerable<Student> GetStudentsbByStage(string stage)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE Room LIKE '{0}%'",stage);
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql);
                    return result;
                }
            }
            catch(Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public IEnumerable<Student> GetStudentsByName(string name)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE StudentName LIKE '%{0}%'", name);
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public IEnumerable<Student> GetStudentsById(int id)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE Id = @Id");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql,new Student {Id = id });
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public IEnumerable<Student> GetStudentsbByRoom(string room)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE Room = @Room");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql, new Student {Room = room }); 
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public IEnumerable<Student> GetStudentsbByGroupName(string groupName)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE GroupName = @GroupName");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql, new Student { GroupName = groupName });
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

   
        public IEnumerable<Student> GetStudentsbByGroupNameAndGroupNumber(string groupName, string groupNumber)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE GroupName = @GroupName AND GroupNumber LIKE '{0}%'", groupNumber);
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql, new Student { GroupName = groupName });
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public bool SetInhabitedById(int id)
        {
            try
            {
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute("UPDATE students SET Inhabited = 1 WHERE Id = @Id", new Student
                    { Id = id });
                }
                return true;
            }
            catch(Exception ex)
            {
                Log.WriteLog(ex.Message);
                return false;
            }
        }

        public bool DelInhabitedById(int id)
        {
            try
            {
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute("UPDATE students SET Inhabited = 0 WHERE Id = @Id", new Student
                    { Id = id });
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
                return false;
            }
        }

        public bool SetEnvictedById(int id)
        {
            try
            {
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute("UPDATE students SET Envicted = 1 WHERE Id = @Id", new Student
                    { Id = id });
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
                return false;
            }
        }

        public bool DelEnvictedById(int id)
        {
            try
            {
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute("UPDATE students SET Envicted = 0 WHERE Id = @Id", new Student
                    { Id = id });
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
                return false;
            }
        }


        public bool AddStudent(Student student)
        {
            try
            {
                string sql = @"INSERT INTO students (StudentName, Room, Inhabited, Envicted, GroupNumber, RoomType, GroupName) VALUES (@StudentName, @Room, @Inhabited, @Envicted, @GroupNumber, @RoomType, @GroupName)";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();

                    var result = con.Execute(sql, student);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
                return false;
            }
        }

        public bool DeleteStudent(int id)
        {
            try
            {
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute("DELETE FROM students WHERE Id = @Id", new Student
                    { Id = id });
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
                return false;
            }
        }

        public IEnumerable<Student> GetStudentsbByInhabited(byte inhabited)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE Inhabited = @Inhabited");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql, new Student { Inhabited = inhabited });
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public IEnumerable<Student> GetStudentsbByEnvicted(byte envicted)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE Envicted = @Envicted");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql, new Student { Envicted = envicted });
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public void DoNewYear()
        {
            try
            {
                SetUnInhabitedToAll();
                var groups = groupController.GetAllGroups();
                var students = GetAllStudents();
                foreach (Student stud in students)
                {
                    foreach(Group group in groups)
                    {
                        if(group.GroupName == stud.GroupName)
                        {
                            if (stud.GroupNumber.ToString()[0].ToString() == group.Courses.ToString())
                            {
                                DeleteStudent(stud.Id);
                            }
                            else
                            {
                                AddCourseForStudent(stud);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
        }

        public int TakeCourse(int groupnumber)
        {
            string groupnum = groupnumber.ToString();
            return Convert.ToInt32(groupnum[0]);
        }

        public void SetUnInhabitedToAll()
        {
            var students = GetAllStudents();

            foreach (Student stud in students)
            {
                DelInhabitedById(stud.Id);
            }
        }

        public void AddCourseForStudent(Student student)
        {
            try
            {
                string groupnumb = student.GroupNumber.ToString();
                char[] arr = groupnumb.ToCharArray();
                arr[0] = Convert.ToChar(Convert.ToInt32(arr[0]) + 1);
                groupnumb = new string(arr);

                student.GroupNumber = Convert.ToInt32(groupnumb);
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute("UPDATE students SET GroupNumber = @GroupNumber WHERE Id = @Id", student);
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
        }
    }
}
