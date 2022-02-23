
## Code First One To One


### Data Annotation
```cs

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }

    public virtual StudentAddress Address { get; set; }
}
     
public class StudentAddress 
{
    [ForeignKey("Student")]// Conncection
    public int StudentAddressId { get; set; }
    public virtual Student Student { get; set; }

    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public int Zipcode { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    
}

```

### Fluent Api

```cs

protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
    // Configure Student & StudentAddress entity
    modelBuilder.Entity<Student>()
                .HasOptional(s => s.Address) // Mark Address property optional in Student entity
                .WithRequired(ad => ad.Student); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
}

```