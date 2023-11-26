namespace ListaMVCMoveisAlan.Models.ModelsView
{
    public class ItemModelView
    {
        public string nomeMoveis { get; set; }

        public bool checkMoveis { get; set; }

        public ItemModelView(string nomeMoveis, bool checkMoveis)
        {
            this.nomeMoveis = nomeMoveis;
            this.checkMoveis = checkMoveis;
        }

        public ItemModelView()
        {


        }
    }
}
