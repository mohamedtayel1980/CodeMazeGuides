namespace NotificationExampleWithDelegate
{
    public class NotificationExample
    {
        // Step 1: Define the delegate
        public delegate void NotifyUserDelegate(string message, string recipient);
        // Step 2: Create notification methods
        public void SendEmail(string message, string email)
        {
            Console.WriteLine($"Email sent to {email}: {message}");
        }
        public void SendSMS(string message, string phoneNumber)
        {
            Console.WriteLine($"SMS sent to {phoneNumber}: {message}");
        }
        public void SendPushNotification(string message, string deviceId)
        {
            Console.WriteLine($"Push notification sent to device {deviceId}: {message}");
        }
        // Step 3: Create a method to use the delegate
        public void NotifyUser(NotifyUserDelegate notifyMethod, string message, string recipient)
        {
            notifyMethod(message, recipient); // Invoke the method that was passed as a delegate
        }
       
        public void RunExample()
        {
            NotifyUserDelegate emailNotifier = SendEmail;
            NotifyUserDelegate smsNotifier = SendSMS;
            NotifyUserDelegate pushNotifier = SendPushNotification;
            // Notify via email
            NotifyUser(emailNotifier, "Your order has been shipped!", "user@example.com");
            // Notify via SMS
            NotifyUser(smsNotifier, "Your package is out for delivery.", "+123456789");
            // Notify via push notification
            NotifyUser(pushNotifier, "Your order has been delivered!", "device12345");
        }
    }
}
