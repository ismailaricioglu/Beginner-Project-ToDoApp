using NLog;
using Services.Contracts;

namespace Services
{
    public class LoggerManager : ILoggerService
    {
        private static ILogger loger = LogManager.GetCurrentClassLogger();

        public void LogDebug(string message) => loger.Debug(message);

        public void LogError(string message) => loger.Error(message);

        public void LogInfo(string message) => loger.Info(message);

        public void LogWarning(string message) => loger.Warn(message);
    }
}
