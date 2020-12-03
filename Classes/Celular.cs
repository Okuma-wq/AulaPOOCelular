using System;

namespace AulaPOOCelular.Classes
{
    public class Celular
    {

        public string cor;

        public string modelo;

        public double tamanho;

        public bool ligado;

        public string onOff;

        public string escolha;

        public  string resposta = "S";

        public bool lOuD(){
            Console.WriteLine("O celular está ligado? (S/N)");
            onOff = Console.ReadLine().ToUpper();

            if (onOff == "S"){
                ligado = true;
            } if (onOff == "N"){
                ligado = false;
            }

            return ligado;
        }

        public void acoes(){
            do{
                if (ligado == true){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O que deseja fazer?");
                Console.ResetColor();
                Console.WriteLine("[1] - Fazer ligação");
                Console.WriteLine("[2] - Enviar mensagem");
                Console.WriteLine("[0] - Desligar o celular");
                escolha = Console.ReadLine();

                    switch (escolha){
                        case "1":
                            Console.Write("Digite o número da pessoa para quem deseja ligar: ");
                            Console.ReadLine();
                            Console.WriteLine(". . . . . Não foi possivel completar a chamada, por favor tente novamente mais tarde");
                            break;
                        case "2":
                            Console.WriteLine("Digite o nome da pessoa para quem deseja mandar a mensagem: ");
                            Console.ReadLine();
                            Console.WriteLine("Digite a mensagem que deseja enviar:");
                            Console.ReadLine();
                            Console.WriteLine("Mensagem enviada");
                            break;
                        case "0":
                            ligado = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                }
                   
                if (ligado == false){
                Console.WriteLine("Deseja ligar o celular? (S/N)");
                resposta = Console.ReadLine().ToUpper();

                    if(resposta == "S"){
                        ligado = true;
                    }else{
                        Console.WriteLine("Muito bem, encerrando serviços");
                    }
                }
            }while(resposta == "S" && ligado == true);
            

        }
        
    }
}