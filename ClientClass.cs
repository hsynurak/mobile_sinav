using SQLite;
using System;

namespace A026.Data.ClientClass
{
    public class ClientClass
    {
        [PrimaryKey, AutoIncrement]
        public int C_ID { get; set; }
        public string C_Name { get; set; }
        public string C_L_Name { get; set; }
        public string C_Tel { get; set; }
        public bool C_Main_Intr1 { get; set; }
        public bool C_Main_Intr2 { get; set; }

    }
}
