using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        double _quantidade;
        double _preco;
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao
        {
            get => _descricao;
            set
            {
                if(value == null || value == string.Empty)
                {
                    throw new Exception("Descrição não pode ser vazia");
                }
                _descricao = value;
            }
        }
        public double Quantidade
        {
            get => _quantidade;
            set 
            {
                if (value == null || value == 0)
                {
                    throw new Exception("Quantidade não pode ser vazia");
                }
                _quantidade = value;
            }
        }
        public double Preco
        {
            get => _preco;
            set
            {
                if (value == null || value == 0)
                {
                    throw new Exception("Preço não pode ser vazio");
                }
                _preco = value;
            }
        }
        public double Total { get => Quantidade * Preco; }
    }
}
