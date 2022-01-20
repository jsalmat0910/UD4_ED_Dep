using System;
class ArrayExample
{
    static void Main()
    {
        //Define un array de caracteres llamado letters
        //se reserva memoria para elementos de tipo char
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];
        for (int i = 0; i < letters.Length; i++)
        {
            //Introduce letra a letra realizando un bucle en el cual al dar 10 vuletas
            //desde 0 a 9, intoduce una letra por vuelta en el bucle
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {
        //Escribe en la consola de visual studio un saludo, el nombre en el cual de escribe
        //letra a
        //letra dependiendo del bucle y las vueltas que da, para terminar escribe un sms
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}