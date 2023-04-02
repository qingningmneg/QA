using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinClient
{
    /// <summary>
    /// 读卡器操作类
    /// </summary>
    public class CardReader
    {
        #region 刷卡器
        [DllImport("kernel32.dll")]
        static extern void Sleep(int dwMilliseconds);

        //=========================== System Function =============================
        [DllImport("hfrdapi.dll")]
        static extern int Sys_GetDeviceNum(UInt16 vid, UInt16 pid, ref UInt32 pNum);

        [DllImport("hfrdapi.dll")]
        static extern int Sys_GetHidSerialNumberStr(UInt32 deviceIndex, UInt16 vid, UInt16 pid, ref Char deviceString, UInt32 deviceStringLength);

        /// <summary>
        /// 打开读卡器
        /// </summary>
        /// <param name="device"></param>
        /// <param name="index"></param>
        /// <param name="vid"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        [DllImport("hfrdapi.dll")]
        static extern int Sys_Open(ref IntPtr device, UInt32 index, UInt16 vid, UInt16 pid);

        /// <summary>
        /// 判断读卡器是否已经打开
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        [DllImport("hfrdapi.dll")]
        static extern bool Sys_IsOpen(IntPtr device);

        /// <summary>
        /// 关闭读卡器
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        [DllImport("hfrdapi.dll")]
        static extern int Sys_Close(ref IntPtr device);

        /// <summary>
        /// 指示灯管理
        /// </summary>
        /// <param name="device">要操作的设备，由Sys_Open()获得</param>
        /// <param name="color">0：熄灭；1：红色；2：绿色；3：黄色</param>
        /// <returns>0：操作成功</returns>
        [DllImport("hfrdapi.dll")]
        static extern int Sys_SetLight(IntPtr device, byte color);

        /// <summary>
        /// 设置蜂鸣器
        /// </summary>
        /// <param name="device">要操作的设备，由Sys_Open()获得</param>
        /// <param name="msec">蜂鸣时限，单位是10毫秒</param>
        /// <returns></returns>
        [DllImport("hfrdapi.dll")]
        static extern int Sys_SetBuzzer(IntPtr device, byte msec);

        /// <summary>
        /// 设置天线状态
        /// </summary>
        /// <param name="device"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        [DllImport("hfrdapi.dll")]
        static extern int Sys_SetAntenna(IntPtr device, byte mode);

        /// <summary>
        /// 功能：设置读写器非接触工作方式
        /// </summary>
        /// <param name="device">要操作的设备，由Sys_Open()获得</param>
        /// <param name="type">'A':ISO14443A；'B':ISO14443B；'r':AT88RF020；'s':ST卡；'1':ISO15693
        /// </param>
        /// <returns>0 -> 操作成功</returns>
        [DllImport("hfrdapi.dll")]
        static extern int Sys_InitType(IntPtr device, byte type);

        //=========================== M1 Card Function =============================
        [DllImport("hfrdapi.dll")]
        static extern int TyA_Request(IntPtr device, byte mode, ref UInt16 pTagType);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_Anticollision(IntPtr device, byte bcnt, byte[] pSnr, ref byte pLen);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_Select(IntPtr device, byte[] pSnr, byte snrLen, ref byte pSize);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_Halt(IntPtr device);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_Authentication2(IntPtr device, byte mode, byte block, byte[] pKey);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_Read(IntPtr device, byte block, byte[] pData, ref byte pLen);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_Write(IntPtr device, byte block, byte[] pData);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_InitValue(IntPtr device, byte block, Int32 value);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_ReadValue(IntPtr device, byte block, ref Int32 pValue);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_Decrement(IntPtr device, byte block, Int32 value);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_Increment(IntPtr device, byte block, Int32 value);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_Restore(IntPtr device, byte block);

        [DllImport("hfrdapi.dll")]
        static extern int TyA_CS_Transfer(IntPtr device, byte block);

        //==========================================================================
        static IntPtr g_hDevice = (IntPtr)(-1); //g_hDevice must init as -1

        static char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public static byte GetHexBitsValue(byte ch)
        {
            byte sz = 0;

            if (ch <= '9' && ch >= '0')
            {
                sz = (byte)(ch - 0x30);
            }
            if (ch <= 'F' && ch >= 'A')
            {
                sz = (byte)(ch - 0x37);
            }
            if (ch <= 'f' && ch >= 'a')
            {
                sz = (byte)(ch - 0x57);
            }

            return sz;
        }

        #region byteHEX
        /// <summary>
        /// 单个字节转字字符.
        /// </summary>
        /// <param name="ib">字节.</param>
        /// <returns>转换好的字符.</returns>
        public static string byteHEX(Byte ib)
        {
            string _str = string.Empty;

            try
            {
                char[] Digit = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                char[] ob = new char[2];
                ob[0] = Digit[(ib >> 4) & 0X0F];
                ob[1] = Digit[ib & 0X0F];
                _str = new String(ob);
            }
            catch (Exception ex)
            {
            }

            return _str;

        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToHexString(byte[] bytes)
        {
            string hexString = string.Empty;

            for (var i = 0; i < bytes.Length; i++)
            {
                hexString += byteHEX(bytes[i]);
            }

            return hexString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="theHex"></param>
        /// <returns></returns>
        public static byte[] ToDigitsBytes(string theHex)
        {
            byte[] bytes = new byte[theHex.Length / 2 + (((theHex.Length % 2) > 0) ? 1 : 0)];

            for (var i = 0; i < bytes.Length; i++)
            {
                char lowbits = theHex[i * 2];
                char highbits;

                if ((i * 2 + 1) < theHex.Length)
                {
                    highbits = theHex[i * 2 + 1];
                }
                else
                {
                    highbits = '0';
                }

                int a = (int)GetHexBitsValue((byte)lowbits);
                int b = (int)GetHexBitsValue((byte)highbits);
                bytes[i] = (byte)((a << 4) + b);
            }

            return bytes;
        }
        #endregion

        /// <summary>
        /// 打开读卡器
        /// </summary>
        /// <returns></returns>
        public static bool Open()
        {
            try
            {
                int status = 0;

                //如果读卡器已经打开，则先关闭读卡器
                if (Sys_IsOpen(g_hDevice) == true)
                {
                    status = Sys_Close(ref g_hDevice);
                    if (status != 0)
                    {
                        return false;
                    }
                }

                //连接读卡器
                status = Sys_Open(ref g_hDevice, 0, 0x0416, 0x8020);
                if (status != 0)
                {
                    return false;
                }

                //设置读卡器读卡类型
                status = Sys_InitType(g_hDevice, (byte)'A');
                if (status != 0)
                {
                    return false;
                }
                Sleep(5); //Appropriate delay after Sys_InitType operating

                //设置读写器天线状态
                status = Sys_SetAntenna(g_hDevice, 1);
                if (status != 0)
                {
                    return false;
                }
                Sleep(5); //Appropriate delay after Sys_SetAntenna operating

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 关闭读卡器
        /// </summary>
        public static void Close()
        {
            Sys_Close(ref g_hDevice);
        }

        /// <summary>
        /// 蜂鸣
        /// </summary>
        public static void Beep()
        {
            //蜂鸣，单位为10ms
            Sys_SetBuzzer(g_hDevice, 20);
        }

        /// <summary>
        /// 设置指示灯颜色
        /// </summary>
        public static void SetLight(Color color)
        {
            byte lightColor = 1;

            if (color == Color.Red)
            {
                lightColor = 1;
            }
            else if (color == Color.Green)
            {
                lightColor = 2;
            }
            else if (color == Color.Yellow)
            {
                lightColor = 3;
            }
            else if (color == Color.Black)
            {
                lightColor = 0;
            }

            //0：熄灭；1：红色；2：绿色；3：黄色
            Sys_SetLight(g_hDevice, lightColor);
        }

        static string CardID = ""; //卡号
        static DateTime LastReadTime = DateTime.Now; //上次读取时间
        /// <summary>
        /// 读卡
        /// </summary>
        /// <returns></returns>
        public static string Read()
        {
            try
            {
                int status = 0;

                //如果读卡器已经关闭，则先打开读卡器
                if (Sys_IsOpen(g_hDevice) == false)
                {
                    var IsOpen = Open();
                    if (IsOpen == false)
                    {
                        return "";
                    }
                }

                byte mode = 0x52;
                ushort TagType = 0;
                byte bcnt = 0x04;//mifare 卡都用4
                byte[] dataBuffer = new byte[256];
                byte len = 255;
                byte size = 0;

                status = TyA_Request(g_hDevice, mode, ref TagType);//搜寻所有的卡
                if (status != 0)
                {
                    return "";
                }

                status = TyA_Anticollision(g_hDevice, bcnt, dataBuffer, ref len);//返回卡的序列号
                if (status != 0)
                {
                    return "";
                }

                status = TyA_Select(g_hDevice, dataBuffer, len, ref size);//锁定一张ISO14443-3 TYPE_A 卡
                if (status != 0)
                {
                    return "";
                }

                string NewID = "";
                for (int q = 0; q < len; q++)
                {
                    NewID += byteHEX(dataBuffer[q]);
                }

                if (NewID != CardID || (DateTime.Now - LastReadTime).TotalSeconds > 5)
                {
                    LastReadTime = DateTime.Now;
                    CardID = NewID;

                    //蜂鸣，单位为10ms
                    status = Sys_SetBuzzer(g_hDevice, 20);
                    if (status != 0)
                    {
                        return "";
                    }

                    return NewID;
                }
            }
            catch (Exception ex)
            {
            }

            return "";
        }
    }
}
