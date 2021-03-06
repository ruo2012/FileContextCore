﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Example.Data.Entities
{
    [DataContract]
    public class User : Base
    {
        [DataMember]
        public string Username { get; set; }

        public string Name { get; set; }

        public int? Test { get; set; }

        [NotMapped]
        public string Ignored { get; set; }

        [NotMapped]
        public string[] VContents
        {
            get
            {
                if(Contents != null)
                {
                    return Contents.Select(c => c.Text).ToArray();
                }
                else
                {
                    return new string[] { };
                }
                
            }
        }

        public virtual List<Content> Contents { get; set; }

        public virtual List<Setting> Settings { get; set; }
    }
}
