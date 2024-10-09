using CodeFirstRelation.Context;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstRelation.Context
{

   

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; } // Gönderinin yazarı
        public User User { get; set; } // İlişkili kullanıcı
    }
}
