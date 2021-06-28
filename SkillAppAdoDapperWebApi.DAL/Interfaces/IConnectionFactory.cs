﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection GetSqlConnection { get; }
        void SetConnection(string connectionString);
    }
}
