using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models;

[DataContract]
public class EchoModel
{
    [DataMember(Name = "chaine")]
    public string Chaine { get; set; }
}