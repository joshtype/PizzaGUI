# PROJECT TITLE
Prototype 2: Pizza Management System (PMS)

## APPLICATION
pmsUI.exe (v.3.0)

## AUTHORSHIP
Joshua Gregory, Nov. 2024

## DESCRIPTION
Pizza Management System is an ordering system for a pizza restaurant that offers pizzas and beverages for carryout and delivery.
This app is a prototype that implements menu, ordering, and order cart requirements for testing via Pizza, Beverage, and Order classes (defined within Form1.cs class file).

The structure of this app was based on author's DB design, author's DB schema, class UML, class specs, and prototype 1 slides (included in folder pmsUI).

Due to this prototype's scope, many classes in the included class UML and class specs and necessary for a complete production version are not implemented. 

Excluded classes: DbOp (DB operations via Data.SqlClient), Customer, Payment, PaymentGateway (payment gateway API), and ReceiptPrinter (System.Drawing).

## INSTALLING
Option 1: Clone and open the solution file pmsUI.sln then run the file (requires .NET runtime).

Option 2: Clone the packaged app folder pmsExe_v3 and launch pmsUI.exe executable file (requires Windows OS).

## USAGE
Launch and run the solution or launch the standalone application. 
Login using prototype credentials (testUser / Password1).
Simulate taking a customer's order by adding, editing, and removing various pizzas & beverages.
Submit the order to view a prototype demo receipt.
Simulate another order or logout and close the application.

## FUTURE RELEASES
I plan to continue this project, implementing all needed classes and using Data.SqlClient via DbOps to connect to a SSMS or MySQL DB server.
