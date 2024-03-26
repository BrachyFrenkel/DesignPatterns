using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;
public class MainBranch : Branch 
{
    static MainBranch instance;
    private MainBranch()
    {

    }
    public static object locker;
    static MainBranch()
    {
        locker = new object();
    }

    public static MainBranch GetInstance()
    {
        if (instance == null)
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new MainBranch();
                }
            }
        }
        return instance;
    }

    public override void AddBranchItem()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }

    public override void Clone(Branch branch)
    {
        throw new NotImplementedException();
    }
}
