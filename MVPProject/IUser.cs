using System;

namespace MVPProject
{
    internal interface IUser
    {
        Guid Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
}