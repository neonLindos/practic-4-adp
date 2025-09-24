using practic_4_adp;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Выберите тип документа:");
Console.WriteLine("1 - Отчет");
Console.WriteLine("2 - Резюме");
Console.WriteLine("3 - Письмо");
Console.WriteLine("4 - Счет-фактура");

string choice = Console.ReadLine();
DocumentCreator creator = null;

switch (choice)
{
    case "1":
        creator = new ReportCreator();
        break;
    case "2":
        creator = new ResumeCreator();
        break;
    case "3":
        creator = new LetterCreator();
        break;
    case "4":
        creator = new InvoiceCreator();
        break;
    default:
        Console.WriteLine("Неизвестный выбор.");
        return;
}

// Создаем документ через фабрику
IDocument doc = creator.CreateDocument();
doc.Open();

Console.ReadKey();