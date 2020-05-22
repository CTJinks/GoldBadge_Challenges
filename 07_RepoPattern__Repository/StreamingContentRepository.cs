using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern__Repository
{
    public class StreamingContentRepository
    {

        private List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        // backing field (or field, or hidden field)
        // CRUD:
        // Create
        // Read
        // Update
        // Delete
        
        public bool AddContentToDirectory(StreamingContent item)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(item);
            bool wasAdded = _contentDirectory.Count == startingCount + 1;
            return wasAdded;
        }
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        public List<StreamingContent> UpdateAllContent()
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                content.Title = "blah";
                content.Actors = "blah";
                content.Description = "blah";
                content.Genre = GenreType.Christmas;
                content.StarRating = 5.0;
                content.MaturityRating = MaturityRating.R;
                
            }
            return _contentDirectory;
        }
        public bool UpdateContentByTitle(string title, StreamingContent newContent)
        {
            StreamingContent content = GetContentByTitle(title);
            if (content == null)
            {
                Console.WriteLine("This is not the content you're looking for...");
                return false;
            }
            else
            {
                content.Title = newContent.Title;
                content.Description = newContent.Description;
                content.StarRating = newContent.StarRating;
                content.MaturityRating = newContent.MaturityRating;
                content.Genre = newContent.Genre;
                return true;
            }
        }
        // Create a RemoveContentByTitle method.
        // AND/OR
        // Create a GetFamilyFriendlyContent method.
        public bool RemoveContentByTitle(string title)
        {
            StreamingContent content = GetContentByTitle(title);
            if (content == null)
            {
                Console.WriteLine("This is not the content you're looking for...");
                return false;
            }
            else
            {
                _contentDirectory.Remove(content);
                // int index = _contentDirectory.IndexOf(content);
                // _contentDirectory.RemoveAt(index);
                return true;
            }
        }
        public List<StreamingContent> GetFamilyFriendlyContent()
        {
            List<StreamingContent> FamilyFriendlyContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly)
                {
                    FamilyFriendlyContent.Add(content);
                }
            }
            return FamilyFriendlyContent;
        }
    }
}
