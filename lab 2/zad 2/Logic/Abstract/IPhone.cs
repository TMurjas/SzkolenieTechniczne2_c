namespace Phone.Logic.Abstract
{
    public interface IPhone
    {
        string Model { get; set; }
        void Call(int number);
        void Text(int number, string textMessage);
        void TransferFiles(int blueId);
        void ConnectInternet();
        void UseGPS();
    }
}