using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirToMayusculas
{
    public class TextFileRepository : IRepository
    {
        public async Task<string> ReadTextAsync(string filePath)
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public async Task WriteTextAsync(string filePath, string text)
        {
           using (StreamWriter writer = new StreamWriter(filePath))
            {
                await writer.WriteAsync(text);
            }
        }
    }
}
