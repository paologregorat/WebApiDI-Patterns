namespace WebAPITest.Patterns.SingletonPattern
{
    public class PrinterSpooler {
        private static PrinterSpooler instance;
        private PrinterSpooler() {
        }
        public static  PrinterSpooler GetInstance() {
            if ( instance==null) {
                instance = new PrinterSpooler();
            }
            return instance;
        }
    }
}