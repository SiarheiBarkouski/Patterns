using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicChat = new ChatRoom();

            var max = new Participant("Max");
            var serg = new Participant("Serg");
            var ksux = new Participant("Ksux");
            var ivan = new Participant("Ivan");

            max.JoinChat(publicChat);
            serg.JoinChat(publicChat);
            ksux.JoinChat(publicChat);

            max.SendMessage("Hi all!", publicChat);

            serg.SendPrivateMessage("How are you?", ksux);

            var chat = ivan.CreatePrivateChat(serg, max);

            ivan.SendMessage("Boys only!!!!", chat);


            Console.ReadKey();

        }
    }
}
