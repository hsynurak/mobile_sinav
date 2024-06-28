using SQLite;

namespace A026.Data
{
    public class Assignment
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int C_ID { get; set; }  // Client ID
        public int S_Id { get; set; }  // Sales Rep ID
    }
}
