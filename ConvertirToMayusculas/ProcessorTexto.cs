using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirToMayusculas
{
    public class ProcessorTexto
    {
        private readonly IRepository _repository;

        public ProcessorTexto(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> ConvertirMayusculaAsync (string texto)
        {
            return await Task.Run(() => texto.ToUpper());
        }
    }
}
