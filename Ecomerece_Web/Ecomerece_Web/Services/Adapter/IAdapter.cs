using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Adapter
{
    public interface IAdapter<Original, Prototype>
    {
        public Prototype convertFromOriginToProtoType(Original original);
        public Original convertFromProtoTypeToOriginal(Prototype prototype);
    }
}
