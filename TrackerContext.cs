using Microsoft.EntityFrameworkCore;

namespace CustomerOrderTracker;

public class TrackerContext : DbContext
{
	public DbSet<Customer> Customers {get; set;}
	public DbSet<Order> Orders {get; set;}



	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite("Data Source=CustomerOrders.db");
	
}



public class Customer
{
	public int CustomerId { get; set; }
	public required string Name { get; set; }
	public required string Email { get; set; }
}



public class Order
{
	public required int OrderId { get; set; }
	public required DateTime OrderDate { get; set; }
	public required double TotalAmount { get; set; }
	// Foreign Key
	public required int CustomerId { get; set; }
}