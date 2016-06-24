namespace WebApi.Models
{
    using System;

    public class Image: Entity
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public byte[] Data { get; set; }

        public DateTime UploadDate { get; set; }
    }
}