namespace Library
{
    public interface IMessageChannel
    {

        Message createMessage(Contact fromCM, Contact toCM);
         void Send(Message message);
    }
}