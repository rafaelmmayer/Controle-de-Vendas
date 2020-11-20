using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoWF
{
    public class SqliteDataAcess
    {
        public static List<Produto> LoadProdutos()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Produto>("select * from Produto", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void AdcionarProduto(Produto p)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Produto(Nome, Preco, Tipo, Quantidade) values (@Nome, @Preco, @Tipo, @Quantidade)", p);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
