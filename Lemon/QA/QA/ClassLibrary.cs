using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA
{
    /// <summary>
    /// 方法库
    /// </summary>
    public class ClassLibrary
    {


    }

    /// <summary>
    /// object 转 Image
    /// </summary>
    class ClassobjToImage : IobjToImage
    {
        /// <summary>
        /// object 转 Image
        /// </summary>
        /// <param name="strphoto"></param>
        /// <returns></returns>
        public Image objToImage(object strphoto)
        {
            Image Result = null;

            if (strphoto != null && strphoto != DBNull.Value)
            {
                var photoByte = Convert.FromBase64String(strphoto.ToString());
                Result = Image.FromStream(new MemoryStream(photoByte));
            }

            return Result;
        }
    }

    public interface IobjToImage
    {
        Image objToImage(object strphoto);
    }
}


