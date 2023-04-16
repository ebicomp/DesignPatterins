namespace Singleton
{

    public class LoggerThreadSafe
    {

        private static readonly Lazy<LoggerThreadSafe> _instance =
            new Lazy<LoggerThreadSafe>(() => new LoggerThreadSafe());
        //private static LoggerThreadSafe? _instace;
        public static LoggerThreadSafe Instance{
            get
            {
                return _instance.Value;
            }
        }
        protected LoggerThreadSafe()
        {
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
