using System;
using System.Collections.Generic;
using Note_App.Models;

namespace Note_App.ViewModels
{
	public class ItemDetailViewModel : BaseViewModel
	{
		public Note Note { get; set; }
		public bool IsNewNote { get; set; }
		public IList<String> CourseList { get; set; }

		public String NoteHeading {
			get { return Note.Heading; }
			set {
				Note.Heading = value;
				OnPropertyChanged();
			}
		}

		public ItemDetailViewModel(Note note = null)
		{
			IsNewNote = (note == null);
			Title = IsNewNote ? "Create Note" : "Edit Note";
			InitializedCourseList();
			Note = note ?? new Note();
		}

		async void InitializedCourseList()
		{
			CourseList = await PluralsightDataStore.GetCoursesAsync();
		}
	}
}
