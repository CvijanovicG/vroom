# vroom
### Kreiranje domenskih klasa Make i Model (koja će migracijom postati tabela u bazi podataka)
### Kreiranje konekcije sa bazom podataka
### Kreiranje DbSet
### Kreiranje servisa u Startup.cs
### Apllay constraints (primijena ograničenja), update-database 0, remove-migration, refresh database and see apllay constraints
###     https://www.youtube.com/watch?v=pT6_Q4V9Bw0&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=11
### Branch_1: Create empty Make Controller, add view, using Model, run aplivation and rooting from browser controller/view
###     https://www.youtube.com/watch?v=6eF3f9DKo6Y&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=12
### Branch_2: Convention-based routing, Attribute-based routing
###     https://www.youtube.com/watch?v=HqdN60ylrEU&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=13
###     Bootstrap migration and Implement CRUD in MVC Core Part-1
###     https://www.youtube.com/watch?v=ZmwQGl1vg0c&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=14
###     Download bootstrap version 4.2.1 and replase content in curent css and js directory with content from downloaded directory
###     Copy navbar from bootstrap, coment old navbar from layout an paste on layout new navbar
###     change navbar class propertis, remowe all the content from home/index view
###     Add Action and View to display list of makes, create Index method, create index view
### Branch_3: Implement CRUD in MVC Core Part 2
###     https://www.youtube.com/watch?v=aMnqJN9Fu78&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=15
###     Create Make/Create method (get and post), create Make/Create view
### Branch_4: Implement CRUD in MVC Core Part 3
###     https://www.youtube.com/watch?v=4ETiJ3kb0xs&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=16
###     Custom Make/Index view group button for edit and delete, create make/Delete method, JavaScript popup box for confirm delete action
### Branch_5: Implement CRUD in MVC Core Part 4
###     https://www.youtube.com/watch?v=llDWIbFg6LY&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=17
###     Adding Edit method and view to Edit Makes, copy Delete method for Edit get and Create post for Edit post and change this
###     create Make/Edit view. View is very similar with Make/Crete view. Copy and paste. Change title,action method and header to Edit
### Branch_6: Models - CRUD for Models of Vehicle - Part 1
###     https://www.youtube.com/watch?v=IwOHL5Sa64A&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=18
###     Eager loading is the process whereby a query for one type of entity also loads related entities as part of the query, 
###     so that we don't need to execute a separate query for related entities. Eager loading is achieved using the Include() method.
###     Create Model/Index method and Model/index view. Copy Make/Index view and paste in Model/Index view. Change text-info an btn-info from Make to Model
###     Add table header and table data kolumn in table.
###     Create Model/Create method get, create Model/Create view, copy Make/Create view and paste. Create Model/Create post action method
###     Implement CRUD for Models of Vehicle -Part 2 and Refactor existing code
###     https://www.youtube.com/watch?v=8X-FeZ7riEo&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=19
###     Create Model/Edit action method and Model/Edit view.  Refactoring - Shered folder _PartialView  to clean code
### Branch_7: Extension Methods in C#
###     https://www.youtube.com/watch?v=Mzoi-gEqRhs&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=21
###     Add extension folder in solution, add class and modify
### Branch_8: Authentication and Authorisation Part 1
###     https://www.youtube.com/watch?v=9ezfoTDIDdo&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=21
###     Authentication - Login and password, Authorisation - what you can do.
###     Authentication - access to the main gate, Authorisation - access to different cabins in organization
###     Identity all class (user,roles,userroles,...), add line in startup.cs, add-migration, update-database and refresh database and see new identity table
###     Add _LoginPartial on _Layout page. Register and login user
### Branch_9: Authentication and Authorization Part 2
###     https://www.youtube.com/watch?v=rEvPCoH4Hz8&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=22
###     Create new class in Model folder ApplicationUser, Add class to DbContext, add-migration, update-database
###     Add PhoneNumber column to AspNetUsers table, add field for Phone in Register.cshtml.cs add field in Register.cshtml
###     Enable roleManager
### Branch_10: Authentication and Authorization - Part 3
###     https://www.youtube.com/watch?v=XQrt5mws7OQ&list=PL_NVFNExoAxdf_NAE5kz8XAOPNvfc9w2d&index=23
###     In login.cshtml.cs and Login.cs change Email to Username. Add on Layout page autorization.
###     Add Authorize in Make and Model controler, cut Registar link from _LoginPartial and paste on _Layout page in dropdown list.
###     Add in Register.cshtml.cs Authorize for Admin and change return to index page.
###     Create Helper folder and Roles class. using helpers in Layout page and change
