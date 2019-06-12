using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AppMVCMongodb.Models
{
    public class Nota
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get;  set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Contenido { get; set; }
        [Required]
        public int Acceso { get; set; }
    }
}
