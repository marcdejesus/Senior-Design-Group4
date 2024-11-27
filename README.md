So, you want to get the files from the GutHub to do development on them? Here's how you do that!

First, you'll want your own local project where you can conduct your work. Visual Studio projects are very large, so we can't upload the entire project folder to GitHub.

You'll need to create a new .NET Maui App, name it 'WellnessApp' and select a directory to place it in, don't place it in the GitHub Repository Folder.

Select '.NET 8.0 (Long Term Support)' for the framework.

Once you've opened the project, press CTRL+ALT+L to show the solution explorer. Under 'WellnessApp', right click on 'Dependencies' and click 'Manage NuGet Packages'.

You will need to install two packages for this project, you may have to click the 'Install' button a few times until they show that they are installed.

Without further ado, the packages are:

sqlite-net-pcl by praeclarum

SQLitePCLRaw.bundle_green by ericsink

xunit (ver 2.5.3 )by xunit

xunit.runner.visualstudio (ver 2.5.3) by xunit

moq by moq (make sure this one is loaded into the unit testing project as well)

Syncfusion.Maui.Calendar by Syncfusion.inc

Now that you have installed the necessary packages, straight up delete all of the .cs and .xaml files from the solution explorer, don't worry, we'll be replacing them shortly!

Next, copy in the .cs files from the 'Visual Studio Source Code' folder in the GitHub repository (only the .cs files, not the .xaml.cs files, mind you).

Then you may copy in the .xaml files from the repository folder as well, this should create the .xaml.cs files underneath them of the same name, and the contents of these files should not be empty either.

For xUnit testing, you will need to right click on the WellnessApp solution (just above where it says WellnessApp) and select 'Add'.

You will add a new xUnit test project named WellnessAppTest in the same directory that you created your project in.

Once that has been created, you can go into the Unit Tests folder in the repository and add the ones you want to the xUnit test project or create new ones!

NEW INSTRUCTIONS

There were a number of configurations needed to make the WellnessApp project compatible with the WellnessAppTest project, and they are too specific and complex to go over here.

Instead, just copy from the Projects folder the .txt file of the project you are working on (either WellnessApp or WellnessAppTest) and copy that code into the .csproj files for those projects (you can access those by clicking on the project name in the solution explorer)

Once you have all of the files copied over, you may see some red squiggly lines over some elements in the code, maybe underneath an 'InitializeComponent()' method call? Perchance.

This should be perfectly alright. Try running the code anyways, the compiler should realize that it was freaking out for no good reason after all and the program will run! Maybe.

If it runs, congrats!

If it does not, we'll figure it out!

If it runs but doesn't work as intended, at least it ran, and we'll figure that out too!

Owen Hook, Crunch Time Studios
