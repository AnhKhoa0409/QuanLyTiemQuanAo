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
    public class DB_Product
    {
        DAL db = null;
        public DB_Product ()
        {
            db = new DAL ();
        }
        public DataTable GetProduct()
        {
            return db.ExecuteQueryDataTable("SELECT * FROM Product", CommandType.Text, null);
        }
        public bool InsertProduct(ref string err, string product_id, string category_id,
            string product_name, string product_size, string color, int unit_price)
        {
            return db.MyExecuteNonQuery("InsertProduct",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@product_id", product_id),
                new SqlParameter("@category_id", category_id),
                new SqlParameter("@product_name", product_name),
                new SqlParameter("@product_size", product_size),
                new SqlParameter("@color", color),
                new SqlParameter("@unit_price", unit_price));
        }
    }
}
