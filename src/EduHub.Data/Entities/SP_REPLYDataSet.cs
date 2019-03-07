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
    /// SMS Reply Recipient Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SP_REPLYDataSet : EduHubDataSet<SP_REPLY>
    {
        /// <inheritdoc />
        public override string Name { get { return "SP_REPLY"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SP_REPLYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, SP_REPLY>>(() => this.ToDictionary(i => i.CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SP_REPLY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SP_REPLY" /> fields for each CSV column header</returns>
        internal override Action<SP_REPLY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SP_REPLY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "Description":
                        mapper[i] = (e, v) => e.Description = v;
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
        /// Merges <see cref="SP_REPLY" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SP_REPLY" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SP_REPLY" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SP_REPLY}"/> of entities</returns>
        internal override IEnumerable<SP_REPLY> ApplyDeltaEntities(IEnumerable<SP_REPLY> Entities, List<SP_REPLY> DeltaEntities)
        {
            HashSet<string> Index_CODE = new HashSet<string>(DeltaEntities.Select(i => i.CODE));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_CODE.Remove(entity.CODE);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, SP_REPLY>> Index_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SP_REPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_REPLY</param>
        /// <returns>Related SP_REPLY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SP_REPLY FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SP_REPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_REPLY</param>
        /// <param name="Value">Related SP_REPLY entity</param>
        /// <returns>True if the related SP_REPLY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out SP_REPLY Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SP_REPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_REPLY</param>
        /// <returns>Related SP_REPLY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SP_REPLY TryFindByCODE(string CODE)
        {
            SP_REPLY value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SP_REPLY table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_REPLY]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SP_REPLY](
        [CODE] varchar(15) NOT NULL,
        [Description] varchar(30) NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SP_REPLY_Index_CODE] PRIMARY KEY CLUSTERED (
            [CODE] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SP_REPLYDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SP_REPLYDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SP_REPLY"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SP_REPLY"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SP_REPLY> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_CODE = new List<string>();

            foreach (var entity in Entities)
            {
                Index_CODE.Add(entity.CODE);
            }

            builder.AppendLine("DELETE [dbo].[SP_REPLY] WHERE");


            // Index_CODE
            builder.Append("[CODE] IN (");
            for (int index = 0; index < Index_CODE.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // CODE
                var parameterCODE = $"@p{parameterIndex++}";
                builder.Append(parameterCODE);
                command.Parameters.Add(parameterCODE, SqlDbType.VarChar, 15).Value = Index_CODE[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SP_REPLY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SP_REPLY data set</returns>
        public override EduHubDataSetDataReader<SP_REPLY> GetDataSetDataReader()
        {
            return new SP_REPLYDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SP_REPLY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SP_REPLY data set</returns>
        public override EduHubDataSetDataReader<SP_REPLY> GetDataSetDataReader(List<SP_REPLY> Entities)
        {
            return new SP_REPLYDataReader(new EduHubDataSetLoadedReader<SP_REPLY>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SP_REPLYDataReader : EduHubDataSetDataReader<SP_REPLY>
        {
            public SP_REPLYDataReader(IEduHubDataSetReader<SP_REPLY> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // CODE
                        return Current.CODE;
                    case 1: // Description
                        return Current.Description;
                    case 2: // LW_TIME
                        return Current.LW_TIME;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
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
                    case 1: // Description
                        return Current.Description == null;
                    case 2: // LW_TIME
                        return Current.LW_TIME == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
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
                    case 0: // CODE
                        return "CODE";
                    case 1: // Description
                        return "Description";
                    case 2: // LW_TIME
                        return "LW_TIME";
                    case 3: // LW_DATE
                        return "LW_DATE";
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
                    case "CODE":
                        return 0;
                    case "Description":
                        return 1;
                    case "LW_TIME":
                        return 2;
                    case "LW_DATE":
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
