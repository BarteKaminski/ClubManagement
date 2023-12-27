using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Helpers
{
    class ImgHelper
    {
        public static byte[] GetImageAsByteArray(string imagePath)
        {
            byte[] imageData = null;

            try
            {
                using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        long byteLength = new FileInfo(imagePath).Length;
                        imageData = binaryReader.ReadBytes((int)byteLength);
                    }
                }
            }
            catch (Exception ex)
            {
               MainForm.ShowError("Błąd odczytu pliku: " + ex.Message);
            }

            return imageData;
        }
    }
}
