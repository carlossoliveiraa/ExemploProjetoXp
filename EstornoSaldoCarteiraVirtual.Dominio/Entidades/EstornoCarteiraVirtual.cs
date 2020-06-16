namespace EstornoSaldoCarteiraVirtual.Dominio.Entidades
{
    public class EstornoCarteiraVirtual : EntidadeBasica
    {
        public decimal Valor { get; set; }
        public string Frotista { get; set; }
        public int Quantidade { get; set; }
        public int EmpresaFrotistaId { get; set; }
    }
}
