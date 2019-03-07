using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Decrypted data IMPORT Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class A_DECRYPDataSet : EduHubDataSet<A_DECRYP>
    {
        /// <inheritdoc />
        public override string Name { get { return "A_DECRYP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal A_DECRYPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, A_DECRYP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="A_DECRYP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="A_DECRYP" /> fields for each CSV column header</returns>
        internal override Action<A_DECRYP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<A_DECRYP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "LINE_TYPE":
                        mapper[i] = (e, v) => e.LINE_TYPE = v;
                        break;
                    case "RECORD":
                        mapper[i] = (e, v) => e.RECORD = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="A_DECRYP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="A_DECRYP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="A_DECRYP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{A_DECRYP}"/> of entities</returns>
        internal override IEnumerable<A_DECRYP> ApplyDeltaEntities(IEnumerable<A_DECRYP> Entities, List<A_DECRYP> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TID.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<Dictionary<int, A_DECRYP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public A_DECRYP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <param name="Value">Related A_DECRYP entity</param>
        /// <returns>True if the related A_DECRYP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out A_DECRYP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public A_DECRYP TryFindByTID(int TID)
        {
            A_DECRYP value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a A_DECRYP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[A_DECRYP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[A_DECRYP](
        [TID] int IDENTITY NOT NULL,
        [LINE_TYPE] varchar(10) NULL,
        [RECORD] varchar(200) NULL,
        [LW_DATE] datetime NULL,
        CONSTRAINT [A_DECRYP_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="A_DECRYPDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="A_DECRYPDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="A_DECRYP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="A_DECRYP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<A_DECRYP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[A_DECRYP] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the A_DECRYP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the A_DECRYP data set</returns>
        public override EduHubDataSetDataReader<A_DECRYP> GetDataSetDataReader()
        {
            return new A_DECRYPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the A_DECRYP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the A_DECRYP data set</returns>
        public override EduHubDataSetDataReader<A_DECRYP> GetDataSetDataReader(List<A_DECRYP> Entities)
        {
            return new A_DECRYPDataReader(new EduHubDataSetLoadedReader<A_DECRYP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class A_DECRYPDataReader : EduHubDataSetDataReader<A_DECRYP>
        {
            public A_DECRYPDataReader(IEduHubDataSetReader<A_DECRYP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // LINE_TYPE
                        return Current.LINE_TYPE;
                    case 2: // RECORD
                        return Current.RECORD;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LINE_TYPE
                        return Current.LINE_TYPE == null;
                    case 2: // RECORD
                        return Current.RECORD == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // LINE_TYPE
                        return "LINE_TYPE";
                    case 2: // RECORD
                        return "RECORD";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "LINE_TYPE":
                        return 1;
                    case "RECORD":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
