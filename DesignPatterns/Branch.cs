using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;
public abstract class Branch
{
    protected List<string> AccessPermissions { get; set; }
    public Branch()
    {
        AccessPermissions = new List<string>();
    }
    public abstract void AddBranchItem();
    public abstract void Update();
    public abstract void Clone(Branch branch);

}
