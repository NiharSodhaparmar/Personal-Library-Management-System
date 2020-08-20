using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LibraryManagement
{
    [ServiceContract]
    public interface IBooksService
    {

        //MANAGE CATAGERIOES ------------------------------------------------------

        [OperationContract]
        DataSet GetCategories();

        [OperationContract]
        string addCategory(string categoryName);

        [OperationContract]
        string deleteCategory(int id);

        [OperationContract]
        string updateCategory(int id, string newCategoryName);


        //MANAGE BOOKS -------------------------------------------------------------

        [OperationContract]
        DataSet getBooks();

        //[OperationContract]
        //Dictionary<string, int> getBook_Categories(int id);

        [OperationContract]
        string addBooks(string bookName, string author, string edition, string pages, string price, Dictionary<string, int> d);

        [OperationContract]
        string deleteBook(int bookId);

        [OperationContract]
        string updateBook(int bookId, string bookName, string author, string edition, string pages, string price, Dictionary<string, int> d);

        [OperationContract]
        DataSet getBooksByCategory(string category);
    }

    
}
