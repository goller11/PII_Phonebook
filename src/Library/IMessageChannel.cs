namespace Library
{
    public interface IMessageChannel
    {

        Message createMessage(Contact from, Contact to);
         void Send(Message message);
    }
}