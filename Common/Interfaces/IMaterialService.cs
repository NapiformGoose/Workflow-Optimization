using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Common
{
    public interface IMaterialService
    {
        MaterialDTO GetMaterial(int? id);
        void MakeMaterial(MaterialDTO materialDto);
        IEnumerable<MaterialDTO> GetMaterials();
    }
}
