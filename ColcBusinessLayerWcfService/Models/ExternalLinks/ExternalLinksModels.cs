using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ColcBusinessLayerWcfService.Models.ExternalLinks
{
    [DataContract]
    public class ExternalLinksModels
    {
        [DataMember]
        public string Section { get; set; }

        [DataMember]
        public string LinkText { get; set; }

        [DataMember]
        public string LinkURL { get; set; }

        [DataMember]
        public string LinkDescription { get; set; }

        [DataMember]
        public int SortOrder { get; set; }
    }
}