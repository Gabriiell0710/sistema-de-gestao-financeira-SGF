using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SGF.DTO;
using SGF.Models;

namespace SGF.Utils
{
    public class PdfExtractDocument : IDocument
    {

        private readonly List<ExtractReportDto> _data;
        private readonly UserModel _user;
        private readonly DateTime _start;
        private readonly DateTime _end;

        public PdfExtractDocument(
            List<ExtractReportDto> data,
            UserModel user,
            DateTime start,
            DateTime end)
        {
            _data = data;
            _user = user;
            _start = start;
            _end = end;
        }

        public DocumentMetadata GetMetadata => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(30);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer()
                    .AlignCenter()
                    .Text(x =>
                    {
                        x.Span("Página ");
                        x.CurrentPageNumber();
                    });
            });
        }

        void ComposeHeader(IContainer container)
        {
            container.Column(col => 
            {
                col.Item().Text("Sistema de Gestão Financeira - Extrato Financeiro")
                .FontSize(18).Bold();

                col.Item().Text($"Usuário: {_user.Name}");
                col.Item().Text(
                    $"Período: {_start:dd/MM/yyyy} até {_end:dd/MM/yyyy}");

                col.Item().PaddingVertical(10)
                .LineHorizontal(1);
            });
        }

        void ComposeContent(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(70);
                    columns.ConstantColumn(60);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.ConstantColumn(80);
                });

                table.Header(header =>
                {
                    header.Cell().Text("Data").Bold();
                    header.Cell().Text("Tipo").Bold();
                    header.Cell().Text("Descrição").Bold();
                    header.Cell().Text("Categoria").Bold();
                    header.Cell().Text("Valor").Bold();
                });

                foreach (var item in _data)
                {
                    table.Cell().Text(item.Date.ToString("dd/MM/yyyy"));
                    table.Cell().Text(item.Type);
                    table.Cell().Text(item.Description);
                    table.Cell().Text(item.Category);
                    table.Cell().Text(item.Value.ToString("C"));
                }

                table.Cell().PaddingTop(15).AlignRight().Column(col =>
                {
                    var totalRevenues = _data
                    .Where(x => x.Type == "Receita")
                    .Sum(x => x.Value);

                    var totalExpenses = _data
                    .Where(x => x.Type == "Despesa")
                    .Sum (x => Math.Abs(x.Value));

                    var balance = totalRevenues - totalExpenses;

                    col.Item().Text($"Total Receitas: {totalRevenues:C}").Bold();
                    col.Item().Text($"Total Despesas: {totalExpenses:C}").Bold();
                    col.Item().Text($"Saldo: {balance:C}").Bold();
                });

            });
        }
    }
}
