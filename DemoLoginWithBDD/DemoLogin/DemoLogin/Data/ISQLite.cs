﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SQLite;       

namespace DemoLogin.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
        
    }

 
}
