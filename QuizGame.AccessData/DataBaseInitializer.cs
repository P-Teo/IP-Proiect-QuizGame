using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace QuizGame.AccessData
{
    public class DataBaseInitializer
    {
        //Numele fisierului bazei de date
        //Se va crea in folderul bin/Debug al proiectului
        private const string DatabaseFileName = "quizDatabase.sqlite";
        private static readonly string ConnectionString = $"Data Source={DatabaseFileName};Version=3;";

        //Metoda care va fi apelata la pornirea programului
        public void InitializeDatabase()
        {
            //Verificam daca baza de date exista deja pentru a nu o suprascrie
            if (!File.Exists(DatabaseFileName))
            {
                //Cream fisierul fizic al bazei de date
                SQLiteConnection.CreateFile(DatabaseFileName);

            }
            //Cream tabelele necesare
            CreateTables();
        }
        private void CreateTables()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                //Cream tabelul: text, 4 variante, 1 corecta
                string createQuestionsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Questions (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        QuestionText TEXT NOT NULL,
                        QuestionA TEXT NOT NULL,
                        QuestionB TEXT NOT NULL,
                        QuestionC TEXT NOT NULL,
                        QuestionD TEXT NOT NULL,
                        CorrectOption TEXT NOT NULL,
                        DifficultyLevel TEXT NOT NULL
                    );";
                using (var command = new SQLiteCommand(createQuestionsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        //de rescris
        public void InsertQuestion(Question q)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Folosim parametri (@) pentru a preveni erorile și SQL Injection
                string insertQuery = @"
            INSERT INTO Questions (QuestionText, QuestionA, QuestionB, QuestionC, QuestionD, CorrectOption, DifficultyLevel) 
            VALUES (@text, @a, @b, @c, @d, @correct, @diff)";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    // Legăm datele din obiectul Question de parametrii din comanda SQL
                    command.Parameters.AddWithValue("@text", q.QuestionText);
                    command.Parameters.AddWithValue("@a", q.OptionA);
                    command.Parameters.AddWithValue("@b", q.OptionB);
                    command.Parameters.AddWithValue("@c", q.OptionC);
                    command.Parameters.AddWithValue("@d", q.OptionD);
                    command.Parameters.AddWithValue("@correct", q.CorrectOption);
                    command.Parameters.AddWithValue("@diff", q.DifficultyLevel);

                    command.ExecuteNonQuery();
                }
            }
        }
        //de rescris asta
        public List<Question> GetAllQuestions()
        {
            var questions = new List<Question>();
            // Folosim ConnectionString-ul definit anterior
            string connectionString = "Data Source=quizDatabase.sqlite; Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Questions";

                using (var command = new SQLiteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        questions.Add(new Question
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            QuestionText = reader["QuestionText"].ToString(),
                            OptionA = reader["QuestionA"].ToString(),
                            OptionB = reader["QuestionB"].ToString(),
                            OptionC = reader["QuestionC"].ToString(),
                            OptionD = reader["QuestionD"].ToString(),
                            CorrectOption = reader["CorrectOption"].ToString(),
                            DifficultyLevel = reader["DifficultyLevel"].ToString()
                        });
                    }
                }
            }
            return questions;
        }

        public List<Question> GetQuestionsByDifficulty(string difficulty)
        {
            var questions = new List<Question>();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Questions WHERE DifficultyLevel = @diff";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@diff", difficulty);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questions.Add(new Question
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                QuestionText = reader["QuestionText"].ToString(),
                                OptionA = reader["QuestionA"].ToString(),
                                OptionB = reader["QuestionB"].ToString(),
                                OptionC = reader["QuestionC"].ToString(),
                                OptionD = reader["QuestionD"].ToString(),
                                CorrectOption = reader["CorrectOption"].ToString(),
                                DifficultyLevel = reader["DifficultyLevel"].ToString()
                            });
                        }
                    }
                }
            }
            return questions;
        }
    }
}
