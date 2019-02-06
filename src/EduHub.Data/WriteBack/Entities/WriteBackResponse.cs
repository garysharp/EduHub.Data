using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.WriteBack.Entities
{
    internal class WriteBackResponse : IWriteBackResponse
    {
        internal WriteBackResponse(IWriteBackDataSet DataSet, string Filename, DateTime Age, bool IsSuccess, string Message, IEnumerable<IWriteBackResponseRecord> Records)
        {
            this.DataSet = DataSet;
            this.Filename = Filename;
            this.Age = Age;
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.Records = Records;
        }

        /// <inheritdoc />
        public IWriteBackDataSet DataSet { get; }

        /// <inheritdoc />
        public string Filename { get; }

        /// <inheritdoc />
        public DateTime Age { get; }

        /// <inheritdoc />
        public bool IsSuccess { get; }

        /// <inheritdoc />
        public string Message { get; }

        /// <inheritdoc />
        public IEnumerable<IWriteBackResponseRecord> Records { get; }

        public static WriteBackResponse Create(WriteBackContext Context, IWriteBackDataSet DataSet)
        {
            // no response if the directory doesn't exit
            if (!Directory.Exists(Context.WriteBackResponsesDirectory))
                return null;

            var prefixPattern = $"{Context.EduHubContext.EduHubSiteIdentifier}_{DataSet.Name}.*";

            var latestResponse = Directory.GetFiles(Context.WriteBackResponsesDirectory, prefixPattern)
                .Where(p =>
                    p.EndsWith(".RESPONSE-SUCCESS", StringComparison.OrdinalIgnoreCase) ||
                    p.EndsWith(".RESPONSE-ERROR", StringComparison.OrdinalIgnoreCase))
                .Select(p => new
                {
                    path = p,
                    age = File.GetCreationTime(p),
                })
                .OrderByDescending(p => p.age)
                .FirstOrDefault();

            // no response
            if (latestResponse == null)
                return null;

            var isSuccess = latestResponse.path.EndsWith(".RESPONSE-SUCCESS", StringComparison.OrdinalIgnoreCase);
            var records = WriteBackResponseRecord.Load(latestResponse.path);

            string message;
            if (!isSuccess)
                message = "Write-Back Failed. See Records for details.";
            else if (records.Count > 0)
                message = records[0].ErrorText;
            else
                message = "Success";

            return new WriteBackResponse(DataSet, latestResponse.path, latestResponse.age, isSuccess, message, records);
        }
    }
}
