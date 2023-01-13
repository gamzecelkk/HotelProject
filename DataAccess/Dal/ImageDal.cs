using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ImageDal
    {
        #region Insert
        public int InsertImage(Images images)
        {
            SqlParameter[] ImageParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ImageName",
                    Value = images.ImageName
                },

                new SqlParameter
                {
                    ParameterName = "ImageURL",
                    Value= images.ImageURL
                },

                new SqlParameter
                {
                    ParameterName="ImageDescription",
                    Value = images.ImageDescription
                }
            };

            int MyImage = HotelHelperSQL.MyExecuteNonQuery("sp_AddImage", "sp", ImageParameters);
            return MyImage;
        }
        #endregion

        #region Update
        public int UpdateImage(Images images)
        {
            SqlParameter[] ImageParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ImageID",
                    Value = images.ImageID
                },
                new SqlParameter
                {
                    ParameterName ="ImageName",
                    Value = images.ImageName
                },

                new SqlParameter
                {
                    ParameterName = "ImageURL",
                    Value= images.ImageURL
                },

                new SqlParameter
                {
                    ParameterName="ImageDescription",
                    Value = images.ImageDescription
                }
            };

            int MyImage = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateImage", "sp", ImageParameters);
            return MyImage;
        }
        #endregion

        #region Delete
        public int DeleteImage(Images images)
        {
            SqlParameter[] ImageParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ImageID",
                    Value = images.ImageID
                },
            };

            int MyImage = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteImage", "sp", ImageParameters);
            return MyImage;
        }
        #endregion
    }
}
