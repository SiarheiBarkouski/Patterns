using System.Collections.Generic;
using ChatMediator;

namespace ChatMediator
{
    public class ChatRoom
    {
        private  readonly ISet<Participant> _participants = new HashSet<Participant>();

        public void SignIn(Participant participant)
        {
            _participants.Add(participant);
        }

        public void SignOut(Participant participant)
        {
            _participants.Remove(participant);
        }

        public void Send(string message, string from)
        {
            foreach (var participant in _participants)
            {
                participant.RecieveMessage(message, from);
            }
        }
    }
}
