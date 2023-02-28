using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.Models
{
    public class ActionSqlParamCls
    {
        public ESupportDb SupportDb
        {
            get
            {
                bool flag = this.DBService.ToLower().Equals("mssql");
                ESupportDb result;
                if (flag)
                {
                    result = ESupportDb.MSSQL;
                }
                else
                {
                    bool flag2 = this.DBService.ToLower().Equals("oracle");
                    if (flag2)
                    {
                        result = ESupportDb.ORACLE;
                    }
                    else
                    {
                        bool flag3 = this.DBService.ToLower().Equals("mysql");
                        if (flag3)
                        {
                            result = ESupportDb.MYSQL;
                        }
                        else
                        {
                            result = ESupportDb.NOT_SUPPORT;
                        }
                    }
                }
                return result;
            }
        }

        public string CreateParameterName(string name)
        {
            return this.SpecialChar + name;
        }

        public string ConnectionString;

        public string Language;

        public IDbTransaction Trans;

        public string DBService = "MSSQL";

        public string SpecialChar = "@";
    }
}
