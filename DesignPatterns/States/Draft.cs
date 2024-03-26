using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.States;
public class Draft : BranchItemState
{
    public Draft(BranchItemContext context) : base(context)
    {
        
    }
    public override void Commit()
    {
        throw new NotImplementedException();
    }

    public override void Create()
    {
        throw new NotImplementedException();
    }

    public override void Edit()
    {
        throw new NotImplementedException();
    }

    public override void Merge()
    {
        throw new NotImplementedException();
    }

    public override void Stage()
    {
        throw new NotImplementedException();
    }

    public override void UnDoCommit()
    {
        throw new NotImplementedException();
    }
}
