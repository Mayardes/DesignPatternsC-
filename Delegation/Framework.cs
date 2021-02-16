using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation
{
    public class Staff
    {
        public virtual void ToWork(string task)
        {
            Console.WriteLine("Staff working..." + task);
        }
    }

    public class Intern
    {
        public void ToWork(string task)
        {

            Console.WriteLine("Intern is studying..." + task);
        }
    }

    public class Developer : Staff
    {
        public override void ToWork(string task)
        {
            Console.WriteLine("Developer programing.." + task);
        }
    }

    public class Architect : Staff
    {
        public void ToWord(string task)
        {
            Console.WriteLine("Architect is working..." + task);
        }
    }

    public class Manager
    {
        private Intern _intern;
        private Developer _developer;
        private Architect _architect;
        private Tester _tester;

        public Manager()
        {
            this._intern = new Intern();
            this._developer = new Developer();
            this._architect = new Architect();
            this._tester = new Tester();
        }

        public void ToWork(string task)
        {
            //here we are make a delegation
            Console.WriteLine("Manager recieve the task .." + task);
            _intern.ToWork(task);
            _architect.ToWork(task);
            _developer.ToWork(task);
            _tester.ToWork(task);
        }


    }


    public class Tester : Staff
    {
        public void Testing(string task)
        {
            Console.WriteLine("Tester is testing.." + task);
        }
     
    }

}
