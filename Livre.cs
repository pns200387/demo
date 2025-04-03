using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Bibliotheque


{

    public class Livre : Document
    
    {
        private string isbn;
        private string editeur;
        private int nombrePages;
        private string v1;
        private string v2;
        private int v3;
        private Document doc;

        public string Isbn

        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Editeur

        {
            get { return editeur; }
            set { editeur = value; }
        }

        public int NombrePages

        {
            get { return nombrePages;}
            set { nombrePages = value;}
        }

        public Livre(string isbn, string editeur, int nombrePages,string id,string password,string titre, int anneePublication, string auteurs):
        base(id,password,titre,anneePublication,auteurs)

        {

            this.isbn = isbn;
            this.editeur = editeur;
            this.nombrePages = nombrePages;
        }


        public  string LireExtrait( String extrait)
        
        {

            Console.WriteLine ("Voici un extrait du livre " +extrait);
    
            return extrait;


        }

        public override void AfficheDetail()
        
        {

            
       
        }

    }



}