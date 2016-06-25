// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Extends our database model to create the subclasses, physical and digital

namespace Selfhost
{
    public abstract partial class Game
    {
        public clsGame MapToDTO()
        {
            clsGame lcGameDTO = GetDTO();
            lcGameDTO.GameName = GameName;
            lcGameDTO.GameCode = GameCode;
            lcGameDTO.Year = Year;
            lcGameDTO.Quantity = Quantity;
            lcGameDTO.GameGenre = GameGenre;
            lcGameDTO.Publisher = Publisher;
            lcGameDTO.Price = Price;
            return lcGameDTO;
        }

        protected abstract clsGame GetDTO();
    }

    public partial class Digital
    {
        protected override clsGame GetDTO()
        {
            return new clsDigital()
            { Platform = this.Platform, GameKey = this.GameKey };
        }
    }

    public partial class Physical
    {
        protected override clsGame GetDTO()
        {
            return new clsPhysical()
            { MediaType = this.MediaType, ShippingCost = this.ShippingCost };
        }
    }
}
