using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula
{
    public class CAlC
    {
        public double _somando;
        public double Somando { get; set; }

        private double _P1;
        public double p1 { get; set; }
        private double _P2;
        public double p2 {get;set;}
           private double _sub;
        public double SUB { get; set; }
           private double  _mult;
        public double Mult { get; set; }
           private double _div;
        public double DIV { get; set; }
        private double _porc;
        public double PORC { get; set; }
           private double  _raiz;
        public double Raiz { get; set; }
        public void Somar()
        {

            Somando = p1 + p2;
            Console.WriteLine($"O resultado de {p1} + {p2} é : {Somando}");


        }
        public void Subtrair()
        {

            SUB = p1 - p2;
            Console.WriteLine($" O resultado de {p1} - {p2} é : {SUB}");

        }
        public void Multiplicar()
        {

            Mult = p1 * p2;
            Console.WriteLine($" O resultado de {p1} * {p2} é : {Mult}");

        }
        public void Dividir()
        {


            DIV = p1 / p2;
            Console.WriteLine($" O resultado de {p1} / {p2} é : {DIV}");

        }
        public void Porcentagem()
        {
            Console.WriteLine("porcentagem de 1 numero ou de 2 numeros?");
            bool menu2 = true;
            while (menu2)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Digite o Numero");
                        try
                        {
                             p1 = double.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            
                            throw new ArgumentException("Valor digitado é considerado invalido");
                        }
                       
                        PORC = p1 / 100;

                        Console.WriteLine($"A porcentagem de {p1} é {PORC}" + "%");
                        break;
                    case "2":
                        Console.WriteLine("Digite o Primeiro Numero");
                        try
                        {
                             p1 = double.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            
                            throw new ArgumentException(" Valor invalido, digite algum valor");
                        }
                       
                        PORC = p1 / 100;
                        Console.Clear();
                        Console.WriteLine("Digite o segundo Numero");
                              try
            {
                  p2 = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                
                throw new ArgumentException("Valor  digitado Invalido, você deixou espaço em branco  ");
            }
            
                       
                        PORC = (p1 / 100) * p2;
                        Console.WriteLine($"A porcentagem de {p1} e {p2} é {PORC}" + "%");
                        break;
                    default:
                        menu2 = false;
                        break;

                }
            }


        }
        public void Raiz_Quadrada()
        {
            Console.WriteLine("Digite o valor ");
            try
            {
                 p1 = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                
                throw new ArgumentException("Valor  digitado Invalido, você deixou espaço em branco  ");
            }
            
            Raiz = Convert.ToSingle(Math.Sqrt(p1));
            Console.WriteLine(Raiz);

        }

    }
}

