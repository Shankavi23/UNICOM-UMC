using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC_Management_System.Database;
using Unicom_TIC_Management_System.Models;




namespace Unicom_TIC_Management_System.Controller
{
  
    
        public class SubjectController
        {
            // Create a new Subject
            public void Create(Subject subject)
            {
                using (var conn = DbConfig.GetConnection())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Subject (SubjectName, CourseID) VALUES (@name, @courseId)";
                    cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@courseId", subject.CourseID);
                    cmd.ExecuteNonQuery();
                }
            }

            // Read all Subjects
            public List<Subject> GetAll()
            {
                var subjects = new List<Subject>();

                using (var conn = DbConfig.GetConnection())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Subject";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject
                            {
                                ID = Convert.ToInt32(reader["SubjectID"]),
                                SubjectName = reader["SubjectName"].ToString(),
                                CourseID = Convert.ToInt32(reader["CourseID"])
                            });
                        }
                    }
                }

                return subjects;
            }

            // Update a Subject
            public bool Update(Subject subject)
            {
                using (var conn = DbConfig.GetConnection())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Subject SET SubjectName = @name, CourseID = @courseId WHERE SubjectID = @id";
                    cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@courseId", subject.CourseID);
                    cmd.Parameters.AddWithValue("@id", subject.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

            // Delete a Subject
            public bool Delete(int subjectId)
            {
                using (var conn = DbConfig.GetConnection())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Subject WHERE SubjectID = @id";
                    cmd.Parameters.AddWithValue("@id", subjectId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

            // Get a single Subject by ID (optional helper)
            public Subject GetById(int id)
            {
                using (var conn = DbConfig.GetConnection())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Subject WHERE SubjectID = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Subject
                            {
                                ID = Convert.ToInt32(reader["SubjectID"]),
                                SubjectName = reader["SubjectName"].ToString(),
                                CourseID = Convert.ToInt32(reader["CourseID"])
                            };
                        }
                    }
                }

                return null;
            }
        }
    }

