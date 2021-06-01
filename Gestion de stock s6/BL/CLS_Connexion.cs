using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_stock_s6.BL
{
    class CLS_Connexion
    {
        //fonction pour verifier la connexion
        public  bool ConnexionValide(dbStockContext db,string Nom,string Mot_de_passe)
        {
            Utilisateur U = new Utilisateur();//table utlilisateur
            U.NomUtilisateur = Nom;
            U.Mot_De_Passe = Mot_de_passe;
            if (db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nom && s.Mot_De_Passe == Mot_de_passe)!=null)//si l'utilisateur et le mot de pass existe dans la base de données
            {
                return true;
            }
            else// si n'existe pas 
            {
                return false;
            }

        }
    }
}
