namespace EduHub.Data.SchemaParser.Db
{
    public class SysIndexColumn
    {
        public int object_id { get; set; }
        public int index_id { get; set; }
        public int column_id { get; set; }
        public byte key_ordinal { get; set; }
    }
}
