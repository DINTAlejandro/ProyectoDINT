using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoRevista.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRevista.Servicios
{
    class ServicioPDF
    {
        
        
        public void GenerarPDF(Articulo articulo)
        {
            // Sustituir los campos de ejemplo por los del articulo

            var document = new Document(PageSize.A4, 50, 50, 25, 25);

            // Crea una nueva instancia de PdfWriter utilizando un stream de salida
            PdfWriter.GetInstance(document, new FileStream("output.pdf", FileMode.Create));

            // Abre el documento para edición
            document.Open();

            // Agrega el título
            var title = new Paragraph("Título del PDF", new Font(Font.FontFamily.HELVETICA, 24, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Agrega la imagen de una URL
            var imageUrl = "https://www.example.com/image.jpg";
            var image = Image.GetInstance(new Uri(imageUrl));
            image.ScaleToFit(document.PageSize.Width - 100, document.PageSize.Height / 2);
            image.Alignment = Element.ALIGN_CENTER;
            document.Add(image);

            // Agrega el texto
            var text = new Paragraph("Texto del PDF", new Font(Font.FontFamily.HELVETICA, 14));
            text.Alignment = Element.ALIGN_JUSTIFIED;
            document.Add(text);

            // Cierra el documento
            document.Close();
        }
        
    }
}
