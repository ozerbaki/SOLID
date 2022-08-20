using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public class CustomException
    {
        //Motor Çalışması
        public class EngineException : Exception
        {

        }

        //Hava Basıncı
        public class AirPressureException : Exception
        {

        }
    }



}
