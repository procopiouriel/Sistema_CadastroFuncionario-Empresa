using System.Security.Policy;

public class Funcionario
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public DateTime DataNascimento { get; set; } 
    public string EstadoCivil { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Endereco { get; set; }
    public double Salario { get; set; }
    public string Funcao { get; set; }

    public Funcionario(string nome, string cpf, string rg, DateTime dataNascimento, string estadoCivil, string telefone, string email, string endereco, double salario, string funcao)
    {
        this.Nome = nome;
        this.Cpf = cpf;
        this.Rg = rg;
        this.Email = email;
        this.DataNascimento = dataNascimento;
        this.Telefone = telefone;
        this.EstadoCivil = estadoCivil;
        this.Endereco = endereco;
        this.Salario = salario;
        this.Funcao = funcao;
    }
}