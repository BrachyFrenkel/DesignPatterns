using DesignPatterns.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;
public class RequestAReviewManager
{
    private List<User> relevantFactors = new();
    private RequestAReview requestAReview = new();
    public void SubScribe(RequestAReview requestAReview , List<User> relevantFactors)
    {
//לשלוח הודעה למשתמשים שצריכים לקבל הודעה על בקשת הreview
    }


}
