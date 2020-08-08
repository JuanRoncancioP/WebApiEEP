# DEVELOPMENT LEADER TEST
## Project name: WebApiEPP

The Api as build as a test for leader of developtment of the business Empresa de Energia de Pereira EPP.

Was developed with architercura MVC. ASP DotNet core and bosotrap from the frontend.

The aplication conects to the API http://masglobaltestapi.azurewebsites.net/api/Employees
to download some employee information on a list and shows the user using boostrap table. 

## How it´s works
The aplication has a text field for read a number id of the employee and has button to querry the api
for all the employee's information. But the app shows the information of the employee id that was asked using Linq. If there was no id given the app shows all the information avaible usin boostrap table and Razor.

# Model layer
The Api use a class that map the json give for the appy.

# Data access layer
This layer conects to the api and download the abaible information using the model class.

# Controler layer
This layer has the class to modelate the information as properly class and the class to build.
Also has de controller class to answer then view layer.

# View layer
This layer offers the user the employees information, the class diagram of the project and the contact data of the developer of the api.  

# Wish
I wish you enjoy checking this application aslong i enjoy programming it and learning.