using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikDestekDepartman
{
    public class Kayit
    {
        public static void Creat()
        {
            Users user = new Users();
            user.ID = 1;
            user.UserName = "Ahmet";
            user.Password = "12345";

            using (var db = new TeknikDepartmanEntities())
            {
                db.Users.Add(user);
                if (db.SaveChanges()==0)
                Console.WriteLine("Ekleme Başarılı");
            }
        }
        public static void Creat2()
        {
            Users user = new Users();
            user.ID = 2;
            user.UserName = "Mehmet";
            user.Password = "123456";

            using (var db = new TeknikDepartmanEntities())
            {
                db.Users.Add(user);
                if (db.SaveChanges() > 0)
                    Console.WriteLine("Ekleme Başarılı");
            }

        }
        public static void TicketCreat()
        {
            Ticket ticket = new Ticket();
            ticket.TicketID = 1;
            ticket.Subjet = "Hata";
            ticket.Description = "Kendiliğinden kapanıyor";
        }
    }
}
