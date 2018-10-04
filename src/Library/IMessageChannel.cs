namespace Library
{
    public interface IMessageChannel
    {

        Message createMessage(Contact fromCM, Contact toCM, string text);
         void Send(Message message);
    }
}