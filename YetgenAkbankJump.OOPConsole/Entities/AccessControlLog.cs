using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.OOPConsole.Common;
using YetgenAkbankJump.OOPConsole.Enums;

namespace YetgenAkbankJump.OOPConsole.Entities
{
    internal class AccessControlLog:EntityBase<Guid>
    {
        public long PersonId { get; set; }
        public string DeviceSerialNumber { get; set; }
        public AccessType AccessType { get; set; }
        public DateTime LogTime { get; set; }

    }
}
