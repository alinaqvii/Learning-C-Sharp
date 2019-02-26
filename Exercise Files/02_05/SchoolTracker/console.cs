namespace Util
{
    public class console
    {
        static public Ask(string question)
        {
            system.console.Write(question);
            return system.console.ReadLine();
        }
        
    }
}