using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Books for Hire Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BKHDataSet : EduHubDataSet<BKH>
    {
        /// <inheritdoc />
        public override string Name { get { return "BKH"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal BKHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKHKEY = new Lazy<Dictionary<string, BKH>>(() => this.ToDictionary(i => i.BKHKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BKH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BKH" /> fields for each CSV column header</returns>
        internal override Action<BKH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BKH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BKHKEY":
                        mapper[i] = (e, v) => e.BKHKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "EDITION":
                        mapper[i] = (e, v) => e.EDITION = v;
                        break;
                    case "AUTHOR":
                        mapper[i] = (e, v) => e.AUTHOR = v;
                        break;
                    case "PUBLISHER":
                        mapper[i] = (e, v) => e.PUBLISHER = v;
                        break;
                    case "PRICE":
                        mapper[i] = (e, v) => e.PRICE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ITEM_TYPE":
                        mapper[i] = (e, v) => e.ITEM_TYPE = v;
                        break;
                    case "NO_COPIES":
                        mapper[i] = (e, v) => e.NO_COPIES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEEDED_NUM":
                        mapper[i] = (e, v) => e.SEEDED_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AVAIL_COPIES":
                        mapper[i] = (e, v) => e.AVAIL_COPIES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ISBN":
                        mapper[i] = (e, v) => e.ISBN = v;
                        break;
                    case "ANNOTATIONS":
                        mapper[i] = (e, v) => e.ANNOTATIONS = v;
                        break;
                    case "PURCHASE_DATE":
                        mapper[i] = (e, v) => e.PURCHASE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PURCHASE_PRICE":
                        mapper[i] = (e, v) => e.PURCHASE_PRICE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HIRE_FEE":
                        mapper[i] = (e, v) => e.HIRE_FEE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REMOVE":
                        mapper[i] = (e, v) => e.REMOVE = v;
                        break;
                    case "BOOK_MOVIE":
                        mapper[i] = (e, v) => e.BOOK_MOVIE = null; // eduHub is not encoding byte arrays
                        break;
                    case "BOOK_SOUND":
                        mapper[i] = (e, v) => e.BOOK_SOUND = null; // eduHub is not encoding byte arrays
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="BKH" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="BKH" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="BKH" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{BKH}"/> of entities</returns>
        internal override IEnumerable<BKH> ApplyDeltaEntities(IEnumerable<BKH> Entities, List<BKH> DeltaEntities)
        {
            HashSet<string> Index_BKHKEY = new HashSet<string>(DeltaEntities.Select(i => i.BKHKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.BKHKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_BKHKEY.Remove(entity.BKHKEY);
                            
                            if (entity.BKHKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, BKH>> Index_BKHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <returns>Related BKH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKH FindByBKHKEY(string BKHKEY)
        {
            return Index_BKHKEY.Value[BKHKEY];
        }

        /// <summary>
        /// Attempt to find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <param name="Value">Related BKH entity</param>
        /// <returns>True if the related BKH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKHKEY(string BKHKEY, out BKH Value)
        {
            return Index_BKHKEY.Value.TryGetValue(BKHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <returns>Related BKH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKH TryFindByBKHKEY(string BKHKEY)
        {
            BKH value;
            if (Index_BKHKEY.Value.TryGetValue(BKHKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a BKH table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[BKH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[BKH](
        [BKHKEY] varchar(13) NOT NULL,
        [TITLE] varchar(40) NULL,
        [EDITION] varchar(20) NULL,
        [AUTHOR] varchar(20) NULL,
        [PUBLISHER] varchar(30) NULL,
        [PRICE] money NULL,
        [ITEM_TYPE] varchar(1) NULL,
        [NO_COPIES] smallint NULL,
        [SEEDED_NUM] smallint NULL,
        [AVAIL_COPIES] smallint NULL,
        [ISBN] varchar(13) NULL,
        [ANNOTATIONS] text NULL,
        [PURCHASE_DATE] datetime NULL,
        [PURCHASE_PRICE] money NULL,
        [HIRE_FEE] money NULL,
        [REMOVE] varchar(1) NULL,
        [BOOK_MOVIE] image NULL,
        [BOOK_SOUND] image NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [BKH_Index_BKHKEY] PRIMARY KEY CLUSTERED (
            [BKHKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="BKHDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="BKHDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="BKH"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="BKH"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<BKH> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_BKHKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_BKHKEY.Add(entity.BKHKEY);
            }

            builder.AppendLine("DELETE [dbo].[BKH] WHERE");


            // Index_BKHKEY
            builder.Append("[BKHKEY] IN (");
            for (int index = 0; index < Index_BKHKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // BKHKEY
                var parameterBKHKEY = $"@p{parameterIndex++}";
                builder.Append(parameterBKHKEY);
                command.Parameters.Add(parameterBKHKEY, SqlDbType.VarChar, 13).Value = Index_BKHKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the BKH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BKH data set</returns>
        public override EduHubDataSetDataReader<BKH> GetDataSetDataReader()
        {
            return new BKHDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the BKH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BKH data set</returns>
        public override EduHubDataSetDataReader<BKH> GetDataSetDataReader(List<BKH> Entities)
        {
            return new BKHDataReader(new EduHubDataSetLoadedReader<BKH>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class BKHDataReader : EduHubDataSetDataReader<BKH>
        {
            public BKHDataReader(IEduHubDataSetReader<BKH> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 21; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // BKHKEY
                        return Current.BKHKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // EDITION
                        return Current.EDITION;
                    case 3: // AUTHOR
                        return Current.AUTHOR;
                    case 4: // PUBLISHER
                        return Current.PUBLISHER;
                    case 5: // PRICE
                        return Current.PRICE;
                    case 6: // ITEM_TYPE
                        return Current.ITEM_TYPE;
                    case 7: // NO_COPIES
                        return Current.NO_COPIES;
                    case 8: // SEEDED_NUM
                        return Current.SEEDED_NUM;
                    case 9: // AVAIL_COPIES
                        return Current.AVAIL_COPIES;
                    case 10: // ISBN
                        return Current.ISBN;
                    case 11: // ANNOTATIONS
                        return Current.ANNOTATIONS;
                    case 12: // PURCHASE_DATE
                        return Current.PURCHASE_DATE;
                    case 13: // PURCHASE_PRICE
                        return Current.PURCHASE_PRICE;
                    case 14: // HIRE_FEE
                        return Current.HIRE_FEE;
                    case 15: // REMOVE
                        return Current.REMOVE;
                    case 16: // BOOK_MOVIE
                        return Current.BOOK_MOVIE;
                    case 17: // BOOK_SOUND
                        return Current.BOOK_SOUND;
                    case 18: // LW_DATE
                        return Current.LW_DATE;
                    case 19: // LW_TIME
                        return Current.LW_TIME;
                    case 20: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // EDITION
                        return Current.EDITION == null;
                    case 3: // AUTHOR
                        return Current.AUTHOR == null;
                    case 4: // PUBLISHER
                        return Current.PUBLISHER == null;
                    case 5: // PRICE
                        return Current.PRICE == null;
                    case 6: // ITEM_TYPE
                        return Current.ITEM_TYPE == null;
                    case 7: // NO_COPIES
                        return Current.NO_COPIES == null;
                    case 8: // SEEDED_NUM
                        return Current.SEEDED_NUM == null;
                    case 9: // AVAIL_COPIES
                        return Current.AVAIL_COPIES == null;
                    case 10: // ISBN
                        return Current.ISBN == null;
                    case 11: // ANNOTATIONS
                        return Current.ANNOTATIONS == null;
                    case 12: // PURCHASE_DATE
                        return Current.PURCHASE_DATE == null;
                    case 13: // PURCHASE_PRICE
                        return Current.PURCHASE_PRICE == null;
                    case 14: // HIRE_FEE
                        return Current.HIRE_FEE == null;
                    case 15: // REMOVE
                        return Current.REMOVE == null;
                    case 16: // BOOK_MOVIE
                        return Current.BOOK_MOVIE == null;
                    case 17: // BOOK_SOUND
                        return Current.BOOK_SOUND == null;
                    case 18: // LW_DATE
                        return Current.LW_DATE == null;
                    case 19: // LW_TIME
                        return Current.LW_TIME == null;
                    case 20: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // BKHKEY
                        return "BKHKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // EDITION
                        return "EDITION";
                    case 3: // AUTHOR
                        return "AUTHOR";
                    case 4: // PUBLISHER
                        return "PUBLISHER";
                    case 5: // PRICE
                        return "PRICE";
                    case 6: // ITEM_TYPE
                        return "ITEM_TYPE";
                    case 7: // NO_COPIES
                        return "NO_COPIES";
                    case 8: // SEEDED_NUM
                        return "SEEDED_NUM";
                    case 9: // AVAIL_COPIES
                        return "AVAIL_COPIES";
                    case 10: // ISBN
                        return "ISBN";
                    case 11: // ANNOTATIONS
                        return "ANNOTATIONS";
                    case 12: // PURCHASE_DATE
                        return "PURCHASE_DATE";
                    case 13: // PURCHASE_PRICE
                        return "PURCHASE_PRICE";
                    case 14: // HIRE_FEE
                        return "HIRE_FEE";
                    case 15: // REMOVE
                        return "REMOVE";
                    case 16: // BOOK_MOVIE
                        return "BOOK_MOVIE";
                    case 17: // BOOK_SOUND
                        return "BOOK_SOUND";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "BKHKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "EDITION":
                        return 2;
                    case "AUTHOR":
                        return 3;
                    case "PUBLISHER":
                        return 4;
                    case "PRICE":
                        return 5;
                    case "ITEM_TYPE":
                        return 6;
                    case "NO_COPIES":
                        return 7;
                    case "SEEDED_NUM":
                        return 8;
                    case "AVAIL_COPIES":
                        return 9;
                    case "ISBN":
                        return 10;
                    case "ANNOTATIONS":
                        return 11;
                    case "PURCHASE_DATE":
                        return 12;
                    case "PURCHASE_PRICE":
                        return 13;
                    case "HIRE_FEE":
                        return 14;
                    case "REMOVE":
                        return 15;
                    case "BOOK_MOVIE":
                        return 16;
                    case "BOOK_SOUND":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
