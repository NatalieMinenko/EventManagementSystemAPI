﻿namespace EventManagementSystemAPI.Models.Requests
{
    public class RegisterUserRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }
    }
}
