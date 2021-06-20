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

## Technologies
* C# - version 9.0
* ASP.NET- version 5.0.5

## Project requirements 

  * `To contain a trelllo board which will allow you to keep track of project planning`
  * `To include a risk assesment of the project`
  * `To produce an application with fully integrated using the Feature-Branch model into a Version Control System which will subsequently be built through a CI server and deployed to a cloud-based environment.`
  * `To ensure if a change is made to the project Azure Pipelines recreates and redeploys the changed application`
  * `The project must follow a setvice orientated architecture`
  * `The application must be deployed using Azure as a platform`

## Architecture 
The project specification requires at least 4 service orientated services to work together. Where service 1 is the core service this will enable the rendering of the HTML tha is required to interact with the application as well as being responsible for communciating with the other three services. Service 2 and 3 are services required to generate a random object.  Finally, service 4 will also generate an object based upon those of service 2 and 3.

### My Approach 
To achieve these requirments that have been set out in the project brief I decided to make a password generator app that contains services to do the following:

* service 1 that will be able to render HTML and required interact with the application:
      * This is shown as the front end which is able to communicate with the other services to show the result of the services.
* Service 2 that will generate a random object.
      * Generates a random number
      * Genrates a random special character
* Service 3 generates another random object
      * Generates a random uppercase letter 
      * Generates a random lowercase letter
* Service 4 generates object based on service 3 and 4.
      * This merges service 2 and 3 to produce a string.
      * Contains a if else loop that states how strong the password is

Below is a diagram which shows how the four services for my peoject interact:







## Project Tracking
A trello board was used for the project management side of this project. This board shows everything that has been implimented into the project from Epics to Testing.
The board consits of Epics which are broken down into corresponsing user stroies which outline the requirments of the epics. The user stories are broken down into tasks which are placed into the backlog, these tasks underpin all the technical aspects of the user stories. The board is colour-coded which is used link the Epics to User stroies and to tasks. Below shows a detailed explanation of what each section means.

* Epics: Encompase a vague feature or addition which is made up of several user stroies.
* User Stories: These are non-technical features that explain how the user uses the features.This keeps the development process user focused and puts the user experience first. 
* Tasks: These are the technical steps which are required  for the user stories. 
* Backlog:  This is a collection of items or products which need to be done.
* Testing: This out lines all the code testing that needs to be done in order to produce a coverage report. The functionality of the test will be tested.
* To do: These are the tasks that need to be done. These will be taken from the backlog and when put in progress these will be the tasks that will be put into focus.
* Doing: Once I have began writing code this means that the task is in progress.
* Done: Once the code has been considered and carries out its function it is placed in the done list.



## CI Pipeline 

Pictured below is the continuous integration pipeline with the associated frameworks and services related to them. This pipeline allows for rapid and simple development-to-deployment by automating the integration process, i.e. I can produce code on my local machine and push it to GitHub, which will automatically push the new code to Microsoft app service. Code was tested using an X-Unit test and a code coverage report was produced.

This process is handled by Azure pipelines with distinct build stages. The design of this type of job means that if a previous build stage fails, the job will fail altogether and provide you with detailed information as to where this occurred. The more modular you make this system, the easier it is to pinpoint where your code is failing. As pictured below, the four build stages are:
* 'Checkout SCM' (pull code from Git respository)
* 'Build' (would be more accurately named 'Installation' as Python doesn't require building, in the strictest sense)
* 'Test' (run xunit test, produce coverage report) 
* 'Run' (start the passwordgenerator app service on the local VM, belonging to systemctl)


## Risk Assesment
The screen shot below shows the risk assessment of the app, possible risks that could occur to the user of the app. The risk assessment contains the risks, liklihood,severity,control measures and revisits
![image](https://user-images.githubusercontent.com/64641730/122683627-64e8b900-d1f8-11eb-877d-97a06263896a.png)

## Coverage Report
The screen shot below shows the converage report of my app. The coverage is _________ this is significantly ______than the value which was required. The tests consisted of x unit testing. The controllers were tested this included the merge,numbers,home and letters controller. Integration testing was used to test the features of the code. 

## Setup

## Features

## Status
Project is: _in progress_ as I want to try and add on extra features to imporve the project.

## Contact
Created by [@Yelhendi] - feel free to contact me!




I
