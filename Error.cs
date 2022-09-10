using System.IO;

namespace Evalua
{
    public class Error : Exception
    {
        public Error(string msg,StreamWriter Log) : base(msg)
        {
            Log.WriteLine(msg);
        }
    }
}