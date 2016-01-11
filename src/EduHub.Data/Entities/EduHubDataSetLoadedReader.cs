using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    internal class EduHubDataSetLoadedReader<T> : IEduHubDataSetReader<T> where T : EduHubEntity
    {
        private readonly EduHubDataSet<T> dataSet;
        private readonly EduHubContext context;
        private readonly List<T> items;
        private int index;

        private Lazy<DateTime?> entityLastModifiedMax;

        internal EduHubDataSetLoadedReader(EduHubDataSet<T> DataSet, List<T> Items)
        {
            if (DataSet == null)
                throw new ArgumentNullException(nameof(DataSet));

            dataSet = DataSet;
            context = DataSet.Context;
            items = Items;
            index = -1;

            entityLastModifiedMax = new Lazy<DateTime?>(CalculateEntityLastModifiedMax);
        }

        /// <inheritdoc />
        public string Name { get { return dataSet.Name; } }

        /// <inheritdoc />
        public EduHubContext Context { get { return context; } }

        /// <inheritdoc />
        public EduHubDataSet<T> DataSet { get { return dataSet; } }

        /// <inheritdoc />
        public bool HasEntities { get { return items.Count > 0; } }

        /// <inheritdoc />
        public double Progress
        {
            get
            {
                if (items.Count > 0)
                {
                    return index / (double)items.Count;
                }
                else
                {
                    return 100;
                }
            }
        }

        /// <inheritdoc />
        public int EntitiesRead { get { return index + 1; } }

        /// <inheritdoc />
        public DateTime? EntityLastModifiedMax { get { return entityLastModifiedMax.Value; } }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                index = i;
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private DateTime? CalculateEntityLastModifiedMax()
        {
            if (DataSet.SupportsEntityLastModified)
            {
                return items
                    .Where(i => i.EntityLastModified != null)
                    .Max(i => i.EntityLastModified);
            }

            return null;
        }

        public void Dispose()
        {
        }
    }
}
