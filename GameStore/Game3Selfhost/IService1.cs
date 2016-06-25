using System.Collections.Generic;
using System.ServiceModel;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Interfaces specifying work units for use through the service

namespace Selfhost
{
    [ServiceContract]
    interface IService1
    {
        // FOR POPULATING THE MAIN FORM
        [OperationContract]
        List<string> GetGenreNames(); 

        // FOR POPULATING THE ORDER FORM
        [OperationContract]
        List<string> GetOrderSummary();

        // FOR POPULATING THE GENRE FORM
        [OperationContract]
        clsGenre GetGenre(string prGenreName);

         // FOR DELETING ORDERS
        [OperationContract]
        int DeleteOrder(clsOrder prCustomerName);

        // ADDING EDITING DELETING GENRES
        [OperationContract]
        int UpdateGenre(clsGenre prGenre);

        [OperationContract]
        int InsertGenre(clsGenre prGenre);

        [OperationContract]
        int DeleteGenre(clsGenre prGenre);
   
        // ADD EDIT DELETE AND DELETE BY KEY FOR GAMES
        [OperationContract]
        int DeleteGameByKey(string prKey, string prGenreName);

        [OperationContract]
        int UpdateGame(clsGame prGame);

        [OperationContract]
        int InsertGame(clsGame prGame);

        [OperationContract]
        int DeleteGame(clsGame prGame);

    }
}
