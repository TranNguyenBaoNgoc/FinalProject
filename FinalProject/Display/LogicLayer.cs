using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class LogicLayer
    {
        public Task[] GetTasks()
        {
            var db = new MyDatabaseEntities();
            return db.Tasks.ToArray();
        }

        public Task GetTask(int id)
        {
            var db = new MyDatabaseEntities();
            var task = db.Tasks.Find();
            return task;
        }

        public SpecEvent[] GetSpecEvents()
        {
            var db = new MyDatabaseEntities();
            return db.SpecEvents.ToArray();
        }

        public SpecEvent GetSpecEvent(int id)
        {
            var db = new MyDatabaseEntities();
            var spevEve = db.SpecEvents.Find();
            return spevEve;
        }

        public Routine[] GetHabits()
        {
            var db = new MyDatabaseEntities();
            return db.Routines.ToArray();
        }

        public Routine GetHabit(int id)
        {
            var db = new MyDatabaseEntities();
            var habit= db.Routines.Find();
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
        }

        public void CreateHabit(DateTime datetime, string title, string detail, bool prio, bool status)
        {
            var habit = new Routine();
            habit.DateTime = datetime;
            habit.Title = title;
            habit.Details = detail;
            habit.Prio = prio;
            habit.Status = status;

            var db = new MyDatabaseEntities();
            db.Routines.Add(habit);
            db.SaveChanges();
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
        }

        public void EditTask(DateTime datetime, string title, string detail, bool prio, bool status)
        {
            var db = new MyDatabaseEntities();
            var task = db.Tasks.Find(datetime, title);

            task.DateTime = datetime;
            task.Title = title;
            task.Details = detail;
            task.Prio = prio;
            task.Status = status;

            db.Entry(task).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void EditHabit(DateTime datetime, string title, string detail, bool prio, bool status)
        {
            var db = new MyDatabaseEntities();
            var habit = db.Routines.Find(datetime, title);

            habit.DateTime = datetime;
            habit.Title = title;
            habit.Details = detail;
            habit.Prio = prio;
            habit.Status = status;

            db.Entry(habit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void EditSpecEvent(DateTime datetime, string title, string location, string start, string end, string detail, bool prio, bool status)
        {
            var db = new MyDatabaseEntities();
            var specEve = db.SpecEvents.Find(datetime, title);

            specEve.DateTime = datetime;
            specEve.Title = title;
            specEve.Location = location;
            specEve.Start = start;
            specEve.EndTime = end;
            specEve.Details = detail;
            specEve.Prio = prio;
            specEve.Status = status;

            db.Entry(specEve).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteTask(DateTime datetime, string title)
        {
            var db = new MyDatabaseEntities();
            var task = db.Tasks.Find(datetime, title);

            db.Tasks.Remove(task);
            db.SaveChanges();
        }

        public void DeleteHabit(DateTime datetime, string title)
        {
            var db = new MyDatabaseEntities();
            var habit = db.Routines.Find(datetime, title);

            db.Routines.Remove(habit);
            db.SaveChanges();
        }

        public void DeleteSpecEvent(DateTime datetime, string title)
        {
            var db = new MyDatabaseEntities();
            var specEve = db.SpecEvents.Find(datetime, title);

            db.SpecEvents.Remove(specEve);
            db.SaveChanges();
        }

        public string GetDay()
        {
            return DateTime.Now.ToString("dd");
        }

        public string GetMonthYear()
        {
            return DateTime.Now.ToString("MMMM yyyy,\ndddd");
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
