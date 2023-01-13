using Entities.Concrete;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PackageDal
    {
        #region Read

        public PackageView ReadMe(SqlDataReader packagesReader)
        {
            PackageView myPackage = new PackageView();
            while (packagesReader.Read())
            {
                myPackage.ID = (int)packagesReader[0];
                myPackage.PackageName = (string)packagesReader[1];
                myPackage.Properties = (string)packagesReader[2];
                myPackage.Price = (decimal)packagesReader[3];
                myPackage.Activity = (bool)packagesReader[4];
                myPackage.Descriptions = (string)packagesReader[5];

            }
            return myPackage;
        }

        #endregion

        #region Insert
        public int InsertPackage(Packages packages)
        {
            SqlParameter[] packageParameters =
            {
                new SqlParameter
                {
                    ParameterName ="PackageName",
                    Value = packages.PackageName
                },

                new SqlParameter
                {
                    ParameterName = "PackageProperties",
                    Value= packages.PackageProperties
                },

                new SqlParameter
                {
                    ParameterName="PackagePrice",
                    Value = packages.PackagePrice
                },
                new SqlParameter
                {
                    ParameterName = "PackageIsActive",
                    Value= packages.PackageIsActive
                },

                new SqlParameter
                {
                    ParameterName="PackageDescription",
                    Value = packages.PackageDescription
                }
            };

            int packageInserted = HotelHelperSQL.MyExecuteNonQuery("sp_AddPackage", "sp", packageParameters);
            return packageInserted;
        }
        #endregion

        #region Update
        public int UpdatePackage(Packages packages)
        {
            SqlParameter[] packageParameters =
            {
                 new SqlParameter
                {
                    ParameterName ="PackageID",
                    Value = packages.PackageID
                },
                new SqlParameter
                {
                    ParameterName ="PackageName",
                    Value = packages.PackageName
                },

                new SqlParameter
                {
                    ParameterName = "PackageProperties",
                    Value= packages.PackageProperties
                },

                new SqlParameter
                {
                    ParameterName="PackagePrice",
                    Value = packages.PackagePrice
                },
                new SqlParameter
                {
                    ParameterName = "PackageIsActive",
                    Value= packages.PackageIsActive
                },

                new SqlParameter
                {
                    ParameterName="PackageDescription",
                    Value = packages.PackageDescription
                }
            };

            int packageUpdated = HotelHelperSQL.MyExecuteNonQuery("sp_UpdatePackage", "sp", packageParameters);
            return packageUpdated;
        }
        #endregion

        #region Delete
        public int DeletePackage(Packages packages)
        {
            SqlParameter[] packageParameters =
            {
                new SqlParameter
                {
                    ParameterName ="PackageID",
                    Value = packages.PackageID
                },
            };

            int packageDeleted = HotelHelperSQL.MyExecuteNonQuery("sp_DeletePackage", "sp", packageParameters);
            return packageDeleted;
        }
        #endregion

        #region All Packages

        public PackageView GetAllPackages()
        {
            SqlDataReader packagesReader = HotelHelperSQL.MyExecuteReader("select * from vw_Packages where Activity = 1", "text", null);
            PackageView allPackages = ReadMe(packagesReader);
            return allPackages;
        }

        #endregion
    }
}
