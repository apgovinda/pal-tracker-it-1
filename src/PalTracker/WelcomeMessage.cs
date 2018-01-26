
namespace PalTracker
{
    public class WelcomeMessage
    {
        private string _message = "WELCOME_MESSAGE not configured." ;

        public WelcomeMessage(string message)
        {
            _message = message;
        }
        public string GetMessage() => _message;
    }
}
