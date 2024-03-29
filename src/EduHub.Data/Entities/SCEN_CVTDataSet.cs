#if !EduHubScoped
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
    /// Census Class Sizes Validation Type Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_CVTDataSet : EduHubDataSet<SCEN_CVT>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_CVT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_CVTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_CVT>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_CVT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_CVT" /> fields for each CSV column header</returns>
        internal override Action<SCEN_CVT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_CVT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "VCODE":
                        mapper[i] = (e, v) => e.VCODE = v;
                        break;
                    case "VALIDATIONMESSAGE":
                        mapper[i] = (e, v) => e.VALIDATIONMESSAGE = v;
                        break;
                    case "WARNING":
                        mapper[i] = (e, v) => e.WARNING = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "DETAILEDMESSAGE":
                        mapper[i] = (e, v) => e.DETAILEDMESSAGE = v;
                        break;
                    case "CVT_TYPE":
                        mapper[i] = (e, v) => e.CVT_TYPE = v;
                        break;
                    case "COMMANDNAME":
                        mapper[i] = (e, v) => e.COMMANDNAME = v;
                        break;
                    case "ISENABLED":
                        mapper[i] = (e, v) => e.ISENABLED = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_CVT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_CVT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_CVT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_CVT}"/> of entities</returns>
        internal override IEnumerable<SCEN_CVT> ApplyDeltaEntities(IEnumerable<SCEN_CVT> Entities, List<SCEN_CVT> DeltaEntities)
        {
            HashSet<int> Index_ID = new HashSet<int>(DeltaEntities.Select(i => i.ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ID.Remove(entity.ID);
                            
                            if (entity.ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SCEN_CVT>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_CVT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CVT</param>
        /// <returns>Related SCEN_CVT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_CVT FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_CVT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CVT</param>
        /// <param name="Value">Related SCEN_CVT entity</param>
        /// <returns>True if the related SCEN_CVT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_CVT Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_CVT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CVT</param>
        /// <returns>Related SCEN_CVT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_CVT TryFindByID(int ID)
        {
            SCEN_CVT value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_CVT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_CVT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_CVT](
        [ID] int IDENTITY NOT NULL,
        [VCODE] varchar(15) NULL,
        [VALIDATIONMESSAGE] varchar(MAX) NULL,
        [WARNING] varchar(1) NULL,
        [PERIOD] varchar(1) NULL,
        [DETAILEDMESSAGE] varchar(MAX) NULL,
        [CVT_TYPE] varchar(3) NULL,
        [COMMANDNAME] varchar(255) NULL,
        [ISENABLED] varchar(1) NULL,
        CONSTRAINT [SCEN_CVT_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_CVTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_CVTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_CVT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_CVT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_CVT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_CVT] WHERE");


            // Index_ID
            builder.Append("[ID] IN (");
            for (int index = 0; index < Index_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ID
                var parameterID = $"@p{parameterIndex++}";
                builder.Append(parameterID);
                command.Parameters.Add(parameterID, SqlDbType.Int).Value = Index_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_CVT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_CVT data set</returns>
        public override EduHubDataSetDataReader<SCEN_CVT> GetDataSetDataReader()
        {
            return new SCEN_CVTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_CVT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_CVT data set</returns>
        public override EduHubDataSetDataReader<SCEN_CVT> GetDataSetDataReader(List<SCEN_CVT> Entities)
        {
            return new SCEN_CVTDataReader(new EduHubDataSetLoadedReader<SCEN_CVT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_CVTDataReader : EduHubDataSetDataReader<SCEN_CVT>
        {
            public SCEN_CVTDataReader(IEduHubDataSetReader<SCEN_CVT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // VCODE
                        return Current.VCODE;
                    case 2: // VALIDATIONMESSAGE
                        return Current.VALIDATIONMESSAGE;
                    case 3: // WARNING
                        return Current.WARNING;
                    case 4: // PERIOD
                        return Current.PERIOD;
                    case 5: // DETAILEDMESSAGE
                        return Current.DETAILEDMESSAGE;
                    case 6: // CVT_TYPE
                        return Current.CVT_TYPE;
                    case 7: // COMMANDNAME
                        return Current.COMMANDNAME;
                    case 8: // ISENABLED
                        return Current.ISENABLED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // VCODE
                        return Current.VCODE == null;
                    case 2: // VALIDATIONMESSAGE
                        return Current.VALIDATIONMESSAGE == null;
                    case 3: // WARNING
                        return Current.WARNING == null;
                    case 4: // PERIOD
                        return Current.PERIOD == null;
                    case 5: // DETAILEDMESSAGE
                        return Current.DETAILEDMESSAGE == null;
                    case 6: // CVT_TYPE
                        return Current.CVT_TYPE == null;
                    case 7: // COMMANDNAME
                        return Current.COMMANDNAME == null;
                    case 8: // ISENABLED
                        return Current.ISENABLED == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // VCODE
                        return "VCODE";
                    case 2: // VALIDATIONMESSAGE
                        return "VALIDATIONMESSAGE";
                    case 3: // WARNING
                        return "WARNING";
                    case 4: // PERIOD
                        return "PERIOD";
                    case 5: // DETAILEDMESSAGE
                        return "DETAILEDMESSAGE";
                    case 6: // CVT_TYPE
                        return "CVT_TYPE";
                    case 7: // COMMANDNAME
                        return "COMMANDNAME";
                    case 8: // ISENABLED
                        return "ISENABLED";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "VCODE":
                        return 1;
                    case "VALIDATIONMESSAGE":
                        return 2;
                    case "WARNING":
                        return 3;
                    case "PERIOD":
                        return 4;
                    case "DETAILEDMESSAGE":
                        return 5;
                    case "CVT_TYPE":
                        return 6;
                    case "COMMANDNAME":
                        return 7;
                    case "ISENABLED":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
