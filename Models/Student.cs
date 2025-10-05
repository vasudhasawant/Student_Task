using System;
using System.Collections.Generic;

namespace StudentTask.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Course { get; set; } = null!;

    public int Marks { get; set; }
}
