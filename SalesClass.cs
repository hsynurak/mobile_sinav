using SQLite;

namespace A026.Data.ClientClass
{
    public class SalesClass
    {
        [PrimaryKey, AutoIncrement]
        public int S_Id { get; set; }
        public string S_Name { get; set; }
        public string S_L_Name { get; set; }
        public int S_Tel { get; set; }
        public decimal S_Intr { get; set; }
    }
}
