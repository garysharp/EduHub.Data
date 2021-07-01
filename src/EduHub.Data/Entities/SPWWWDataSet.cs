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
    /// Report WWW templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPWWWDataSet : EduHubDataSet<SPWWW>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPWWW"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPWWWDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SPWWWKEY = new Lazy<Dictionary<string, SPWWW>>(() => this.ToDictionary(i => i.SPWWWKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPWWW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPWWW" /> fields for each CSV column header</returns>
        internal override Action<SPWWW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPWWW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPWWWKEY":
                        mapper[i] = (e, v) => e.SPWWWKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
                        break;
                    case "DISPLAY_NAME":
                        mapper[i] = (e, v) => e.DISPLAY_NAME = v;
                        break;
                    case "PATH":
                        mapper[i] = (e, v) => e.PATH = v;
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
        /// Merges <see cref="SPWWW" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPWWW" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPWWW" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPWWW}"/> of entities</returns>
        internal override IEnumerable<SPWWW> ApplyDeltaEntities(IEnumerable<SPWWW> Entities, List<SPWWW> DeltaEntities)
        {
            HashSet<string> Index_SPWWWKEY = new HashSet<string>(DeltaEntities.Select(i => i.SPWWWKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SPWWWKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SPWWWKEY.Remove(entity.SPWWWKEY);
                            
                            if (entity.SPWWWKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, SPWWW>> Index_SPWWWKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPWWW by SPWWWKEY field
        /// </summary>
        /// <param name="SPWWWKEY">SPWWWKEY value used to find SPWWW</param>
        /// <returns>Related SPWWW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPWWW FindBySPWWWKEY(string SPWWWKEY)
        {
            return Index_SPWWWKEY.Value[SPWWWKEY];
        }

        /// <summary>
        /// Attempt to find SPWWW by SPWWWKEY field
        /// </summary>
        /// <param name="SPWWWKEY">SPWWWKEY value used to find SPWWW</param>
        /// <param name="Value">Related SPWWW entity</param>
        /// <returns>True if the related SPWWW entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPWWWKEY(string SPWWWKEY, out SPWWW Value)
        {
            return Index_SPWWWKEY.Value.TryGetValue(SPWWWKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPWWW by SPWWWKEY field
        /// </summary>
        /// <param name="SPWWWKEY">SPWWWKEY value used to find SPWWW</param>
        /// <returns>Related SPWWW entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPWWW TryFindBySPWWWKEY(string SPWWWKEY)
        {
            SPWWW value;
            if (Index_SPWWWKEY.Value.TryGetValue(SPWWWKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPWWW table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPWWW]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPWWW](
        [SPWWWKEY] varchar(15) NOT NULL,
        [DESCRIPTION] varchar(60) NULL,
        [REPORT_NAME] varchar(80) NULL,
        [DISPLAY_NAME] varchar(50) NULL,
        [PATH] varchar(255) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPWWW_Index_SPWWWKEY] PRIMARY KEY CLUSTERED (
            [SPWWWKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SPWWWDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SPWWWDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPWWW"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPWWW"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPWWW> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SPWWWKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SPWWWKEY.Add(entity.SPWWWKEY);
            }

            builder.AppendLine("DELETE [dbo].[SPWWW] WHERE");


            // Index_SPWWWKEY
            builder.Append("[SPWWWKEY] IN (");
            for (int index = 0; index < Index_SPWWWKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SPWWWKEY
                var parameterSPWWWKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSPWWWKEY);
                command.Parameters.Add(parameterSPWWWKEY, SqlDbType.VarChar, 15).Value = Index_SPWWWKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPWWW data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPWWW data set</returns>
        public override EduHubDataSetDataReader<SPWWW> GetDataSetDataReader()
        {
            return new SPWWWDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPWWW data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPWWW data set</returns>
        public override EduHubDataSetDataReader<SPWWW> GetDataSetDataReader(List<SPWWW> Entities)
        {
            return new SPWWWDataReader(new EduHubDataSetLoadedReader<SPWWW>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPWWWDataReader : EduHubDataSetDataReader<SPWWW>
        {
            public SPWWWDataReader(IEduHubDataSetReader<SPWWW> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SPWWWKEY
                        return Current.SPWWWKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // REPORT_NAME
                        return Current.REPORT_NAME;
                    case 3: // DISPLAY_NAME
                        return Current.DISPLAY_NAME;
                    case 4: // PATH
                        return Current.PATH;
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
                    case 2: // REPORT_NAME
                        return Current.REPORT_NAME == null;
                    case 3: // DISPLAY_NAME
                        return Current.DISPLAY_NAME == null;
                    case 4: // PATH
                        return Current.PATH == null;
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
                    case 0: // SPWWWKEY
                        return "SPWWWKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // REPORT_NAME
                        return "REPORT_NAME";
                    case 3: // DISPLAY_NAME
                        return "DISPLAY_NAME";
                    case 4: // PATH
                        return "PATH";
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
                    case "SPWWWKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "REPORT_NAME":
                        return 2;
                    case "DISPLAY_NAME":
                        return 3;
                    case "PATH":
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
