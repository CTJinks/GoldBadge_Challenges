using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern__Repository
{


    public class WatchParty
    {
        public string YourName { get; set; }
        public string FriendsNames { get; set; }
        public WatchParty() { }
        public WatchParty(
            string yourName,
            string friendsNames
            )
        {
            YourName = yourName;
            FriendsNames = friendsNames;
        }
    }
    
    public enum GenreType { Horror, Comedy, SciFi = 2, Documentary, Drama = 1, Action = 3, Bromance, Christmas }
    public enum MaturityRating { G, PG, PG_13, R, NC_17, TV_Y, TV_G, TV_PG, TV_MA, U }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    default:
                        return false;
                }
            }
        }
        public string Director { get; set; }
        public GenreType Genre { get; set; }
        public string Actors { get; set; }
        public StreamingContent() { }
        public StreamingContent(
            string title,
            string description,
            double starRating,
            MaturityRating maturityRating,
            GenreType genre,
            string actors

        )
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = maturityRating;
            Genre = genre;
            Actors = actors;
        }
    }





}
