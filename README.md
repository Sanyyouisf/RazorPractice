# RazorPracticeRazor Exercise

Set Up

Scaffold your application in Visual Studio:

File > New > Project (ctrl + shift + n)
Select Templates > Visual C# > Web > ASP.NET Web Application (.NET Framework)
Name it RazorPractice
Choose the MVC option and click Ok (initializing an empty git repo is a handy option here, too) In the Index.cshtml in your Views/Home/ folder (correlates to the Home Controller):
Make a list of names (List) in Razor code
Loop through the names in an unordered list on your page using Razor
Use a multi-line razor statement to make two variables (string UserName and string Greeting) and set the values to whatever you want.
Use your username and greeting variables in your html to say hello to your user
Use an if statement to print "TGIF" on the page if it's Friday
Create a C# model in your Models folder for an object (think Song, Person, Order, Car, etc.)
Make a form to create an instance of your model (a song, a person, an order, a car, etc.) using the Razor @Html form, input, and other extensions (not standard HTML)
In the controller, make an action that accepts the POST request from the form you create and use the debugger to verify your form is submitting correctly. FormExtensions, InputExtensions, and others!
