using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Helpers
{
    public interface IComboHelper
    {
        IEnumerable<SelectListItem> GetComboDocumentTypes();
        IEnumerable<SelectListItem> GetComboProcedures();
        IEnumerable<SelectListItem> GetComboVehicleTypes();
        IEnumerable<SelectListItem> GetComboBrands();
    }
}
