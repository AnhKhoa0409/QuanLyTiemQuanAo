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
    public class DB_Stock
    {
        DAL db = null;
        public DB_Stock(string strConnect_local)
        {
            db = new DAL(strConnect_local);
        }
        public DataTable GetStock()
        {
            return db.ExecuteQueryDataTable("SELECT * FROM DBO.GetStock()");
        }
        public DataTable FindProductByBranch(string branch_id)
        {
            return db.ExecuteNonQueryDataTable("SELECT * FROM DBO.FindProductByBranch(@branch_id)",
                 new SqlParameter("@branch_id", branch_id));
        }
        public DataTable FindProductByID(string product_id)
        {
            return db.ExecuteNonQueryDataTable("SELECT * FROM DBO.FindProductByID(@product_id)",
                 new SqlParameter("@product_id", product_id));
        }
        public bool SellProduct(ref string err, string branch_id, string product_id, int quantity)
        {
            return db.MyExecuteNonQuery("SP_Sell_Product",
                ref err,
                new SqlParameter("@branch_id", branch_id),
                new SqlParameter("@product_id", product_id),
                new SqlParameter("@quantity", quantity));
        }
        public bool UndoSellProduct(ref string err, string branch_id, string product_id, int quantity)
        {
            return db.MyExecuteNonQuery("SP_Undo_Sell_Product",
                ref err,
                new SqlParameter("@branch_id", branch_id),
                new SqlParameter("@product_id", product_id),
                new SqlParameter("@quantity", quantity));
        }

    }
}
