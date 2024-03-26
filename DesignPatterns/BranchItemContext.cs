using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.States;

namespace DesignPatterns;
public class BranchItemContext
{
    private BranchItemState state;
    public RequestAReviewManager events {  get; set; }
    public BranchItemContext(BranchItemState state)
    {
        events = new RequestAReviewManager();
        this.state = state;
    }
    public void ChangeState(BranchItemState state)
    {
        throw new NotImplementedException();
    }
    public void Merge()
    {
    }
    public void Edit()
    {
    }
    public void Commit()
    {
    }
    public void UnDoCommit()
    {
    }
    public void Stage()
    {
    }
    public void Create()
    {
    }
    public void RequesetReview()
    {
    }
    public Memnto Save()
    {
        return new Memnto(state);    
    }
    public Memnto Restore(Memnto memnto)
    {
        return memnto;
    }
}
