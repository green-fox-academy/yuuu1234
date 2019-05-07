using System.Collections.Generic;

namespace ImageUploadService.Models
{
    public class Image
    {
        public long ImageId { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public long Size { get; set; }

        public ICollection<Image> ResizedVariants { get; set; }
        public Image RawImage { get; set; }

        public bool IsRaw => RawImage == null;
    }
}
