namespace EduHub.Data.SchemaParser.Db
{
    public class SysColumn
    {
        public int object_id { get; set; }
        public string name { get; set; }
        public int column_id { get; set; }
        public int user_type_id { get; set; }
        public int max_length { get; set; }
        public bool is_nullable { get; set; }
        public bool is_identity { get; set; }
    }
}
