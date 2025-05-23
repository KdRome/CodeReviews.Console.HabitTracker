﻿namespace yashsachdev.HabitTracker;
public class User
{
    public User() : this(0)
    {

    }
    public User(int user_Id)
    {
        user_Id = User_Id;
        HabitEnrolls = new List<HabitEnroll>();
    }
    public int User_Id { get; set; }
    public List<HabitEnroll> HabitEnrolls { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}