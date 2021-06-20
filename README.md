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

#Project requirements 
*This is the hardest part of writing a README.* Try some of these Mad Libs to
  get started:

  * `To contain a trelllo board which will allow you to keep track of project planning`
  * `To include a risk assesmen of the project`
  * `To produce an application with fully integrated using the Feature-Branch model into a Version Control System which will subsequently be built through a CI server and deployed to a cloud-based environment.`
  * `To ensure if a change is made to the project Azure Pipelines recreates and redeploys the changed application`
  * `The project must follow a setvice orientated architecture`
  * `The application must be deployed using Azure as a platform`

## Architecture 
The project specification requires at least 4 service orientated services to work together. Where service 1 is the core service this will enable the rendering of the HTML tha is required to interact with the application as well as being responsible for communciating with the other three services. Service 2 and 3 are services required to generate a random object.  Finally, service 4 will also generate an object based upon those of service 2 and 3.

I
