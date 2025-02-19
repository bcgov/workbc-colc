using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDMEntities.Filters;

namespace EDMEntities
{
    public class WorkBC_CurrentNOCEDMContext : WorkBC_EDMContext
    {
        public WorkBC_CurrentNOCEDMContext() 
            : base()
        {
            this.ApplyFilters(new List<IFilter<WorkBC_EDMContext>>()
                             {
                                 new NOCYearFilter()                                         
                             });
        }
    }
}
