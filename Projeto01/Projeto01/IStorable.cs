using System;
using System.IO;

namespace Projeto01
{
    interface IStorable
    {
        void Save(BinaryWriter writer);
        void Load(BinaryReader reader);
    }
}
