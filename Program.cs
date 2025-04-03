using System;
using System.Collections.Generic;


namespace Bibliotheque


{

    class Program
    {

        static void Main(string[] args)
        {


            Document doc = new Document("23769D","onfi8479","ExamenUA@", 2000,"C2025");
            doc.AfficheDetail();

            Livre l = new Livre("book","styve", 2,"2376cdcD","onfi8rgr79","ExamenUA1", 2020,"C20rfr5");
            l.AfficheDetail();
            string prefaxe = "IPSUM";
            l.LireExtrait(prefaxe);

            Utilisateur utilisateur = new Utilisateur(2726827,"styve","peuyo","2726827@collegelacite","840 springlanda",343558497);

            utilisateur.EmprunterDocument(doc);
            utilisateur.RetournerDocument(l);


            

        }
    }


}