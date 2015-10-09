using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    interface Flyable
    {
        void Fly();
    }

    interface Runnable
    {
        void Run();
    }

    interface Barkable
    {
        void Bark();
    }
}
