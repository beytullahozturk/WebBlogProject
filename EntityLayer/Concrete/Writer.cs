using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterEmail { get; set; }
        //[DataType(DataType.Password)]
        public string WriterPassword { get; set; }
        //[DataType(DataType.Password)]
        //[Compare("WriterPassword", ErrorMessage = "Parolalar eşleşmiyor. Lütfen tekrar deneyin!")]
        //public string ConfirmPassword { get; set; }
        public bool WriterStatus { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}
