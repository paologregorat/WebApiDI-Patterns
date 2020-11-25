namespace WebAPITest.Patterns.AdapterPattern
{
    class AClient
    {
        private readonly ITarget _target;

        public AClient(ITarget target)
        {
            _target = target;
        }

        public void MakeRequest()
        {
            _target.MethodA();
        }
    }
}
