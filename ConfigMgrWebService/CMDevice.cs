using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfigMgrWebService
{
    public class CMDevice
    {
        public string DeviceName { get; set; }
        public string ResourceID { get; set; }
        public string SMBIOSGUID { get; set; }
        public string[] MACAddresses { get; set; }
        public string[] SystemOUName { get; set; }
        public string LastLogonUserName { get; set; }
    }
}