using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace DiscordBot.Modules
{

    public class AnimeEnum
    {
       public static int Getrand()
        {
            Random random = new Random();

            int Randchislo = random.Next(1, 10);

            return Randchislo;

        }
      

        public void Vibor()
        {
        //TODO: здесь требуется сделать рандомный вывод 
        switch (Randchislo)



        }
    }
}