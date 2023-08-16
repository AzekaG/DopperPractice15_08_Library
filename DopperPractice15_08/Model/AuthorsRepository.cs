using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DopperPractice15_08.Model
{
    class AuthorsRepository : IRepository<Author>, IDisposable
    {

        SqlConnection connection = null;

        public AuthorsRepository()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

        }

        public int Create(Author obj)
        {
            string sql = "INSERT INTO Authors(FirstName, LastName) VALUES (@FirstName, @LastName)";
            return connection.Execute(sql, obj);
        }


        public int Delete(Author obj)
        {
            string sql = "DELETE FROM Authors WHERE ID = @Id";
            return connection.Execute(sql, obj);

        }

        public void Dispose()
        {
            connection?.Dispose();
        }

        public IList<Author> GetAll()
        {
            string sql = "SELECT * FROM Authors";

            return connection.Query<Author>(sql).ToList();
        }


        public IList<Book> GetBooks(int AuthorId)
        {
            var query = "SELECT* FROM Authors WHERE Id = @id;" +
                "SELECT Id, Name, YearPress, Id_Author FROM Books WHERE Id_Author = @Id";

            var result = connection.QueryMultiple(query, new { Id = AuthorId });
            var author = result.ReadSingle<Author>();
            return result.Read<Book>().ToList();

        }


        public Author GetById(int id)
        {
            string sql = "SELECT * FROM Authors Where Id = @id";
            return connection.QueryFirstOrDefault<Author>(sql, new { Id = id });
        }

        public int Update(Author obj)
        {
            string sql = "UPDATE Authors SET FirstName = @FirstName, LastName = @LastName WHERE Id = @id";
            return connection.Execute(sql, obj);
        }

        public IList<Author> FindAuthorByName(string name)
            {
            string sql = "Select* From Authors Where FirstName = @name";
            var res = connection.Query<Author>(sql ,new {name = name}).ToList();
            return res;
            }
        public IList<Author> FindBySurNameAuthor(string surname)
        {
            string sql = "Select* From Authors Where LastName = @surname";
            return connection.Query<Author>(sql).ToList();
        }
        public IList<Author> FindAuthorByName(string name,string surname)
        {
            string sql = "Select* From Authors Where FirstName = @name , SecondName = @surname";
            return connection.Query<Author>(sql).ToList();
        }
        public void AddBook(Book book)
        {
            string sql = "INSERT INTO Books(Name, YearPress, Id_Author, Quantity,Pages,Id_Press) VALUES (@Name, @YearPress , @Id_Author , '10', '500', '1') ";
           

            connection.Execute(sql, book);
        }


        public void DeleteBook(Book book)
        {

            string sql = "DELETE FROM Books WHERE ID = @Id";
            connection.Execute(sql, book);

        }




    }
}
