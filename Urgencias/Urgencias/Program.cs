using System;

namespace Urgencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Medic m1 = new Medic("Ginecologista", "A16", "Ruben");  //criar um médico m1
            Console.WriteLine("m1:"+ m1);                           //executa o toString do objeto m1
            Medic m2 = new Medic("Cardiologista", "A16", "Sebastiao");//cria um médico m2
            Console.WriteLine(m1.Equals(m2));       //Usa o metodo equals para verificar o "code" de m1 e m2 sao iguais
            Patient p1 = new Patient("123A", "Joao", 19);           //cria um paciente p1
            p1.criarFicha("Red", "Cardiologia");                    //utiliza o metodo para criar uma ficha do p1
            Console.WriteLine(p1);                                  //executa o metodo toString do p1
            PatientList pl1 = new PatientList();                    //cria uma lista de pacientes pl1
            pl1.checkIn(p1);                                        //insere um paciente na lista pl1
           


        }
    }
}
