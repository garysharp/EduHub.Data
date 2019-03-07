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
    /// School Associations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCADataSet : EduHubDataSet<SCA>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SCADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCAKEY = new Lazy<Dictionary<string, SCA>>(() => this.ToDictionary(i => i.SCAKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCA" /> fields for each CSV column header</returns>
        internal override Action<SCA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCAKEY":
                        mapper[i] = (e, v) => e.SCAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FIRST_DATE":
                        mapper[i] = (e, v) => e.FIRST_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_DATE":
                        mapper[i] = (e, v) => e.LAST_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SCA_MEMO":
                        mapper[i] = (e, v) => e.SCA_MEMO = v;
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
        /// Merges <see cref="SCA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCA}"/> of entities</returns>
        internal override IEnumerable<SCA> ApplyDeltaEntities(IEnumerable<SCA> Entities, List<SCA> DeltaEntities)
        {
            HashSet<string> Index_SCAKEY = new HashSet<string>(DeltaEntities.Select(i => i.SCAKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCAKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SCAKEY.Remove(entity.SCAKEY);
                            
                            if (entity.SCAKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, SCA>> Index_SCAKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCA FindBySCAKEY(string SCAKEY)
        {
            return Index_SCAKEY.Value[SCAKEY];
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <param name="Value">Related SCA entity</param>
        /// <returns>True if the related SCA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAKEY(string SCAKEY, out SCA Value)
        {
            return Index_SCAKEY.Value.TryGetValue(SCAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCA TryFindBySCAKEY(string SCAKEY)
        {
            SCA value;
            if (Index_SCAKEY.Value.TryGetValue(SCAKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCA](
        [SCAKEY] varchar(15) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [FIRST_DATE] datetime NULL,
        [LAST_DATE] datetime NULL,
        [SCA_MEMO] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCA_Index_SCAKEY] PRIMARY KEY CLUSTERED (
            [SCAKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCADataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCADataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SCAKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SCAKEY.Add(entity.SCAKEY);
            }

            builder.AppendLine("DELETE [dbo].[SCA] WHERE");


            // Index_SCAKEY
            builder.Append("[SCAKEY] IN (");
            for (int index = 0; index < Index_SCAKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCAKEY
                var parameterSCAKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSCAKEY);
                command.Parameters.Add(parameterSCAKEY, SqlDbType.VarChar, 15).Value = Index_SCAKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCA data set</returns>
        public override EduHubDataSetDataReader<SCA> GetDataSetDataReader()
        {
            return new SCADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCA data set</returns>
        public override EduHubDataSetDataReader<SCA> GetDataSetDataReader(List<SCA> Entities)
        {
            return new SCADataReader(new EduHubDataSetLoadedReader<SCA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCADataReader : EduHubDataSetDataReader<SCA>
        {
            public SCADataReader(IEduHubDataSetReader<SCA> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCAKEY
                        return Current.SCAKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // FIRST_DATE
                        return Current.FIRST_DATE;
                    case 3: // LAST_DATE
                        return Current.LAST_DATE;
                    case 4: // SCA_MEMO
                        return Current.SCA_MEMO;
                    case 5: // LW_DATE
                        return Current.LW_DATE;
                    case 6: // LW_TIME
                        return Current.LW_TIME;
                    case 7: // LW_USER
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
                    case 2: // FIRST_DATE
                        return Current.FIRST_DATE == null;
                    case 3: // LAST_DATE
                        return Current.LAST_DATE == null;
                    case 4: // SCA_MEMO
                        return Current.SCA_MEMO == null;
                    case 5: // LW_DATE
                        return Current.LW_DATE == null;
                    case 6: // LW_TIME
                        return Current.LW_TIME == null;
                    case 7: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCAKEY
                        return "SCAKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // FIRST_DATE
                        return "FIRST_DATE";
                    case 3: // LAST_DATE
                        return "LAST_DATE";
                    case 4: // SCA_MEMO
                        return "SCA_MEMO";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCAKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "FIRST_DATE":
                        return 2;
                    case "LAST_DATE":
                        return 3;
                    case "SCA_MEMO":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
