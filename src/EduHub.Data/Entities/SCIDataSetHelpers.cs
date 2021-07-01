using System.Linq;

namespace EduHub.Data.Entities
{
    partial class SCIDataSet
    {
        private SCI _ADMIN_SITE;

        /// <summary>
        /// The administrative campus for this school
        /// </summary>
        public SCI ADMIN_SITE
        {
            get
            {
                if (_ADMIN_SITE == null)
                {
                    _ADMIN_SITE = this.FirstOrDefault(s => s.ADMIN_SITE == "Y");
                }
                return _ADMIN_SITE;
            }
        }
    }
}
