using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Database;
using Unicom_TIC_Management_System.Models;

namespace Unicom_TIC_Management_System.Controller
{
    public static class StudentController
    {
        // CREATE
        public static void AddStudent(Student student)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Student (Name, CourseID, DateOfBirth, Email, PhoneNumber, Gender, Address) VALUES (@name, @courseId,@dob, @email, @phone, @gender, @address)";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@courseId", student.CourseID);
                cmd.Parameters.AddWithValue("@dob", student.DateOfBirth);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@phone", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@gender", student.Gender);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.ExecuteNonQuery();
            }
        }

        // READ ALL
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT StudentID, Name, CourseID , DateOfBirth, Email, PhoneNumber, Gender, Address FROM Student";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentID = Convert.ToInt32(reader["StudentID"]),
                            Name = reader["Name"].ToString(), 
                            CourseID = Convert.ToInt32(reader["CourseID"]),
                            DateOfBirth = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader["DateOfBirth"])).DateTime,

                            Email = reader["Email"].ToString(),
                            PhoneNumber = Convert.ToInt32(reader["PhoneNumber"]),
                            Gender = reader["Gender"].ToString(),
                            Address = reader["Address"].ToString()
                        });
                    }
                }
            }

            return students;
        }

        // UPDATE
        public static void UpdateStudent(Student student)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Student SET Name = @name, CourseID = @courseId , DateOfBirth = @dob, Email = @email, PhoneNumber = @phone,Gender = @gender, Address = @address  WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@courseId", student.CourseID);
                cmd.Parameters.AddWithValue("@id", student.StudentID);
                cmd.Parameters.AddWithValue("@dob", student.DateOfBirth);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@phone", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@gender", student.Gender);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public static void DeleteStudent(int studentId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Student WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@id", studentId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
