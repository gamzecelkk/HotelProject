using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.View;
using System.Data.SqlClient;

namespace DataAccess
{
    public class FloorDal
    {
        #region Read

        public FloorView ReadMe(SqlDataReader floorsReader)
        {
            FloorView myFloors = new FloorView();
            while (floorsReader.Read())
            {
                myFloors.ID = (int)floorsReader[0];
                myFloors.Number = (string)floorsReader[1];
                myFloors.Properties = (string)floorsReader[2];
                myFloors.Activity = (bool)floorsReader[3];
                myFloors.Descriptions = (string)floorsReader[4];

            }
            return myFloors;
        }

        #endregion

        #region Insert
        public int InsertFloor(Floors floors)
        {
            SqlParameter[] floorParameters =
            {
                new SqlParameter
                {
                    ParameterName ="FloorNumber",
                    Value = floors.FloorNumber
                },

                new SqlParameter
                {
                    ParameterName = "FloorProperties",
                    Value= floors.FloorProperties
                },

                new SqlParameter
                {
                    ParameterName="FloorIsActive",
                    Value = floors.FloorIsActive
                },
                new SqlParameter
                {
                    ParameterName="FloorDescription",
                    Value = floors.FloorDescription
                }
            };

            int floorInserted = HotelHelperSQL.MyExecuteNonQuery("sp_AddFloor", "sp", floorParameters);
            return floorInserted;
        }
        #endregion

        #region Update
        public int UpdateFloor(Floors floors)
        {
            SqlParameter[] floorParameters =
            {
                new SqlParameter
                {
                    ParameterName ="FloorID",
                    Value = floors.FloorID
                },
                new SqlParameter
                {
                    ParameterName ="FloorNumber",
                    Value = floors.FloorNumber
                },

                new SqlParameter
                {
                    ParameterName = "FloorProperties",
                    Value= floors.FloorProperties
                },

                new SqlParameter
                {
                    ParameterName="FloorIsActive",
                    Value = floors.FloorIsActive
                },
                new SqlParameter
                {
                    ParameterName="FloorDescription",
                    Value = floors.FloorDescription
                }
            };

            int floorUpdated = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateFloor", "sp", floorParameters);
            return floorUpdated;
        }
        #endregion

        #region Delete
        public int DeleteFloor(Floors floors)
        {
            SqlParameter[] floorParameters =
            {
                new SqlParameter
                {
                    ParameterName ="FloorID",
                    Value = floors.FloorID
                }
            };

            int floorDeleted = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteFloor", "sp", floorParameters);
            return floorDeleted;
        }
        #endregion

        #region All Floor

        public FloorView GetAllFloors()
        {
            SqlDataReader floorsReader = HotelHelperSQL.MyExecuteReader("select * from vw_Floors where Activity = 1", "text", null);
            FloorView allFloors = ReadMe(floorsReader);
            return allFloors;
        }

        #endregion
    }
}
