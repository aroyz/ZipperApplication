using Microsoft.AspNetCore.Mvc.Rendering; //imports Microsoft.AspNetCore.Mvc.Rendering
using System.Collections.Generic; // imports System.Collections.Generic

namespace ZipperApplication.Models //start of ZipperApplication.Models namespace
{
    public class ZipperTypeViewModel //start of ZipperTypeViewModel class
    {
        public List<Zipper> Zippers { get; set; } //contains a list of movie
        public SelectList Types { get; set; } //contains a SelectList of the types of zippers
        public string ZipperType { get; set; } //contains the selected type
        public string SearchString { get; set; } //constains the user's search query
    } //end of ZipperTypeViewModel class
} //end of ZipperApplication.Models namespace
