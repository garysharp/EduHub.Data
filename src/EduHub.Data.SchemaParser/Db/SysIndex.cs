namespace EduHub.Data.SchemaParser.Db
{
    public class SysIndex
    {
        public int object_id { get; set; }
        public string name { get; set; }
        public int index_id { get; set; }
        public int type { get; set; }
        public bool is_unique { get; set; }
        public bool is_primary_key { get; set; }
    }
}
