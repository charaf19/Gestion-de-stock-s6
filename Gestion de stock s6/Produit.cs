//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_de_stock_s6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.Details_Commande = new HashSet<Details_Commande>();
        }
    
        public int Id_Produit { get; set; }
        public string Nom_Produit { get; set; }
        public int Quantite_Produit { get; set; }
        public string Prix_Produit { get; set; }
        public byte[] Image_Produit { get; set; }
        public int ID_CATEGORIE { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Details_Commande> Details_Commande { get; set; }
    }
}
