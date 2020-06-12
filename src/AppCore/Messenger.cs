using System;
using System.Threading.Tasks;

namespace AppCore
{
    public class Messenger
    {

        public async Task<string> GetMessage(string name)
        {
            return await Task.FromResult("hola " + name);
        }
    }
}
