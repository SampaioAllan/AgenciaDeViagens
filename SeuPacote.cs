namespace AgenciaDeViagens
{
    public class SeuPacote
    {
        
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }
        public float ValorPacote { get; set; }
        

        public void MontarPacote()
        {
            Console.WriteLine("Qual seria a data de ida?");
            DataIda = EscolherData();            

            Console.WriteLine("Qual seria a data da volta?");
            DataVolta = EscolherData();

            Console.WriteLine($"A sua data de ida é: {DataIda}");
            Console.WriteLine($"A sua data de volta é: {DataVolta}");
        }
        
        public DateTime EscolherData()
        {
            Console.WriteLine($"digite o ano?({DateTime.Now.Year}-{DateTime.Now.AddYears(1).Year})");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o mês?");            
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o dia?");            
            int dia = int.Parse(Console.ReadLine());

            int horas=0;
            int minutos=0;
            int segundos=0;
            
            bool corrigir= false;
            do
            {
                
                
                

                Console.WriteLine("Escolha o horário do seu vôo."); 
                Console.WriteLine("    (  1  ).... 08:42:00 Hrs"); 
                Console.WriteLine(""); 
                Console.WriteLine("    (  2  ).... 14:39:00 Hrs");
                Console.WriteLine(""); 
                Console.WriteLine("    (  3  ).... 23:17:00 Hrs"); 
                Console.WriteLine("");
                int horaEscolhida=int.Parse (Console.ReadLine());
                
                if(horaEscolhida == 1)
                {
                    horas=08;
                    minutos=42;
                    segundos=00;
                    corrigir= false;
                }

                if(horaEscolhida == 2)
                {
                    horas=14;
                    minutos=39;
                    segundos=00;
                    corrigir= false;
                }
                if(horaEscolhida == 3)
                {
                    horas=23;
                    minutos=17;
                    segundos=00;
                    corrigir= false;
                }
                if(horaEscolhida < 1 || horaEscolhida > 3)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA!!! Porfavor digite novamente.");
                    corrigir= true;
                }
            }while(corrigir == true);

            DateTime data = new DateTime(ano, mes, dia, horas, minutos, segundos);
            return data;
        } 
    }
}