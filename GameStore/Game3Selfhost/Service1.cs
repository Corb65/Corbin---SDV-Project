using System.Collections.Generic;
using System.Linq;
using System;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Methods that load data from the database entities 

namespace Selfhost
{
    [System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    class Service1 : IService1
    {
        // A list of strings containing Genre.GenreName from the database
        public List<string> GetGenreNames()
        {
            using (DatabaseEntities lcContext = new DatabaseEntities())
                return lcContext.Genres
                    .Select(lcGenre => lcGenre.GenreName)
                    .ToList();
        }

        // A collection of order information from the database
        public List<string> GetOrderSummary()
        {
            using (DatabaseEntities lcContext = new DatabaseEntities())
                return lcContext.Orders
                    .Select(lcOrder => lcOrder.CustomerName)
                    .ToList();
        }

        // A collection of Genre.GenreName and Genre.GenreDescription
        public clsGenre GetGenre(string prGenreName)
        // service method using clsGenre
        {
            using (DatabaseEntities lcContext = new DatabaseEntities())
            {
                Genre lcGenre = lcContext.Genres
                       .Include("Games")
                       .Where(Genre => Genre.GenreName == prGenreName)
                       .FirstOrDefault();

                clsGenre lcGenreDTO = new clsGenre()
                { GenreName = lcGenre.GenreName, GenreDescription = lcGenre.GenreDescription, Games = new List<clsGame>() };

                foreach (Game item in lcGenre.Games)
                    lcGenreDTO.Games.Add(item.MapToDTO());
                return lcGenreDTO;
            }
        }

        private int process<TEntity>(TEntity prItem,
            System.Data.Entity.EntityState prState) where TEntity : class
        {
            try
            {
                using (DatabaseEntities lcContext = new DatabaseEntities())
                {
                    lcContext.Entry(prItem).State = prState;
                    int lcCount = lcContext.SaveChanges();

                    return lcCount;
                }
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }

        public int UpdateGenre(clsGenre prGenre)
        {
            return process(prGenre.MapToEntity(), System.Data.Entity.EntityState.Modified);
        }

        public int InsertGenre(clsGenre prGenre)
        {
            return process(prGenre.MapToEntity(), System.Data.Entity.EntityState.Added);
        }

        public int DeleteOrder(clsOrder prCustomerName)
        {
            return process(prCustomerName.MapToEntity(), System.Data.Entity.EntityState.Deleted);
        }

        public int DeleteGenre(clsGenre prGenre)
        {
            return process(prGenre.MapToEntity(), System.Data.Entity.EntityState.Deleted);
        }

        public int UpdateGame(clsGame prGame)
        {
            return process(prGame.MapToEntity(), System.Data.Entity.EntityState.Modified);
        }

        public int InsertGame(clsGame prGame)
        {
            return process(prGame.MapToEntity(), System.Data.Entity.EntityState.Added);
        }

        public int DeleteGame(clsGame prGame)
        {
            return process(prGame.MapToEntity(), System.Data.Entity.EntityState.Deleted);
        }

        public int DeleteGameByKey(string prKey, string prGenreName)
        {
            Game lcGame = new Physical();
            lcGame.GameName = prKey;
            lcGame.GameGenre = prGenreName;
            return process(lcGame, System.Data.Entity.EntityState.Deleted);
        }
    }
}