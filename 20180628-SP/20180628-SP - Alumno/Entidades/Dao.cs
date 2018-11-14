using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Entidades
{
    public class Dao<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            SqlConnection conexion = null;
            SqlCommand comando = new SqlCommand();

            try
            {
                string connetionSql = "Data Source = ./SQLEXPRESS; Initial Catalog = votacion-sp-2018.bak; Integrated Security=True";                
                conexion = new SqlConnection(connetionSql);            
            }
            catch (Exception)
            {
                throw;
            }


        }

        public T Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
