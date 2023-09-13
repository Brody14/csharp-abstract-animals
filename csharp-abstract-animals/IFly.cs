using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    /*Gli animali che volano hanno il seguente metodo :
    void Vola() (mostra a video “Sto volando!!!”)*/
    public interface IFly
    {
        public void Fly();
    }
}
