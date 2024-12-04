using EventManagementSystem.DAL.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.DAL.Repositories;

public class EventRepository
{
    private Context _context;

    public EventRepository()
    {
        _context = new Context();
    }

    public void AddEvent(EventDto event)
    {
        _context.Events.Add(event);
        _context.SaveChanges();
    }

public void UpdateEvent(EventDto course)
    {
        _context.Events.Update(event);
        _context.SaveChanges();
    }

    public IEnumerable<UserDto> GetUsersByEventId(Guid eventId)
    {
        var users = _context.Events.Include(c => c.Users).Where(c => c.Id == eventId).FirstOrDefault();
        return _context.Users.ToList();
    }

    public IEnumerable<EventDto> GetGradesByCourseId(Guid eventId)
    {
        var grades = _context.GradeBooks.Include(g => g.Grade).Where(c => c.Id == eventId).ToList();
        return _context.Courses.ToList();
    }

    public void AddGradeByCourseId(GradeBookDto gradeBook, Guid courseId)
    {
        var grade = _context.GradeBooks.Include(s => s.Grade).Where(c => c.Id == courseId).SingleOrDefault();
        _context.GradeBooks.Add(grade);
        _context.SaveChanges();
    }

    public void UpdateGradeByCourseId(GradeBookDto gradeBook, Guid courseId)
    {
        var grade = _context.GradeBooks.Include(s => s.Grade).Where(c => c.Id == courseId).SingleOrDefault();
        _context.GradeBooks.Update(grade);
        _context.SaveChanges();
    }
}

