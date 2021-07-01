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
    /// Staff Positions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSCDataSet : EduHubDataSet<KSC>
    {
        /// <inheritdoc />
        public override string Name { get { return "KSC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KSCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSCKEY = new Lazy<Dictionary<string, KSC>>(() => this.ToDictionary(i => i.KSCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSC" /> fields for each CSV column header</returns>
        internal override Action<KSC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSCKEY":
                        mapper[i] = (e, v) => e.KSCKEY = v;
                        break;
                    case "SF_POSITION":
                        mapper[i] = (e, v) => e.SF_POSITION = v;
                        break;
                    case "ALLOTMENT":
                        mapper[i] = (e, v) => e.ALLOTMENT = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="KSC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KSC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KSC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KSC}"/> of entities</returns>
        internal override IEnumerable<KSC> ApplyDeltaEntities(IEnumerable<KSC> Entities, List<KSC> DeltaEntities)
        {
            HashSet<string> Index_KSCKEY = new HashSet<string>(DeltaEntities.Select(i => i.KSCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KSCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KSCKEY.Remove(entity.KSCKEY);
                            
                            if (entity.KSCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KSC>> Index_KSCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSC FindByKSCKEY(string KSCKEY)
        {
            return Index_KSCKEY.Value[KSCKEY];
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <param name="Value">Related KSC entity</param>
        /// <returns>True if the related KSC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSCKEY(string KSCKEY, out KSC Value)
        {
            return Index_KSCKEY.Value.TryGetValue(KSCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSC TryFindByKSCKEY(string KSCKEY)
        {
            KSC value;
            if (Index_KSCKEY.Value.TryGetValue(KSCKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KSC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSC](
        [KSCKEY] varchar(6) NOT NULL,
        [SF_POSITION] varchar(30) NULL,
        [ALLOTMENT] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSC_Index_KSCKEY] PRIMARY KEY CLUSTERED (
            [KSCKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KSCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KSCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KSC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KSC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KSC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KSCKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KSCKEY.Add(entity.KSCKEY);
            }

            builder.AppendLine("DELETE [dbo].[KSC] WHERE");


            // Index_KSCKEY
            builder.Append("[KSCKEY] IN (");
            for (int index = 0; index < Index_KSCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KSCKEY
                var parameterKSCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKSCKEY);
                command.Parameters.Add(parameterKSCKEY, SqlDbType.VarChar, 6).Value = Index_KSCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSC data set</returns>
        public override EduHubDataSetDataReader<KSC> GetDataSetDataReader()
        {
            return new KSCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSC data set</returns>
        public override EduHubDataSetDataReader<KSC> GetDataSetDataReader(List<KSC> Entities)
        {
            return new KSCDataReader(new EduHubDataSetLoadedReader<KSC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSCDataReader : EduHubDataSetDataReader<KSC>
        {
            public KSCDataReader(IEduHubDataSetReader<KSC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KSCKEY
                        return Current.KSCKEY;
                    case 1: // SF_POSITION
                        return Current.SF_POSITION;
                    case 2: // ALLOTMENT
                        return Current.ALLOTMENT;
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
                    case 1: // SF_POSITION
                        return Current.SF_POSITION == null;
                    case 2: // ALLOTMENT
                        return Current.ALLOTMENT == null;
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
                    case 0: // KSCKEY
                        return "KSCKEY";
                    case 1: // SF_POSITION
                        return "SF_POSITION";
                    case 2: // ALLOTMENT
                        return "ALLOTMENT";
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
                    case "KSCKEY":
                        return 0;
                    case "SF_POSITION":
                        return 1;
                    case "ALLOTMENT":
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
