﻿using KnowledgeSpace.BackendServer.Model.Interfaces;

public class User : IDateTracking
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "User";
    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }

}