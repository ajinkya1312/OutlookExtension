using System;
using Redemption;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Outlook_extension
{
    class Program
    {
        public static void InteropAPIDataCollection()
        {
            var outlookApplication = new Outlook.Application();
            var folderTasks = outlookApplication.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar);
            var calendarItem = folderTasks.Items[1] as Outlook.AppointmentItem;
            Console.WriteLine(calendarItem.Subject);
            foreach (Outlook.Recipient recip in calendarItem.Recipients)
            {
                Console.WriteLine(recip.Address);
            }
        }
        public static void RedemptionAPIDataCollection()
        {
            var outlookApplication = new Outlook.Application();
            var folderTasks = outlookApplication.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar);
            Redemption.RDOSession session = new RDOSession();
            session.MAPIOBJECT = outlookApplication.Session.MAPIOBJECT;
            var calendarItem = session.GetDefaultFolder(rdoDefaultFolders.olFolderCalendar).Items[1];
            Console.WriteLine(calendarItem.Subject);
            foreach (Redemption.RDORecipient recip in calendarItem.Recipients)
            {
                Console.WriteLine(recip.SMTPAddress);
            }
        }
        static void Main(string[] args)
        {
            //InteropAPIDataCollection();
            //RedemptionAPIDataCollection();
        }
    }
}
