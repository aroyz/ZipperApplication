using System;
using System.ComponentModel.DataAnnotations;

namespace ZipperApplication.Models
{
    public class Zipper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public int Length { get; set; }
        public int Size { get; set; }
        public string TapeColour { get; set; }
        public string Closure { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
