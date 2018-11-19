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
    public class GroupController
    {
        public IEnumerable<Group> GetAllGroups()
        {
            try
            {
                string sql = string.Format("SELECT * FROM groups");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Group>(sql);
                    return result;
                }
            }
            catch(Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public bool AddGroup(Group group)
        {
            try
            {
                string sql = @"INSERT INTO groups (GroupName, Courses) VALUES (@GroupName, @Courses)";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Execute(sql, group);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
                return false;
            }
        }

        public bool DeleteGroup(int id)
        {
            try
            {
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute("DELETE FROM groups WHERE Id = @Id", new Group
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
    }
}
