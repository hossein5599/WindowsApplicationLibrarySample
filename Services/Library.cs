using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WindowsAppLibrarySample.Infrastructure;
using WindowsAppLibrarySample.Models;

namespace WindowsAppLibrarySample.Services
{
    public class Library
    {
        private readonly IUnitOfWork _unitOfWork;
        public List<Book> Books { get; set; } = new List<Book>();

        public Library(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddBook(Book book)
        {
            var repository = _unitOfWork.Repository<Book>();
            repository.Add(book);
            _unitOfWork.Save();
        }

        public bool RemoveBook(string isbn)
        {
            var repository = _unitOfWork.Repository<Book>();
            var bookToRemove = repository.GetAll().FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
                repository.Delete(bookToRemove);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
         

        public List<string> ListBooks()
        {
            var repository = _unitOfWork.Repository<Book>();
            var books = repository.GetAll().ToList<Book>();

            var result = books.Select(b => b.GetBookInfo()).ToList();
            return result;
        }


        public Book GetById(int id)
        {
            var repository = _unitOfWork.Repository<Book>();
            return  repository.FindSingle(id);
        }

        public List<Book> GetAllBooks()
        {
            var repository = _unitOfWork.Repository<Book>();
            var books = repository.GetAll().ToList<Book>();
            return books;
        }

        public void UpdateBook(Book entity)
        {
            var repository = _unitOfWork.Repository<Book>();
            repository.Update(entity);
            _unitOfWork.Save();
        }

        public void DeleteBookById(int id)
        {
            var repository = _unitOfWork.Repository<Book>();
            repository.Delete(id);
            _unitOfWork.Save();
        }
    }
}
