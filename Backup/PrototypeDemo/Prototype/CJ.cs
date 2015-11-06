using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    class CJ : AProtagonist
    {
        public override AProtagonist Clone()
        {
            return this.MemberwiseClone() as AProtagonist;
        }
    }
}
