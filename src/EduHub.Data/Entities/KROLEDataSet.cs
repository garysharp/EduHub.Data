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
    /// Role Codes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KROLEDataSet : EduHubDataSet<KROLE>
    {
        /// <inheritdoc />
        public override string Name { get { return "KROLE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KROLEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KROLEKEY = new Lazy<Dictionary<string, KROLE>>(() => this.ToDictionary(i => i.KROLEKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KROLE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KROLE" /> fields for each CSV column header</returns>
        internal override Action<KROLE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KROLE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KROLEKEY":
                        mapper[i] = (e, v) => e.KROLEKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_NAME":
                        mapper[i] = (e, v) => e.ROLE_NAME = v;
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
        /// Merges <see cref="KROLE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KROLE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KROLE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KROLE}"/> of entities</returns>
        internal override IEnumerable<KROLE> ApplyDeltaEntities(IEnumerable<KROLE> Entities, List<KROLE> DeltaEntities)
        {
            HashSet<string> Index_KROLEKEY = new HashSet<string>(DeltaEntities.Select(i => i.KROLEKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KROLEKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KROLEKEY.Remove(entity.KROLEKEY);
                            
                            if (entity.KROLEKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KROLE>> Index_KROLEKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <returns>Related KROLE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KROLE FindByKROLEKEY(string KROLEKEY)
        {
            return Index_KROLEKEY.Value[KROLEKEY];
        }

        /// <summary>
        /// Attempt to find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <param name="Value">Related KROLE entity</param>
        /// <returns>True if the related KROLE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKROLEKEY(string KROLEKEY, out KROLE Value)
        {
            return Index_KROLEKEY.Value.TryGetValue(KROLEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <returns>Related KROLE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KROLE TryFindByKROLEKEY(string KROLEKEY)
        {
            KROLE value;
            if (Index_KROLEKEY.Value.TryGetValue(KROLEKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KROLE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KROLE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KROLE](
        [KROLEKEY] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [ROLE_NAME] varchar(32) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KROLE_Index_KROLEKEY] PRIMARY KEY CLUSTERED (
            [KROLEKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KROLEDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KROLEDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KROLE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KROLE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KROLE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KROLEKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KROLEKEY.Add(entity.KROLEKEY);
            }

            builder.AppendLine("DELETE [dbo].[KROLE] WHERE");


            // Index_KROLEKEY
            builder.Append("[KROLEKEY] IN (");
            for (int index = 0; index < Index_KROLEKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KROLEKEY
                var parameterKROLEKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKROLEKEY);
                command.Parameters.Add(parameterKROLEKEY, SqlDbType.VarChar, 2).Value = Index_KROLEKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KROLE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KROLE data set</returns>
        public override EduHubDataSetDataReader<KROLE> GetDataSetDataReader()
        {
            return new KROLEDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KROLE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KROLE data set</returns>
        public override EduHubDataSetDataReader<KROLE> GetDataSetDataReader(List<KROLE> Entities)
        {
            return new KROLEDataReader(new EduHubDataSetLoadedReader<KROLE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KROLEDataReader : EduHubDataSetDataReader<KROLE>
        {
            public KROLEDataReader(IEduHubDataSetReader<KROLE> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KROLEKEY
                        return Current.KROLEKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // ROLE_NAME
                        return Current.ROLE_NAME;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // ROLE_NAME
                        return Current.ROLE_NAME == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KROLEKEY
                        return "KROLEKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ROLE_NAME
                        return "ROLE_NAME";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KROLEKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ROLE_NAME":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
