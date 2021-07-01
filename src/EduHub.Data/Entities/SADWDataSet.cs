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
    /// Accident Witnesses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADWDataSet : EduHubDataSet<SADW>
    {
        /// <inheritdoc />
        public override string Name { get { return "SADW"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SADWDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACCIDENTID = new Lazy<Dictionary<int, IReadOnlyList<SADW>>>(() => this.ToGroupedDictionary(i => i.ACCIDENTID));
            Index_TID = new Lazy<Dictionary<int, SADW>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADW" /> fields for each CSV column header</returns>
        internal override Action<SADW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = int.Parse(v);
                        break;
                    case "WITNESS_TYPE":
                        mapper[i] = (e, v) => e.WITNESS_TYPE = v;
                        break;
                    case "WITNESSKEY":
                        mapper[i] = (e, v) => e.WITNESSKEY = v;
                        break;
                    case "WITNESS_DFAB":
                        mapper[i] = (e, v) => e.WITNESS_DFAB = v;
                        break;
                    case "FULL_NAME":
                        mapper[i] = (e, v) => e.FULL_NAME = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SADW" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SADW" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SADW" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SADW}"/> of entities</returns>
        internal override IEnumerable<SADW> ApplyDeltaEntities(IEnumerable<SADW> Entities, List<SADW> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ACCIDENTID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.ACCIDENTID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, IReadOnlyList<SADW>>> Index_ACCIDENTID;
        private Lazy<Dictionary<int, SADW>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <returns>List of related SADW entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADW> FindByACCIDENTID(int ACCIDENTID)
        {
            return Index_ACCIDENTID.Value[ACCIDENTID];
        }

        /// <summary>
        /// Attempt to find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <param name="Value">List of related SADW entities</param>
        /// <returns>True if the list of related SADW entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID(int ACCIDENTID, out IReadOnlyList<SADW> Value)
        {
            return Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <returns>List of related SADW entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADW> TryFindByACCIDENTID(int ACCIDENTID)
        {
            IReadOnlyList<SADW> value;
            if (Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <returns>Related SADW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADW FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <param name="Value">Related SADW entity</param>
        /// <returns>True if the related SADW entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SADW Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <returns>Related SADW entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADW TryFindByTID(int TID)
        {
            SADW value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SADW table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SADW]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SADW](
        [TID] int IDENTITY NOT NULL,
        [ACCIDENTID] int NOT NULL,
        [WITNESS_TYPE] varchar(2) NULL,
        [WITNESSKEY] varchar(10) NULL,
        [WITNESS_DFAB] varchar(1) NULL,
        [FULL_NAME] varchar(64) NULL,
        [ADDRESS] varchar(120) NULL,
        [TELEPHONE] varchar(20) NULL,
        [STATEMENT] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SADW_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SADW_Index_ACCIDENTID] ON [dbo].[SADW]
    (
            [ACCIDENTID] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SADW]') AND name = N'SADW_Index_TID')
    ALTER INDEX [SADW_Index_TID] ON [dbo].[SADW] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SADW]') AND name = N'SADW_Index_TID')
    ALTER INDEX [SADW_Index_TID] ON [dbo].[SADW] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SADW"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SADW"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SADW> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SADW] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SADW data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADW data set</returns>
        public override EduHubDataSetDataReader<SADW> GetDataSetDataReader()
        {
            return new SADWDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SADW data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADW data set</returns>
        public override EduHubDataSetDataReader<SADW> GetDataSetDataReader(List<SADW> Entities)
        {
            return new SADWDataReader(new EduHubDataSetLoadedReader<SADW>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SADWDataReader : EduHubDataSetDataReader<SADW>
        {
            public SADWDataReader(IEduHubDataSetReader<SADW> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 12; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ACCIDENTID
                        return Current.ACCIDENTID;
                    case 2: // WITNESS_TYPE
                        return Current.WITNESS_TYPE;
                    case 3: // WITNESSKEY
                        return Current.WITNESSKEY;
                    case 4: // WITNESS_DFAB
                        return Current.WITNESS_DFAB;
                    case 5: // FULL_NAME
                        return Current.FULL_NAME;
                    case 6: // ADDRESS
                        return Current.ADDRESS;
                    case 7: // TELEPHONE
                        return Current.TELEPHONE;
                    case 8: // STATEMENT
                        return Current.STATEMENT;
                    case 9: // LW_DATE
                        return Current.LW_DATE;
                    case 10: // LW_TIME
                        return Current.LW_TIME;
                    case 11: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // WITNESS_TYPE
                        return Current.WITNESS_TYPE == null;
                    case 3: // WITNESSKEY
                        return Current.WITNESSKEY == null;
                    case 4: // WITNESS_DFAB
                        return Current.WITNESS_DFAB == null;
                    case 5: // FULL_NAME
                        return Current.FULL_NAME == null;
                    case 6: // ADDRESS
                        return Current.ADDRESS == null;
                    case 7: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 8: // STATEMENT
                        return Current.STATEMENT == null;
                    case 9: // LW_DATE
                        return Current.LW_DATE == null;
                    case 10: // LW_TIME
                        return Current.LW_TIME == null;
                    case 11: // LW_USER
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
                    case 1: // ACCIDENTID
                        return "ACCIDENTID";
                    case 2: // WITNESS_TYPE
                        return "WITNESS_TYPE";
                    case 3: // WITNESSKEY
                        return "WITNESSKEY";
                    case 4: // WITNESS_DFAB
                        return "WITNESS_DFAB";
                    case 5: // FULL_NAME
                        return "FULL_NAME";
                    case 6: // ADDRESS
                        return "ADDRESS";
                    case 7: // TELEPHONE
                        return "TELEPHONE";
                    case 8: // STATEMENT
                        return "STATEMENT";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
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
                    case "ACCIDENTID":
                        return 1;
                    case "WITNESS_TYPE":
                        return 2;
                    case "WITNESSKEY":
                        return 3;
                    case "WITNESS_DFAB":
                        return 4;
                    case "FULL_NAME":
                        return 5;
                    case "ADDRESS":
                        return 6;
                    case "TELEPHONE":
                        return 7;
                    case "STATEMENT":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
