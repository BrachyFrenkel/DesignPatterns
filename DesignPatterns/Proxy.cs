using DesignPatterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;
public class Proxy: Premitted
{
    public ActionInvoker actionInvoker;
    private Queue<BranchCommand> actionsQueue;
    public Queue<BranchItem> Items = new();
    public Proxy(ActionInvoker actionInvoker)
    {
        this.actionInvoker= actionInvoker;
    }

    

    public bool CheckAcces(User user, BranchItem branchItem)
    {
        if (user.Acces!= null)
        {
            return true;
        }
        return false;
    }
    public void EnterTheQueue(BranchItem branch, BranchCommand branchCommand)
    {
        actionsQueue.Enqueue(branchCommand);
        Items.Enqueue(branch);
    }
}
