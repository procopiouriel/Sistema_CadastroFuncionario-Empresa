using Venda_Bovina;

namespace TelaDesign
{
    internal static class Program
    {
        public static List<Funcionario> funcionarios = new List<Funcionario>();
        public static List<Funcionario> funcionariosLista = new List<Funcionario>();
        public static List<Empresa> empresas = new List<Empresa>();
        public static List<Empresa> empresasLista = new List<Empresa>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormInicial());
        }
    }
}