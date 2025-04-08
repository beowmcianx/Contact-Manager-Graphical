using System;
using System.Collections.Generic;

namespace Contact_Manager_Graphical.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public long PhoneNum { get; set; }

    public string? Email { get; set; }

    public int PersonId { get; set; }

    public DateOnly CreationDate { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
