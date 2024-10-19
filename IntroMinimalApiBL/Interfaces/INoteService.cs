using System;
using IntroMinimalApiBL.Models;

namespace IntroMinimalApiBL.Interfaces;

public interface INoteService
{
    IEnumerable<NoteModel> GetNotes();
}
