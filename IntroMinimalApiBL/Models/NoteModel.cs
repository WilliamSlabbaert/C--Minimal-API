using System;
using IntroMinimalApiDL;

namespace IntroMinimalApiBL.Models;

public class NoteModel : IBaseModel
{
    public int Id { get; set; }
    public string Note { get; set; }
}
