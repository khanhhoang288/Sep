using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDisk
    {
        private int diskID, titleID;
        private string diskStatus, diskCode;

        public string DiskCode
        {
            get
            {
                return diskCode;
            }

            set
            {
                diskCode = value;
            }
        }

        public int DiskID
        {
            get
            {
                return diskID;
            }

            set
            {
                diskID = value;
            }
        }

        public string DiskStatus
        {
            get
            {
                return diskStatus;
            }

            set
            {
                diskStatus = value;
            }
        }

        public int TitleID
        {
            get
            {
                return titleID;
            }

            set
            {
                titleID = value;
            }
        }

        public eDisk()
        {
            this.DiskID = 0;
            this.TitleID = 0;
            this.DiskCode = "";
            this.DiskStatus = "";
        }

        public eDisk(int did, int tid, string dcode, string dstatus)
        {
            this.DiskID = did;
            this.TitleID = tid;
            this.DiskCode = dcode;
            this.DiskStatus = dstatus;
        }
    }
}
