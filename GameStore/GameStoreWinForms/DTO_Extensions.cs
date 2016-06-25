// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Extending the DTO, allowing our subclasses to work correctly

namespace GameStoreWinForms.ServiceReference1
{
    public abstract partial class clsGame
    {
        public static readonly string FACTORY_PROMPT = "Enter D for Digital, or P for Physical";

        public static clsGame NewGame(char prChoice)
        {
            
            switch (char.ToUpper(prChoice))
            {
                case 'D': return new clsDigital();
                case 'P': return new clsPhysical();
                default: return null;
            }
        }
        public override string ToString()
        {
            return this.GameName + "\t" + this.GetType();
        }

        public abstract void EditDetails();
    }

    public partial class clsDigital : clsGame
    {
        public delegate void LoadDigitalFormDelegate(clsDigital prDigital);
        public static LoadDigitalFormDelegate LoadDigitalForm;

        public override void EditDetails()
        {
            LoadDigitalForm(this);
        }
    }

    public partial class clsPhysical : clsGame
    {
        public delegate void LoadPhysicalFormDelegate(clsPhysical prPhysical);
        public static LoadPhysicalFormDelegate LoadPhysicalForm;

        public override void EditDetails()
        {
            LoadPhysicalForm(this);
        }
    }
}