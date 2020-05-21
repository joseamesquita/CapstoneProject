
<p align = "center">
  <u><big> ** <b> Capstone Project: Coding Fundamentals </b></big><u>
</p>

<p align = "center">
  <strong>Program Developed by: Jose Amesquita</strong>
<p>

<p align = "center">
  <a href = "https://www.linkedin.com/in/joseamesquita/">
    <img src = "https://img.shields.io/badge/-LinkedIn-black.svg?style=social&logo=linkedin">
  </a>
  || 
  <a href = "mailto: joseamesquita11@gmail.com.com">
    <img src = "https://img.shields.io/badge/-Gmail-black.svg?style=social&logo=gmail">
  </a>
</p>
--------------------------------

### <u>Table of Contents</u>
* About the Project
    * Description
    * Known Bugs
* Scope 
    * Minimal-Viable Product
    * Product Roadmap
    * Specs 
    * Wireframe
* Getting Started 
    * Prerequisites
    * Installation 
    * Use
* Auxiliary 
    * Technology
    * Contributors
    * Contact 
    * License
    * Acknowledgements 

--------------------------------

## About the Project

### Description
Coding Fundamentals: Create an appplication for students to learn how to code depending on their preference of programming language.

## Known Bugs

* No known bugs. 

--------------------------------

### Use Case 
<details>
<summary>Expand Use Case </summary>
</details>

### Minimum-Viable Product (To Be Completed)
  * Capability to add, update, and remove students (Full CRUD)
  * Capability to add, update, and remove Programming Languages (Full CRUD)  

### Specs 

<details>
<summary>User stories and specifications</summary>
<table>
  <tr>
    <th> Story 01 </th>
  </tr>
  <tr>
    <td> User Story </td>
    <td> As an Admin, I want to be able to add programming languages to the Registrar, so students can enrolled for the upcoming academic term.</td>
  <tr>
    <td>Behavior 01-A</td>
    <td>User is able to browse the programming languages and select the course of their choice.</td>
  </tr>
  <tr>
    <td>Input</td>
    <td>"Add a Programming Language Course"</td>
  </tr>
  <tr>
    <td>Output</td>
    <td>Query the programming language courses that are offered</td>
  </tr>
  <tr>
    <td>Completion</td>
    <td>False</td>
  </tr>
<table>

## Setup and Use

## Technologies Used
* Bootstrap 
* ASP.NET Core MVC
* Entity Framework Core
* HTML/CSS
* C#
* Git
* MySQL Workbench
* Visual Studio Code 

### Installing MySQL on MacOS

* Enter legacy password encryption
* Set password (change the password field in appsettings.json from repository to match your password)
* select finish
* Git Bash users: Open Terminal and enter the command echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile 
* Verify MySQL installation by opening Terminal and entering the command mysql -uroot -p{your password here, omitted brackets}. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.


### Prerequisites
* Understanding of Markdown and HTML languages 
* Option 1: [VisualStudioCode](https://www.npmjs.com/)

### How To Run The Program On Your Machine
1. cd ~ 
2. cd Desktop
3. git clone https://github.com/joseamesquita/CapstoneProject.git
4. cd CapstoneProject/UniversityRegistrar.Solution/UniversityRegistrar/
5. dotnet restore
6. dotnet build 
7. dotnet ef database update 
8. dotnet watch run OR dotnet run


  



