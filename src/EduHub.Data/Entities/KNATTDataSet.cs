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
    /// Notes and Attachment Type Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNATTDataSet : EduHubDataSet<KNATT>
    {
        /// <inheritdoc />
        public override string Name { get { return "KNATT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KNATTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KNATTKEY = new Lazy<Dictionary<string, KNATT>>(() => this.ToDictionary(i => i.KNATTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KNATT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KNATT" /> fields for each CSV column header</returns>
        internal override Action<KNATT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KNATT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KNATTKEY":
                        mapper[i] = (e, v) => e.KNATTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="KNATT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KNATT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KNATT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KNATT}"/> of entities</returns>
        internal override IEnumerable<KNATT> ApplyDeltaEntities(IEnumerable<KNATT> Entities, List<KNATT> DeltaEntities)
        {
            HashSet<string> Index_KNATTKEY = new HashSet<string>(DeltaEntities.Select(i => i.KNATTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KNATTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KNATTKEY.Remove(entity.KNATTKEY);
                            
                            if (entity.KNATTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KNATT>> Index_KNATTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KNATT by KNATTKEY field
        /// </summary>
        /// <param name="KNATTKEY">KNATTKEY value used to find KNATT</param>
        /// <returns>Related KNATT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNATT FindByKNATTKEY(string KNATTKEY)
        {
            return Index_KNATTKEY.Value[KNATTKEY];
        }

        /// <summary>
        /// Attempt to find KNATT by KNATTKEY field
        /// </summary>
        /// <param name="KNATTKEY">KNATTKEY value used to find KNATT</param>
        /// <param name="Value">Related KNATT entity</param>
        /// <returns>True if the related KNATT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKNATTKEY(string KNATTKEY, out KNATT Value)
        {
            return Index_KNATTKEY.Value.TryGetValue(KNATTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KNATT by KNATTKEY field
        /// </summary>
        /// <param name="KNATTKEY">KNATTKEY value used to find KNATT</param>
        /// <returns>Related KNATT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNATT TryFindByKNATTKEY(string KNATTKEY)
        {
            KNATT value;
            if (Index_KNATTKEY.Value.TryGetValue(KNATTKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KNATT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KNATT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KNATT](
        [KNATTKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KNATT_Index_KNATTKEY] PRIMARY KEY CLUSTERED (
            [KNATTKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KNATTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KNATTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KNATT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KNATT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KNATT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KNATTKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KNATTKEY.Add(entity.KNATTKEY);
            }

            builder.AppendLine("DELETE [dbo].[KNATT] WHERE");


            // Index_KNATTKEY
            builder.Append("[KNATTKEY] IN (");
            for (int index = 0; index < Index_KNATTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KNATTKEY
                var parameterKNATTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKNATTKEY);
                command.Parameters.Add(parameterKNATTKEY, SqlDbType.VarChar, 10).Value = Index_KNATTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KNATT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KNATT data set</returns>
        public override EduHubDataSetDataReader<KNATT> GetDataSetDataReader()
        {
            return new KNATTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KNATT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KNATT data set</returns>
        public override EduHubDataSetDataReader<KNATT> GetDataSetDataReader(List<KNATT> Entities)
        {
            return new KNATTDataReader(new EduHubDataSetLoadedReader<KNATT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KNATTDataReader : EduHubDataSetDataReader<KNATT>
        {
            public KNATTDataReader(IEduHubDataSetReader<KNATT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KNATTKEY
                        return Current.KNATTKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // LW_DATE
                        return Current.LW_DATE;
                    case 3: // LW_TIME
                        return Current.LW_TIME;
                    case 4: // LW_USER
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
                    case 2: // LW_DATE
                        return Current.LW_DATE == null;
                    case 3: // LW_TIME
                        return Current.LW_TIME == null;
                    case 4: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KNATTKEY
                        return "KNATTKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KNATTKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
