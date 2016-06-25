using System.Collections.Generic;
using System.Runtime.Serialization;
using System;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Create classes (genre,order,game,physical,digital) and their variables

namespace Selfhost
{
    [DataContract]
    public class clsGenre
    {
        [DataMember]
        public string GenreName { get; set; }
        [DataMember]
        public string GenreDescription { get; set; }
        [DataMember]
        public virtual ICollection<clsGame> Games { get; set; }

        public Genre MapToEntity()
        {
            return new Genre()
            { GenreName = this.GenreName, GenreDescription = this.GenreDescription };
        }
    }

    [DataContract]
    public class clsOrder
    {
        [DataMember]
        public string CustomerName { get; set; }

        public Order MapToEntity()
        {
            return new Order()
            { CustomerName = this.CustomerName };
        }
    }

    [DataContract]
    [KnownType(typeof(clsDigital))]
    [KnownType(typeof(clsPhysical))]

    public abstract class clsGame
    {

        [DataMember]
        public string GameName { get; set; }
        [DataMember]
        public int GameCode { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public string GameGenre { get; set; }
        [DataMember]
        public string Publisher { get; set; }
        [DataMember]
        public decimal Price { get; set; }

        public Game MapToEntity()
        {
            Game lcMapEntity = GetEntity();
            lcMapEntity.GameName = GameName;
            lcMapEntity.GameCode = GameCode;
            lcMapEntity.Year = Year;
            lcMapEntity.Quantity = Quantity;
            lcMapEntity.GameGenre = GameGenre;
            lcMapEntity.Publisher = Publisher;
            lcMapEntity.Price = Price;
            return lcMapEntity;
        }
        protected abstract Game GetEntity();
    }

    [DataContract]
    public class clsPhysical : clsGame
    {
        [DataMember]
        public string MediaType { get; set; }
        [DataMember]
        public Nullable<decimal> ShippingCost { get; set; }
        [DataMember]
        public string Media { get; set; }

        protected override Game GetEntity()
        {
            return new Physical()
            { MediaType = this.MediaType, ShippingCost = this.ShippingCost };
        }
    }

        [DataContract]
    public class clsDigital : clsGame
    {
        [DataMember]
        public string GameKey { get; set; }
        [DataMember]
        public string Platform { get; set; }
        [DataMember]
        public string Media { get; set; }

        protected override Game GetEntity()
        {
            return new Digital()
            { GameKey = this.GameKey, Platform = this.Platform, };
        }
    }
}