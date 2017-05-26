using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Signatories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BANKSIGDataSet : EduHubDataSet<BANKSIG>
    {
        /// <inheritdoc />
        public override string Name { get { return "BANKSIG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal BANKSIGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<Dictionary<string, IReadOnlyList<BANKSIG>>>(() => this.ToGroupedDictionary(i => i.GLCODE));
            Index_TID = new Lazy<Dictionary<int, BANKSIG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BANKSIG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BANKSIG" /> fields for each CSV column header</returns>
        internal override Action<BANKSIG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BANKSIG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "SIGNATORY":
                        mapper[i] = (e, v) => e.SIGNATORY = v;
                        break;
                    case "BANK_ROLE":
                        mapper[i] = (e, v) => e.BANK_ROLE = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="BANKSIG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="BANKSIG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="BANKSIG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{BANKSIG}"/> of entities</returns>
        internal override IEnumerable<BANKSIG> ApplyDeltaEntities(IEnumerable<BANKSIG> Entities, List<BANKSIG> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.GLCODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.GLCODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<BANKSIG>>> Index_GLCODE;
        private Lazy<Dictionary<int, BANKSIG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BANKSIG by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find BANKSIG</param>
        /// <returns>List of related BANKSIG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BANKSIG> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find BANKSIG by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find BANKSIG</param>
        /// <param name="Value">List of related BANKSIG entities</param>
        /// <returns>True if the list of related BANKSIG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<BANKSIG> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find BANKSIG by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find BANKSIG</param>
        /// <returns>List of related BANKSIG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BANKSIG> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<BANKSIG> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BANKSIG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BANKSIG</param>
        /// <returns>Related BANKSIG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BANKSIG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find BANKSIG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BANKSIG</param>
        /// <param name="Value">Related BANKSIG entity</param>
        /// <returns>True if the related BANKSIG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out BANKSIG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find BANKSIG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BANKSIG</param>
        /// <returns>Related BANKSIG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BANKSIG TryFindByTID(int TID)
        {
            BANKSIG value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a BANKSIG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[BANKSIG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[BANKSIG](
        [TID] int IDENTITY NOT NULL,
        [GLCODE] varchar(10) NOT NULL,
        [SIGNATORY] varchar(30) NULL,
        [BANK_ROLE] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [BANKSIG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [BANKSIG_Index_GLCODE] ON [dbo].[BANKSIG]
    (
            [GLCODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[BANKSIG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[BANKSIG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[BANKSIG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[BANKSIG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="BANKSIG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="BANKSIG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<BANKSIG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[BANKSIG] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the BANKSIG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BANKSIG data set</returns>
        public override EduHubDataSetDataReader<BANKSIG> GetDataSetDataReader()
        {
            return new BANKSIGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the BANKSIG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BANKSIG data set</returns>
        public override EduHubDataSetDataReader<BANKSIG> GetDataSetDataReader(List<BANKSIG> Entities)
        {
            return new BANKSIGDataReader(new EduHubDataSetLoadedReader<BANKSIG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class BANKSIGDataReader : EduHubDataSetDataReader<BANKSIG>
        {
            public BANKSIGDataReader(IEduHubDataSetReader<BANKSIG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // GLCODE
                        return Current.GLCODE;
                    case 2: // SIGNATORY
                        return Current.SIGNATORY;
                    case 3: // BANK_ROLE
                        return Current.BANK_ROLE;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SIGNATORY
                        return Current.SIGNATORY == null;
                    case 3: // BANK_ROLE
                        return Current.BANK_ROLE == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
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
                    case 1: // GLCODE
                        return "GLCODE";
                    case 2: // SIGNATORY
                        return "SIGNATORY";
                    case 3: // BANK_ROLE
                        return "BANK_ROLE";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
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
                    case "GLCODE":
                        return 1;
                    case "SIGNATORY":
                        return 2;
                    case "BANK_ROLE":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
