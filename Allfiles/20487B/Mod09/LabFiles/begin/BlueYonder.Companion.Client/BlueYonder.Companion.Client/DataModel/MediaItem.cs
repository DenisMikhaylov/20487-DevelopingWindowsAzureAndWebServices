using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueYonder.Companion.Client.DataModel
{
    public enum FolderType
    {
        Temp,
        Local
    }

    public class MediaItem
    {
        public string Name { get; private set; }
        public int ReservationId { get; set; }
        public FolderType FolderType { get; private set; }

        public MediaItem(FolderType folderType, int reservationId, string name)
        {
            FolderType = folderType;
            ReservationId = reservationId;
            Name = name;
        }

        public MediaItem(FolderType folderType, string basePath, string name)
        {
            FolderType = folderType;
            BasePath = basePath;
            Name = name;
        }

        public string Path
        {
            get
            {
                if (string.IsNullOrEmpty(BasePath))
                    return string.Format("ms-appdata:///{0}/Media/{1}/{2}", this.FolderType, this.ReservationId, this.Name);
                return string.Format("{0}/{1}", BasePath, this.Name);
            }
        }

        public string BasePath { get; set; }
    }
}
