using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;
public class MainBranch : Branch 
{ 
    private MainBranch MainBranchInstance = new MainBranch();
    private MainBranch()
    {
        this.MainBranchInstance= MainBranchInstance;
    }
    public MainBranch GetMainBranch()
    {
        return this.MainBranchInstance; 
    }

}
