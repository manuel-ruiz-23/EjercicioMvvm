using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pruebaMR.Models;

namespace pruebaMR.ViewModels
{
    public class RegistroViewModel
    {
        private readonly LogsContext _context;

        public RegistroViewModel(LogsContext context)
        {
            _context = context;
        }

        public string Titulo { get; set; }


    }
}
