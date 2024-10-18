using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppLibrarySample.Models
{
    public class Book
    {
        [Browsable(false)]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublished { get; set; }

        public string GetBookInfo()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}, Year: {YearPublished}";
        }
    }
}
