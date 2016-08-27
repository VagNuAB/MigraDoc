using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace MigraDoc.Tests
{
    [TestClass]
    public class DevTests
    {



        [TestMethod]
        public void ReadNumPages()
        {
            //var contents = File.ReadAllBytes(@"C:\Users\sebas\Documents\Dev\VägNu\vägfas\vCurrent\VagFasWebb.Tests\Testfiles\PDFTest\scan0557.pdf");
            //var contents = File.ReadAllBytes(@"C:\Users\sebas\Documents\Dev\VägNu\vägfas\vCurrent\VagFasWebb.Tests\Testfiles\PDFTest\Informationsträff.pdf");
            var contents = File.ReadAllBytes(@"C:\Users\sebas\Documents\Dev\VägNu\vägfas\vCurrent\VagFasWebb.Tests\Testfiles\PDFTest\Protokoll 160605.pdf");
            PdfDocument pdf;

            using (var stream = new MemoryStream(contents))
                pdf = PdfReader.Open(stream, PdfDocumentOpenMode.Import);

            Assert.AreEqual(2, pdf.PageCount);
        }
    }
}
