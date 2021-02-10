using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class SessionGroup : List<String>
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        String[] Items
        {
            get
            {
                return this.ToArray();
            }
            set
            {
                if (value != null)
                    this.AddRange(value);
            }
        }

        public SessionGroup()
        {

        }
        public SessionGroup(string name, List<String> list) : base(list)
        {
            Name = name;
        }



    }
}
