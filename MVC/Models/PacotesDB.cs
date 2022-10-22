using System;
using System.Collections.Generic;
using MySqlConnector;

namespace MVC.Models
{
    public class PacotesDB
    {
        // Dados de conexão
        private static string dadosConexao = "Database=veiculos; Data Source=localhost; User Id=root;";

        public static String TestarConexao() {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            
            conexao.Open();
            conexao.Close();    
            string mensagem = "Conectado com sucesso!";

            return mensagem;        
        }

        /* CRUD de Carro */
        public static void Inserir (Pacotes pacotes) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "INSERT INTO pacotes (Pacote, Destino, Valor, Observacao) VALUES (@NomePacote, @Destinno, @Valor, @Observacao);";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@NomePacote", pacotes.NomePacote);
            comando.Parameters.AddWithValue("@Destino", pacotes.Destino);
            comando.Parameters.AddWithValue("@Valor", pacotes.Valor);
            comando.Parameters.AddWithValue("@Observacao", pacotes.Observacao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }


        public static List<Pacotes> Listar() {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "SELECT * FROM pacotes;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();
            
            List<Pacotes> lista = new List<Pacotes>();

            while (leitor.Read()) {
                Pacotes pacote = new Pacotes();

                if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
                    pacote.id           = leitor.GetInt32("id");
                if (!leitor.IsDBNull(leitor.GetOrdinal("")))
                    pacote.NomePacote   = leitor.GetString("");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Destino")))
                    pacote.Destino      = leitor.GetString("Destino");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Valor")))
                    pacote.Valor        = leitor.GetInt32("Valor");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Observacao")))
                    pacote.Observacao   = leitor.GetDouble("Observacao");

                lista.Add(pacote);
            }

            conexao.Close();
            return lista;
        }

        public static void Atualizar (Pacotes pacote) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "UPDATE carro SET marca=@marca, ano=@ano, cor=@cor, valor=@valor WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@marca", carro.marca);
            comando.Parameters.AddWithValue("@ano", carro.ano);
            comando.Parameters.AddWithValue("@cor", carro.cor);
            comando.Parameters.AddWithValue("@valor", carro.valor);
            comando.Parameters.AddWithValue("@id", carro.id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }        

        public static void Remover (int id) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "DELETE FROM carro WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }        


        // Métodos auxiliares
        public static Carro BuscarPorId(int id) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "SELECT * FROM carro WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader leitor = comando.ExecuteReader();
            
            Carro carro = new Carro();

            if (leitor.Read()) {
                if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
                    carro.id = leitor.GetInt32("id");
                if (!leitor.IsDBNull(leitor.GetOrdinal("marca")))
                    carro.marca = leitor.GetString("marca");
                if (!leitor.IsDBNull(leitor.GetOrdinal("cor")))
                    carro.cor = leitor.GetString("cor");
                if (!leitor.IsDBNull(leitor.GetOrdinal("ano")))
                    carro.ano = leitor.GetInt32("ano");
                if (!leitor.IsDBNull(leitor.GetOrdinal("valor")))
                    carro.valor = leitor.GetDouble("valor");
            }

            conexao.Close();
            return carro;
        }



    }
}