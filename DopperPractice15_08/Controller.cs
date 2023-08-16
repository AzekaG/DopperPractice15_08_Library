using DopperPractice15_08.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopperPractice15_08
{
     class Controller
    {
        AuthorsRepository authorsRepository;
        public Controller()
        { 
            authorsRepository = new AuthorsRepository(); 
        }

        public void AddAuthor(string firstname, string lastname)
        {
            authorsRepository.Create(new Author() {FirstName = firstname , LastName = lastname });


        }

        public void DeleteAuthor(Author author) 
        {
            authorsRepository.Delete(author);

        }

        public Author FindAuthor(int id)
        {
           return authorsRepository.GetById(id);
        }

        public IList<Author> GetAuthorList() 
        {
            return authorsRepository.GetAll();
        }

        public IList<Author> GetAuthorListByName(string Name)
        {
            return authorsRepository.FindAuthorByName(Name);
        }
        public IList<Author> GetAuthorListBySurName(string Surname)
        {
            return authorsRepository.FindBySurNameAuthor(Surname);
        }
        public IList<Author> GetAuthorListByName(string Name , string SurName)
        {
            return authorsRepository.FindAuthorByName(Name, SurName);
        }



        public IList<Book> GetBookList(Author obj) 
        {
            return authorsRepository.GetBooks(obj.Id);
        }

        public void UpdateAuthor(string FirstName, string SecondName, int id)
        {
           Author temp =  FindAuthor(id);
            temp.FirstName = FirstName;
            temp.LastName = SecondName;
            authorsRepository.Update(temp);
        }

        public void AddBook(Book book , Author author)
        {

            book.id_Author = author.Id;
            authorsRepository.AddBook(book);

        }

        public void DeleteBook(Book book)
        {
            authorsRepository.DeleteBook(book);
        }


    }
}
