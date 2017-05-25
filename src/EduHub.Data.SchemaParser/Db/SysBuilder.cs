using System;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.SchemaParser.Db
{
    internal static class SysBuilder
    {

        internal static List<T> ImportCsv<T>(CsvReader Reader, params (string ColumnName, Action<T, string> Mapper)[] Actions) where T : new()
        {
            var headers = Reader.Header.ToArray();
            var mapper = Actions.Select(a => (ColumnIndex: Array.IndexOf(headers, a.ColumnName), Mapper: a.Mapper)).ToArray();
            var results = new List<T>();

            while (true)
            {
                var record = Reader.ReadRecord();

                if (record == null)
                    break;

                var result = new T();

                for (int i = 0; i < mapper.Length; i++)
                {
                    var map = mapper[i];
                    map.Mapper(result, record[map.ColumnIndex]);
                }

                results.Add(result);
            }

            return results;
        }

    }
}
