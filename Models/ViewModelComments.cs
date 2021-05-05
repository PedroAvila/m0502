using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M0502.Models
{
    public class ViewModelComments
    {
        public List<Comment> Comments { get; set; }

        public ViewModelComments()
        {
            Comments = new List<Comment>()
            {
                new Comment{ID = 1, Subject="C 1", HtmlSubject="Comment 1"},
                new Comment{ID = 2, Subject="C 2", HtmlSubject="Comment 2"},
                new Comment{ID = 1, Subject="C 3", HtmlSubject="Comment 3"},
                new Comment{ID = 3, Subject="C 4", HtmlSubject="Comment 4"},
                new Comment{ID = 1, Subject="C 5", HtmlSubject="Comment 5"},
                new Comment{ID = 4, Subject="C 6", HtmlSubject="Comment 6"},
                new Comment{ID = 1, Subject="C 7", HtmlSubject="Comment 7"},
                new Comment{ID = 5, Subject="C 8", HtmlSubject="Comment 8"},
                new Comment{ID = 1, Subject="C 9", HtmlSubject="Comment 9"},
                new Comment{ID = 6, Subject="C 10", HtmlSubject="Comment 10"}
            };
        }
    }
}