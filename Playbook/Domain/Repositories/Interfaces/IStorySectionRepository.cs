using Model.Entities.Sections.StorySections;

namespace Domain.Repositories.Interfaces; 

public interface IStorySectionRepository : IRepository<StorySection> {

    Task<StorySection?> ReadStorySectionAsync(int bookId, int sectionNr);
    int GetFirstStorySectionId(int bookId);
}