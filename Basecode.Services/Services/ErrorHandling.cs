namespace Basecode.Services.Services
{
    public class ErrorHandling
    {
        public class Log
        {
            public string? ErrorCode { get; set; } = string.Empty;
            public DateTime Time { get; set; }
            public string Message { get; set; } = string.Empty;
            public bool Result { get; set; } = true;
        }

        public static string SetLog(Log log)
        {
            return "ErrorCode: " + log.ErrorCode + ". Message: \"" + log.Message + "\"";
        }
    }
}
