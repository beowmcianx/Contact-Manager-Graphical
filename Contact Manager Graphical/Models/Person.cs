using System;
using System.Collections.Generic;

namespace Contact_Manager_Graphical.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? SecondName { get; set; }

    public string? Address { get; set; }

    public DateOnly? BirthDate { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
