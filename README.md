About
Laundromat 

The Laundromat tool is a C# application that allows users to retrieve data from the database of laundromat stores. Be it customer name, age, which machine they are using and how often they are using and which store they are visiting etc. The goal was to provide trackable information of their visit in reference to the store vs equipment vs equipment in use. By running the program, the user is given options from the database to select from. Once the user selects and enters the answer, the program then prompts with thus provided information: the user first and last name, how many equipment are being in use and the type of equipment in use. This is possible due to the code that has been implemented however, if needed one can also request the relation of the store being visited and other properties listed.  


This app was developed for the software development track of the boot camp Code Louisville in which I am enrolled in for the 2023 fall course.


Instructions


      1. Clone Repository: Using the green 'Code' button above clone the repo to your local machine
      
      2. Clone Repository by: Open TERMINAL
      
      3. Change the current working directory to the location where you want the cloned directory
      
      4. Type git clone, and then paste the URL you copied earlier (Which will look something like... git@github.com:agshab/Laundromat.git)"
            For Example: git clone git@github.com:agshab/Laundromat.git
            
      5. Go to the Repository on computer and open the file Laundromat.sln in Visual Studio (or your preferred IDE)
      
      6. Switch to Branch4 on the local 

      7. NET SDK: Ensure that you have the .NET SDK installed to build. 
            Back on the TERMINAL or use cmd or git bash to run "dotnet ef migrations add Initial" command, once thats is sucessful
            Then run "dotnet ef database update" command in the subfolder dir. This will create the "Laundromat.db" on your desktop.                Run dotnet ef database update from within the Laundromat project to create the database structure
      
      8. Seed the database onto your machine (Make sure to uncomment out //seedthedatabase before you store it onto your machine)  

      
      


3 Key Required Features Used 


     Creates a List ✅
        
         Populate it with several values, 
          
         Use it to retrieve data from the database in the program  
      
     Make application asynchronous ✅
     
         SeedTheDataBase made it Async 
         
         All the ToList, made it async  

     Add comments to code ✅           
          
         While Loop Method (In Program)
            
         List Method (In Program) 

         Async Method (In Program) 
         
         

Requirements & Features 

      GitHub Repository and Commits: ✅
   
          Upload your project to GitHub repository with a minimum of 5 distinct commits.
          
          Uploading via Git commands demonstrates regular usage rather than a single final upload.
       
      README File: ✅
   
          Include a README file explaining your project.
          
          Describe your project in a paragraph or more.
          
          Identify 3+ features from the provided list that you've integrated.
          
          Add any special instructions for the reviewer to run your project.
       
      Visual Appeal: ✅
   
          Design your project to be visually appealing; follow industry trends.
          
          Aim to create projects that employers find attractive and engaging.
          
          Explore other websites for inspiration. Emulate styles and functionalities you find compelling.
          
          Select a color palette and font stack to enhance design consistency.
          
      Database Interaction: ✅
   
          Develop at least one class (excluding the default class in a new project),
          
          create an object of that class, populate it with data from a database, and incorporate the data in
          
          your application. A minimum of 1 table (entity) should be utilized. Note that classes should be
          
          created even when using object relational mappers like Entity Framework.
       
      Functions/Methods: ✅
   
          Create and utilize a minimum of 3 functions or methods, with at least one
          
          returning a value integral to your application.
          
      3 Required Features: ✅
          
          Make your application asynchronous...
          
          Add comments to your code explaining how you are using at least 2 of the solid principles
          
          Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program
          

Technologies/Languages/Libraries 

       C#
       
       .NET
       
       Entity Framework
       
       SQLLite
       
