namespace ESCAPSULAMENTO.classes
{
    public class cartao
    {
        //declaraçao dos tributos

        private string numero;

        private string bandeira;
        public string Bandeira
        {
            get{return bandeira;}
            set{bandeira = value;}
        } 

        protected string token = "qwertyui";

        private string cvv;

        protected float limite = 5000;

        //declaraçao dos metodos

        public string RegistrarCompra(bool validado)
        {

            return "";


        }
        private bool ValidarCompra(float saldo)
        {
            return true;
        }

        protected string ValidarToken(string token)
        {

            return "";
        }

    }
}