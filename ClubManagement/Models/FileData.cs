using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Models
{
    class FileData
    {
        public string Fil_Name { get; set; }
        public string Fil_Size { get; set; }
        public string Fil_Extension { get; set; }
        public int? Fil_ObjectEnum { get; set; }
        public int? Fil_ObjectId { get; set; }
        public int? Fil_ObjectLp { get; set; }
        public byte[] Fil_BinaryData { get; set; }

        public FileData(string name, string size, string extension, byte[] binaryData)
        {
            Fil_Name = name;
            Fil_Size = size;
            Fil_Extension = extension;
            Fil_BinaryData = binaryData;
        }

        public FileData(string name, string size, string extension, int? objectEnum, int? objectId, int? objectLp, byte[] binaryData)
            : this(name, size, extension, binaryData)
        {
            Fil_ObjectEnum = objectEnum;
            Fil_ObjectId = objectId;
            Fil_ObjectLp = objectLp;
        }
    }
}
