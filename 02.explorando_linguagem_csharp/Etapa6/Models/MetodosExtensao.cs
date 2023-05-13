using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa6.Models
{
    public static class MetodosExtensao
    {
        public static bool ehPar(this int num)
        {
			return num % 2 == 0;
		}
    }
}