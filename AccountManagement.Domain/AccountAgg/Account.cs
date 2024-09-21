﻿using _0_Framework.Domain;
using AccountManagement.Domain.RoleAgg;

namespace AccountManagement.Domain.AccountAgg;

public class Account : EntityBase
{
    public Account(string fullname, string username, string password, string mobile,
        long roleId, string? profilePhoto, string? email)
    {
        Fullname = fullname;
        Username = username;
        Password = password;
        Mobile = mobile;
        RoleId = roleId;

        if (roleId == 0)
            RoleId = 2;

        ProfilePhoto = profilePhoto;
        Email = email;
    }

    public string Fullname { get; private set; }
    public string Username { get; private set; }
    public string Password { get; private set; }
    public string Mobile { get; private set; }
    public string? Email { get; private set; }
    public long RoleId { get; private set; }
    public Role Role { get; }
    public string? ProfilePhoto { get; private set; }

    public void Edit(string fullname, string username, string mobile,
        long roleId, string? profilePhoto, string? email)
    {
        Fullname = fullname;
        Username = username;
        Mobile = mobile;
        RoleId = roleId;

        if (!string.IsNullOrWhiteSpace(profilePhoto))
            ProfilePhoto = profilePhoto;
        Email = email;
    }

    public void ChangePassword(string password)
    {
        Password = password;
    }
}