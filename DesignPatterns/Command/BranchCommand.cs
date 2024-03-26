using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command;
public abstract class BranchCommand
{
    public BranchReciver branchReciver = new();
    public abstract void Excute();
}
