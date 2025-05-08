namespace Task_1
{
    public abstract class SupportHandler
    {
        protected SupportHandler NextHandler;

        public void SetNext(SupportHandler handler)
        {
            NextHandler = handler;
        }

        public abstract bool Handle(SupportRequest request);
    }
}


