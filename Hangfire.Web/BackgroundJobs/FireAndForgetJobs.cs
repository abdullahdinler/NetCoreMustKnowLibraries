using Hangfire.Web.Services;

namespace Hangfire.Web.BackgroundJobs
{
    public class FireAndForgetJobs
    {
        public static void SendEmail(string userId, string message)
        {
            Hangfire.BackgroundJob.Enqueue<IEmailSender>(x => x.SendEmailAsync(userId, message));
        }
    }
}
