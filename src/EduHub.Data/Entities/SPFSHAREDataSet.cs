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
    /// File Sharing Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPFSHAREDataSet : EduHubDataSet<SPFSHARE>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPFSHARE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPFSHAREDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, SPFSHARE>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPFSHARE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPFSHARE" /> fields for each CSV column header</returns>
        internal override Action<SPFSHARE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPFSHARE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FILE_NAME":
                        mapper[i] = (e, v) => e.FILE_NAME = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FILE_ID":
                        mapper[i] = (e, v) => e.FILE_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "CREATED_DATE":
                        mapper[i] = (e, v) => e.CREATED_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EXPIRY_DATE":
                        mapper[i] = (e, v) => e.EXPIRY_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SUMMARY":
                        mapper[i] = (e, v) => e.SUMMARY = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SPFSHARE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPFSHARE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPFSHARE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPFSHARE}"/> of entities</returns>
        internal override IEnumerable<SPFSHARE> ApplyDeltaEntities(IEnumerable<SPFSHARE> Entities, List<SPFSHARE> DeltaEntities)
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

        private Lazy<Dictionary<int, SPFSHARE>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPFSHARE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPFSHARE</param>
        /// <returns>Related SPFSHARE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPFSHARE FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPFSHARE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPFSHARE</param>
        /// <param name="Value">Related SPFSHARE entity</param>
        /// <returns>True if the related SPFSHARE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPFSHARE Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPFSHARE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPFSHARE</param>
        /// <returns>Related SPFSHARE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPFSHARE TryFindByTID(int TID)
        {
            SPFSHARE value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPFSHARE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPFSHARE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPFSHARE](
        [TID] int IDENTITY NOT NULL,
        [FILE_NAME] varchar(50) NULL,
        [DESCRIPTION] varchar(100) NULL,
        [FILE_ID] int NULL,
        [CATEGORY] varchar(3) NULL,
        [CREATED_DATE] datetime NULL,
        [EXPIRY_DATE] datetime NULL,
        [SUMMARY] varchar(MAX) NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPFSHARE_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SPFSHAREDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SPFSHAREDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPFSHARE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPFSHARE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPFSHARE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SPFSHARE] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SPFSHARE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPFSHARE data set</returns>
        public override EduHubDataSetDataReader<SPFSHARE> GetDataSetDataReader()
        {
            return new SPFSHAREDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPFSHARE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPFSHARE data set</returns>
        public override EduHubDataSetDataReader<SPFSHARE> GetDataSetDataReader(List<SPFSHARE> Entities)
        {
            return new SPFSHAREDataReader(new EduHubDataSetLoadedReader<SPFSHARE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPFSHAREDataReader : EduHubDataSetDataReader<SPFSHARE>
        {
            public SPFSHAREDataReader(IEduHubDataSetReader<SPFSHARE> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // FILE_NAME
                        return Current.FILE_NAME;
                    case 2: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 3: // FILE_ID
                        return Current.FILE_ID;
                    case 4: // CATEGORY
                        return Current.CATEGORY;
                    case 5: // CREATED_DATE
                        return Current.CREATED_DATE;
                    case 6: // EXPIRY_DATE
                        return Current.EXPIRY_DATE;
                    case 7: // SUMMARY
                        return Current.SUMMARY;
                    case 8: // LW_TIME
                        return Current.LW_TIME;
                    case 9: // LW_DATE
                        return Current.LW_DATE;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // FILE_NAME
                        return Current.FILE_NAME == null;
                    case 2: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 3: // FILE_ID
                        return Current.FILE_ID == null;
                    case 4: // CATEGORY
                        return Current.CATEGORY == null;
                    case 5: // CREATED_DATE
                        return Current.CREATED_DATE == null;
                    case 6: // EXPIRY_DATE
                        return Current.EXPIRY_DATE == null;
                    case 7: // SUMMARY
                        return Current.SUMMARY == null;
                    case 8: // LW_TIME
                        return Current.LW_TIME == null;
                    case 9: // LW_DATE
                        return Current.LW_DATE == null;
                    case 10: // LW_USER
                        return Current.LW_USER == null;
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
                    case 1: // FILE_NAME
                        return "FILE_NAME";
                    case 2: // DESCRIPTION
                        return "DESCRIPTION";
                    case 3: // FILE_ID
                        return "FILE_ID";
                    case 4: // CATEGORY
                        return "CATEGORY";
                    case 5: // CREATED_DATE
                        return "CREATED_DATE";
                    case 6: // EXPIRY_DATE
                        return "EXPIRY_DATE";
                    case 7: // SUMMARY
                        return "SUMMARY";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_USER
                        return "LW_USER";
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
                    case "FILE_NAME":
                        return 1;
                    case "DESCRIPTION":
                        return 2;
                    case "FILE_ID":
                        return 3;
                    case "CATEGORY":
                        return 4;
                    case "CREATED_DATE":
                        return 5;
                    case "EXPIRY_DATE":
                        return 6;
                    case "SUMMARY":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
