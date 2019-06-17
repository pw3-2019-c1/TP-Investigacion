using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AppMVCMongodb.Models
{
    [BsonIgnoreExtraElements()] // Para que no rompa si algun docuento tiene otros campos adicionales
    public class Direccion
    {
        [BsonIgnoreIfNull]
        public string Calle { get; set; }
        [BsonIgnoreIfNull]
        public int Numero { get; set; }
        [BsonIgnoreIfNull]
        public string Localidad { get; set; }
    }
}
