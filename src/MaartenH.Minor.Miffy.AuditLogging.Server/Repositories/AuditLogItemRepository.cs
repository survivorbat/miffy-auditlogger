using System.Collections.Generic;
using System.Linq;
using MaartenH.Minor.Miffy.AuditLogging.Server.Abstract;
using MaartenH.Minor.Miffy.AuditLogging.Server.DAL;
using MaartenH.Minor.Miffy.AuditLogging.Server.Models;

namespace MaartenH.Minor.Miffy.AuditLogging.Server.Repositories
{
    public class AuditLogItemRepository : IAuditLogItemRepository
    {
        /// <summary>
        /// Context
        /// </summary>
        private readonly AuditLogContext _auditLogContext;

        /// <summary>
        /// Inject needed dependencies
        /// </summary>
        public AuditLogItemRepository(AuditLogContext context)
        {
            _auditLogContext = context;
        }

        /// <summary>
        /// Save a log item to the database
        /// </summary>
        public void Save(AuditLogItem item)
        {
            _auditLogContext.AuditLogItems.Add(item);
            _auditLogContext.SaveChanges();
        }

        /// <summary>
        /// Retrieve audit log items between two timestamps
        /// </summary>
        public IEnumerable<AuditLogItem> FindByTimeStamps(long fromTimeStamp, long toTimeStamp)
        {
            return _auditLogContext.AuditLogItems.Where(e =>
                e.TimeStamp >= fromTimeStamp && e.TimeStamp <= toTimeStamp);
        }
    }
}
