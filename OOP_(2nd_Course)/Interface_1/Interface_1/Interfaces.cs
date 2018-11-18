using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    interface IBreathe
    {
        bool Breathe();
    }
    interface IThink
    {
        void Think();
    }
    interface IMoveVoice
    {
        void Move();
        void Voice();
    }
}