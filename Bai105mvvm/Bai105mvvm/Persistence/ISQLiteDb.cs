﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Bai105mvvm.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
