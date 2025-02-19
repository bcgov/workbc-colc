using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EDMEntities.Filters
{
    public interface IFilter<T> where T : DbContext
    {
        T DbContext { get; set; }
        void Apply();
    }
}
