using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirToMayusculas
{
    public interface IRepository
    {
        Task<string> ReadTextAsync(string filePath);
        Task WriteTextAsync(string filePath,string text);
    }
}
