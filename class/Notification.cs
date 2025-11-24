using System;

public class Notification
{
    public int Id { get; set; }
    public string ReceiverRole { get; set; } 
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public string ReceiverUsername { get; internal set; }
    public string SenderRole { get; internal set; }
}


