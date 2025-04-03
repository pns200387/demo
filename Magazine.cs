using System;
using System.Collections.Generic;


namespace Bibliotheque


{

 public class Magazine : Document
    
    {
        
        private string frequence;
        private int numero;

        public string Frequence

        {
            get { return frequence; }
            set { frequence = value; }
        }


        public int Numero

        {
            get { return numero;}
            set { numero = value;}
        }

        public Magazine(int numero, string frequence, string id,string password,string titre, int anneePublication, string auteurs):
        base(id,password,titre,anneePublication,auteurs)

        {

            this.numero = numero;
            this.frequence = frequence;
            
        }


        public void AfficheSommaire()
        
        {

            Console.WriteLine ("Sommaire du magazine");
    

        }


        public override void AfficheDetail()
        
        {

            
       
        }

    }


}