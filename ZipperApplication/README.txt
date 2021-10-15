README for Assignment 1 MVC Core Application

Program name: ZipperApplication
Program purpose: Create an MVC application using ASP.NET Core MVC about zippers
				 Zipper Model: Id         - The unique Id for each zipper object.
				               Name       - The product name for each zipper object.
							   Type       - The type of each zipper object. This will be one of 4 options: Coil, Molded Plastic, Metal, or Invisible.
							   Length     - The length of each zipper object.
							   Size       - The size of each zipper object. This will be traditional zipper sizing which are numbers from 1-10.
							   TapeColour - The colour of the tape surrounding each zipper object.
							   Closure    - The closure type of each zipper object. Will be either Closed Bottom or Separating.
							   Price      - The price of each zipper object. 
							   Rating     - The customer rating of each zipper object. Will be from 1-5 stars.
Program author: Abbey Roy
Date modified: 2021-10-15

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
\\ END @ 10:40AM 2021-10-06 \\

// START @ 1:28PM 2021-10-08 //
1:28PM - Start project over
1:29PM - Modified launchSettings.json to comment out SSL to run on college computers and use port 1234
1:30PM - Added Zipper model
1:33PM - Added NuGet packages
1:34PM - Scaffolding Zipper page
1:37PM - Added link to zipper index page to _Layout.cshtml
1:40PM - ERROR when testing code: Accidentally set the asp-controller attribute of my new link to "Zipper" instead of "Zippers". Fixed.
1:48PM - Whoops got distracted applying to tutor! 
2:31PM - Uploaded to Github
\\ END @ 2:32PM 2021-10-08 \\

// START @ 9:20AM 2021-10-13 //
9:20AM  - Added a section to top of README describing my zipper model
9:31AM  - Editing Create.cshtml to make the inputs fit with the data
	      - Made the Rating field a slider. Fiddled with CSS to make 1 and 5 appear on either side of the slider. Don't like the space on either side. Got rid of default padding to fix.
		  - Made the Type field a select list.
		  - Made the Size field a select list.
		  - Made the Closure field a select list.
10:40AM - Created SeedData Class.
10:45AM - Uploaded to Onedrive because I forgot how to upload to github with visual studio and didn't have time to figure it out.
\\ END @ 10:45AM 2021-10-13 \\

// START @ 8:34PM 2021-10-13 //
8:34PM  - Started working on SeedData Class
9:06PM  - ERROR in SeedData using statement: "cannot convert from 'method group' DbContextOptions<ZipperApplicationContext>". was missing a set of round brackets. fixed.
9:44PM  - Tested SeedData. It works :)
9:59PM  - Add search by name
\\ END @ 10:33PM 2021-10-13 \\

// START @ 5:13PM 2021-10-14 //
5:13PM  - Add search by type
5:47PM  - ERROR when testing search: 
		  InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'System.Collections.Generic.List`1[ZipperApplication.Models.Zipper]', but this ViewDataDictionary instance requires a model item of type 'ZipperApplication.Models.ZipperTypeViewModel'.
		  FIXED: looked through code with a fine tooth comb and realized I forgot to add the part of the ZippersController.cs file that creates a new ZipperTypeViewModel object so I added it and it worked
7:37PM  - Add validation rules
8:19PM  - Modified launchSettings.json to reinstate SSL
8:21PM  - Added AboutController for About Page
8:25PM  - Added About View folder with Index.cshtml for About Page
8:29PM  - Started to modify About Page's Index.cshtml
8:54PM  - Image for Headquarters section from https://pixabay.com/photos/buildings-glass-windows-reflection-984195/
9:32PM  - Oh! Andrew gave me an extension! I guess that means I'm going to go way overboard to take advantage of this extra time!
9:44PM  - Modifying Zippers Index.cshtml
12:11AM - Zipper image from https://pixabay.com/vectors/zip-zipper-metal-clothing-material-1296968/
12:38AM - Modifying Home Index.cshtml
12:41AM - Crown image from https://pixabay.com/vectors/crown-golden-royal-shining-shiny-312734/
1:30AM  - Ask Andrew tomorrow: 
		  - Can product image be the same for all products?
		  - What should I do with the Privacy Policy page?
1:37AM  - Almost done. Just want to ask Andrew my questions and finish commenting and then I can hand in.
\\ END @ 1:39AM 2021-10-15 \\

// START @ 4:17PM 2021-10-15 //
4:17PM  - Fiddling more with styles
4:32PM  - Modified product name and image to be a clickable link to the details page
4:48PM  - Commented the stuff I haven't yet
6:01PM  - Finished commenting, started going over assignment rubric and description to make sure I didn't miss anything
6:06PM  - Publish to Azure
6:42PM  - Trying to figure out github!
6:59PM  - Figured out github! Pushed to github.
7:25PM  - Made slight change to text on About Page.
7:29PM  - Trying to figure out how to fix version published to Azure
7:37PM  - Pushed final version to Azure
7:38PM  - Review Rubric one final time!
7:47PM  - Pushed final version to Github!
\\ END @ 7:47PM 2021-10-15 \\


