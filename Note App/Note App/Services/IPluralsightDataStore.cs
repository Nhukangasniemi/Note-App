using Note_App.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Note_App.Services
{
	public interface IPluralsightDataStore
	{
		Task<String> AddNoteAsync(Note courseNote);

		Task<bool> UpdateNoteAsync(Note courseNote);

		Task<Note> GetNoteAsync(String id);

		Task<IList<Note>> GetNotesAsync();

		Task<IList<String>> GetCoursesAsync();
	}
}