namespace APIConcepts.Services.TransientScopedSingleton
{
    public interface Interface1
    {
        void DoWork();
    }
    public interface Interface2
    {
        void DoWork();
    }


    public class MyClass : Interface1, Interface2
    {
        void DoWork()
        {
            throw new NotImplementedException();
        }
        void Interface1.DoWork()
        {
            throw new NotImplementedException();
        }

        void Interface2.DoWork()
        {
            throw new NotImplementedException();
        }
        void Main()
        {
            var c = new MyClass();
            c.DoWork();
            ((Interface1)c).DoWork();
            ((Interface2)c).DoWork();
        }

    }
}
