# MyPracticalProject
> This is a simple password generator app made using visual studio, C# and ASP.NET and deployed using GitHub actions and Terraform.

* [General info](#general-info)
* [Project requirements](#Project-requirements)
* [Technologies](#technologies)
* [Architecture](#architecture)
   * [My Approach](#my-approach)
   * [Project Tracking](#project-tracking)
   * [CI Pipeline](#cI-Pipeline)
* [Risk assessment](#risk-assessment)
* [Testing](#testing)
   * [Coverage Report](#coverage-report)
* [Setup](#setup)
* [Things to consider in the future](#things-to-consider-in-the-future)
    * [Issues](#issues)
    * [Improvements]( #improvements)
* [Status](#status)
* [Contact](#contact)


## General info
The purpose of this project was to create an application that generates “Objects” upon a set of predefined rules where the “Objects” can be from any domain. This would encompass prior learning that was conducted by QA. Prior subject knowledge that would be applied to this project are:

* Continuous development 
* Cloud Fundamentals 
* Software development within C#

## Project requirements 

  * `To contain a Trello board which will allow you to keep track of project planning`
  * `To include a risk assessment of the project`
  * `To produce an application with fully integrated using the Feature-Branch model into a Version Control System which will subsequently be built through a CI server and deployed to a cloud-based environment.`
  * `To ensure if a change is made to the project Azure Pipelines recreates and redeploys the changed application`
  * `The project must follow a service orientated architecture`
  * `The application must be deployed using Azure as a platform via terraform`

## Technologies
* C# - version 9.0
* ASP.NET- version 5.0.5
* Terraform - version 1.0.0
* GitHub Action


## Architecture 

The project specification requires at least 4 service orientated services to work together.
Where:
* Service 1 is the core service this will enable the rendering of the HTML that is required to interact with the application as well as being responsible for communicating with the other three services. 
* Service 2 and 3 are services required to generate a random object.  
* Finally, service 4 will also generate an object based upon those of service 2 and 3.

### My Approach 
To achieve these requirements set in the project brief I decided to make a password generator app that contains services that do the following:

Service 1 render HTML and required interact with the application:
      * This is shown as the front end which can communicate with the other services to show the result of the services.
      
Service 2 that will generate a random object:
      * Generates a random number
      * Generates a random special character
      
Service 3 generates another random object:
      * Generates a random uppercase letter 
      * Generates a random lowercase letter
      
Service 4 generates object based on service 3 and 4:
      * This merges service 2 and 3 to produce a string.
      * Contains an if/ else loop that states the strength of the password.
      

Below is a flow diagram which shows how the four services created for my project interact:

![image](https://user-images.githubusercontent.com/64641730/123110280-d791a880-d433-11eb-9952-f4a8f95abf1e.png)

![image](https://user-images.githubusercontent.com/64641730/123157395-61f10100-d462-11eb-99e8-74cadd2637f4.png)


## Project Tracking
A Trello board was used for the project management side of this project. This board shows everything that has been implemented into the project from Epics to Testing.
The board consist of Epics which are broken down into corresponding user stories which outline the requirements of the epics. In this project however, there were not many user stories as the user only interacts with the frontend and does not have to input any values to obtain an output. The user stories are broken down into tasks which are placed into the backlog, these tasks underpin all the technical aspects of the user stories. The board is colour-coded which is used link the Epics to User stories and to tasks. Below shows a detailed explanation of what each section means.

* Epics: Encompassed a vague feature or addition which is made up of several user stories.
* User Stories: These are non-technical features that explain how the user uses the features. This keeps the development process user focused and puts the user experience first. 
* Tasks: These are the technical steps which are required for the user stories. 
* Backlog:  This is a collection of items or products which need to be done.
* Testing: This out lines all the code testing that needs to be done to produce a coverage report. The functionality of the test will be tested.
* To do: These are the tasks that need to be done. These will be taken from the backlog and when put in progress these will be the tasks that will be put into focus.
* Doing: Once I have begun writing code this means that the task is in progress.
* Done: Once the code has been considered and carries out its function it is placed in the done list.

![image](https://user-images.githubusercontent.com/64641730/123151153-16872480-d45b-11eb-97bd-ac54f7cf180b.png)


## CI Pipeline 

Pictured below is the continuous integration pipeline with the associated frameworks and services related to them. This pipeline allows for rapid and simple development-to-deployment by automating the integration process, i.e. This means I can make a change to my code on my local machine and push it to GitHub, which will automatically push the new code to GitHub actions.

This process is handled by GitHub Actions with distinct build and deploy stages. The design of this type of job means that if any previous build stage fails, the job will fail altogether and provide you with information as to where this occurred.
The diagram shows various tools that were all used in the implementation and deployment of this code.
* The source code used was C# this is because it is a modern, open-source and cross platform language.
* The version control system (VCS) used was GIT, this is used for branching, merging, unifying, resolving, tracking changes and as a collaboration tool. The Version Control System provider is GitHub.
* The project management tool selected was Trello, this allowed me to keep track of tasks that I had to complete and prioritise them. 
* GitHub Actions was used as the CI/CD pipeline tool to automate the whole deployment process. Yaml files were produced that represented the pipeline of each service. GitHub actions was used as it was easier to manage and produce workflows with git.
* X-Unit testing was conducted on visual studio.
* Terraform was used to manage the infrastructure of my app services and enable continuous deployment to these services.

![image](https://user-images.githubusercontent.com/64641730/123214842-9f37ac00-d4bf-11eb-812d-7b72b8e4e1dd.png)

The process of deployment is as follows:
Firstly, A terraform file is created this contains all the relevant infrastructure. Within this file a for/each loop was produced in order to create the app services, these included YasminNumbers-app-service, YasminMerge-app-service, YasminLetters-app-service and YasminFrontEnd-app-service.

A resource group was also created using the terraform file as shown below.

![image](https://user-images.githubusercontent.com/64641730/123132061-395b0e00-d446-11eb-8719-b555e651dcbf.png)

After creating the terraform file and typing the following commands into the command prompt.
Terraform init - to initialise the terraform file
Terraform plan- this creates an execution plan, which lets you preview the changes that Terraform plans to make to your infrastructure
Terraform apply - this executes the actions proposed in a Terraform plan

Once completed this would have produced four different app services, under the same resource group.

The controllers are then published using visual studio code and selecting the associated app-service. CI/CD pipeline is selected, this generates a Yaml file which contains that pipeline for that controller.

![image](https://user-images.githubusercontent.com/64641730/123133257-7673d000-d447-11eb-93e2-431a6ac6501a.png)

The Yaml file states that on push to the master branch the following build and deploy actions should take place. This is contained under name and run. 
Changes to the Yaml file that were required included adding the specific directory where my code was stored in the AZURE_WEBAPP_PACKAGE_PATH and WORKING_DIRECTORY. Once completed this was committed and the workflow run. The build and deploy process was then triggered.

Below shows a successful build and deploy process:
![image](https://user-images.githubusercontent.com/64641730/123130653-d6b54280-d444-11eb-908d-e12081cee58d.png)


## Risk Assessment
The screen shot below shows the risk assessment of the app, possible risks that could occur to the user of the app. The risk assessment contains the risks, liklihood, severity, control measures and revisits where I provided updates on the various risks.
![image](https://user-images.githubusercontent.com/64641730/122683627-64e8b900-d1f8-11eb-877d-97a06263896a.png)

# Testing
This section contains the details testing including the code coverage report and unit testing conducted.

![image](https://user-images.githubusercontent.com/64641730/123136157-85a84d00-d44a-11eb-957c-ceaef6544c4c.png)

The testing conducted here was Arrange, Act and Assert testing pattern, a total of 4-unit tests were conducted for this project which tested the operations required for those controllers such as producing the required output.

## Coverage Report
![image](https://user-images.githubusercontent.com/64641730/123134770-0a926700-d449-11eb-90e1-1be9cc10746a.png)

The image above shows the coverage report of my app. The coverage is 73% this is significantly high value and is above the value which was required. The tests consisted of x unit testing. These are designed to assert that if a certain function is run, the output should be a known value. The controllers were tested this included the merge, numbers, home and letters controller. The result could have been higher if I was able to find a way to exclude code that was not intended to be tested, for instance the views in the front end. 

![image](https://user-images.githubusercontent.com/64641730/123134849-1d0ca080-d449-11eb-961e-d5ea014eda58.png)
From the image above we can see that the controllers that were initially required to be tested. Three controllers had an average percentage above 94% however the merge controller had a lower percentage of 64.2% which intern reduced the overall test score as well as having the front controller view in the final report.

![image](https://user-images.githubusercontent.com/64641730/123135285-868caf00-d449-11eb-96ad-52cabacdc8b1.png)
The code above shows the parts of the merge controller that were not tested. This included the else if loop. This was because I was unable to understand how to conduct the x-unit test on this kind of logic correctly and accurately. 

# Setup
<img width="484" alt="Capture-new frontend" src="https://user-images.githubusercontent.com/64641730/123150843-ba240500-d45a-11eb-8773-2ffec45c77a7.PNG">

Above is an image the user will see when opening this web page.

A typical user story journey includes:

A page is loaded, and a random password is generated, it is “AC24!6cl”.

Because the password contains a capitol letters, a special character, a lowercase letter and a number this is a "very strong password", this is described in the logic of service 4.

The Back-end completes the logic to decide whether this password does in fact contain these values to make it strong and then displays this for the user.

## Best Practices
I incorporated the best practices within this project. This included documenting code using comments. This ensures that people reading my code understand how certain functions operate. This is important especially when collaborating on projects to ensure individuals understand your code.

# Things to consider in the future

## Issues
When completing the project many issues arose, these were noted down so if this occurred in the future, I would understand the next steps to take:
* When deploying using CI/CD pipeline on visual studio it is important to make 2 small changes to the yaml file before committing and pushing the workflow. This includes specifying the directory your code is in. For example, adding *./code/* AZURE_WEBAPP_PACKAGE_PATH  and  WORKING_DIRECTORY. This will allow the deployment process to run smoothly as it is able to find the relevant code in the directory.
* To ensure that I have added the terraform in tor the git ignore as this is a large file and should not be pushed onto GitHub.
* The push and commit function stopped working on my visual studio this meant I had to remove all the cached data and reset anything that was not pushed using the following function `git reset --hard @{u}`. Before doing this I had to ensure that all my code was saved and anything that had not yet been pushed was copied.
* When writing my terraform file it was important to include the AppSettings Infront of the service URL which was also present in the appsettings.json file this ensured that the app-services produced were configured therefore when running the URL the application would work.
* Finally, an issue with GitHub Actions occurred which was outside my control. The server had gone down and changes to my application were not being made and deployment was failing. This can be shown in the screenshot below:

 ![image](https://user-images.githubusercontent.com/64641730/123140307-0a956580-d44f-11eb-8de5-0799313b4c9a.png)

* The above image specifies the error that had occurred. This meant my website incurred some downtime. Next time this error occurs it is important to wait until making another change to the website, until the server is running again. This could of been to the high volume of people using the server potentially leading to the server to break.


## Improvements
* Making the password generator contain a database, so that already generated passwords can be stored.
* To ensure the code coverage report contained a higher percentage above 90% by excluding things that were not required to be tested
* Changing the layout of the UI, make it more visually appealing to the user.


## Acknowledgements 
Thank you Dara and Victoria for all your help.

## Status
Project is: _in progress_ as I want to try and add on extra features to improve the project.

## Contact
Created by [@Yelhendi] - feel free to contact me!
