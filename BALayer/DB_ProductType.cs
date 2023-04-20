﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class DB_ProductType
    {
        DAL db = null;

        public DB_ProductType(string strConnect_local) 
        {
            db = new DAL(strConnect_local);
        }
        public DataTable GetProductType()
        {
            return db.ExecuteQueryDataTable("select * from ProductType");
        }
    }
}
