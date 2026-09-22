using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin
{
    public class Utilisateur
    {
        public bool EstGestionnaire { get; set; }
        public string id { get; set; }
        public string mot_de_passe { get; set; }
        public string nom { get; set; }

        public Utilisateur(string id, string nom = "", string motdepasse = "password1", bool EstGestionnaire = false)
        {
            this.nom = nom;
            this.id = id;
            this.mot_de_passe = motdepasse;
            this.EstGestionnaire = EstGestionnaire;
        }

        public override string ToString()
        {
            return $"vous etes un utilisateur";
        }

    }
}

   
