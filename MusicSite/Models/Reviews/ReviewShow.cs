using Microsoft.AspNetCore.Mvc;
using MusicSite.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews
{
    public class ReviewShow
    {
        [JsonIgnore]
        [HiddenInput]
        public string ID { get; set; }
        public ShowUserModel Author { get; set; }
        [JsonIgnore]
        public String ReturnURL { get; set; }
        public int rating { get; set; }
        public string reviewText { get; set; }

        public ReviewShow(Review review, string userID)
        {
            this.ID = review.ID;
            this.rating = review.rating;
            this.reviewText = review.reviewText;
            if (review.author != null) this.Author = new ShowUserModel(review.author, userID);
        }
    }
}
