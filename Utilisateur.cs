using System;
using System.Collections.Generic;
using System.Data.Common;


namespace Bibliotheque


{
    public class Utilisateur 
    
    {

        private int  id;
        private string nom;
        private string prenom;
        private string email;
        private string adresse;
        private int telephone;


        public int Id

        {
            get { return id; }
            set { id = value; }
        }

        public string Nom

        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom

        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Email

        {
            get { return email; }
            set { email = value; }
        }

        public int Telephone

        {
            get { return telephone; }
            set { telephone = value; }
        }


        public Utilisateur(int id, string nom, string prenom, string email,string adresse,int telephone)

        {

            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.adresse = adresse;
            this.telephone = telephone;
        }

        public void EmprunterDocument (Document doc)

        {

            

        }

        public void RetournerDocument (Document doc)

        {

            

        }


    }


}