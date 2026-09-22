using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin
{
    public class Compte
    {
        private decimal solde;
        public decimal Solde
        {
            get { return this.solde; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La valeur ne peut pas être négative!");
                }
                this.solde = value;
            }
        }

        public Compte() : this(0)
        {

        }

        public Compte(decimal soldeDepart)
        {
            this.solde = soldeDepart;
        }

        public void Depot(decimal montant)
        {
            this.Solde += montant;
        }

        public void Retrait(decimal montant)
        {
            this.Solde -= montant;
        }

        public override string ToString()
        {
            return $"Compte bancaire qui possède {this.solde:F2}$";
        }
    }

    public class CompteHerite : Compte
    {
        public string Couleur { get; set; }

    }

}
