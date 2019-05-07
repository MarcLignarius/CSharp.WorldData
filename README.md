# _WorldData.Solution_

#### _Program which allows user to view information about countries and cities, 05/06/2019_

#### By _**Marc Davies and Justin Kerntz**_

## Description

_Program which allows user to view information about countries and cities. The application is connected to a MySQL database and returns information from that database._

## Setup/Installation Requirements

_Downloading & Importing the Database:_

* _Download [this zip file](https://github.com/epicodus-lessons/world-data-mysql/blob/master/world.sql.zip?raw=true). Open the file to unzip it._
* _Launch MAMP, click Start Servers, and double-check the Apache Server and MySQL Sever checkboxes in the upper-right corner of the MAMP window are selected._
* _After servers are running, click Open start page on the MAMP window. This will take you to the MAMP startup page in your browser at localhost:8888/MAMP/. Open the Tools menu at the top of the page and select phpMyAdmin._
* _Click the Import tab near the top of this page._
* _Under File to import, select the unzipped database file. Keep all other default values on the form, and click Go at the bottom of the page._
* _You should see a Import has been successfully finished success message, and a new world database appear in the left-hand list._

_Cloning & Launching the Application:_

* _Clone from GitHub_
* _$cd WorldData.Solution/WorldData_
* _$dotnet run to start the application_
* _Launch [http://localhost:5000/](http://localhost:5000/) in your browser_

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| 1. Upon launching the application, user has option to *View Countries* | Launch application | ![Image of homepage](https://i.imgur.com/q8fyviE.png) |
| 2. Upon clicking on *View Countries*, user is presented with information about countries. For each country, the use can click on *Major Cities* or *Back to Homepage* | Click *View Countries* | ![Image of countriesscreen](https://i.imgur.com/8ndo4El.png) |
| 3. If user clicks on *Back to Homepage*, see Step 1. If user clicks on *Major Cities*, user is presented with information about cities. For each city, user can click on *Back to Countries* or *Back to Homepage*. | Click  *Major Cities* | ![Image of citiesscreen](https://i.imgur.com/P2Q1j0w.png) |
| 4. If user clicks on *Back to Homepage*, see step 1. If user clicks on *Back to Countries*, see step 2. | | |

## Known Bugs

_None as of last update._

## Support and contact details

_Please contact me at marcdaviesriot@gmail.com if you run into any issues or have questions, ideas or feedback._

## Technologies Used

_C#_

### License

*This software is licensed under the GPL license.*

Copyright (c) 2019 **_Marc Davies and Justin Kerntz_**
