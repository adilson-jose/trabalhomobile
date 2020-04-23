using System.Runtime.Serialization;

namespace Movies.Models
{
    [DataContract]
    public class Language
    {
        [DataMember(Name = "iso_3166_1")]
        public string Iso639Code { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}