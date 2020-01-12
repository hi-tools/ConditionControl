using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ConditionControl
{
    public static class ExtensionMethod
    {
        public static long ToLong(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            long res = 0;
            long.TryParse(str.Replace(",", string.Empty).Replace("/", "."), out res);
            return res;
        }

        public static int ToInt(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            int res = 0;
            int.TryParse(str.Replace(",", string.Empty).Replace("/", "."), out res);
            return res;
        }

        public static DataRow Copy(this DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }
            DataRow res = dr.Table.NewRow();
            foreach (DataColumn item in dr.Table.Columns)
            {
                res[item.ColumnName] = dr[item.ColumnName];
            }
            return res;
        }
    }
}
