using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.States;
public abstract class BranchItemState
{
    protected BranchItemContext context;
    private List<Memnto> history = new();
    public BranchItemState(BranchItemContext context)
    {
        this.context = context;
    }
    public abstract void Merge();
    public abstract void Edit();

    public abstract void Commit();

    public abstract void UnDoCommit();

    public abstract void Stage();

    public abstract void Create();

}
