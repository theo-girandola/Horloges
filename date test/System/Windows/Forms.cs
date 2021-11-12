namespace System.Windows
{
    internal class Forms
    {
        internal class Timer
        {
            public Timer()
            {
            }

            public Action<object, object> Tick { get; internal set; }
            public int Interval { get; internal set; }

            internal void Start()
            {
                throw new NotImplementedException();
            }
        }
    }
}