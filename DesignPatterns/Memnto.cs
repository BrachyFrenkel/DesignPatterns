using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.States;

namespace DesignPatterns;
public class Memnto
{
    private BranchItemState state;
    private Memnto(BranchItemState state)
    {
        this.state = state;  
    }
    private BranchItemState GetState()
    {
        return state;
    }
}
