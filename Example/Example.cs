using System.Threading.Tasks;

namespace Example
{
    public class Example
    {
        public int Parse(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch
            {
                throw;
            }
        }

        public async Task<int> ParseAsync(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch
            {
                await Task.Delay(0);

                throw;
            }
        }
    }
}
