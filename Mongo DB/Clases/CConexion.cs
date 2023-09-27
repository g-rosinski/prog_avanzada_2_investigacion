using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;
using static Mongo_DB.Program;

namespace MongoDBCsharp.Clases{
    class CConexion{
        static String servidor = "Joan:grupo5pa2@cluster0.jmxppie.mongodb.net";
        public static MongoClient cliente = new MongoClient("mongodb+srv://Joan:grupo5pa2@cluster0.jmxppie.mongodb.net/");

        public MongoClient establecerConexion(){
            try{
                List<String> NombresBasesDatos = cliente.ListDatabaseNames().ToList();

                foreach (var db in NombresBasesDatos){
                    MessageBox.Show("Se pudo conectar correctamente a la Base de Datos: " + db.ToString());
                }
            }
            catch (MongoClientException e){
                MessageBox.Show("No se logró conectar a MongoDB, error: " + e.ToString());
            }
            return cliente;
        }

        public MongoClient establecerConexionRedis()
        {
            var redisDB = RedisDB.Connection.GetDatabase();
            redisDB.StringSet("1", "Reddis");

            var valor = redisDB.StringGet("1");
            MessageBox.Show("Se pudo conectar correctamente a la Base de Datos: " + valor);
            return cliente;
        }

    }

}
