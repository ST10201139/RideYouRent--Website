## Rental Management System
The Rental Management System is a web-based application developed for "The Ride You Rent," a start-up company that provides rental cars to e-hailing drivers. The system aims to streamline operations and facilitate efficient management of drivers, rentals, returns, and late fees.

## Features
Driver Management: Maintain a database of drivers with their personal information, including name, address, email, and mobile number.

Inspector Management: Keep track of vehicle inspectors responsible for collecting rental cars. Store their details, including inspector number, name, email, and mobile number.

Car Management: Manage a fleet of rental vehicles, including make, model, body type, kilometers traveled, and service kilometers available.

Rental Management: Track rental information, including car number, assigned inspector, renting driver, rental fee, start date, and end date.

Return Management: Log the return of rental vehicles, capturing car number, handling inspector, returning driver, return date, and any late fees incurred.

## System Access
The Rental Management System is accessible from both desktop computers and mobile phones. Inspectors can use their mobile phones to log returns immediately upon vehicle collection at pick-up points.

## Future Expansion
The system's core functionalities encompass Driver, Inspector, Vehicle, Rental, and Return Management. However, future expansions are planned to incorporate additional functionality.

## Installation and Deployment
1. Clone the project repository from GitHub - git clone https://github.com/therideyourent/rental-management-system.git

2. Install the required dependencies and libraries -cd rental-management-system
npm install
  
3. Configure the database connection in the .env file  -DB_HOST=your_database_host,DB_USERNAME=your_database_username,DB_PASSWORD=your_database_password
 
4. Copy code
 
5. Build and deploy the system - npm run build ,npm start

6. Access the system from your web browser at https://therideyourentpoe13.azurewebsites.net/
   
   -Default login credentials: Username: "st@gmail.com" and Password: "trickshot1_"

   -Feel free to update the login credentials as needed for your deployment.

## Contributing
Contributions to the Rental Management System are welcome. If you encounter any issues or have suggestions for improvements, please submit an issue on the project's GitHub repository.

## License
The Rental Management System is released under the MIT License.
