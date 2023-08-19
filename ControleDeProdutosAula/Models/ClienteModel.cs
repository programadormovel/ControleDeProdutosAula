using System.Diagnostics.CodeAnalysis;

namespace ControleDeProdutosAula.Models
{
    public class ClienteModel
    {
        public Int32 Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
        [MaybeNull]
        public string NomeDaFoto { get; set; }
        [MaybeNull]
        public byte[] Foto { get; set; }
        public bool Status { get; set; }
        public DateTime DataDeRegistro { get; internal set; }
    }
}
