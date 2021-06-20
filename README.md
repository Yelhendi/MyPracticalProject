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

## Architecture 
The project specification requires at least 4 service orientates services to work together. Where service 1 is the core service this will enable the rendering of the HTML tha is required to interact with the application as well as being responsible for communciating with the other three services.
