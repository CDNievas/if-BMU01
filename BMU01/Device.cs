using BMU01.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMU01
{
    public class Device
    {

        public ushort icDev { get; set; }
        public int port { get; set; }
        public int baud { get; set; }

        public Device(ushort icDev)
        {

            if ((RFIDLib.rf_init_device_number(icDev)) == 0) {
                this.icDev = icDev;
            } else
            {
                throw new CantSetDeviceCodeException();
            }

        }

        public void beep(int msec){

            char cmsec = (char)msec;

            if ((RFIDLib.rf_beep(this.icDev, cmsec)) != 0){
                throw new CantBeepException();
            }

        }

        public static void disconnect()
        {

            if (RFIDLib.rf_ClosePort(port, baud) != 0){

                throw new CantDisconnectDeviceException();

            }

        }

    }
}
