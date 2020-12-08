namespace ESCAPSULAMENTO.classes
{
    
    public class MasterCard : cartao
    {
        //Atributos

        private int parcelas;

        //get e set

        public int Parcelas{
            get{return parcelas;}
            set {parcelas = value;}

        }

        //Metodos

        public string compraComDesconto(){
            return "";
        }
        
        
    }
}