using System;

namespace IntroMinimalApiDL;

public static class NoteRepository
{
    public static List<NoteEntity> Notes { get; set; } = new()
    {
        new()
        {
            Id = 1,
            Note = "Remember to buy milk on the way home."
        },
        new()
        {
            Id = 2,
            Note = "Call Mom tomorrow to wish her a happy birthday."
        },
        new()
        {
            Id = 3,
            Note = "Finish the report for the client by the end of the week."
        },
        new()
        {
            Id = 4,
            Note = "Don't forget to pick up the kids from school at 3 PM."
        },
        new()
        {
            Id = 5,
            Note = "Book a flight to Paris for the summer vacation."
        },
        new()
        {
            Id = 6,
            Note = "Meet with the new team members on Monday at 10 AM."
        },
        new()
        {
            Id = 7,
            Note = "Schedule a dentist appointment for next week."
        },
        new()
        {
            Id = 8,
            Note = "Pay the electricity bill before the due date."
        },
        new()
        {
            Id = 9,
            Note = "Buy a new pair of shoes."
        },
        new()
        {
            Id = 10,
            Note = "Learn how to play the guitar."
        }
    };
}

public class NoteEntity
{
    public int Id { get; set; }
    public string Note { get; set; }
}
