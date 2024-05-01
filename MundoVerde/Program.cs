using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            string stringConexao = @"Data Source=localhost;Initial Catalog=Mundo_verde;Integrated Security=True";
            string consulta = "SELECT * FROM USUARIO";

            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                SqlCommand comando = new SqlCommand(consulta, conexao);
                conexao.Open();

                using (SqlDataReader tabelinha = comando.ExecuteReader())
                {
                    while (tabelinha.Read())
                    {
                        Console.WriteLine($"ID: {tabelinha["id_usuario"]}, NOME: {tabelinha["NOME"]}, DOCUMENTO: {tabelinha["documento"]}, TIPO: {tabelinha["tipo_documento"]}, E-MAIL: {tabelinha["email"]}, TELEFONE: {tabelinha["telefone"]}, SENHA: {tabelinha["senha"]}");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
