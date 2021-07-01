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
    /// Assets - Locations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKLDataSet : EduHubDataSet<AKL>
    {
        /// <inheritdoc />
        public override string Name { get { return "AKL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal AKLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOCATION = new Lazy<Dictionary<string, AKL>>(() => this.ToDictionary(i => i.LOCATION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKL" /> fields for each CSV column header</returns>
        internal override Action<AKL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ESTIMATE_UNITS":
                        mapper[i] = (e, v) => e.ESTIMATE_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNITS_TO_DATE":
                        mapper[i] = (e, v) => e.UNITS_TO_DATE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACUTOFF":
                        mapper[i] = (e, v) => e.ACUTOFF = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATEFU":
                        mapper[i] = (e, v) => e.DATEFU = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PURDATE":
                        mapper[i] = (e, v) => e.PURDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "AFLAG":
                        mapper[i] = (e, v) => e.AFLAG = v;
                        break;
                    case "TFLAG":
                        mapper[i] = (e, v) => e.TFLAG = v;
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
        /// Merges <see cref="AKL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AKL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AKL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AKL}"/> of entities</returns>
        internal override IEnumerable<AKL> ApplyDeltaEntities(IEnumerable<AKL> Entities, List<AKL> DeltaEntities)
        {
            HashSet<string> Index_LOCATION = new HashSet<string>(DeltaEntities.Select(i => i.LOCATION));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.LOCATION;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_LOCATION.Remove(entity.LOCATION);
                            
                            if (entity.LOCATION.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, AKL>> Index_LOCATION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <returns>Related AKL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKL FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <param name="Value">Related AKL entity</param>
        /// <returns>True if the related AKL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out AKL Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <returns>Related AKL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKL TryFindByLOCATION(string LOCATION)
        {
            AKL value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AKL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKL](
        [LOCATION] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [ESTIMATE_UNITS] int NULL,
        [PERIOD_UNITS] int NULL,
        [UNITS_TO_DATE] int NULL,
        [ACUTOFF] smallint NULL,
        [DATEFU] datetime NULL,
        [PURDATE] datetime NULL,
        [AFLAG] varchar(1) NULL,
        [TFLAG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKL_Index_LOCATION] PRIMARY KEY CLUSTERED (
            [LOCATION] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="AKLDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="AKLDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AKL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AKL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AKL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_LOCATION = new List<string>();

            foreach (var entity in Entities)
            {
                Index_LOCATION.Add(entity.LOCATION);
            }

            builder.AppendLine("DELETE [dbo].[AKL] WHERE");


            // Index_LOCATION
            builder.Append("[LOCATION] IN (");
            for (int index = 0; index < Index_LOCATION.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // LOCATION
                var parameterLOCATION = $"@p{parameterIndex++}";
                builder.Append(parameterLOCATION);
                command.Parameters.Add(parameterLOCATION, SqlDbType.VarChar, 10).Value = Index_LOCATION[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKL data set</returns>
        public override EduHubDataSetDataReader<AKL> GetDataSetDataReader()
        {
            return new AKLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKL data set</returns>
        public override EduHubDataSetDataReader<AKL> GetDataSetDataReader(List<AKL> Entities)
        {
            return new AKLDataReader(new EduHubDataSetLoadedReader<AKL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKLDataReader : EduHubDataSetDataReader<AKL>
        {
            public AKLDataReader(IEduHubDataSetReader<AKL> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // LOCATION
                        return Current.LOCATION;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // ESTIMATE_UNITS
                        return Current.ESTIMATE_UNITS;
                    case 3: // PERIOD_UNITS
                        return Current.PERIOD_UNITS;
                    case 4: // UNITS_TO_DATE
                        return Current.UNITS_TO_DATE;
                    case 5: // ACUTOFF
                        return Current.ACUTOFF;
                    case 6: // DATEFU
                        return Current.DATEFU;
                    case 7: // PURDATE
                        return Current.PURDATE;
                    case 8: // AFLAG
                        return Current.AFLAG;
                    case 9: // TFLAG
                        return Current.TFLAG;
                    case 10: // LW_DATE
                        return Current.LW_DATE;
                    case 11: // LW_TIME
                        return Current.LW_TIME;
                    case 12: // LW_USER
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
                    case 2: // ESTIMATE_UNITS
                        return Current.ESTIMATE_UNITS == null;
                    case 3: // PERIOD_UNITS
                        return Current.PERIOD_UNITS == null;
                    case 4: // UNITS_TO_DATE
                        return Current.UNITS_TO_DATE == null;
                    case 5: // ACUTOFF
                        return Current.ACUTOFF == null;
                    case 6: // DATEFU
                        return Current.DATEFU == null;
                    case 7: // PURDATE
                        return Current.PURDATE == null;
                    case 8: // AFLAG
                        return Current.AFLAG == null;
                    case 9: // TFLAG
                        return Current.TFLAG == null;
                    case 10: // LW_DATE
                        return Current.LW_DATE == null;
                    case 11: // LW_TIME
                        return Current.LW_TIME == null;
                    case 12: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // LOCATION
                        return "LOCATION";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ESTIMATE_UNITS
                        return "ESTIMATE_UNITS";
                    case 3: // PERIOD_UNITS
                        return "PERIOD_UNITS";
                    case 4: // UNITS_TO_DATE
                        return "UNITS_TO_DATE";
                    case 5: // ACUTOFF
                        return "ACUTOFF";
                    case 6: // DATEFU
                        return "DATEFU";
                    case 7: // PURDATE
                        return "PURDATE";
                    case 8: // AFLAG
                        return "AFLAG";
                    case 9: // TFLAG
                        return "TFLAG";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "LOCATION":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ESTIMATE_UNITS":
                        return 2;
                    case "PERIOD_UNITS":
                        return 3;
                    case "UNITS_TO_DATE":
                        return 4;
                    case "ACUTOFF":
                        return 5;
                    case "DATEFU":
                        return 6;
                    case "PURDATE":
                        return 7;
                    case "AFLAG":
                        return 8;
                    case "TFLAG":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
