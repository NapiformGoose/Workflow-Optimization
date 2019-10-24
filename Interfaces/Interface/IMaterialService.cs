using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;
using Common;

namespace Interfaces
{
    public interface IMaterialService
    {
        MaterialDTO GetMaterial(int? id);
        void MakeMaterial(MaterialDTO materialDto);
        IEnumerable<MaterialDTO> GetMaterials();
    }
}
