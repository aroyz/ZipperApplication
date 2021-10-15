using System.ComponentModel.DataAnnotations; //import System.ComponentModel.DataAnnotations
using System.ComponentModel.DataAnnotations.Schema; //import System.ComponentModel.DataAnnotations.Schema

namespace ZipperApplication.Models //start of ZipperApplication.Models namespace
{
    public class Zipper //start of Zipper class
    {
        public int Id { get; set; } //public integer property of Zipper class named Id to hold the Id of the Zipper object

        [Required] //makes property required
        [RegularExpression(@"[a-zA-Z0-9#\s""]{3,}")] //regular expression to check that name is at least 3 characters and contains only letters, numbers, white space, # and "
        public string Name { get; set; } //public string property of Zipper class named Name to hold the Name of the Zipper object

        //Type doesn't need validation because it's input with a selection list
        [Required] //makes property required
        public string Type { get; set; } //public string property of Zipper class named Type to hold the Type of the Zipper object

        [Required] //makes property required
        [Display(Name = "Length (inches)")] //sets display name to be "Length (inches)" instead of just "Length"
        [Range(10, 100)] //sets the range to be between 10 and 100 so that there are no zippers shorter than 10 inches or longer than 100 inches
        public int Length { get; set; } //public integer property of Zipper class named Length to hold the Length of the Zipper object

        //Size doesn't need validation because it's input with a selection list
        [Required] //makes property required
        public int Size { get; set; } //public integer property of Zipper class named Size to hold the Size of the Zipper object

        [Required] //makes property required
        [Display(Name = "Tape Colour")] //sets display name to be "Tape Colour" instead of "TapeColour"
        [RegularExpression(@"[a-zA-Z0-9\s]{3,}")] //regular expression to check that name is at least 3 characters and contains only letters, numbers, white space
        public string TapeColour { get; set; } //public string property of Zipper class named TapeColour to hold the Tape Colour of the Zipper object

        //Closure doesn't need validation because it's input with a selection list
        [Required] //makes property required
        public string Closure { get; set; } //public string property of Zipper class named Closure to hold the Closure Type of the Zipper object

        [Required] //makes property required
        [DataType(DataType.Currency)] //sets the DataType to Currency
        [Column(TypeName = "decimal(18, 2")] //tells the Entity Framework Core to map Price to currency in the database
        public decimal Price { get; set; } //public decimal property of Zipper class named Price to hold the Price of the Zipper object

        //Rating doesn't need validation because it's input with a range slider
        [Required] //makes property required
        public int Rating { get; set; } //public integer property of Zipper class named Rating to hold the Rating of the Zipper object
    } //end of Zipper class
} //end of ZipperApplication.Models namespace
