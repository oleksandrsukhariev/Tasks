using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public class WorkingWithImage
    {
        StringBuilder MyStringBuilder = new StringBuilder();

        /// <summary>
        /// Convert string in xml file to picture
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public Image FromXml(string hex)
        {
            Image tempImage = null;
            try
            {
                var newByte = ToByteArray(hex);
                var memStream = new MemoryStream(newByte);
                tempImage = Image.FromStream(memStream);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Your picture is broken!", e.Message);
            }
            return tempImage;
        }
        
        /// <summary>
        /// Convert picture file to string and wrote it to xml
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string ToXml(string path)
        {
            string picture = string.Empty;
            try
            {
                using (var filestream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var b = new byte[filestream.Length];

                    filestream.Read(b, 0, (int)filestream.Length);
                    foreach (var a in b.Select(zb => (int)zb))
                    {
                        MyStringBuilder.Append(a.ToString("X2"));
                    }

                    picture = Convert.ToString(MyStringBuilder);
                }
                MyStringBuilder.Clear();
                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Fill all boxes to save people info!", ex.Message);
            }
            return picture;
        }

        /// <summary>
        /// Convert hex string to array of bytes
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(string hexString)
        {
            var numberChars = hexString.Length;

            var bytes = new byte[numberChars / 2];

            for (var i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
