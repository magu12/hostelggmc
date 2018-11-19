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
    public class RoomController
    {
        public IEnumerable<Room> GetAllRooms()
        {
            try
            {
                string sql = string.Format("SELECT * FROM rooms");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Room>(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public bool AddRoom(Room room)
        {
            try
            {
                string sql = @"INSERT INTO rooms (Stage, Number) VALUES (@Stage, @Number)";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Execute(sql, room);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
                return false;
            }
        }

        public bool DeleteRoom(int id)
        {
            try
            {
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute("DELETE FROM rooms WHERE Id = @Id", new Room
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

        public IEnumerable<Room> RoomSearch(int stage)
        {
            try
            {
                string sql = string.Format("SELECT * FROM rooms WHERE Stage = @Stage ");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Room>(sql, new Room { Stage = stage });
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return null;
        }

        public int StudentInRoomSearch(Room room)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE Room = @Room");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql, new Student { Room = (room.Stage.ToString() + "-" + room.Number.ToString()) });
                    return result.Count();
                }
            }        
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return 0;
        }

        public int StudentCountFor2(Room room)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE Room = @Room AND RoomType = 1");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql,new Student {Room = (room.Stage.ToString() + "-" + room.Number.ToString()) });
                    return result.Count();
                }
            }
            catch(Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return 0;
        }

        public int StudentCountFor3(Room room)
        {
            try
            {
                string sql = string.Format("SELECT * FROM students WHERE Room = @Room AND RoomType = 0");
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Student>(sql, new Student { Room = (room.Stage.ToString() + "-" + room.Number.ToString()) });
                    return result.Count();
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            return 0;
        }
    }
}
