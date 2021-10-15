using Microsoft.EntityFrameworkCore; //import Microsoft.EntityFrameworkCore
using Microsoft.Extensions.DependencyInjection; //import Microsoft.Extensions.DependencyInjection
using ZipperApplication.Data; //import ZipperApplication.Data
using System; //import System
using System.Linq; //import System.Linq

namespace ZipperApplication.Models //start of ZipperApplication.Models namespace
{
    public class SeedData //start of SeedData class
    {
        public static void Initialize(IServiceProvider serviceProvider) //start of Initialize method which accepts an argument of type IServiceProvider named serviceProvider
        {
            using (var context = new ZipperApplicationContext(serviceProvider.GetRequiredService<DbContextOptions<ZipperApplicationContext>>())) //creates new ZipperApplicationContext object named context
            {
                // Look for any Zippers
                if (context.Zipper.Any()) //do code in brackets if there are already zippers in the database
                {
                    return; // DB has already been seeded so the rest of the seed code does not need to be carried out
                }

                context.Zipper.AddRange( //adds collection of zipper objects to database
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#1 Red Nylon Coil Closed Bottom Zipper 10\"", //sets Name property
                        Type = "Coil",                                        //sets Type property
                        Length = 10,                                          //sets Length property
                        Size = 1,                                             //sets Size property
                        TapeColour = "Red",                                   //sets TapeColour property
                        Closure = "Closed Bottom",                            //sets Closure property
                        Price = 3.99m,                                        //sets Price property
                        Rating = 3                                            //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#2 Black Molded Plastic Separating Zipper 20\"", //sets Name property
                        Type = "Molded Plastic",                                 //sets Type property
                        Length = 20,                                             //sets Length property
                        Size = 2,                                                //sets Size property
                        TapeColour = "Black",                                    //sets TapeColour property
                        Closure = "Separating",                                  //sets Closure property
                        Price = 5.99m,                                           //sets Price property
                        Rating = 4                                               //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#3 Gray Metal Closed Bottom Zipper 30\"", //sets Name property
                        Type = "Metal",                                   //sets Type property
                        Length = 30,                                      //sets Length property
                        Size = 3,                                         //sets Size property
                        TapeColour = "Gray",                              //sets TapeColour property
                        Closure = "Closed Bottom",                        //sets Closure property         
                        Price = 7.99m,                                    //sets Price property
                        Rating = 5                                        //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#4 White Invisible Closed Bottom Zipper 50\"", //sets Name property
                        Type = "Invisible",                                    //sets Type property
                        Length = 50,                                           //sets Length property
                        Size = 4,                                              //sets Size property
                        TapeColour = "White",                                  //sets TapeColour property
                        Closure = "Closed Bottom",                             //sets Closure property
                        Price = 9.99m,                                         //sets Price property
                        Rating = 3                                             //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#5 Blue Molded Plastic Separating Zipper 100\"", //sets Name property
                        Type = "Molded Plastic",                                 //sets Type property
                        Length = 100,                                            //sets Length property
                        Size = 5,                                                //sets Size property
                        TapeColour = "Blue",                                     //sets TapeColour property
                        Closure = "Separating",                                  //sets Closure property
                        Price = 15.99m,                                          //sets Price property
                        Rating = 2                                               //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#6 Orange Nylon Coil Separating Zipper 30\"", //sets Name property
                        Type = "Coil",                                        //sets Type property
                        Length = 30,                                          //sets Length property
                        Size = 6,                                             //sets Size property
                        TapeColour = "Orange",                                //sets TapeColour property
                        Closure = "Separating",                               //sets Closure property
                        Price = 6.99m,                                        //sets Price property
                        Rating = 4                                            //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#7 Green Invisible Closed Bottom Zipper 10\"", //sets Name property
                        Type = "Invisible",                                    //sets Type property
                        Length = 10,                                           //sets Length property
                        Size = 7,                                              //sets Size property
                        TapeColour = "Green",                                  //sets TapeColour property
                        Closure = "Closed Bottom",                             //sets Closure property
                        Price = 4.99m,                                         //sets Price property
                        Rating = 4                                             //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#8 Purple Metal Separating Zipper 50\"", //sets Name property
                        Type = "Metal",                                  //sets Type property
                        Length = 50,                                     //sets Length property
                        Size = 8,                                        //sets Size property
                        TapeColour = "Purple",                           //sets TapeColour property
                        Closure = "Separating",                          //sets Closure property
                        Price = 8.99m,                                   //sets Price property
                        Rating = 5                                       //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#9 Pink Nylon Coil Closed Bottom Zipper 20\"", //sets Name property
                        Type = "Coil",                                         //sets Type property
                        Length = 20,                                           //sets Length property
                        Size = 9,                                              //sets Size property
                        TapeColour = "Pink",                                   //sets TapeColour property
                        Closure = "Closed Bottom",                             //sets Closure property
                        Price = 6.99m,                                         //sets Price property
                        Rating = 3                                             //sets Rating property
                    }, //end of new Zipper object
                    new Zipper //creates new zipper object with the defined properties
                    {
                        Name = "#10 Yellow Invisible Separating Zipper 100\"", //sets Name property
                        Type = "Invisible",                                    //sets Type property
                        Length = 100,                                          //sets Length property
                        Size = 10,                                             //sets Size property
                        TapeColour = "Yellow",                                 //sets TapeColour property
                        Closure = "Separating",                                //sets Closure property
                        Price = 16.99m,                                        //sets Price property
                        Rating = 5                                             //sets Rating property
                    } //end of new Zipper object
                ); //end of AddRange
                context.SaveChanges(); //saves all changed made in this context to the database
            } //end of using statement, context object is disposed of
        } //end of Initialize method
    } //end of SeedData class
} //end of ZipperApplication.Models namespace
