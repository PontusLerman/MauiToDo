using MauiToDo.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace MauiToDo.Services
{
    public class JsonServices
    {
        private readonly JsonSerializerOptions _options;

        private string _fileName = FileSystem.AppDataDirectory + "/Notes.json";

        public JsonServices()
        {
            _options = new JsonSerializerOptions();
        }

        public async Task WriteToFileAsync(ObservableCollection<Note> notes)
        {
            var writeNotesData = JsonSerializer.Serialize(notes);
            await File.WriteAllTextAsync(this._fileName, writeNotesData);
        }

        public async Task<ObservableCollection<Note>> ReadFromFileAsync()
        {
            ObservableCollection<Note> readNotes = new();

            if (File.Exists(this._fileName) == false)
            {
                return new ObservableCollection<Note>();
            }

            var rawNotesData = await File.ReadAllTextAsync(_fileName);

            readNotes = JsonSerializer.Deserialize<ObservableCollection<Note>>(rawNotesData, _options);

            return readNotes;
        }
    }
}
