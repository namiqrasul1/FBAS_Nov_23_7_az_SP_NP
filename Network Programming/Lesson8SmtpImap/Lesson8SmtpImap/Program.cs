using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using System.Net;
using System.Net.Mail;

// 

#region SMTP Gmail

//using var client = new SmtpClient("smtp.google.com", 587);
//client.DeliveryMethod = SmtpDeliveryMethod.Network;
//client.EnableSsl = true;

//client.UseDefaultCredentials = false;

//client.Credentials = new NetworkCredential(userName: "ferhat00g1276@gmail.com",
//                                            password: "onma folf rhxo zdsh");

//var message = new MailMessage
//{
//    Body = "Salam, Murad",
//    Subject = "Murada mail",
//    From = new MailAddress("ferhat00g1276@gmail.com", "Turboboy"),
//    IsBodyHtml = false
//};

//message.To.Add("muradbabayev5600@gmail.com");
//message.CC.Add("namiq_rasullu@itstep.org");

//client.Send(message);

#endregion


#region SMTP Mail

//using var client = new SmtpClient("smtp.mail.ru", 587);
//client.DeliveryMethod = SmtpDeliveryMethod.Network;
//client.EnableSsl = true;

//client.UseDefaultCredentials = false;

//client.Credentials = new NetworkCredential(userName: "namigrasul@mail.ru",
//                                            password: "K2UK38Qzhcww5AgkPevj");

//var message = new MailMessage
//{
//    Body = "<h1 style='color: red'>Salam, Murad</h1>",
//    Subject = "Murada mail",
//    From = new MailAddress("namigrasul@mail.ru", "Turboboy"),
//    IsBodyHtml = true
//};

//message.To.Add("muradbabayev5600@gmail.com");
//message.CC.Add("namiq_rasullu@itstep.org");

//client.Send(message);

#endregion

#region IMAP

//using var imap = new ImapClient();

//imap.Connect("imap.gmail.com", 993);
//imap.Authenticate(userName: "ferhat00g1276@gmail.com", password: "onma folf rhxo zdsh");

//var folder = imap.GetFolder("Sent");
//var folder = imap.GetFolder(SpecialFolder.Sent);
//var folder = imap.Inbox;

//folder.Open(FolderAccess.ReadOnly);

//var ids = folder.Search(SearchQuery.All);

//foreach (var id in ids)
//{
//    Console.WriteLine($"{id}: {folder.GetMessage(id).Subject}");
//}

//folder.Open(FolderAccess.ReadWrite);

//var id = new UniqueId(374);

//folder.SetFlags(id, MessageFlags.Deleted, true);
//folder.Expunge();


#endregion

class A
{
    public override int GetHashCode()
    {
        return 545443;
    }
}

#region Question

//var str = "abc" + "cba";                          // "abccba
//var str1 = string.Format("{0}{1}", "abc", "cba"); // "abccba"

//Console.WriteLine(str == str1);
//Console.WriteLine(((object)str) == ((object)str1));




#endregion