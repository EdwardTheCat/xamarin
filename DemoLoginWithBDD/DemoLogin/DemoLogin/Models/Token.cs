using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLogin.Models
{
    
    class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime exprire_date { get; set; }

        public Token() {}

    }
}
