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
    /// Fuel Tax Credit Rates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KFTCDataSet : EduHubDataSet<KFTC>
    {
        /// <inheritdoc />
        public override string Name { get { return "KFTC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KFTCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KFTCKEY = new Lazy<Dictionary<string, KFTC>>(() => this.ToDictionary(i => i.KFTCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KFTC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KFTC" /> fields for each CSV column header</returns>
        internal override Action<KFTC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KFTC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KFTCKEY":
                        mapper[i] = (e, v) => e.KFTCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FTC_RATE":
                        mapper[i] = (e, v) => e.FTC_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GL_CODE":
                        mapper[i] = (e, v) => e.GL_CODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "INACTIVE":
                        mapper[i] = (e, v) => e.INACTIVE = v;
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
        /// Merges <see cref="KFTC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KFTC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KFTC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KFTC}"/> of entities</returns>
        internal override IEnumerable<KFTC> ApplyDeltaEntities(IEnumerable<KFTC> Entities, List<KFTC> DeltaEntities)
        {
            HashSet<string> Index_KFTCKEY = new HashSet<string>(DeltaEntities.Select(i => i.KFTCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KFTCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KFTCKEY.Remove(entity.KFTCKEY);
                            
                            if (entity.KFTCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KFTC>> Index_KFTCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <returns>Related KFTC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFTC FindByKFTCKEY(string KFTCKEY)
        {
            return Index_KFTCKEY.Value[KFTCKEY];
        }

        /// <summary>
        /// Attempt to find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <param name="Value">Related KFTC entity</param>
        /// <returns>True if the related KFTC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKFTCKEY(string KFTCKEY, out KFTC Value)
        {
            return Index_KFTCKEY.Value.TryGetValue(KFTCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <returns>Related KFTC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFTC TryFindByKFTCKEY(string KFTCKEY)
        {
            KFTC value;
            if (Index_KFTCKEY.Value.TryGetValue(KFTCKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KFTC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KFTC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KFTC](
        [KFTCKEY] varchar(3) NOT NULL,
        [DESCRIPTION] varchar(80) NULL,
        [FTC_RATE] float NULL,
        [GL_CODE] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [INACTIVE] varchar(1) NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KFTC_Index_KFTCKEY] PRIMARY KEY CLUSTERED (
            [KFTCKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KFTCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KFTCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KFTC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KFTC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KFTC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KFTCKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KFTCKEY.Add(entity.KFTCKEY);
            }

            builder.AppendLine("DELETE [dbo].[KFTC] WHERE");


            // Index_KFTCKEY
            builder.Append("[KFTCKEY] IN (");
            for (int index = 0; index < Index_KFTCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KFTCKEY
                var parameterKFTCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKFTCKEY);
                command.Parameters.Add(parameterKFTCKEY, SqlDbType.VarChar, 3).Value = Index_KFTCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KFTC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KFTC data set</returns>
        public override EduHubDataSetDataReader<KFTC> GetDataSetDataReader()
        {
            return new KFTCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KFTC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KFTC data set</returns>
        public override EduHubDataSetDataReader<KFTC> GetDataSetDataReader(List<KFTC> Entities)
        {
            return new KFTCDataReader(new EduHubDataSetLoadedReader<KFTC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KFTCDataReader : EduHubDataSetDataReader<KFTC>
        {
            public KFTCDataReader(IEduHubDataSetReader<KFTC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KFTCKEY
                        return Current.KFTCKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // FTC_RATE
                        return Current.FTC_RATE;
                    case 3: // GL_CODE
                        return Current.GL_CODE;
                    case 4: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 5: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 6: // INITIATIVE
                        return Current.INITIATIVE;
                    case 7: // INACTIVE
                        return Current.INACTIVE;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // FTC_RATE
                        return Current.FTC_RATE == null;
                    case 3: // GL_CODE
                        return Current.GL_CODE == null;
                    case 4: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 5: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 6: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 7: // INACTIVE
                        return Current.INACTIVE == null;
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
                    case 0: // KFTCKEY
                        return "KFTCKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // FTC_RATE
                        return "FTC_RATE";
                    case 3: // GL_CODE
                        return "GL_CODE";
                    case 4: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 5: // GLPROGRAM
                        return "GLPROGRAM";
                    case 6: // INITIATIVE
                        return "INITIATIVE";
                    case 7: // INACTIVE
                        return "INACTIVE";
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
                    case "KFTCKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "FTC_RATE":
                        return 2;
                    case "GL_CODE":
                        return 3;
                    case "SUBPROGRAM":
                        return 4;
                    case "GLPROGRAM":
                        return 5;
                    case "INITIATIVE":
                        return 6;
                    case "INACTIVE":
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
