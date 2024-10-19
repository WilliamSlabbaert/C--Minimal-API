using System;
using System.Linq;
using IntroMinimalApiBL.Interfaces;
using IntroMinimalApiBL.Mappers;
using IntroMinimalApiBL.Models;
using IntroMinimalApiDL;

namespace IntroMinimalApiBL.Services;

public class NoteService : INoteService
{
    public IEnumerable<NoteModel> GetNotes() => NoteRepository.Notes.Select(_ => BaseMapper<NoteEntity, NoteModel>.MapToModel(_));
}
