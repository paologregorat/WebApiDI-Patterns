namespace WebAPITest.Patterns.AdapterPattern
{
    public class Adapter : ITarget
    {
        readonly Adaptee _adaptee = new Adaptee();

        public void MethodA()
        {
            _adaptee.MethodB();
        }
    }
}
