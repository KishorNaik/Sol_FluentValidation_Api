using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sol_Demo.Models
{
    [DataContract]
    public class UserCommunicationModel 
    {
        [DataMember(EmitDefaultValue =false)]
        public String EmailId { get; set; }

        [DataMember(EmitDefaultValue =false)]
        public String MobileNo { get; set; }
    }
}
