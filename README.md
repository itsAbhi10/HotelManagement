This project is basically based on ASP.Net Entity-frame work.


Key Points:
          ASP.Net entity Framework (without stored procedure)
          C#
          SQL Server

In this project basically i craeted two section:
     1) User Section
     2) Admin Section


As the user visit the website it shows the home page with view room and and booking window for the user

At the user section there are following sections:
      1) Contact Us
      2)Services
      3) Rooms
      4) Bookings 
At the Admin section there also some section as follows:
      1) Admin
      2) View Room
      3) Add room 
      4) Request

In the entitiy frame work core we dont have to use stored procedure.
It is able t take data from the database without stored procedures.


In this Project I used following models :
      Account Model
      Booking Model 
      Database context

In entity framework we have to add database context for the model in  that we have to add following code :
    
      public class DatabaseContext : DbContext
{
    public DatabaseContext() { }


    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public virtual DbSet<AccountModel> AccountModel { get; set; }   //Decleare the model name in database context 

    public virtual DbSet<BookingModel> BookingModel { get; set; }

    public virtual DbSet<Contact> Contact { get; set; }
}


Also I used two layouts for this 
    1=> User Layout   - Used for user section
    2=> Master Layout -  Used for Admin section 
