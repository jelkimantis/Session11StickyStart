 make a model (think about your db table - what is it called? What fields does it have?)
    * create a dbset for it in data.cs

    Model File-Name: Stickynotes.cs
        Columns:        
        public int Id {get;set;}
        public string Notetitle {get;set;} 
        public string Notetext {get;set;}
        public int Order {get;set;}
        [DataType(DataType.Date)]
        public DateTime NoteDate {get; set;}

* do scaffolding.
    * Scaffolding:
    - dotnet aspnet-codegenerator controller -name StickiesController -m Sticky -dc StickyContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

* make the table in the db - 'migrate'
    dotnet ef migrations add InitialCreate
    dotnet ef database update

* run it! make sure you can create stickies!
    - CHECK IS SUCCESSFUL? YAS

* start making it look/work like you actually want it to.
HTML/CSS/Javascript

-automatically set order and post-time
-stickynotes should look like stickynotes, and not db entries