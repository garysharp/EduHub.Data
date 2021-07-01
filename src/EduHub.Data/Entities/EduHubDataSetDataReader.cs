using System;
using System.Collections.Generic;
using System.Data;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// An <see cref="IDataReader"/> and <see cref="IDataRecord"/> for eduHub data sets
    /// </summary>
    /// <typeparam name="T">The <see cref="EduHubEntity"/> entity</typeparam>
    public abstract class EduHubDataSetDataReader<T> : IEduHubDataSetDataReader where T : EduHubEntity
    {
        /// <summary>
        /// A eduHub data set iterator reader
        /// </summary>
        protected readonly IEduHubDataSetReader<T> Reader;
        /// <summary>
        /// The enumerator for the reader
        /// </summary>
        protected readonly IEnumerator<T> ReaderEnumerator;
        /// <summary>
        /// The current entity
        /// </summary>
        protected T Current;

        internal EduHubDataSetDataReader(IEduHubDataSetReader<T> Reader)
        {
            this.Reader = Reader;
            ReaderEnumerator = Reader.GetEnumerator();
        }

        /// <inheritdoc />
        public bool HasEntities { get { return Reader.HasEntities; } }

        /// <inheritdoc />
        public double Progress { get { return Reader.Progress; } }

        /// <inheritdoc />
        public int EntitiesRead { get { return Reader.EntitiesRead; } }

        /// <inheritdoc />
        public DateTime? EntityLastModifiedMax { get { return Reader.EntityLastModifiedMax; } }

        /// <inheritdoc />
        public abstract int FieldCount { get; }

        /// <inheritdoc />
        public bool IsClosed { get { return false; } }

        /// <inheritdoc />
        public object this[string name]
        {
            get
            {
                return GetValue(GetOrdinal(name));
            }
        }

        /// <inheritdoc />
        public object this[int i]
        {
            get
            {
                return GetValue(i);
            }
        }

        /// <inheritdoc />
        public bool Read()
        {
            if (ReaderEnumerator.MoveNext())
            {
                Current = ReaderEnumerator.Current;
                return true;
            }
            else
            {
                Current = null;
                return false;
            }
        }

        /// <inheritdoc />
        public abstract object GetValue(int i);

        /// <inheritdoc />
        public abstract bool IsDBNull(int i);

        /// <inheritdoc />
        public abstract string GetName(int ordinal);

        /// <inheritdoc />
        public abstract int GetOrdinal(string name);

        /// <inheritdoc />
        public int Depth { get { throw new NotImplementedException(); } }
        /// <inheritdoc />
        public int RecordsAffected { get { throw new NotImplementedException(); } }
        /// <inheritdoc />
        public void Close() { throw new NotImplementedException(); }
        /// <inheritdoc />
        public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public byte GetByte(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public char GetChar(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public IDataReader GetData(int i) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public double GetDouble(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public float GetFloat(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public short GetInt16(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public int GetInt32(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public long GetInt64(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public string GetString(int ordinal) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public int GetValues(object[] values) { throw new NotImplementedException(); }
        /// <inheritdoc />
        public bool NextResult() { throw new NotImplementedException(); }
        /// <inheritdoc />
        public DataTable GetSchemaTable() { throw new NotImplementedException(); }

        /// <inheritdoc />
        public void Dispose()
        {
            ReaderEnumerator.Dispose();
            Reader.Dispose();
        }
    }
}
