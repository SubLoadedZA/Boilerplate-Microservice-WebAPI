# Boilerplate-Microservice-WebAPI
<div id="top"></div>
<!--
*** Thanks for checking out the Microservice API boilerplate. Feel free to fork and contribute once repo has been made public ***
-->
<h3 align="center">Boilerplate-Microservice-WebAPI</h3>

  <p align="center">
    Project created to streamline new API development. 
    Currently set up with Controllers, Models, Repositories and Interfaces that allow basic extension on CRUD contracts.
    Project has been setup to use Docker-Compose and can also be run with IIS Express. 
  </p>
</div>

### Built With

.NET 6.0,
C# 10,
EFCore,
Docker

### How to

- [ ] Grab the code and ensure .NET 6.0 SDK is available on dev environment
- [ ] Update SQL connection string in appsettings.json
- [ ] Entity Framework Core Migrations --> Open Package Manager Console, type command "Add-Migration" and give that a meaningful name for e.g. InitialCreation and      press enter. Run "update-database" command to apply migrations to DB. 

<!-- ROADMAP -->
## Roadmap

- [ ] Allow Abstractions from Repositories (implement IRepositories...)
- [ ] Logging - seperate project - injectable as service/middleware or inherited and used
- [ ] Authentication (JWT etc) - injectable/wrapper or inherited and used
- [ ] Flurl/HttpClient support 

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. 

Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request


