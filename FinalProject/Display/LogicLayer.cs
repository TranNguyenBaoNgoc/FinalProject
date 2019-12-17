using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class LogicLayer
    {
        public List<Task> GetTasks()
        {
            var db = new MyDatabaseEntities();
            return db.Tasks.ToList();
        }

        public Task GetTask(int id)
        {
            var db = new MyDatabaseEntities();
            var task = db.Tasks.Find(id);
            return task;
        }

        public List<SpecEvent> GetSpecEvents()
        {
            var db = new MyDatabaseEntities();
            return db.SpecEvents.ToList();
        }

        public SpecEvent GetSpecEvent(int id)
        {
            var db = new MyDatabaseEntities();
            var spevEve = db.SpecEvents.Find(id);
            return spevEve;
        }

        public List<Routine> GetHabits()
        {
            var db = new MyDatabaseEntities();
            return db.Routines.ToList();
        }

        public Routine GetHabit(int id)
        {
            var db = new MyDatabaseEntities();
            var habit= db.Routines.Find(id);
            return habit;
        }

        public void CreateTask(DateTime datetime, string title, string detail, bool prio, bool status)
        {
            var task = new Task();
            task.DateTime = datetime;
            task.Title = title;
            task.Details = detail;
            task.Prio = prio;
            task.Status = status;

            var db = new MyDatabaseEntities();
            db.Tasks.Add(task);
            db.SaveChanges();
            db.Dispose();
        }

        public void CreateHabit(string title, string detail, bool prio, bool status)
        {
            var habit = new Routine();
            habit.Title = title;
            habit.Details = detail;
            habit.Prio = prio;
            habit.Status = status;

            var db = new MyDatabaseEntities();
            db.Routines.Add(habit);
            db.SaveChanges();
            db.Dispose();
        }

        public void CreateSpecEvent(DateTime datetime, string title, string location, string start, string end, string detail, bool prio, bool status)
        {
            var specEve = new SpecEvent();
            specEve.DateTime = datetime;
            specEve.Title = title;
            specEve.Location = location;
            specEve.Start = start;
            specEve.EndTime = end;
            specEve.Details = detail;
            specEve.Prio = prio;
            specEve.Status = status;

            var db = new MyDatabaseEntities();
            db.SpecEvents.Add(specEve);
            db.SaveChanges();
            db.Dispose();
        }

        public void EditTask(int id, string title, string detail)
        {
            var db = new MyDatabaseEntities();
            var task = db.Tasks.Find(id);

            task.Title = title;
            task.Details = detail;

            db.Entry(task).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void EditStaTask(int id, bool status)
        {
            var db = new MyDatabaseEntities();
            var task = db.Tasks.Find(id);

            task.Status = status;

            db.Entry(task).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void EditPrioTask(int id, bool prio)
        {
            var db = new MyDatabaseEntities();
            var task = db.Tasks.Find(id);

            task.Prio = prio;

            db.Entry(task).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void EditHabit(int id, string title, string detail)
        {
            var db = new MyDatabaseEntities();
            var habit = db.Routines.Find(id);

            habit.Title = title;
            habit.Details = detail;

            db.Entry(habit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void EditStaHabit(int id, bool status)
        {
            var db = new MyDatabaseEntities();
            var habit = db.Routines.Find(id);

            habit.Status = status;

            db.Entry(habit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void EditPrioHabit(int id, bool prio)
        {
            var db = new MyDatabaseEntities();
            var habit = db.Routines.Find(id);

            habit.Prio = prio;

            db.Entry(habit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void EditSpecEvent(int id, string title, string detail,string location, string start, string end)
        {
            var db = new MyDatabaseEntities();
            var specEve = db.SpecEvents.Find(id);

            specEve.Title = title;
            specEve.Location = location;
            specEve.Start = start;
            specEve.EndTime = end;
            specEve.Details = detail;

            db.Entry(specEve).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void EditStaEvent(int id, bool status)
        {
            var db = new MyDatabaseEntities();
            var speEvent = db.SpecEvents.Find(id);

            speEvent.Status = status;

            db.Entry(speEvent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void EditPrioEvent(int id, bool prio)
        {
            var db = new MyDatabaseEntities();
            var speEvent = db.SpecEvents.Find(id);

            speEvent.Prio = prio;

            db.Entry(speEvent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void DeleteTask(int id)
        {
            var db = new MyDatabaseEntities();
            var task = db.Tasks.Find(id);

            db.Tasks.Remove(task);
            db.SaveChanges();
            db.Dispose();
        }

        public void DeleteHabit(int id)
        {
            var db = new MyDatabaseEntities();
            var habit = db.Routines.Find(id);

            db.Routines.Remove(habit);
            db.SaveChanges();
            db.Dispose();
        }

        public void DeleteSpecEvent(int id)
        {
            var db = new MyDatabaseEntities();
            var specEve = db.SpecEvents.Find(id);

            db.SpecEvents.Remove(specEve);
            db.SaveChanges();
            db.Dispose();
        }

        public string GetDay(DateTime date)
        {
            return date.ToString("dd");
        }

        public string GetMonthYear(DateTime date)
        {
            return date.ToString("MMMM yyyy,\ndddd");
        }

        public string GetHour()
        {
            return DateTime.Now.ToString("HH");
        }
        
        public string GetMinute()
        {
            return DateTime.Now.ToString("mm");
        }
    }
}
