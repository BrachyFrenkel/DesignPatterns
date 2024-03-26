using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;

public class Folder : BranchItem
{
    //public List<BranchItem> Items = new List<BranchItem>;
    public List<BranchItem> Items { get; set; }
    public Folder()
    {
        Items = new List<BranchItem>();
    }
    public override void Excute()
    {
        throw new NotImplementedException();
    }
    public BranchItem Add(BranchItem item)
    {
        Items.Add(item);
        return item;
    }
    public BranchItem Remove(BranchItem item)
    {
        Items.Remove(item);
        return item;
    }

}
