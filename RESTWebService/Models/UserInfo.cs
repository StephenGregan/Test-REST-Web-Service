using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTWebService.Models
{
    // With data contract you can define the name of the
    // properties if they are different than the object names
    // in C#.
    [DataContract]
    public class UserInfo
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "degree")]
        public float Degree { get; set; }

        [DataMember(Name = "DateTime")]
        public DateTime DateTime { get; set; }
    }
}