using System;
using System.Collections.Generic;
using System.Data.Common;


namespace Bibliotheque


{
    public class EmprunterDocument

    {
        private DateOnly dateEmprunt;
        private DateOnly dateRetour;
        private Boolean documentRetourne;
        Document doc;
        Utilisateur utilisateur;




        public DateOnly DateEmprunt

        {
            get { return dateEmprunt; }
            set { dateEmprunt = value; }
        } 

        public DateOnly DateRetour

        {
            get { return dateRetour; }
            set { dateRetour = value; }
        }

        public Boolean DocumentRetourne

        {
            get { return documentRetourne; }
            set { documentRetourne = value; }
        } 

        public Document Document

        {
            get { return doc;}
        }

        public Utilisateur User

        {
            get { return utilisateur;}
        }
  
 

    }

   


}