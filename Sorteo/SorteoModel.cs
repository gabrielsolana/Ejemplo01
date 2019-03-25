using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteo
{
   
    class SorteoModel
    {
        private Random random;

        public List<string> ListaNombres { get; } = new List<string>();

        public void Anadir(string name) => ListaNombres.Add(name);
        public void Borrar(int pos) => ListaNombres.RemoveAt(pos);
        public int Sortear()
        {
            random = new Random();
            int pos = random.Next(0, ListaNombres.Count - 1);
            return pos;
        }
        
    }
}
