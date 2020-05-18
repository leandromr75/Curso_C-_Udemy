using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_composicao_netcore.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
