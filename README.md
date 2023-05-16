# SpaceX_API
Source code repo: https://github.com/paulayushi/SpaceX_API

Download/clone the repo: git clone https://github.com/paulayushi/SpaceX_API.git

Open the SpaceX in Visual Studio editor

Build the solution: Ctrl + B

Run the solution: Ctrl + F5 or 'dotnet run' command

Open Postman and import postman projects attached in the SpaceX solution

First run the Login API to generate the token- https://localhost:7071/spacex/auth/api/login
Please use below credential to generate the token:
"Username":"superuser",
"Password":"Password@2023"

Please use and pass the generated JWT token to pass as bearer authorization token in the postman request to call the Launches APIs
Run Launches API to validate passing the JWT token