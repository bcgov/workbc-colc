using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ColcDataLayerWcfService.Models.Locations
{
    [DataContract]
    public class LocationsModels
    {
        [DataMember]
        public short LocationID { get; set; }

        [DataMember]
        public string LocationName { get; set; }

        [DataMember]
        public Nullable<short> ParentLocationID { get; set; }
        
        [DataMember]
        public byte LocationTypeID { get; set; }
    }
}