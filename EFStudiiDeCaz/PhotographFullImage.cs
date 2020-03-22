using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudiiDeCaz
{
    public class PhotographFullImage
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int PhotoId { get; set; }
        public byte[] HighResolutionBits { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("PhotoId")]
        public virtual Photograph Photograph { get; set; }
    }
}
