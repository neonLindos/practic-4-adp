using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_4_adp
{
    public class Report : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Открыт отчет.");
        }
    }

    public class Resume : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Открыто резюме.");
        }
    }

    public class Letter : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Открыто письмо.");
        }
    }

    public class Invoice : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Открыт счет-фактура.");
        }
    }
    public abstract class DocumentCreator
    {
        public abstract IDocument CreateDocument();
    }

    public class ReportCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Report();
        }
    }

    public class ResumeCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Resume();
        }
    }
    public class LetterCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Letter();
        }
    }

    public class InvoiceCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Invoice();
        }
    }
}
