# MyPracticalProject
> This is a simple password generator app made using visual studio, C# and ASP.NET and deployed usinf Microsoft azure app service and terraform.

* [General info](#general-info)
* [Technologies](#technologies)
* [Architecture](#architecture)
   * [Project Tracking](#project-tracking)
* [Risk assessment](#risk-assessment)
* [Coverage Report](#coverage-report)
* [Setup](#setup)
* [Deployment](#deployment)
* [Features](#features)
* [Status](#status)
* [Contact](#contact)


## General info
The purpose of this project was to create an application that generates “Objects” upon a set of predefined rules where the “Objects” can be from any domain.
-[] An Asana board (or equivalent Kanban board tech) with full expansion on tasks needed to complete the project.
This could also provide a record of any issues or risks that you faced creating your project.
An Application fully integrated using the Feature-Branch model into a Version Control System which will subsequently be built through a CI server and deployed to a cloud-based environment.
If a change is made to a code base, then Webhooks should be used so that Azure Pipelines recreates and redeploys the changed application
The project must follow the Service-oriented architecture that has been asked for.
The applications services should be deployed using Azure as a cloud platform but you can deploy the app using any Azure services you like.

## Architecture 
The project specification requires at least 4 service orientated services to work together. Where service 1 is the core service this will enable the rendering of the HTML tha is required to interact with the application as well as being responsible for communciating with the other three services. Service 2 and 3 are services required to generate a random object.  Finally, service 4 will also generate an object based upon those of service 2 and 3.

I
