using BMU01.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMU01
{
    public static class BMU
    {

        public static Device connect(int port, int baud){

            if(RFIDLib.rf_init_com(port,baud) == 0)
            {

                ushort idDev = 1;
                return new Device(idDev);

            } else {
                throw new NotDeviceConnectedException();
            }

        }

    }
}
