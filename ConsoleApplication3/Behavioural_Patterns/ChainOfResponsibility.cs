using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication3.Behavioural_Patterns
{
    public class Request
    {
        
        public int RequestID { get; set; }
    }
    public class ActionType
    {
        public string ActionName { get; set; }

    }
    public class RequestAction : Request
    {
        public ActionType action { get; set; }
    }
    public class ActionEventArgs : EventArgs
    {
        internal RequestAction RequestAction { get; set; }
    }
    public abstract class Approver
    {
        public  EventHandler<ActionEventArgs> RequestAction;
        //public event EventHandler<ActionEventArgs> RequestAction; its the same,compiler understands
        public abstract void ActionHandler(object sender, ActionEventArgs e);//thsi is left for the other kinds how they will work upon logic
        public Approver()
        {
            RequestAction += ActionHandler;
            
        }
        public void ProcessRequest(RequestAction request)
        {
            OnAction(new ActionEventArgs { RequestAction = request });

        }
        public virtual void OnAction(ActionEventArgs e)
        {
            if (RequestAction != null)
            {
                RequestAction(this, e);
            }
        }
        public Approver Successor { get; set; }

    }
    public class Manager : Approver
    {
        public override void ActionHandler(object sender, ActionEventArgs e)
        {
            if (e.RequestAction.action.ActionName == "reject")
            {
                //approve in databse 
                Console.WriteLine("{0} rejected request# {1}", sender.GetType().Name, e.RequestAction.action);

            }
            else if (Successor != null)
            {
                Successor.ActionHandler(this, e);
                Console.WriteLine("{0} Approved request# {1}", sender.GetType().Name, e.RequestAction.action);
                Console.WriteLine("{0} pending with request# {1}", this.Successor.GetType().Name, "Waiting");

            }
        }
    }
    public class Sbuhead : Approver
    {
        public override void ActionHandler(object sender, ActionEventArgs e)
        {
            if (e.RequestAction.action.ActionName == "approve")
            {
                //approve in databse 
                this.Successor = null;
            }
        }
    }
}
