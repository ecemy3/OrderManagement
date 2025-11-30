# Order Management System

A professional C# Windows Forms desktop application for managing customer orders, inventory tracking, and administrative operations. Built with Entity Framework 6 and SQL Server backend.

## Features

- **Order Management**: Create, update, and track customer orders
- **Inventory Management**: Monitor product stock levels and availability
- **Customer Management**: Maintain and manage customer information
- **Admin Panel**: Administrative controls and user management
- **User Authentication**: Secure login system with admin registration
- **Activity Logging**: Track all system operations and changes
- **Real-time Updates**: Live stock status monitoring

## Technical Stack

- **Language**: C# (.NET Framework 4.7.2)
- **UI Framework**: Windows Forms
- **Database**: SQL Server
- **ORM**: Entity Framework 6.5.1
- **Architecture**: Layered (Models, Services, UI Forms)

## Project Structure

```
OrderManagement/
├── Fromss/                          # User Interface Forms
│   ├── Form1.cs                     # Main application window
│   ├── AdminSign.cs                 # Admin login form
│   ├── AdminRegister.cs             # Admin registration form
│   ├── Shopping.cs                  # Order/Shopping form
│   └── StokDurum.cs                 # Stock status form
├── Models/                          # Data Models
│   ├── AppDbContext.cs              # Entity Framework DbContext
│   ├── Order.cs                     # Order entity
│   ├── Costumer.cs                  # Customer entity
│   ├── Product.cs                   # Product entity
│   └── Log.cs                       # Activity log entity
├── Services/                        # Business Logic
│   └── OrderLogManager.cs           # Order and logging operations
├── Migrations/                      # Entity Framework Migrations
├── App.config                       # Application configuration
└── OrderManagement.csproj          # Project file
```

## Prerequisites

- .NET Framework 4.7.2 or higher
- Visual Studio 2019 or later (Community, Professional, or Enterprise)
- SQL Server 2016 or higher
- NuGet Package Manager

## Installation

1. Clone the repository:
```bash
git clone https://github.com/ecemy3/OrderManagement.git
cd OrderManagement
```

2. Open the solution in Visual Studio:
```bash
OrderManagement.sln
```

3. Restore NuGet packages:
   - Right-click on the solution in Solution Explorer
   - Select "Restore NuGet Packages"

4. Configure your database connection:
   - Edit `App.config` and update the connection string
   - Default connection string key: `DefaultConnection`

5. Update the database:
   - Open Package Manager Console
   - Run: `Update-Database`

6. Build and run:
   - Press `Ctrl+F5` or click "Start Without Debugging"

## Database Setup

The application uses Entity Framework Code-First migrations. After updating the connection string in `App.config`, run:

```powershell
Update-Database
```

This will automatically create the database schema with all necessary tables.

## Usage

### Starting the Application

1. Run the application
2. Use admin credentials to log in or register a new admin account
3. Navigate through the dashboard to:
   - Create and manage orders
   - Track inventory
   - Monitor activity logs

### Main Forms

| Form | Purpose |
|------|---------|
| Form1 | Main dashboard and navigation hub |
| AdminSign | Secure admin login interface |
| AdminRegister | Create new admin accounts |
| Shopping | Order creation and management |
| StokDurum | Real-time inventory status |

## Configuration

Edit `App.config` to configure:
- **Database Connection**: Update `DefaultConnection` connection string
- **Application Settings**: Modify settings in the `<applicationSettings>` section

Example connection string:
```xml
<add name="DefaultConnection" 
     connectionString="Server=YOUR_SERVER;Database=OrderManagement;User Id=sa;Password=YOUR_PASSWORD;" 
     providerName="System.Data.SqlClient" />
```

## Development

### Adding a New Migration

```powershell
Add-Migration MigrationName
Update-Database
```

### Project Dependencies

- EntityFramework 6.5.1
- System.Windows.Forms
- System.ComponentModel.DataAnnotations

View full dependencies in `packages.config`

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -m 'Add YourFeature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Author

**ecemy3** - Initial development

## Support

For issues, bugs, or feature requests, please open an issue on the GitHub repository.

## Changelog

### Version 1.0.0 (Current)
- Initial release with core features
- Order and inventory management
- Admin authentication system
- Activity logging
