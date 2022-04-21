using System;
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
        static void Main(string[] args)
        {
            InteropAPIDataCollection();
        }
    }
}
