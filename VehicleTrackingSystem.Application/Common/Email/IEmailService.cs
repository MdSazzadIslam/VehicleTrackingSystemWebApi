using System.Collections.Generic;


namespace VehicleTrackingSystem.Application.Common.Email
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage);
        List<EmailMessage> ReceiveEmail(int maxCount = 10);
    }
}
