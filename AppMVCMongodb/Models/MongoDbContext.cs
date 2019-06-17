using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace AppMVCMongodb.Models
{
    public class MongoDbContext
    {
        // ConnectionString - Obtiene la cadena de conexión
        public static string ConnectionString { get; set; }
        // Databasename - Obtiene el nombre de la colección
        public static string DatabaseName { get; set; }
        // IsSSL - Indica si SSL
        public static bool IsSSL { get; set; }
        private IMongoDatabase _database { get; }
        public MongoDbContext()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo conectar con el servidor.", ex);
            }
        }
        public IMongoCollection<Persona> Personas
        {
            get
            {
                return _database.GetCollection<Persona>("Personas");
            }
        }
        public IMongoCollection<Nota> Notas
        {
            get
            {
                return _database.GetCollection<Nota>("Notas");
            }
        }
    }
}
