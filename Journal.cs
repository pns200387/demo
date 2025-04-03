using System;
using System.Collections.Generic;


namespace Bibliotheque


{

 public class Jounal : Document
    
    {
        private DateOnly date;
    
       
        public DateOnly Date

        {
            get { return date;}
            set { date = value;}
        }

        public Jounal(DateOnly date,string id,string password,string titre, int anneePublication, string auteurs):
        base(id,password,titre,anneePublication,auteurs)

        {

            this.date = date;
            
        }


        public string LireArticlePrincipal( String article)
        
        {

            Console.WriteLine ("Voici un extrait du livre " +article);
    
            return article;


        }

        public override void AfficheDetail()
        
        {

            
       
        }

    }


}