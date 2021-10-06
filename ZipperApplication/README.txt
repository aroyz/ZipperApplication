README for Assignment 1 MVC Core Application

Program name: ZipperApplication
Program purpose: Create an MVC application using ASP.NET Core MVC about zippers
Program author: Abbey Roy
Date modified:

// START @ 9:15AM 2021-10-06 //
9:15AM - Created ZipperApplication project
9:16AM - Created README
9:18AM - Modified launchSettings.json to comment out SSL to run on college computers and use port 1234
9:19AM - Started researching zippers to figure out what products I will be putting on my site
9:33AM - Added Zipper model
9:38AM - Added NuGet packages
9:40AM - ERROR when running application: Forgot to add line "using System.ComponentModel.DataAnnotations;" in Zipper.cs file, fixed
9:42AM - Scaffolding Zipper page
9:48AM - ERROR when running initial migration command: More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands. Fixed by adding "-Context ZipperApplicationContext" to end of command.
9:55AM - ERROR when testing code: Clicking ZipperApplication link just links back to home page. Fixed by modifying _Layout.cshtml file so that ZipperApplication's asp-controller attribute is 'Zippers' instead of 'Home'
9:58AM - Asked Andrew about data for my project (sorry for my confusing question!)
10:04AM - Updated my Zipper.cs item to add more attributes
10:08AM - Research how to update my database with new model
10:38AM - Have to restart because I messed up my model
10:39AM - Pushed everything to github