# Project2023-CRM

<!-- ABOUT THE PROJECT -->
This is a simple project that is built for accessing a list of contact that have details of its username, email, phone, skills and hobbies.

This project is built on .net 6.0 framework, and the database that is used for this project is MongoDb.

Project flow is from CRM.Web -> CRM.Application -> CRM.DataAccess

CRM.Web is where controller is placed, then to CRM.Application's services then to CRM.DataAccess where repositories is located.

CRM.DataAccess is use to process the input to useful information to fit the query for MongoDb.
After it is queried, it will then return the result to the service layer (CRM.Application) to process the output, oftenly mapping back to the designated dto

CRM.Core is where dto and models are stored, dto is the input and output of the API, while models are fir to table structure.

Note: Database is hosted at MongoDb cloud, if you are intrested to look at the database, you can access via MongoDb compass. The connection string is as below
mongodb+srv://<username>:<password>@cluster.liiv9ts.mongodb.net/


<!-- GETTING STARTED -->
To get started, with at least Visual Studio 2022 version and .net 6.0 framework installed, choose CRM.Web as a startup project and you will be good to go.

<!-- How to Use the Project -->
.Net Core will comes with an API interface(swaggger) for you to test on the api you have created. 
It will automatically created when you start the project, you can try to play around at there.

<!-- Further enhancement -->
The future enhancement for this project will be 
- adding logging
- introduce account (login, sign up)
- limit access


<!-- CONTACT -->
Lee Yoong Hean - henrylyh96@gmail.com
Project Link: https://github.com/henrylyh3/Project2023-CRM-API.git
Project2023-CRM
