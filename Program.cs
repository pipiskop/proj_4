using NotePad__;

static void Menu(DateTime date) 
{
    Console.WriteLine($"{date.ToString("D")}");
    Console.WriteLine("1. Посмотреть заметку");
    Console.WriteLine("2. Создать заметку");
    Console.WriteLine("3. Выйти из программы");
}

static void ReadNotes(DateTime date, IEnumerable<Note> DayNotes)
{
    Console.Clear();
    Console.WriteLine($"Дата заметок - {date.ToString("D")}");
    foreach (Note note in DayNotes)
    {
        Console.WriteLine($"   {note.name}");
    }
    Console.WriteLine("   ");
    Console.WriteLine("   Выход в меню");
}

static void AbouteNote(DateTime date, Note note)
{
    Console.Clear();
    Console.WriteLine($"{date.ToString("D")}");
    
    Console.WriteLine($"{note.name}"); 
    Console.WriteLine($"{note.text}"); 
    
    Console.WriteLine("Bыйти из меню");
    Console.ReadKey();
}

static void AppendNotes(DateTime date, List<Note> notes) 
{
    Console.Clear();
    Console.WriteLine("Введите название заметки:");
    string name = Console.ReadLine();
    Console.WriteLine("Введите текст заметки:");
    string text = Console.ReadLine();
    notes.Add(new Note() { date = date, name = name, text = text });
}

static int UpdateCursorPos(int doUP, int MaxdoUP, int MindoUP, ConsoleKey key) 
{
    switch (key)
    {
        case ConsoleKey.PageUp:
            doUP--;
            if (doUP < MindoUP)
            {
                doUP = MindoUP;
            }
            break;
        case ConsoleKey.PageDown:
            doUP++;
            if (doUP > doUP)
            {
                doUP = doUP;
            };
            break;
    }
    return doUP;
}

static void WriteCursor(int VerPos) 
{
    Console.SetCursorPosition(0, VerPos);
    Console.WriteLine("==>");
}
    





