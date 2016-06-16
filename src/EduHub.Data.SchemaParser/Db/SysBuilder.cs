using System;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.SchemaParser.Db
{
    internal static class SysBuilder
    {

        internal static List<T> ImportCsv<T>(CsvReader Reader, params Tuple<string, Action<T, string>>[] Actions) where T : new()
        {
            var headers = Reader.Header.ToArray();
            var mapper = Actions.Select(a => Tuple.Create(Array.IndexOf(headers, a.Item1), a.Item2)).ToArray();
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
                    map.Item2(result, record[map.Item1]);
                }

                results.Add(result);
            }

            return results;
        }

    }
}
