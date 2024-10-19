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

    public NoteModel GetNote(int id) => BaseMapper<NoteEntity, NoteModel>.MapToModel(NoteRepository.Notes.FirstOrDefault(_ => _.Id == id));

    public string AddNote(string note)
    {
        try
        {
            NoteRepository.Notes.Add(new NoteEntity() { Id = GetNotes().Max(_ => _.Id) + 1, Note = note });

            return "OK";
        }
        catch
        {
            return "Something went wrong";
        }
    }
}
