This program creates a RESTful web service in C#.  This application provides no autentication or business logic.  A controller 
was created and that controller returns a list.  A third party tool called SWAGGER was used to test the created web service 
(more infomation on SWAGGER below). After the application is completed and the Nuget package installed you can run the project.
If you click the API tab on the web page and Default is listed under Values it has been successful.  After clicking GET api/
Default, you will see the resourse description (what we created in the UserInfo class).  You will also get a sample JSON response.
Use the url http://localhost:62591/swagger, from the you should see The Default Controller (named Default).  On this page you can
click the button 'Try It Out', you should get a response back with 10 entries that we created earlier in the DefaultController 
class.  You will know it worked if the status code is 200.


To add the Nuget package Swashbuckle, right click on the project name, select 'Manage Nuget Packages...', select browse, type
Swashbuckle into the search box and click install.  I have provided a link down below if you would like to see the capabilities 
of SWAGGER.

https://swagger.io/

