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
    /// School Association Positions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAPDataSet : EduHubDataSet<SAP>
    {
        /// <inheritdoc />
        public override string Name { get { return "SAP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SAPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SAPKEY = new Lazy<Dictionary<string, SAP>>(() => this.ToDictionary(i => i.SAPKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAP" /> fields for each CSV column header</returns>
        internal override Action<SAP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAPKEY":
                        mapper[i] = (e, v) => e.SAPKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SORT_CODE":
                        mapper[i] = (e, v) => e.SORT_CODE = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SAP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SAP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SAP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SAP}"/> of entities</returns>
        internal override IEnumerable<SAP> ApplyDeltaEntities(IEnumerable<SAP> Entities, List<SAP> DeltaEntities)
        {
            HashSet<string> Index_SAPKEY = new HashSet<string>(DeltaEntities.Select(i => i.SAPKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SAPKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SAPKEY.Remove(entity.SAPKEY);
                            
                            if (entity.SAPKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, SAP>> Index_SAPKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <returns>Related SAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAP FindBySAPKEY(string SAPKEY)
        {
            return Index_SAPKEY.Value[SAPKEY];
        }

        /// <summary>
        /// Attempt to find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <param name="Value">Related SAP entity</param>
        /// <returns>True if the related SAP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAPKEY(string SAPKEY, out SAP Value)
        {
            return Index_SAPKEY.Value.TryGetValue(SAPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <returns>Related SAP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAP TryFindBySAPKEY(string SAPKEY)
        {
            SAP value;
            if (Index_SAPKEY.Value.TryGetValue(SAPKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SAP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAP](
        [SAPKEY] varchar(25) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [SORT_CODE] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAP_Index_SAPKEY] PRIMARY KEY CLUSTERED (
            [SAPKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SAPDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SAPDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SAP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SAP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SAP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SAPKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SAPKEY.Add(entity.SAPKEY);
            }

            builder.AppendLine("DELETE [dbo].[SAP] WHERE");


            // Index_SAPKEY
            builder.Append("[SAPKEY] IN (");
            for (int index = 0; index < Index_SAPKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SAPKEY
                var parameterSAPKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSAPKEY);
                command.Parameters.Add(parameterSAPKEY, SqlDbType.VarChar, 25).Value = Index_SAPKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAP data set</returns>
        public override EduHubDataSetDataReader<SAP> GetDataSetDataReader()
        {
            return new SAPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAP data set</returns>
        public override EduHubDataSetDataReader<SAP> GetDataSetDataReader(List<SAP> Entities)
        {
            return new SAPDataReader(new EduHubDataSetLoadedReader<SAP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAPDataReader : EduHubDataSetDataReader<SAP>
        {
            public SAPDataReader(IEduHubDataSetReader<SAP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SAPKEY
                        return Current.SAPKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // SORT_CODE
                        return Current.SORT_CODE;
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
                    case 2: // SORT_CODE
                        return Current.SORT_CODE == null;
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
                    case 0: // SAPKEY
                        return "SAPKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // SORT_CODE
                        return "SORT_CODE";
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
                    case "SAPKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "SORT_CODE":
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
