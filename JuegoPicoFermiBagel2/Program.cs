using System;

namespace JuegoPicoFermiBagel2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero;
            int[] cifras = new int[3] { 5, 1, 2};
            int[] cifras2 = new int[3]; 
            bool bandera = false;
            Console.WriteLine("Pico, Fermi, Bagels es un clásico juego de lógica, en el que la computadora piensa un número de 3 dígitos," +
                " y el jugador trata de adivinar el número secreto. Después de cada intento la computadora te da pistas." +
                "  \n1) Si la computadora dice BAGELS significa que ninguno de los dígitos es el numero secreto." +
                " \n2) Si la computadora dice PICO, significa que uno de los dígitos que pensaste está correcto, pero en la posición" +
                " equivocada. \n3) Si la computadora dice FERMI, entonces uno de los dígitos es correcto y está en la posición correcta"
                );

            Console.WriteLine("");
            int cont2 = 0;

            while (cont2 < 10) //cantidad de intentos
            {
                string[] cifra3 = new string[3] { " ", " ", " " };
                int x = 0;
                int y = 2;
                Console.WriteLine("Ingrese numero entero de 3 digitos del 1 al 9, los digitos no deben ser repetidos");
                numero = Int32.Parse(Console.ReadLine());
              
                //desgloso el numero que ingresa por teclado en tres digitos y lo guardo en un arreglo
                while (numero > 0)
                {
                    cifras2[y - x] = numero % 10;
                    numero = numero / 10;
                    x++;
                }
                
                for (int j = 0; j< 3; j++)
                { //recorro array cifras

                    for (int h = 0; h < 3 ;h++)
                    { //recorro array cifras2

                        if (cifras[j] == cifras2[h] && j == h)//Fermi
                        {
                            if (cifra3[h] == " " || cifra3[h] == "P")
                            cifra3[h] = "F";
                           

                        }
 
                       if (cifras[j] == cifras2[h] && j !=h )//Pico
                        {

                            if (cifra3[h] == " " || cifra3[h] == "P")
                                cifra3[h] = "P";
                      
                          
                        }

                        if (cifras[j] != cifras2[h])//Bagels
                        {

                            if (cifra3[h] == " ")
                                cifra3[h] = " ";
                           

                        }
                    }

                }

                if (cifra3[0]== "F" && cifra3[1] == "F" && cifra3[2] == "F")
                {
                    Console.WriteLine("FFF GANASTE ");
                    bandera = true;
                    break;
                }
                else
                {
                    if (cifra3[0] == " " && cifra3[1] == " " && cifra3[2] == " ")
                    {
                        Console.WriteLine("    BAGELS");
                      
                    }
                    else {
                        for (int z = 0; z < 3; z++)
                        {
                            Console.Write(cifra3[z]);
                        }
                        Console.WriteLine("");
                    }
                   
                }
                cont2++;
            }

            if (cont2 == 10 && bandera == false) {
                Console.WriteLine("Usaste todas las oportunidades PERDISTE");
            }
            
        }

    }
}
