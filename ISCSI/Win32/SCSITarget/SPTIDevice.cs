using DiskAccessLibrary;
using SCSI.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace ISCSIConsole
{
    public class SPTIDevice : Disk // a fake disk that serves SPTI device direct
    {
        private string path;
        private SPTITarget device;
        public SPTIDevice(string path)
        {
            this.path = path;
            device= new SPTITarget(path);
        }

        public override byte[] ReadSectors(long sectorIndex, int sectorCount)
        {
            throw new NotImplementedException();
        }

        public override void WriteSectors(long sectorIndex, byte[] data)
        {
            throw new NotImplementedException();
        }

        public SCSI.SCSIStatusCodeName SCSIDirect(SCSI.SCSICommandDescriptorBlock command, SCSI.LUNStructure lun, byte[] data, out byte[] response)
        {
            response = null;
            return device.ExecuteCommand(command.GetBytes(), lun, data, out response);
        }

        public override int BytesPerSector
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override long Size
        {
            get
            {
                return 0;
            }
        }

    }
}
