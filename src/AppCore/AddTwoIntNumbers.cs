using System;
using System.Threading.Tasks;

namespace AppCore
{
    public class AddTwoIntNumbers
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Add()
        {
            return Number1 + Number2;
        }

        public async Task<int> AddAsync()
        {
            return await Task.FromResult(Number1 + Number2);
        }
    }
}
