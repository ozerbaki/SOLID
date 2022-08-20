using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public class TripInfoLogger
    {
        private readonly ILogger _logger;

        public TripInfoLogger(ILogger logger)
        {
            this._logger = logger;
        }

        public void Log(string logStr)
        {
            _logger.Log(logStr);
        }


        //public void LogToIstanbul(string logStr)
        //{
        //    new IstanbulLogger().Log(logStr);
        //}

        //public void LogToLocal(string logStr)
        //{
        //    new LocalLogger().Log(logStr);
        //}

    }

    public class IstanbulLogger : ILogger
    {
        public void Log(string logStr)
        {
            throw new NotImplementedException();
        }
    }

    public class LocalLogger : ILogger
    {
        public void Log(string logStr)
        {
            throw new NotImplementedException();
        }
    }

    public class AnkaraLogger : ILogger
    {
        public void Log(string logStr)
        {
            throw new NotImplementedException();
        }
    }

    public interface ILogger
    {
        void Log(string logStr);
    }
}
