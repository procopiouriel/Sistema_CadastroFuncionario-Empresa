using System.Security.Policy;

public class Empresa
{
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string SituacaoCadastral { get; set; }
    public string RegimeTributario { get; set; }
    public DateTime DataInicio { get; set; }
    public string Telefone { get; set; }
    public double CapitalSocial { get; set; }
    public string Endereco { get; set; }
    public string Tipo { get; set; }
    public string PorteEmpresa { get; set; }
    public string NaturezaJuridica { get; set; }
    public string Proprietario { get; set; }
    public string CPF { get; set; }

    public Empresa(string cnpj, string razaoSocial, string nomeFantasia, string situacaoCadastral, string regimeTributario, DateTime dataInicio, string telefone, double capitalSocial, string endereco, string tipo, string porteEmpresa, string naturezaJuridica, string proprietario, string cPF)
    {
        Cnpj = cnpj;
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        SituacaoCadastral = situacaoCadastral;
        RegimeTributario = regimeTributario;
        DataInicio = dataInicio;
        Telefone = telefone;
        CapitalSocial = capitalSocial;
        Endereco = endereco;
        Tipo = tipo;
        PorteEmpresa = porteEmpresa;
        NaturezaJuridica = naturezaJuridica;
        Proprietario = proprietario;
        CPF = cPF;
    }
}