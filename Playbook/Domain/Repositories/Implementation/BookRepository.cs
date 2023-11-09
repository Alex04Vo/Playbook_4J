using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities.Books;
using Model.Entities.Books.Models;
using Model.Entities.Sections;
using Model.Entities.Sections.StorySections;

namespace Domain.Repositories.Implementation; 

public class BookRepository : ARepository<Book>, IBookRepository {

    private readonly IRuleSectionRepository _ruleSectionRepository;
    private readonly IStorySectionRepository _storySectionRepository;
    public BookRepository(PlaybookContext context, IRuleSectionRepository ruleSectionRepository, IStorySectionRepository storySectionRepository) : base(context) {
        _ruleSectionRepository = ruleSectionRepository;
        _storySectionRepository = storySectionRepository;
    }

    public async Task<List<Book>> ReadAllWithTitlePageAsync() {
        var list = await Table.ToListAsync();

        foreach (var book in list) {
            book.TitlePage = await _ruleSectionRepository.GetTitlePageOfBook(book.Id);
        }
        return list;
    }
    
    public async Task<BookOverviewModel?> ReadCompleteBookOverviewAsync(int bookId) {
        var book = await Table.Where(b => b.Id == bookId).SingleOrDefaultAsync();

        if (book is null) return null;

        BookOverviewModel bookOverview = new BookOverviewModel() {
            Book = book,
            RuleSections = await _ruleSectionRepository.GetRuleSectionsOfBook(bookId),
            StorySections = await _storySectionRepository.ReadAllStorySectionsOfBookAsync(bookId)
        };

        return bookOverview;
    }
}