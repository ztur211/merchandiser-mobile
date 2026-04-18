using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Project.Models;

namespace Project.Data
{
    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection database;

        public NoteDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Note>().Wait();
        }

        public Task<List<Note>> GetNotesAsync()
        {
            //Get all notes.
            return database.Table<Note>().ToListAsync();
        }

        public Task<Note> GetNoteAsync(int id)
        {
            // Get a specific note.
            return database.Table<Note>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Note note)
        {
            if (note.ID != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(note);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(note);
            }
        }
        public Task<int> DeleteNoteAsync(Note note)
        {
            // Delete a note.
            return database.DeleteAsync(note);
        }

        public Task<List<Worker>> GetWorkerAsync()
        {
            return database.Table<Worker>().ToListAsync();
        }
        public Task<int> SaveWorkerAsync(Worker worker)
        {
            return database.InsertAsync(worker);
        }
        public Task<int> DeleteWorkerAsync(Worker worker)
        {
            // Delete a note.
            return database.DeleteAsync(worker);
        }

        public Task<List<Client>> GetTicketAsync()
        {
            return database.Table<Client>().ToListAsync();
        }
        public Task<int> SaveTicketAsync(Client ticket)
        {
            return database.InsertAsync(ticket);
        }
        public Task<int> DeleteTicketAsync(Client ticket)
        {
            return database.DeleteAsync(ticket);
        }
    }
}