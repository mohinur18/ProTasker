﻿using ProTasker.Domain.Enum;
using ProTasker.Domain.Models;

namespace ProTasker.DTOModels.Worker;

public class WorkerUpdateModel
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Bio { get; set; }
    public List<Category> Categories { get; set; }
    public Gender Gender { get; set; }
    public string Location { get; set; }
}
