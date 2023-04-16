namespace Singleton
{

    public class Logger
    {
        private static Logger? _instace;
        public static Logger Instance{
            get
            {
                if (_instace == null)
                    _instace = new Logger();
                return _instace;
            }
        }
        protected Logger()
        {
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
