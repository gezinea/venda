//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErpSigmaVenda.Conexao
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fornecedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedores()
        {
            this.Fornecimento = new HashSet<Fornecimento>();
        }
    
        public System.Guid IdFornecedores { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public System.Guid idEndereco { get; set; }
    
        public virtual Endereco Endereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fornecimento> Fornecimento { get; set; }
    }
}
