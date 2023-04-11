﻿using System.Text.Json.Serialization;

namespace Auth.Entities;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }

    [JsonIgnore]
    public string Password { get; set; }

}
