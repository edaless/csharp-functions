
//In questo esercizio vi chiedo di definire qualche funzione di utilità
//che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:



using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice,
            int[] arrInput = { 2, 6, 7, 5, 3, 9 };

            
            var anInstanceofMyClass = new Program();


            //si vogliono utilizzare le funzioni per:


            //Stampare l’array di numeri fornito a video
            Console.WriteLine($"Array d'Input:");
            anInstanceofMyClass.StampaArray(arrInput);
            Console.WriteLine("\r\n");



            //Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
            Console.WriteLine($"Array d'Input al quadrato:");
            anInstanceofMyClass.StampaArray
                (
                anInstanceofMyClass.ElevaArrayAlQuadrato
                    (
                    arrInput
                    )
                );
            Console.WriteLine("\r\n");

            //(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale
            //e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
            Console.WriteLine($"Array d'Input di nuovo:");
            anInstanceofMyClass.StampaArray(arrInput);
            Console.WriteLine("\r\n");



            //Stampare la somma di tutti i numeri
            Console.WriteLine($"somma degli elementi dell'Array d'Input:");
            Console.WriteLine(
            anInstanceofMyClass.sommaElementiArray(arrInput)
            );
            Console.WriteLine("\r\n");


            //Stampare la somma di tutti i numeri elevati al quadrati
            Console.WriteLine($"somma degli elementi dell'Array al quadrato:");
            Console.WriteLine
            (
                anInstanceofMyClass.sommaElementiArray
                (
                    anInstanceofMyClass.ElevaArrayAlQuadrato
                        (
                            arrInput
                        )
                )
            );
            Console.WriteLine("\r\n");



            //BONUS: Convertire le funzioni appena dichiarate in funzioni generiche,
            //ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
            //ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
            //A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire,
            //e dopo di che questi vengono inseriti a mano dall’utente esternamente.
            //Rieseguire il programma con l’input preso esternamente dall’utente.

        }



        //void StampaArray(int[] array): che preso un array di numeri interi,
        //stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
        void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            { 
            Console.WriteLine($"Elemento {i + 1}:   {array[i]}");
            }

        }

        //int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
        int Quadrato(int numero)
        {
            return numero * numero;
        }


        //int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi,
        //restituisca un nuovo array con tutti gli elementi elevati quadrato.
        //Attenzione: è importante restituire un nuovo array,
        //e non modificare l’array come parametro della funzione!
        //Vi ricordate perchè? Pensateci (vedi slide)



        int[] ElevaArrayAlQuadrato(int[] array)
        {
            //creo array ESITO lungo uguale all'array di input 
            int[] esito = new int[array.Length];
            for (int i = 0;i < array.Length; i++)
            {
                esito[i] = Quadrato(array[i]);
            }

            return esito;
        }

        //int sommaElementiArray(int[] array): che preso un array di numeri interi,
        //restituisca la somma totale di tutti gli elementi dell’array.
        int sommaElementiArray(int[] array)
        {
            int somma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                somma = somma + array[i];
            }

            return somma;
        }



    }
}


