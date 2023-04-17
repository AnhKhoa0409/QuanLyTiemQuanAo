﻿using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DB_Employee
    {
        DAL db = null;
        public DB_Employee()
        {
            db = new DAL();
        }
        public DataTable GetEmployee()
        {
            return db.ExecuteQueryDataTable("select * from Employee");
        }
        public bool InsertEmployee(ref string err, string employee_id, string job_id,
            string full_name, string gender, DateTime birthday, string phone,
            string employee_address, string email, bool work_status)
        {
            return db.MyExecuteNonQuery("SP_Insert_Employee",
                ref err,
                new SqlParameter("@employee_id", employee_id),
                new SqlParameter("@job_id", job_id),
                new SqlParameter("@full_name", full_name),
                new SqlParameter("@gender", gender),
                new SqlParameter("@birthday", birthday),
                new SqlParameter("@phone", phone),
                new SqlParameter("@employee_address", employee_address),
                new SqlParameter("@email", email),
                new SqlParameter("@work_status", work_status));
        }
        public bool FindEmployee(ref string err, string employee_id, string job_id,
            string full_name, string gender, DateTime birthday, string phone,
            string employee_address, string email, bool work_status)
        {
            return db.MyExecuteNonQuery("SP_Find_Employee",
                ref err,
                new SqlParameter("@employee_id", employee_id),
                new SqlParameter("@job_id", job_id),
                new SqlParameter("@full_name", full_name),
                new SqlParameter("@gender", gender),
                new SqlParameter("@birthday", birthday),
                new SqlParameter("@phone", phone),
                new SqlParameter("@employee_address", employee_address),
                new SqlParameter("@email", email),
                new SqlParameter("@work_status", work_status));
        }
        public bool UpdateEmployee(ref string err, string employee_id, string job_id,
            string full_name, string gender, DateTime birthday, string phone,
            string employee_address, string email, bool work_status)
        {
            return db.MyExecuteNonQuery("SP_Update_Employee",
                ref err,
                new SqlParameter("@employee_id", employee_id),
                new SqlParameter("@job_id", job_id),
                new SqlParameter("@full_name", full_name),
                new SqlParameter("@gender", gender),
                new SqlParameter("@birthday", birthday),
                new SqlParameter("@phone", phone),
                new SqlParameter("@employee_address", employee_address),
                new SqlParameter("@email", email),
                new SqlParameter("@work_status", work_status));
        }
        public bool DeleteEmployee(ref string err, string employee_id)
        {
            return db.MyExecuteNonQuery("SP_Delete_Employee", ref err,
                new SqlParameter("@employee_id", employee_id));
        }
    }
}