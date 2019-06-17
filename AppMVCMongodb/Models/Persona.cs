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
    public class Persona
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required]
        public string Dni { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [BsonIgnoreIfNull]
        public Direccion Direccion { get; set; }
    }
}
