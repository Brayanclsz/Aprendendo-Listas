public class Produto
{
    public string Nome { get; set; } = string.Empty;
    public double Preco { get; set; }
    public double Desconto { get; set; } = 10;
    public double PrecoDesconto => Preco * (100 - Desconto) / 100;
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
    public Produto()
    {
        
    }
    public override string ToString()
    {
        return $"{Nome} - R$ {Preco:F2}"; 
    }
}