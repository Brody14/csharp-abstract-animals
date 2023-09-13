using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    /*Gli animali che nuotano hanno il seguente metodo :
    void Nuota() (mostra a video “Sto nuotando!!!”)*/
    public interface ISwim
    {
        public void Swim();
    }
}
