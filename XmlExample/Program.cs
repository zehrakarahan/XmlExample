// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using XmlExample;

Process[] chromeProcesses = Process.GetProcessesByName("chrome");

// Her bir işlemi döngüye al ve kapat
foreach (Process process in chromeProcesses)
{
    process.Kill();
}
Process[] arrProcess = Process.GetProcesses();

foreach (Process process in arrProcess)
{
    process.Kill();
}
using (StreamReader reader = new StreamReader("C:\\Users\\user\\source\\repos\\XmlExample\\XmlExample\\Deneme.xml"))
{
    XmlSerializer serializer = new XmlSerializer(typeof(catalog));
    var school = (catalog)serializer.Deserialize(reader);
}
using (StreamReader reader = new StreamReader("C:\\Users\\user\\source\\repos\\XmlExample\\XmlExample\\Deneme.xml"))
{
    XmlSerializer serializer = new XmlSerializer(typeof(catalog));
    var catalog = (catalog)serializer.Deserialize(reader);

    // Deserialization işlemi başarılı. Verileri kullanabilirsiniz.
    foreach (var book in catalog.book)
    {
        Console.WriteLine($"Title: {book.title}, Author: {book.description}");
    }
}

