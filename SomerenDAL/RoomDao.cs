using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao 
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT Room_ID, No_Of_Occupants, RoomType FROM ROOM";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Room r = new Room()
                    {
                        Number = (int)dr["Room_ID"],
                        Capacity = (int)dr["No_Of_Occupants"],
                        Type = (RoomType)dr["RoomType"]
                    };
                    rooms.Add(r);
                }
                return rooms;
        }
    }
}
