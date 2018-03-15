using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        //define and create properties 
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set;}
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favourite { get; set; }

        //display the seriestitle and issue number
        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        //display comic book image
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() +
                    "-" + IssueNumber + ".jpg";
            }
        }
    }
}