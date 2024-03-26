using DesignPatterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;
public class ActionInvoker:Premitted
{
    private BranchCommand commands;
    private Queue<BranchCommand> actionsQueue;

    public Queue<BranchItem> Items= new();

    public void EnterTheQueue(BranchItem branch,BranchCommand branchCommand) 
    {  
        actionsQueue.Enqueue(branchCommand);
        Items.Enqueue(branch);
    }
    public void SetCommand(BranchCommand command)
    {

    }
    public void ExcuteActions()
    {
        commands= actionsQueue.Dequeue();
        commands.Excute();
    }
}
