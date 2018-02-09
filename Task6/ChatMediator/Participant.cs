using System;
using System.Collections.Generic;

namespace ChatMediator
{
    public class Participant
    {
        public string Name { get; }

        public Participant(string name)
        {
            Name = name;
        }

        public void JoinChat(ChatRoom chatRoom)
        {
            chatRoom.SignIn(this);
        }

        public void LeaveChat(ChatRoom chatRoom)
        {
            chatRoom.SignOut(this);
        }


        public virtual void RecieveMessage(string message, string from)
        {
            if (Name != from)
            {
                Console.WriteLine("{0} recieved a message from {1}: {2}", Name, from, message);
            }
        }

        public void SendMessage(string message, ChatRoom chatRoom)
        {
            if (chatRoom != null)
            {
                Console.WriteLine("Sent from {0}: {1}", Name, message);
                chatRoom.Send(message, Name);
            }
        }

        public void SendPrivateMessage(string message, Participant participant)
        {
            Console.WriteLine("{0} sent private message to {1} : {2}", Name, participant.Name, message);
            participant.RecieveMessage(message, Name);
        }

        public ChatRoom CreatePrivateChat(params Participant[] participants)
        {
            var chat = new ChatRoom();
            JoinChat(chat);
            foreach (var human in participants)
            {
                human.JoinChat(chat);
            }
            return chat;
        }
    }
}
