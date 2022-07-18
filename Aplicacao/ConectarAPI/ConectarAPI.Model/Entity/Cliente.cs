namespace ConectarAPI.Model.Entity
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                   Id == cliente.Id &&
                   Nome == cliente.Nome &&
                   DataNascimento == cliente.DataNascimento;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, DataNascimento);
        }

        public override string? ToString() => $"{Id} {Nome} {DataNascimento} " ;
        
    }
}