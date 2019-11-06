using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BMU01
{
    public static class RFIDLib
    {

        // int WINAPI rf_init_com(int port,long baud);
        [DllImport("MasterRD.dll")]
        public static extern int rf_init_com(int port, long baud);

        // int WINAPI rf_ClosePort();
        [DllImport("MasterRD.dll")]
        public static extern int rf_ClosePort();

        // int WINAPI rf_init_device_number (unsigned short icdev);
        [DllImport("MasterRD.dll")]
        public static extern int rf_init_device_number(ushort icdev);

        // int WINAPI rf_beep(unsigned short icdev, unsigned char msec);
        [DllImport("MasterRD.dll")]
        public static extern int rf_beep(ushort icdev, char msec);

        /*
        // int WINAPI rf_request(unsigned short icdev, unsigned char model, unsigned short *TagType);
        [DllImport("MasterRD")]
        public static extern int rf_request(short icdv, byte model, short tagType);

        // int WINAPI rf_anticoll(unsigned short icdev, unsigned char bcnt, unsigned char *ppSnr, unsigned char* pRLength);
        [DllImport("MasterRD")]
        public static extern int rf_anticoll(ushort icdev, byte bcnt, byte[] ppSnr, byte[] pRLength);

        // int WINAPI rf_select(unsigned short icdev, unsigned char* pSnr, unsigned char srcLen, unsigned char *Size);
        [DllImport("MasterRD")]
        public static extern int rf_select(ushort icdev, byte[] pSnr, byte srcLen, byte[] Size);

        // int WINAPI rf_M1_authentication2(unsigned short icdev,unsigned char model,unsigned char block, unsigned char *key);
        [DllImport("MasterRD")]
        public static extern int rf_M1_authentication2(ushort icdev, byte model, byte block, byte[] key);

        // int WINAPI rf_M1_read(unsigned short icdev, unsigned char block, unsigned char* ppData, unsigned char *pLen);
        [DllImport("MasterRD")]
        public static extern int rf_M1_read(ushort icdev, byte block, byte[] ppData, byte[] pLen);

        // int WINAPI rf_M1_write(unsigned short icdev, unsigned char block, unsigned char *data);
        [DllImport("MasterRD")]
        public static extern int rf_M1_write(ushort icdev, byte block, byte[] data);

        // int WINAPI rf_halt(unsigned short icdev);
        [DllImport("MasterRD")]
        public static extern int rf_halt(ushort icdev);
        */

    }
}
