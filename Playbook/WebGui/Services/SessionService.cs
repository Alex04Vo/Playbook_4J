using Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;
using Model.Entities.Sessions;

namespace WebGui.Services;

public class SessionService {
    protected readonly ISessionRepository _sessionRepository;
    protected readonly IPlayedBookRepository _playedBookRepository;
    protected readonly ISectionHistoryRepository _sectionHistoryRepository;
    protected readonly ILogger<SessionService> _logger;
    protected readonly NavigationManager _navManager;

    public SessionService(ISessionRepository sessionRepository, ILogger<SessionService> logger,
        NavigationManager navManager, IPlayedBookRepository playedBookRepository, ISectionHistoryRepository sectionHistoryRepository) {
        _sessionRepository = sessionRepository;
        _playedBookRepository = playedBookRepository;
        _sectionHistoryRepository = sectionHistoryRepository;
        _logger = logger;
        _navManager = navManager;
    }

    public Session? CurrentSession { get; private set; }

    public async Task<Session?> CheckAndSetCurrentSession(int sessionId, int userId) {
        var session = await _sessionRepository.ReadSession(sessionId);

        if (session is null) return null;

        if (session.UserId == userId) {
            CurrentSession = session;
            return CurrentSession;
        }

        return null;
    }

    public void ResetCurrentSession() {
        CurrentSession = null;
    }

    public async Task<bool> StartPlaySession(int sessionId) {
        var ids = await _sessionRepository.GetCurrentBookIdAndCurrentSectionId(sessionId);
        if (ids is not null) {
            _navManager.NavigateTo($"/s/{sessionId}/books/{ids[0]}/sections/{ids[1]}");
            return true;
        }

        return false;
    }

    public async Task<Session?> SaveChoosenSection(int bookId, int rootSectionId, int goalSectionId) {
        if (CurrentSession is null) return null;

        await _playedBookRepository.UpdatePlayTimestamp(CurrentSession.Id, bookId);
        await _sectionHistoryRepository.CreateAsync(new SectionHistory() {
            SessionId = CurrentSession.Id,
            BookId = bookId,
            SectionId = goalSectionId,
            Timestamp = DateTime.Now
        });

        CurrentSession = await _sessionRepository.ReadSession(CurrentSession.Id);
        return CurrentSession;
    }
}