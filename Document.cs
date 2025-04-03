using System;
using System.Collections.Generic;


namespace Bibliotheque


{


    public class Document

    {
        private string id;
        private string password;
        private string titre;
        private int anneePublication;
        private string auteurs;

        public string Id 
        {
            get { return id; }
            set { id = value; }
        }

        public string Password

        {
            get { return password; }
            set { password = value; }
        }

        public string Titre

        {
            get {return titre; }
            set { titre = value; }

        }

        public int AnneePublication

        {
            get { return anneePublication;}
            set { anneePublication = value;}
        }

        public string Auteurs

        {
            get { return auteurs;}
            set { auteurs = value;}
        }


        public Document(string id,string password,string titre, int anneePublication, string auteurs)

        {

            this.id = id;
            this.password = password;
            this.titre = titre;
            this.anneePublication=anneePublication;
            this.auteurs=auteurs;

        }


        public virtual void AfficheDetail()
        
        {

            Console.WriteLine($"Le details du document emprunte sont {this.id} {this.password}  {this.titre} {this.anneePublication} {this.auteurs}");
       
       }

    }



}