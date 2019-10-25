using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Interfaces
{
    public interface IMaterialService
    {
        Material GetMaterial(int? id);
        void MakeMaterial(Material materialDto);
        IEnumerable<Material> GetMaterials();
    }
}
