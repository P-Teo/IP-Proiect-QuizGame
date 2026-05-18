using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace QuizGame.AccessData
{
    /// <summary>
    /// Clasa responsabila cu initializarea si gestionarea bazei de date SQLite.
    /// Asigura crearea tabelelor necesare si operatiile CRUD pentru intrebari.
    /// </summary>
    public class DataBaseInitializer 
    {
        
        private const string DatabaseFileName = "quizDatabase.sqlite"; // Numele fisierului bazei de date; se va crea in folderul bin/Debug al proiectului
        private static readonly string ConnectionString = $"Data Source={DatabaseFileName};Version=3;";  // String-ul de conectare construit pe baza numelui fisierului bazei de date

        /// <summary>
        /// Initializeaza baza de date la pornirea aplicatiei.
        /// Daca fisierul nu exista, il creeaza, apoi genereaza tabelele necesare.
        /// </summary>
        /// <exception cref="Exception">Aruncata cand fisierul bazei de date nu poate fi creat sau tabelele nu pot fi initializate</exception>
        public void InitializeDatabase()
        {
            try
            {
                // Cream fisierul doar daca nu exista deja, pentru a nu suprascrie datele existente
                if (!File.Exists(DatabaseFileName))
                {
                    SQLiteConnection.CreateFile(DatabaseFileName);
                }

                CreateTables();
            }
            catch (Exception ex)
            {
                throw new Exception($"Eroare la inițializarea bazei de date: {ex.Message}");
            }
        }

        /// <summary>
        /// Creeaza tabelele necesare in baza de date daca acestea nu exista deja.
        /// Tabelul Questions stocheaza textul intrebarii, cele 4 variante, raspunsul corect si dificultatea.
        /// </summary>
        private void CreateTables()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Cream tabelul cu structura: text intrebare, 4 variante de raspuns, varianta corecta si nivelul de dificultate
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


        /// <summary>
        /// Insereaza o intrebare noua in baza de date.
        /// Foloseste parametri pentru a preveni atacurile de tip SQL Injection.
        /// </summary>
        /// <param name="q">Obiectul Question care contine datele intrebarii de inserat</param>
        /// <exception cref="SQLiteException">Aruncata cand interogarea SQL de inserare esueaza</exception>
        /// <exception cref="Exception">Aruncata cand apare o eroare generala la inserarea intrebarii</exception>
        public void InsertQuestion(Question q)
        {
            
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string insertQuery = @"
            INSERT INTO Questions 
            (QuestionText, QuestionA, QuestionB, QuestionC, QuestionD, CorrectOption, DifficultyLevel) 
            VALUES (@text, @a, @b, @c, @d, @correct, @diff)";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        // Legam fiecare parametru la proprietatea corespunzatoare din obiectul intrebarii
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
            catch (SQLiteException ex)
            {
                throw new Exception($"Eroare SQL la inserarea întrebării: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Eroare generală: {ex.Message}");
            }
        }

        /// <summary>
        /// Returneaza toate intrebarile existente in baza de date, indiferent de dificultate.
        /// </summary>
        /// <returns>Lista completa de obiecte Question din baza de date</returns>
        /// <exception cref="SQLiteException">Aruncata cand interogarea SQL de selectie esueaza</exception>
        /// <exception cref="Exception">Aruncata cand apare o eroare generala la extragerea intrebarilor</exception>
        public List<Question> GetAllQuestions()
        {
            try
            {
                var questions = new List<Question>();

                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Questions";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        // Parcurgem fiecare rand returnat si construim obiectul corespunzator
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
            catch (SQLiteException ex)
            {
                throw new Exception($"Eroare SQL la extragerea întrebărilor: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Eroare generală: {ex.Message}");
            }
        }

        /// <summary>
        /// Returneaza intrebarile filtrate dupa nivelul de dificultate specificat.
        /// Folosita de strategii pentru a incarca doar intrebarile relevante dificultatii alese.
        /// </summary>
        /// <param name="difficulty">Nivelul de dificultate dupa care se filtreaza (ex: "Usor", "Mediu", "Greu")</param>
        /// <returns>Lista de obiecte Question corespunzatoare dificultatii specificate</returns>
        public List<Question> GetQuestionsByDifficulty(string difficulty)
        {
            var questions = new List<Question>();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Filtram intrebarile prin parametru pentru a evita SQL Injection
                string selectQuery = "SELECT * FROM Questions WHERE DifficultyLevel = @diff";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@diff", difficulty);
                    using (var reader = command.ExecuteReader())
                    {
                        // Construim obiectul Question pentru fiecare rand din rezultat
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
